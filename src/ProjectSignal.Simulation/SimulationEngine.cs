using ProjectSignal.Core;

namespace ProjectSignal.Simulation;

public sealed class SimulationEngine
{
    public SimulationRun Run<TState>(IScenario<TState> scenario, int seed) where TState : notnull
    {
        var state = scenario.CreateInitialState(seed);
        var reports = new Dictionary<Faction, List<FactionReport>>
        {
            [Faction.Human] = [],
            [Faction.Alien] = []
        };
        var interpretations = new Dictionary<Faction, List<WorkingInterpretation>>
        {
            [Faction.Human] = [.. scenario.CreateInitialInterpretations(Faction.Human)],
            [Faction.Alien] = [.. scenario.CreateInitialInterpretations(Faction.Alien)]
        };
        var turns = new List<TurnRecord>();

        for (var turn = 1; turn <= scenario.TurnCount; turn++)
        {
            var humanSituation = BuildSituation(Faction.Human, turn, reports, interpretations);
            var alienSituation = BuildSituation(Faction.Alien, turn, reports, interpretations);
            var orders = scenario.ChooseOrders(humanSituation)
                .Concat(scenario.ChooseOrders(alienSituation))
                .ToArray();

            ValidateOrders(turn, orders);

            var objective = scenario.Adjudicate(state, turn, orders);
            var humanObservations = scenario.Collect(
                state,
                Faction.Human,
                turn,
                objective.Signatures,
                orders);
            var alienObservations = scenario.Collect(
                state,
                Faction.Alien,
                turn,
                objective.Signatures,
                orders);
            var humanReports = humanObservations.Select(scenario.Interpret).ToArray();
            var alienReports = alienObservations.Select(scenario.Interpret).ToArray();

            reports[Faction.Human].AddRange(humanReports);
            reports[Faction.Alien].AddRange(alienReports);

            interpretations[Faction.Human] = [.. scenario.UpdateInterpretations(
                BuildSituation(Faction.Human, turn, reports, interpretations))];
            interpretations[Faction.Alien] = [.. scenario.UpdateInterpretations(
                BuildSituation(Faction.Alien, turn, reports, interpretations))];

            turns.Add(new TurnRecord(
                turn,
                orders,
                objective.Events,
                objective.Signatures,
                humanObservations,
                alienObservations,
                humanReports,
                alienReports,
                [.. interpretations[Faction.Human]],
                [.. interpretations[Faction.Alien]],
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