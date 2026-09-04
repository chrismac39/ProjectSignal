using ProjectSignal.Core;

namespace ProjectSignal.Simulation;

public sealed class SimulationEngine
{
    public SimulationRun Run<TState>(IScenario<TState> scenario, int seed) where TState : notnull
    {
        var state = scenario.CreateInitialState(seed);
        var reports = new Dictionary<Faction, List<FactionReport>>
        {
            [Faction.Vanguard] = [],
            [Faction.Plastai] = []
        };
        var interpretations = new Dictionary<Faction, List<WorkingInterpretation>>
        {
            [Faction.Vanguard] = [.. scenario.CreateInitialInterpretations(Faction.Vanguard)],
            [Faction.Plastai] = [.. scenario.CreateInitialInterpretations(Faction.Plastai)]
        };
        var turns = new List<TurnRecord>();

        for (var turn = 1; turn <= scenario.TurnCount; turn++)
        {
            var vanguardSituation = BuildSituation(Faction.Vanguard, turn, reports, interpretations);
            var plastaiSituation = BuildSituation(Faction.Plastai, turn, reports, interpretations);
            var orders = scenario.ChooseOrders(vanguardSituation)
                .Concat(scenario.ChooseOrders(plastaiSituation))
                .ToArray();

            ValidateOrders(turn, orders);

            var objective = scenario.Adjudicate(state, turn, orders);
            var vanguardObservations = scenario.Collect(
                state,
                Faction.Vanguard,
                turn,
                objective.Signatures,
                orders);
            var plastaiObservations = scenario.Collect(
                state,
                Faction.Plastai,
                turn,
                objective.Signatures,
                orders);
            var vanguardReports = vanguardObservations.Select(scenario.Interpret).ToArray();
            var plastaiReports = plastaiObservations.Select(scenario.Interpret).ToArray();

            reports[Faction.Vanguard].AddRange(vanguardReports);
            reports[Faction.Plastai].AddRange(plastaiReports);

            interpretations[Faction.Vanguard] = [.. scenario.UpdateInterpretations(
                BuildSituation(Faction.Vanguard, turn, reports, interpretations))];
            interpretations[Faction.Plastai] = [.. scenario.UpdateInterpretations(
                BuildSituation(Faction.Plastai, turn, reports, interpretations))];

            turns.Add(new TurnRecord(
                turn,
                orders,
                objective.Events,
                objective.Signatures,
                vanguardObservations,
                plastaiObservations,
                vanguardReports,
                plastaiReports,
                [.. interpretations[Faction.Vanguard]],
                [.. interpretations[Faction.Plastai]],
                scenario.CaptureSnapshot(state, turn)));
        }

        return new SimulationRun(
            scenario.Id,
            scenario.Title,
            scenario.Description,
            seed,
            turns,
            scenario.BuildAarFindings(turns));
    }

    private static FactionSituation BuildSituation(
        Faction faction,
        int turn,
        IReadOnlyDictionary<Faction, List<FactionReport>> reports,
        IReadOnlyDictionary<Faction, List<WorkingInterpretation>> interpretations) =>
        new(
            faction,
            turn,
            reports[faction].Where(report => report.DeliveryTurn <= turn).ToArray(),
            [.. interpretations[faction]]);

    private static void ValidateOrders(int turn, IReadOnlyList<Order> orders)
    {
        if (orders.Any(order => order.Turn != turn))
        {
            throw new InvalidOperationException($"All committed orders must target turn {turn}.");
        }

        var duplicateId = orders.GroupBy(order => order.Id).FirstOrDefault(group => group.Count() > 1);
        if (duplicateId is not null)
        {
            throw new InvalidOperationException($"Order ID '{duplicateId.Key}' was committed more than once.");
        }
    }
}