using System;
using Godot;

public partial class Main : Node
{
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

	public override void _Ready()
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

		var migrationEvent = new MigrationEvent
		{
			Id = 1,
			Name = "Prototype Migration",
			Direction = Vector2.Right,
			Distance = 50f
		};
		var replayTimeline = new ReplayTimeline();

		GD.Print("ProjectSignal Prototype 0 started.");
		GD.Print($"World contains {worldState.Wildlife.Count} wildlife entities.");

		replayTimeline.AddSnapshot(0, worldState);

		migrationEvent.Apply(worldState);
		replayTimeline.AddSnapshot(1, worldState);

		var firstSnapshot = replayTimeline.Snapshots[0];
		var lastSnapshot = replayTimeline.Snapshots[replayTimeline.Snapshots.Count - 1];
		var firstWildlifeXMovement = lastSnapshot.FirstWildlifePosition.X - firstSnapshot.FirstWildlifePosition.X;
		var firstSignal = worldState.Signals[0];
		var humanReality = HumanReality.GenerateFrom(worldState);
		var firstVisibleSignal = humanReality.VisibleSignals[0];
		var alienReality = AlienReality.GenerateFrom(worldState);
		var firstAlienSignal = alienReality.VisibleSignals[0];
		var omniscientReality = OmniscientReality.GenerateFrom(worldState);
		var firstOmniscientSignal = omniscientReality.Signals[0];
		var currentLayer = RealityLayerType.Human;

		GD.Print($"Applied migration event: {migrationEvent.Name}");
		GD.Print(string.Empty);
		GD.Print($"Replay snapshot count: {replayTimeline.Snapshots.Count}");
		GD.Print($"First snapshot tick: {firstSnapshot.Tick}");
		GD.Print($"Last snapshot tick: {lastSnapshot.Tick}");
		GD.Print($"Tick 0 first wildlife position: {firstSnapshot.FirstWildlifePosition}");
		GD.Print($"Tick 1 first wildlife position: {lastSnapshot.FirstWildlifePosition}");
		GD.Print($"First wildlife X movement: {firstWildlifeXMovement:0.##}");
		GD.Print(string.Empty);
		GD.Print($"Signal count: {worldState.Signals.Count}");
		GD.Print($"Signal type: {firstSignal.SignalType}");
		GD.Print($"Signal description: {firstSignal.Description}");
		GD.Print($"Signal position: {firstSignal.Position}");
		GD.Print($"Human Reality visible signals: {humanReality.VisibleSignals.Count}");
		GD.Print($"First visible signal description: {firstVisibleSignal.Description}");
		GD.Print(string.Empty);
		GD.Print($"Alien Reality visible signals: {alienReality.VisibleSignals.Count}");
		GD.Print($"First alien signal description: {firstAlienSignal.Description}");
		GD.Print(string.Empty);
		GD.Print($"Omniscient wildlife count: {omniscientReality.Wildlife.Count}");
		GD.Print($"Omniscient signal count: {omniscientReality.Signals.Count}");
		GD.Print($"First omniscient signal description: {firstOmniscientSignal.Description}");
		GD.Print(string.Empty);

		PrintCurrentRealityLayer(currentLayer, humanReality, alienReality, omniscientReality);
		currentLayer = RealityLayerType.Alien;
		PrintCurrentRealityLayer(currentLayer, humanReality, alienReality, omniscientReality);
		currentLayer = RealityLayerType.Omniscient;
		PrintCurrentRealityLayer(currentLayer, humanReality, alienReality, omniscientReality);
	}
}
