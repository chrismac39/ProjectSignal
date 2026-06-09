using System;
using Godot;

public class WildlifeEntity
{
    public Guid Id { get; set; }
    public string Species { get; set; } = string.Empty;
    public Vector2 Position { get; set; }
}
