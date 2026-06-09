using Godot;

public class MigrationEvent
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Vector2 Direction { get; set; }
    public float Distance { get; set; }

    public void Apply(WorldState worldState)
    {
        var offset = Direction.Normalized() * Distance;

        foreach (var wildlife in worldState.Wildlife)
        {
            wildlife.Position += offset;
        }

        if (worldState.Wildlife.Count == 0)
        {
            return;
        }

        var sum = Vector2.Zero;

        foreach (var wildlife in worldState.Wildlife)
        {
            sum += wildlife.Position;
        }

        var averagePosition = sum / worldState.Wildlife.Count;

        var signal = new SignalEvent
        {
            Id = worldState.Signals.Count + 1,
            SignalType = "Migration",
            Position = averagePosition,
            Description = "Large wildlife migration detected."
        };

        worldState.Signals.Add(signal);
    }
}
