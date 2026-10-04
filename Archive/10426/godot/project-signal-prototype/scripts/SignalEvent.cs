using Godot;

public class SignalEvent
{
    public int Id { get; set; }
    public WorldEventType EventType { get; set; }
    public EventCategory Category { get; set; }
    public EventClarity Clarity { get; set; }
    public string SignalType { get; set; } = string.Empty;
    public Vector2 Position { get; set; }
    public string Description { get; set; } = string.Empty;
}
