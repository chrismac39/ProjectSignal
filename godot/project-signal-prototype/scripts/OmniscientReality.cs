using System.Collections.Generic;
using Godot;

public class OmniscientReality
{
    public List<WildlifeEntity> Wildlife { get; }
    public List<SignalEvent> Signals { get; }

    private OmniscientReality(List<WildlifeEntity> wildlife, List<SignalEvent> signals)
    {
        Wildlife = wildlife;
        Signals = signals;
    }

    public static OmniscientReality GenerateFrom(WorldState worldState)
    {
        var wildlife = new List<WildlifeEntity>();

        foreach (var entity in worldState.Wildlife)
        {
            wildlife.Add(new WildlifeEntity
            {
                Id = entity.Id,
                Species = entity.Species,
                Position = entity.Position
            });
        }

        var signals = new List<SignalEvent>();

        foreach (var signal in worldState.Signals)
        {
            signals.Add(new SignalEvent
            {
                Id = signal.Id,
                SignalType = signal.SignalType,
                Position = signal.Position,
                Description = BuildOmniscientDescription(signal),
                AffectedWildlifeCount = signal.AffectedWildlifeCount,
                AverageMovement = signal.AverageMovement
            });
        }

        return new OmniscientReality(wildlife, signals);
    }

    private static string BuildOmniscientDescription(SignalEvent signal)
    {
        if (signal.SignalType == "Migration")
        {
            var affectedWildlifeCount = signal.AffectedWildlifeCount ?? 0;
            var averageMovement = signal.AverageMovement ?? Vector2.Zero;
            var movementDistance = averageMovement.Length();
            var movementDirection = DescribeDirection(averageMovement);

            return
                $"MigrationEvent #{signal.Id} affected {affectedWildlifeCount} wildlife entities.\n" +
                $"Average movement: {movementDistance:0.##} units {movementDirection}.\n" +
                $"Observed center position: ({signal.Position.X:0.##}, {signal.Position.Y:0.##}).";
        }

        return
            $"SignalEvent #{signal.Id} recorded as {signal.SignalType}.\n" +
            $"Observed position: ({signal.Position.X:0.##}, {signal.Position.Y:0.##}).";
    }

    private static string DescribeDirection(Vector2 movement)
    {
        if (movement == Vector2.Zero)
        {
            return "stationary";
        }

        if (Mathf.Abs(movement.X) >= Mathf.Abs(movement.Y))
        {
            return movement.X >= 0f ? "east" : "west";
        }

        return movement.Y >= 0f ? "south" : "north";
    }
}