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
        "Plastai nursery growth displaces wildlife from a valley while the Vanguard prepares a convoy route through it.";

    public int TurnCount => 3;

    public EmptyCorridorState CreateInitialState(int seed) => new();

    public IReadOnlyList<WorkingInterpretation> CreateInitialInterpretations(Faction faction) => faction switch
    {
        Faction.Vanguard =>
        [
            new("V-I-T0-01", faction, 0, "The central corridor is the shortest planned convoy route.", [])
        ],
        Faction.Plastai =>
        [
            new("P-I-T0-01", faction, 0, "The central nursery is entering a normal growth phase.", [])
        ],
        _ => throw new ArgumentOutOfRangeException(nameof(faction))
    };

    public IReadOnlyList<Order> ChooseOrders(FactionSituation situation) =>
        (situation.Faction, situation.Turn) switch
        {
            (Faction.Vanguard, 1) =>
            [
                new("V-O-T1-01", 1, Faction.Vanguard, "RemoteSurvey", Corridor,
                    "Check the planned route before convoy commitment.")
            ],
            (Faction.Plastai, 1) =>
            [
                new("P-O-T1-01", 1, Faction.Plastai, "TendNursery", Corridor,
                    "Continue the nursery growth cycle.")
            ],
            (Faction.Vanguard, 2) =>
            [
                new("V-O-T2-01", 2, Faction.Vanguard, "CollectSoilSample", Corridor,
                    "Distinguish environmental change from deliberate route clearing.")
            ],
            (Faction.Plastai, 2) =>
            [
                new("P-O-T2-01", 2, Faction.Plastai, "ObserveSurfaceCadence", NorthApproach,
                    "Distinguish transit preparation from an isolated disturbance.")
            ],
            (Faction.Vanguard, 3) => ChooseVanguardCommitment(situation),
            (Faction.Plastai, 3) => ChoosePlastaiCommitment(situation),
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
            (Faction.Vanguard, 1) => new[] { "WildlifeAbsence" },
            (Faction.Plastai, 1) => new[] { "SoilChemistry", "WildlifeDisplacement", "SurfaceCompression" },
            (Faction.Vanguard, 2) => new[] { "SoilChemistry" },
            (Faction.Plastai, 2) => new[] { "TrafficCadence", "SoilIntrusion" },
            (Faction.Vanguard, 3) => new[] { "ConvoyTelemetry" },
            (Faction.Plastai, 3) => new[] { "RouteCessation", "AlternateCompression" },
            _ => []
        };

        var sourceClass = (faction, turn) switch
        {
            (Faction.Vanguard, 1) => "Remote multispectral survey",
            (Faction.Vanguard, 2) => "Field sampling team",
            (Faction.Vanguard, 3) => "Convoy telemetry",
            (Faction.Plastai, 1) => "Nursery sensory network",
            (Faction.Plastai, 2) => "Buried vibration organisms",
            (Faction.Plastai, 3) => "Distributed trail organisms",
            _ => "Unknown collector"
        };

        var conditions = (faction, turn) switch
        {
            (Faction.Vanguard, 1) => "One remote pass; no ground access.",
            (Faction.Vanguard, 2) => "Direct sample from one corridor site.",
            (Faction.Vanguard, 3) => "Authenticated friendly-system feed.",
            (Faction.Plastai, 1) => "Continuous contact within the nursery watershed.",
            (Faction.Plastai, 2) => "One full operational turn of local vibration sensing.",
            (Faction.Plastai, 3) => "Partial coverage across two surface routes.",
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
            (Faction.Vanguard, "WildlifeAbsence") =>
                "Large-animal activity is markedly lower than prior route surveys.",
            (Faction.Vanguard, "SoilChemistry") =>
                "The sample contains an unfamiliar active biological compound distributed through the soil.",
            (Faction.Vanguard, "ConvoyTelemetry") =>
                "The convoy entered the western spur and accumulated an additional two turns of travel.",
            (Faction.Plastai, "SoilChemistry") =>
                "Nursery root chemistry is propagating through the central watershed.",
            (Faction.Plastai, "WildlifeDisplacement") =>
                "Grazers are leaving the nursery watershed along the expected lowland path.",
            (Faction.Plastai, "SurfaceCompression") =>
                "Repeated hard-surface compression has begun at the northern edge.",
            (Faction.Plastai, "TrafficCadence") =>
                "Mechanical compression repeats on a transport cadence and returns to the same northern origin.",
            (Faction.Plastai, "SoilIntrusion") =>
                    "A small Vanguard intrusion removed living soil from the nursery watershed.",
            (Faction.Plastai, "RouteCessation") =>
                "The prepared central disturbance ceased before the expected heavy passage.",
            (Faction.Plastai, "AlternateCompression") =>
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
            (Faction.Vanguard, 1) =>
            [
                new("V-I-T1-01", Faction.Vanguard, 1,
                    "The corridor is abnormally quiet; deliberate clearing and ecological disruption remain plausible.",
                    ReportIds(situation))
            ],
            (Faction.Vanguard, 2) =>
            [
                new("V-I-T2-01", Faction.Vanguard, 2,
                    "An unidentified biological process is changing the corridor; its source and intent remain unknown.",
                    ReportIds(situation))
            ],
            (Faction.Vanguard, 3) =>
            [
                new("V-I-T3-01", Faction.Vanguard, 3,
                    "The reroute avoided the unresolved corridor condition at the cost of operational delay.",
                    ReportIds(situation))
            ],
            (Faction.Plastai, 1) =>
            [
                new("P-I-T1-01", Faction.Plastai, 1,
                    "Nursery growth is normal, while a recurring industrial disturbance is forming to the north.",
                    ReportIds(situation))
            ],
            (Faction.Plastai, 2) =>
            [
                new("P-I-T2-01", Faction.Plastai, 2,
                    "The Vanguard is preparing repeated transit and has begun investigating nursery soil.",
                    ReportIds(situation))
            ],
            (Faction.Plastai, 3) =>
            [
                new("P-I-T3-01", Faction.Plastai, 3,
                    "The main Vanguard passage shifted west after the soil intrusion.",
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
            $"Vanguard central route prepared: {state.RoutePrepared}",
            $"Vanguard soil sample collected: {state.SoilSampled}",
            $"Plastai route observation completed: {state.RouteObserved}",
            $"Vanguard convoy rerouted west: {state.ConvoyRerouted}",
            $"Plastai network observed alternate route: {state.AlternateRouteObserved}"
        });

    public IReadOnlyList<string> BuildAarFindings(IReadOnlyList<TurnRecord> turns) =>
    [
        "The Vanguard observed ecological silence but did not collect the nursery's soil signature on turn 1; the Plastai recognized the nursery process through continuous watershed contact.",
        "The Plastai initially saw hard-surface disturbance without knowing its industrial purpose. A full turn of cadence observation distinguished route preparation from an isolated machine event.",
        "Vanguard soil sampling narrowed the explanation to an active biological process but did not reveal Plastai intent or the nursery's function.",
        "The Vanguard reroute avoided the active nursery corridor and added two turns of travel. Plastai observation then exposed the alternate route.",
        "A second soil sample farther from the corridor could have tested the gradient before commitment; longer route observation could have shown whether wildlife absence preceded Vanguard preparation."
    ];

    private static IReadOnlyList<Order> ChooseVanguardCommitment(FactionSituation situation)
    {
        var hasBiologicalEvidence = situation.AvailableReports.Any(report =>
            report.Description.Contains("biological compound", StringComparison.Ordinal));

        return hasBiologicalEvidence
            ? [new("V-O-T3-01", 3, Faction.Vanguard, "RerouteConvoy", AlternateRoute,
                "Avoid the unresolved biological change in the central corridor.")]
            : [new("V-O-T3-01", 3, Faction.Vanguard, "AdvanceConvoy", Corridor,
                "Use the shortest prepared route.")];
    }

    private static IReadOnlyList<Order> ChoosePlastaiCommitment(FactionSituation situation)
    {
        var observedTransit = situation.AvailableReports.Any(report =>
            report.Description.Contains("transport cadence", StringComparison.Ordinal));

        return observedTransit
            ? [new("P-O-T3-01", 3, Faction.Plastai, "ExtendTrailNetwork", NorthApproach,
                "Observe where the prepared Vanguard passage enters the watershed.")]
            : [new("P-O-T3-01", 3, Faction.Plastai, "GuardNursery", Corridor,
                "Concentrate observation around the Vanguard soil intrusion.")];
    }

    private static ObjectiveTurnResult AdjudicateTurnOne(EmptyCorridorState state)
    {
        state.SoilChemistryChanged = true;
        state.WildlifeDisplaced = true;
        state.RoutePrepared = true;

        return new(
        [
            new("EV-T1-01", 1, "NurseryGrowth", Corridor,
                "Plastai nursery growth altered soil chemistry across the central watershed."),
            new("EV-T1-02", 1, "WildlifeMigration", Corridor,
                "Grazers abandoned the central corridor in response to nursery chemistry."),
            new("EV-T1-03", 1, "RoutePreparation", NorthApproach,
                "Vanguard route crews made repeated preparation passes toward the central corridor.")
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
                "A Vanguard field team removed a soil sample from the nursery watershed."),
            new("EV-T2-02", 2, "RouteObservation", NorthApproach,
                "Plastai vibration organisms remained near the Vanguard route for one turn.")
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
            ? "The Vanguard convoy entered the western spur, adding two turns of travel and avoiding the nursery."
            : "The Vanguard convoy entered the central corridor and crossed the nursery watershed.";

        return new(
        [
            new("EV-T3-01", 3, "ConvoyCommitment", convoyLocation, convoySummary),
            new("EV-T3-02", 3, "TrailNetworkExtension", NorthApproach,
                "Plastai trail organisms extended their observation network around the prepared route.")
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

    private static string FactionPrefix(Faction faction) => faction switch
    {
        Faction.Vanguard => "V",
        Faction.Plastai => "P",
        _ => throw new ArgumentOutOfRangeException(nameof(faction), faction, "Unknown faction.")
    };

    private static IReadOnlyList<string> ReportIds(FactionSituation situation) =>
        situation.AvailableReports.Select(report => report.Id).ToArray();
}