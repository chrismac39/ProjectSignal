using Godot;

public class ReplaySnapshot
{
    public int Tick { get; set; }
    public int WildlifeCount { get; set; }
    public int SignalCount { get; set; }
    public Vector2 FirstWildlifePosition { get; set; }

    public static ReplaySnapshot Capture(int tick, WorldState worldState)
    {
        var firstWildlifePosition = worldState.Wildlife.Count > 0
            ? worldState.Wildlife[0].Position
            : Vector2.Zero;

        return new ReplaySnapshot
        {
            Tick = tick,
            WildlifeCount = worldState.Wildlife.Count,
            SignalCount = worldState.Signals.Count,
            FirstWildlifePosition = firstWildlifePosition
        };
    }
}