using ProjectSignal.Core;

namespace ProjectSignal.Simulation;

public sealed class EmptyCorridorState
{
    public bool SoilChemistryChanged { get; set; }

    public bool WildlifeDisplaced { get; set; }

    public bool RoutePrepared { get; set; }

    public bool SoilSampled { get; set; }

    public bool RouteObserved { get; set; }

    public bool ConvoyRerouted { get; set; }

    public bool AlternateRouteObserved { get; set; }
}

public sealed class EmptyCorridorScenario : IScenario<EmptyCorridorState>
{
    private static readonly Location Corridor = new("Central Corridor");
    private static readonly Location NorthApproach = new("North Approach");
    private static readonly Location AlternateRoute = new("Western Spur");

    public string Id => "empty-corridor";

    public string Title => "The Empty Corridor";

    public string Description =>
        "Alien nursery growth displaces wildlife from a valley while humans prepare a convoy route through it.";

    public int TurnCount => 3;

    public EmptyCorridorState CreateInitialState(int seed) => new();

    public IReadOnlyList<WorkingInterpretation> CreateInitialInterpretations(Faction faction) => faction switch
    {
        Faction.Human =>
        [
            new("H-I-T0-01", faction, 0, "The central corridor is the shortest planned convoy route.", [])
        ],
        Faction.Alien =>
        [
            new("A-I-T0-01", faction, 0, "The central nursery is entering a normal growth phase.", [])
        ],
        _ => throw new ArgumentOutOfRangeException(nameof(faction))
    };

    public IReadOnlyList<Order> ChooseOrders(FactionSituation situation) =>
        (situation.Faction, situation.Turn) switch
        {
            (Faction.Human, 1) =>
            [
                new("H-O-T1-01", 1, Faction.Human, "RemoteSurvey", Corridor,
                    "Check the planned route before convoy commitment.")
            ],
            (Faction.Alien, 1) =>
            [
                new("A-O-T1-01", 1, Faction.Alien, "TendNursery", Corridor,
                    "Continue the nursery growth cycle.")
            ],
            (Faction.Human, 2) =>
            [
                new("H-O-T2-01", 2, Faction.Human, "CollectSoilSample", Corridor,
                    "Distinguish environmental change from deliberate route clearing.")
            ],
            (Faction.Alien, 2) =>
            [
                new("A-O-T2-01", 2, Faction.Alien, "ObserveSurfaceCadence", NorthApproach,
                    "Distinguish transit preparation from an isolated disturbance.")
            ],
            (Faction.Human, 3) => ChooseHumanCommitment(situation),
            (Faction.Alien, 3) => ChooseAlienCommitment(situation),
            _ => []
        };

    public ObjectiveTurnResult Adjudicate(
        EmptyCorridorState state,
        int turn,
        IReadOnlyList<Order> committedOrders) => turn switch
        {
            1 => AdjudicateTurnOne(state),
            2 => AdjudicateTurnTwo(state, committedOrders),
            3 => AdjudicateTurnThree(state, committedOrders),
            _ => new([], [])
        };

    public IReadOnlyList<Observation> Collect(
        EmptyCorridorState state,
        Faction faction,
        int turn,
        IReadOnlyList<PhysicalSignature> signatures,
        IReadOnlyList<Order> committedOrders)
    {
        var observedKinds = (faction, turn) switch
        {
            (Faction.Human, 1) => new[] { "WildlifeAbsence" },
            (Faction.Alien, 1) => new[] { "SoilChemistry", "WildlifeDisplacement", "SurfaceCompression" },
            (Faction.Human, 2) => new[] { "SoilChemistry" },
            (Faction.Alien, 2) => new[] { "TrafficCadence", "SoilIntrusion" },
            (Faction.Human, 3) => new[] { "ConvoyTelemetry" },
            (Faction.Alien, 3) => new[] { "RouteCessation", "AlternateCompression" },
            _ => []
        };

        var sourceClass = (faction, turn) switch
        {
            (Faction.Human, 1) => "Remote multispectral survey",
            (Faction.Human, 2) => "Field sampling team",
            (Faction.Human, 3) => "Convoy telemetry",
            (Faction.Alien, 1) => "Nursery sensory network",
            (Faction.Alien, 2) => "Buried vibration organisms",
            (Faction.Alien, 3) => "Distributed trail organisms",
            _ => "Unknown collector"
        };

        var conditions = (faction, turn) switch
        {
            (Faction.Human, 1) => "One remote pass; no ground access.",
            (Faction.Human, 2) => "Direct sample from one corridor site.",
            (Faction.Human, 3) => "Authenticated friendly-system feed.",
            (Faction.Alien, 1) => "Continuous contact within the nursery watershed.",
            (Faction.Alien, 2) => "One full operational turn of local vibration sensing.",
            (Faction.Alien, 3) => "Partial coverage across two surface routes.",
            _ => "Unspecified conditions."
        };

        return signatures
            .Where(signature => observedKinds.Contains(signature.Kind, StringComparer.Ordinal))
            .Select((signature, index) => new Observation(
                $"{FactionPrefix(faction)}-OBS-T{turn}-{index + 1:00}",
                faction,
                turn,
                turn,
                sourceClass,
                signature.Kind,
                signature.Location,
                signature.ObservableDetail,
                conditions))
            .ToArray();
    }

    public FactionReport Interpret(Observation observation)
    {
        var description = (observation.Faction, observation.ObservedKind) switch
        {
            (Faction.Human, "WildlifeAbsence") =>
                "Large-animal activity is markedly lower than prior route surveys.",
            (Faction.Human, "SoilChemistry") =>
                "The sample contains an unfamiliar active biological compound distributed through the soil.",
            (Faction.Human, "ConvoyTelemetry") =>
                "The convoy entered the western spur and accumulated an additional two turns of travel.",
            (Faction.Alien, "SoilChemistry") =>
                "Nursery root chemistry is propagating through the central watershed.",
            (Faction.Alien, "WildlifeDisplacement") =>
                "Grazers are leaving the nursery watershed along the expected lowland path.",
            (Faction.Alien, "SurfaceCompression") =>
                "Repeated hard-surface compression has begun at the northern edge.",
            (Faction.Alien, "TrafficCadence") =>
                "Mechanical compression repeats on a transport cadence and returns to the same northern origin.",
            (Faction.Alien, "SoilIntrusion") =>
                "A small human intrusion removed living soil from the nursery watershed.",
            (Faction.Alien, "RouteCessation") =>
                "The prepared central disturbance ceased before the expected heavy passage.",
            (Faction.Alien, "AlternateCompression") =>
                "Heavy mechanical compression now propagates along the western watershed boundary.",
            _ => observation.ObservableDetail
        };

        return new FactionReport(
            observation.Id.Replace("-OBS-", "-R-", StringComparison.Ordinal),
            observation.Faction,
            observation.ObservedTurn,
            observation.DeliveryTurn,
            observation.SourceClass,
            observation.Location,
            description,
            observation.CollectionConditions);
    }

    public IReadOnlyList<WorkingInterpretation> UpdateInterpretations(FactionSituation situation) =>
        (situation.Faction, situation.Turn) switch
        {
            (Faction.Human, 1) =>
            [
                new("H-I-T1-01", Faction.Human, 1,
                    "The corridor is abnormally quiet; deliberate clearing and ecological disruption remain plausible.",
                    ReportIds(situation))
            ],
            (Faction.Human, 2) =>
            [
                new("H-I-T2-01", Faction.Human, 2,
                    "An unidentified biological process is changing the corridor; its source and intent remain unknown.",
                    ReportIds(situation))
            ],
            (Faction.Human, 3) =>
            [
                new("H-I-T3-01", Faction.Human, 3,
                    "The reroute avoided the unresolved corridor condition at the cost of operational delay.",
                    ReportIds(situation))
            ],
            (Faction.Alien, 1) =>
            [
                new("A-I-T1-01", Faction.Alien, 1,
                    "Nursery growth is normal, while a recurring industrial disturbance is forming to the north.",
                    ReportIds(situation))
            ],
            (Faction.Alien, 2) =>
            [
                new("A-I-T2-01", Faction.Alien, 2,
                    "Humans are preparing repeated transit and have begun investigating nursery soil.",
                    ReportIds(situation))
            ],
            (Faction.Alien, 3) =>
            [
                new("A-I-T3-01", Faction.Alien, 3,
                    "The main human passage shifted west after the soil intrusion.",
                    ReportIds(situation))
            ],
            _ => situation.WorkingInterpretations
        };

    public WorldSnapshot CaptureSnapshot(EmptyCorridorState state, int turn) => new(
        turn,
        new[]
        {
            $"Nursery soil chemistry changed: {state.SoilChemistryChanged}",
            $"Wildlife displaced from central corridor: {state.WildlifeDisplaced}",
            $"Human central route prepared: {state.RoutePrepared}",
            $"Human soil sample collected: {state.SoilSampled}",
            $"Alien route observation completed: {state.RouteObserved}",
            $"Human convoy rerouted west: {state.ConvoyRerouted}",
            $"Alien network observed alternate route: {state.AlternateRouteObserved}"
        });

    public IReadOnlyList<string> BuildAarFindings(IReadOnlyList<TurnRecord> turns) =>
    [
        "Humans observed ecological silence but did not collect the nursery's soil signature on turn 1; aliens recognized the nursery process through continuous watershed contact.",
        "Aliens initially saw hard-surface disturbance without knowing its industrial purpose. A full turn of cadence observation distinguished route preparation from an isolated machine event.",
        "Human soil sampling narrowed the explanation to an active biological process but did not reveal alien intent or the nursery's function.",
        "The human reroute avoided the active nursery corridor and added two turns of travel. Alien observation then exposed the alternate route.",
        "A second soil sample farther from the corridor could have tested the gradient before commitment; longer route observation could have shown whether wildlife absence preceded human preparation."
    ];

    private static IReadOnlyList<Order> ChooseHumanCommitment(FactionSituation situation)
    {
        var hasBiologicalEvidence = situation.AvailableReports.Any(report =>
            report.Description.Contains("biological compound", StringComparison.Ordinal));

        return hasBiologicalEvidence
            ? [new("H-O-T3-01", 3, Faction.Human, "RerouteConvoy", AlternateRoute,
                "Avoid the unresolved biological change in the central corridor.")]
            : [new("H-O-T3-01", 3, Faction.Human, "AdvanceConvoy", Corridor,
                "Use the shortest prepared route.")];
    }

    private static IReadOnlyList<Order> ChooseAlienCommitment(FactionSituation situation)
    {
        var observedTransit = situation.AvailableReports.Any(report =>
            report.Description.Contains("transport cadence", StringComparison.Ordinal));

        return observedTransit
            ? [new("A-O-T3-01", 3, Faction.Alien, "ExtendTrailNetwork", NorthApproach,
                "Observe where the prepared human passage enters the watershed.")]
            : [new("A-O-T3-01", 3, Faction.Alien, "GuardNursery", Corridor,
                "Concentrate observation around the human soil intrusion.")];
    }

    private static ObjectiveTurnResult AdjudicateTurnOne(EmptyCorridorState state)
    {
        state.SoilChemistryChanged = true;
        state.WildlifeDisplaced = true;
        state.RoutePrepared = true;

        return new(
        [
            new("EV-T1-01", 1, "NurseryGrowth", Corridor,
                "Alien nursery growth altered soil chemistry across the central watershed."),
            new("EV-T1-02", 1, "WildlifeMigration", Corridor,
                "Grazers abandoned the central corridor in response to nursery chemistry."),
            new("EV-T1-03", 1, "RoutePreparation", NorthApproach,
                "Human route crews made repeated preparation passes toward the central corridor.")
        ],
        [
            new("SIG-T1-01", "EV-T1-01", 1, "SoilChemistry", Corridor,
                "A propagating active compound is changing soil and water chemistry."),
            new("SIG-T1-02", "EV-T1-02", 1, "WildlifeAbsence", Corridor,
                "Large-animal presence is substantially below the seasonal baseline."),
            new("SIG-T1-03", "EV-T1-02", 1, "WildlifeDisplacement", Corridor,
                "Grazers are moving away from the watershed along lowland paths."),
            new("SIG-T1-04", "EV-T1-03", 1, "SurfaceCompression", NorthApproach,
                "Repeated heavy compression and mechanical vibration mark the northern surface.")
        ]);
    }

    private static ObjectiveTurnResult AdjudicateTurnTwo(
        EmptyCorridorState state,
        IReadOnlyList<Order> orders)
    {
        state.SoilSampled = orders.Any(order => order.Kind == "CollectSoilSample");
        state.RouteObserved = orders.Any(order => order.Kind == "ObserveSurfaceCadence");

        return new(
        [
            new("EV-T2-01", 2, "SoilSampling", Corridor,
                "A human field team removed a soil sample from the nursery watershed."),
            new("EV-T2-02", 2, "RouteObservation", NorthApproach,
                "Alien vibration organisms remained near the human route for one turn.")
        ],
        [
            new("SIG-T2-01", "EV-T1-01", 2, "SoilChemistry", Corridor,
                "The active soil compound forms a gradient toward the central nursery."),
            new("SIG-T2-02", "EV-T1-03", 2, "TrafficCadence", NorthApproach,
                "Mechanical passes repeat at transport intervals and return north."),
            new("SIG-T2-03", "EV-T2-01", 2, "SoilIntrusion", Corridor,
                "A small area of living soil was cut, contained, and removed.")
        ]);
    }

    private static ObjectiveTurnResult AdjudicateTurnThree(
        EmptyCorridorState state,
        IReadOnlyList<Order> orders)
    {
        state.ConvoyRerouted = orders.Any(order => order.Kind == "RerouteConvoy");
        state.AlternateRouteObserved = state.ConvoyRerouted &&
            orders.Any(order => order.Kind == "ExtendTrailNetwork");

        var convoyLocation = state.ConvoyRerouted ? AlternateRoute : Corridor;
        var convoySummary = state.ConvoyRerouted
            ? "The human convoy entered the western spur, adding two turns of travel and avoiding the nursery."
            : "The human convoy entered the central corridor and crossed the nursery watershed.";

        return new(
        [
            new("EV-T3-01", 3, "ConvoyCommitment", convoyLocation, convoySummary),
            new("EV-T3-02", 3, "TrailNetworkExtension", NorthApproach,
                "Alien trail organisms extended their observation network around the prepared route.")
        ],
        [
            new("SIG-T3-01", "EV-T3-01", 3, "ConvoyTelemetry", convoyLocation,
                "Authenticated convoy telemetry records route entry and projected delay."),
            new("SIG-T3-02", "EV-T3-01", 3, "RouteCessation", Corridor,
                "Preparation vibration ceased without heavy passage through the central corridor."),
            new("SIG-T3-03", "EV-T3-01", 3, "AlternateCompression", AlternateRoute,
                "Heavy mechanical compression appeared along the western watershed boundary.")
        ]);
    }

    private static string FactionPrefix(Faction faction) => faction == Faction.Human ? "H" : "A";

    private static IReadOnlyList<string> ReportIds(FactionSituation situation) =>
        situation.AvailableReports.Select(report => report.Id).ToArray();
}