using System.Collections.Generic;

public class ReplayTimeline
{
    public List<ReplaySnapshot> Snapshots { get; }

    public ReplayTimeline()
    {
        Snapshots = new List<ReplaySnapshot>();
    }

    public void AddSnapshot(int tick, WorldState worldState)
    {
        Snapshots.Add(ReplaySnapshot.Capture(tick, worldState));
    }
}