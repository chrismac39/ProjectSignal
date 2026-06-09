using System;
using Godot;

public class PrototypeScenarioRunner
{
    public void Run()
    {
        var worldState = CreateWorldStateWithWildlife();
        var migrationEvent = CreatePrototypeMigrationEvent();
        var replayTimeline = new ReplayTimeline();

        GD.Print($"World contains {worldState.Wildlife.Count} wildlife entities.");

        RecordMigrationSnapshots(worldState, migrationEvent, replayTimeline);
        AddPerceptionTestSignals(worldState);

        var firstSnapshot = replayTimeline.Snapshots[0];
        var lastSnapshot = replayTimeline.Snapshots[replayTimeline.Snapshots.Count - 1];
        var firstWildlifeXMovement = lastSnapshot.FirstWildlifePosition.X - firstSnapshot.FirstWildlifePosition.X;
        var (humanReality, alienReality, omniscientReality) = GenerateRealities(worldState);

        PrintScenarioSummary(
            worldState,
            migrationEvent,
            replayTimeline,
            firstSnapshot,
            lastSnapshot,
            firstWildlifeXMovement,
            humanReality,
            alienReality,
            omniscientReality);

        PrintRealityLayerSwitching(humanReality, alienReality, omniscientReality);
    }

    private static WorldState CreateWorldStateWithWildlife()
    {
        var worldState = new WorldState();
        var rng = new RandomNumberGenerator();

        for (var i = 0; i < 10; i++)
        {
            var wildlife = new WildlifeEntity
            {
                Id = Guid.NewGuid(),
                Species = "Unknown",
                Position = new Vector2(rng.RandfRange(0f, 1000f), rng.RandfRange(0f, 1000f))
            };

            worldState.Wildlife.Add(wildlife);
        }

        return worldState;
    }

    private static MigrationEvent CreatePrototypeMigrationEvent()
    {
        return new MigrationEvent
        {
            Id = 1,
            Name = "Prototype Migration",
            Direction = Vector2.Right,
            Distance = 50f
        };
    }

    private static void RecordMigrationSnapshots(
        WorldState worldState,
        MigrationEvent migrationEvent,
        ReplayTimeline replayTimeline)
    {
        replayTimeline.AddSnapshot(0, worldState);
        migrationEvent.Apply(worldState);
        replayTimeline.AddSnapshot(1, worldState);
    }

    private static void AddPerceptionTestSignals(WorldState worldState)
    {
        worldState.Signals.Add(new SignalEvent
        {
            Id = worldState.Signals.Count + 1,
            EventType = WorldEventType.IndustrialActivity,
            SignalType = "Industrial",
            Description = "Refinery construction completed.",
            Position = new Vector2(600f, 300f)
        });

        worldState.Signals.Add(new SignalEvent
        {
            Id = worldState.Signals.Count + 1,
            EventType = WorldEventType.UnknownDisturbance,
            SignalType = "Unknown",
            Description = "Unclassified disturbance.",
            Position = new Vector2(200f, 700f)
        });
    }

    private static (HumanReality humanReality, AlienReality alienReality, OmniscientReality omniscientReality)
        GenerateRealities(WorldState worldState)
    {
        var humanReality = HumanReality.GenerateFrom(worldState);
        var alienReality = AlienReality.GenerateFrom(worldState);
        var omniscientReality = OmniscientReality.GenerateFrom(worldState);

        return (humanReality, alienReality, omniscientReality);
    }

    private static void PrintScenarioSummary(
        WorldState worldState,
        MigrationEvent migrationEvent,
        ReplayTimeline replayTimeline,
        ReplaySnapshot firstSnapshot,
        ReplaySnapshot lastSnapshot,
        float firstWildlifeXMovement,
        HumanReality humanReality,
        AlienReality alienReality,
        OmniscientReality omniscientReality)
    {
        GD.Print($"Applied migration event: {migrationEvent.Name}");
        GD.Print(string.Empty);
        GD.Print($"Replay snapshot count: {replayTimeline.Snapshots.Count}");
        GD.Print($"First snapshot tick: {firstSnapshot.Tick}");
        GD.Print($"Last snapshot tick: {lastSnapshot.Tick}");
        GD.Print($"Tick 0 first wildlife position: {firstSnapshot.FirstWildlifePosition}");
        GD.Print($"Tick 1 first wildlife position: {lastSnapshot.FirstWildlifePosition}");
        GD.Print($"First wildlife X movement: {firstWildlifeXMovement:0.##}");
        GD.Print(string.Empty);
        GD.Print($"WorldState signal count: {worldState.Signals.Count}");
        GD.Print($"Human Reality visible signals: {humanReality.VisibleSignals.Count}");
        GD.Print($"Human visible signal descriptions: {JoinSignalDescriptions(humanReality.VisibleSignals)}");
        GD.Print(string.Empty);
        GD.Print($"Alien Reality visible signals: {alienReality.VisibleSignals.Count}");
        GD.Print($"Alien visible signal descriptions: {JoinSignalDescriptions(alienReality.VisibleSignals)}");
        GD.Print(string.Empty);
        GD.Print($"Omniscient wildlife count: {omniscientReality.Wildlife.Count}");
        GD.Print($"Omniscient signal count: {omniscientReality.Signals.Count}");
        GD.Print(string.Empty);

        PrintCrossLayerInterpretation(humanReality, alienReality, omniscientReality);
        GD.Print(string.Empty);
    }

    private static void PrintCrossLayerInterpretation(
        HumanReality humanReality,
        AlienReality alienReality,
        OmniscientReality omniscientReality)
    {
        GD.Print("Same world events interpreted by each reality layer:");

        for (var i = 0; i < omniscientReality.Signals.Count; i++)
        {
            var eventId = omniscientReality.Signals[i].Id;
            var humanDescription = GetSignalDescriptionById(humanReality.VisibleSignals, eventId);
            var alienDescription = GetSignalDescriptionById(alienReality.VisibleSignals, eventId);
            var omniscientDescription = omniscientReality.Signals[i].Description;

            GD.Print($"Event #{eventId} Human: {humanDescription}");
            GD.Print($"Event #{eventId} Alien: {alienDescription}");
            GD.Print($"Event #{eventId} Omniscient: {omniscientDescription}");
            GD.Print(string.Empty);
        }
    }

    private static string GetSignalDescriptionById(
        System.Collections.Generic.List<SignalEvent> signals,
        int id)
    {
        for (var i = 0; i < signals.Count; i++)
        {
            if (signals[i].Id == id)
            {
                return signals[i].Description;
            }
        }

        return "No visible interpretation.";
    }

    private static string JoinSignalDescriptions(System.Collections.Generic.List<SignalEvent> signals)
    {
        if (signals.Count == 0)
        {
            return "None";
        }

        var descriptions = new string[signals.Count];

        for (var i = 0; i < signals.Count; i++)
        {
            descriptions[i] = signals[i].Description;
        }

        return string.Join(" | ", descriptions);
    }

    private static void PrintRealityLayerSwitching(
        HumanReality humanReality,
        AlienReality alienReality,
        OmniscientReality omniscientReality)
    {
        var currentLayer = RealityLayerType.Human;

        PrintCurrentRealityLayer(currentLayer, humanReality, alienReality, omniscientReality);
        currentLayer = RealityLayerType.Alien;
        PrintCurrentRealityLayer(currentLayer, humanReality, alienReality, omniscientReality);
        currentLayer = RealityLayerType.Omniscient;
        PrintCurrentRealityLayer(currentLayer, humanReality, alienReality, omniscientReality);
    }

    private static void PrintCurrentRealityLayer(
        RealityLayerType currentLayer,
        HumanReality humanReality,
        AlienReality alienReality,
        OmniscientReality omniscientReality)
    {
        GD.Print($"Active Reality Layer: {currentLayer}");

        switch (currentLayer)
        {
            case RealityLayerType.Human:
                GD.Print($"Layer signal: {(humanReality.VisibleSignals.Count > 0 ? humanReality.VisibleSignals[0].Description : "No visible signals.")}");
                break;
            case RealityLayerType.Alien:
                GD.Print($"Layer signal: {(alienReality.VisibleSignals.Count > 0 ? alienReality.VisibleSignals[0].Description : "No visible signals.")}");
                break;
            case RealityLayerType.Omniscient:
                GD.Print($"Layer signal: {(omniscientReality.Signals.Count > 0 ? omniscientReality.Signals[0].Description : "No factual signals.")}");
                break;
        }

        GD.Print(string.Empty);
    }
}
