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

		GD.Print("ProjectSignal Prototype 0 started.");
		GD.Print($"World contains {worldState.Wildlife.Count} wildlife entities.");
	}
}
