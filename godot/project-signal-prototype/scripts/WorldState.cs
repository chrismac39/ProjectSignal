using System.Collections.Generic;

public class WorldState
{
    public List<WildlifeEntity> Wildlife { get; }
    public List<SignalEvent> Signals { get; }

    public WorldState()
    {
        Wildlife = new List<WildlifeEntity>();
        Signals = new List<SignalEvent>();
    }
}
