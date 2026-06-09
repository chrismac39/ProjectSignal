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
        var visibleSignals = new List<SignalEvent>();

        foreach (var signal in worldState.Signals)
        {
            if (signal.SignalType != "Migration" && signal.SignalType != "Industrial")
            {
                continue;
            }

            var interpretedSignal = new SignalEvent
            {
                Id = signal.Id,
                SignalType = signal.SignalType,
                Position = signal.Position,
                Description = signal.SignalType == "Migration"
                    ? "Large wildlife migration observed."
                    : signal.Description
            };

            visibleSignals.Add(interpretedSignal);
        }

        return new HumanReality(visibleSignals);
    }
}