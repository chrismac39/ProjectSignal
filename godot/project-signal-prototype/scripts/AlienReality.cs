using System.Collections.Generic;

public class AlienReality
{
    public List<SignalEvent> VisibleSignals { get; }

    private AlienReality(List<SignalEvent> visibleSignals)
    {
        VisibleSignals = visibleSignals;
    }

    public static AlienReality GenerateFrom(WorldState worldState)
    {
        var visibleSignals = new List<SignalEvent>();

        foreach (var signal in worldState.Signals)
        {
            var interpretedSignal = new SignalEvent
            {
                Id = signal.Id,
                SignalType = signal.SignalType,
                Position = signal.Position,
                Description = signal.SignalType == "Migration"
                    ? "Docile herbavore movement pattern sensed."
                    : "Unknown ecological disturbance sensed."
            };

            visibleSignals.Add(interpretedSignal);
        }

        return new AlienReality(visibleSignals);
    }
}