using ProjectSignal.Core;

namespace ProjectSignal.Simulation;

public interface IScenario<TState> where TState : notnull
{
    string Id { get; }

    string Title { get; }

    string Description { get; }

    int TurnCount { get; }

    TState CreateInitialState(int seed);

    IReadOnlyList<WorkingInterpretation> CreateInitialInterpretations(Faction faction);

    IReadOnlyList<Order> ChooseOrders(FactionSituation situation);

    ObjectiveTurnResult Adjudicate(TState state, int turn, IReadOnlyList<Order> committedOrders);

    IReadOnlyList<Observation> Collect(
        TState state,
        Faction faction,
        int turn,
        IReadOnlyList<PhysicalSignature> signatures,
        IReadOnlyList<Order> committedOrders);

    FactionReport Interpret(Observation observation);

    IReadOnlyList<WorkingInterpretation> UpdateInterpretations(FactionSituation situation);

    WorldSnapshot CaptureSnapshot(TState state, int turn);

    IReadOnlyList<string> BuildAarFindings(IReadOnlyList<TurnRecord> turns);
}