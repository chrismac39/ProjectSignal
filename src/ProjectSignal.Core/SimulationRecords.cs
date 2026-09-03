namespace ProjectSignal.Core;

public enum Faction
{
    Human,
    Alien
}

public readonly record struct Location(string Area)
{
    public override string ToString() => Area;
}

public sealed record Order(
    string Id,
    int Turn,
    Faction Faction,
    string Kind,
    Location Destination,
    string Intent);

public sealed record ObjectiveEvent(
    string Id,
    int Turn,
    string Kind,
    Location Location,
    string Summary);

public sealed record PhysicalSignature(
    string Id,
    string SourceEventId,
    int Turn,
    string Kind,
    Location Location,
    string ObservableDetail);

public sealed record Observation(
    string Id,
    Faction Faction,
    int ObservedTurn,
    int DeliveryTurn,
    string SourceClass,
    string ObservedKind,
    Location Location,
    string ObservableDetail,
    string CollectionConditions);

public sealed record FactionReport(
    string Id,
    Faction Faction,
    int ObservedTurn,
    int DeliveryTurn,
    string SourceClass,
    Location Location,
    string Description,
    string CollectionConditions);

public sealed record WorkingInterpretation(
    string Id,
    Faction Faction,
    int Turn,
    string Claim,
    IReadOnlyList<string> BasedOnReportIds);

public sealed record FactionSituation(
    Faction Faction,
    int Turn,
    IReadOnlyList<FactionReport> AvailableReports,
    IReadOnlyList<WorkingInterpretation> WorkingInterpretations);

public sealed record WorldSnapshot(
    int Turn,
    IReadOnlyList<string> ObjectiveFacts);

public sealed record ObjectiveTurnResult(
    IReadOnlyList<ObjectiveEvent> Events,
    IReadOnlyList<PhysicalSignature> Signatures);

public sealed record TurnRecord(
    int Turn,
    IReadOnlyList<Order> Orders,
    IReadOnlyList<ObjectiveEvent> ObjectiveEvents,
    IReadOnlyList<PhysicalSignature> Signatures,
    IReadOnlyList<Observation> HumanObservations,
    IReadOnlyList<Observation> AlienObservations,
    IReadOnlyList<FactionReport> HumanReports,
    IReadOnlyList<FactionReport> AlienReports,
    IReadOnlyList<WorkingInterpretation> HumanInterpretations,
    IReadOnlyList<WorkingInterpretation> AlienInterpretations,
    WorldSnapshot Snapshot);

public sealed record SimulationRun(
    string ScenarioId,
    string ScenarioTitle,
    string ScenarioDescription,
    int Seed,
    IReadOnlyList<TurnRecord> Turns,
    IReadOnlyList<string> AarFindings);