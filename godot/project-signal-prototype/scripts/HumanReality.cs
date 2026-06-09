using System.Collections.Generic;

public class HumanReality
{
    public List<SignalEvent> VisibleSignals { get; }

    private HumanReality(List<SignalEvent> visibleSignals)
    {
        VisibleSignals = visibleSignals;
    }

    public static HumanReality GenerateFrom(WorldState worldState)
    {
        var visibleSignals = new List<SignalEvent>(worldState.Signals);
        return new HumanReality(visibleSignals);
    }
}