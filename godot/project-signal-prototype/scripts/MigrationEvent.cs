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
    }
}
