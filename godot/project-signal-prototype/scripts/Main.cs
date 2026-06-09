using System;
using Godot;

public partial class Main : Node
{
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

		GD.Print("ProjectSignal Prototype 0 started.");
		GD.Print($"World contains {worldState.Wildlife.Count} wildlife entities.");

		migrationEvent.Apply(worldState);
		var firstSignal = worldState.Signals[0];
		var humanReality = HumanReality.GenerateFrom(worldState);
		var firstVisibleSignal = humanReality.VisibleSignals[0];
		var alienReality = AlienReality.GenerateFrom(worldState);
		var firstAlienSignal = alienReality.VisibleSignals[0];

		GD.Print($"Applied migration event: {migrationEvent.Name}");
		GD.Print($"Signal count: {worldState.Signals.Count}");
		GD.Print($"Signal type: {firstSignal.SignalType}");
		GD.Print($"Signal description: {firstSignal.Description}");
		GD.Print($"Signal position: {firstSignal.Position}");
		GD.Print($"Human Reality visible signals: {humanReality.VisibleSignals.Count}");
		GD.Print($"First visible signal description: {firstVisibleSignal.Description}");
		GD.Print($"Alien Reality visible signals: {alienReality.VisibleSignals.Count}");
		GD.Print($"First alien signal description: {firstAlienSignal.Description}");
	}
}
