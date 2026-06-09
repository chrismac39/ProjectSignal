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

		var firstWildlife = worldState.Wildlife[0];

		var migrationEvent = new MigrationEvent
		{
			Id = 1,
			Name = "Prototype Migration",
			Direction = Vector2.Right,
			Distance = 50f
		};

		GD.Print("ProjectSignal Prototype 0 started.");
		GD.Print($"World contains {worldState.Wildlife.Count} wildlife entities.");
		GD.Print($"First wildlife starting position: {firstWildlife.Position}");

		migrationEvent.Apply(worldState);

		GD.Print($"Applied migration event: {migrationEvent.Name}");
		GD.Print($"First wildlife ending position: {firstWildlife.Position}");
	}
}
