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
            if (signal.SignalType != "Migration" && signal.SignalType != "Ecological")
            {
                continue;
            }

            var interpretedSignal = new SignalEvent
            {
                Id = signal.Id,
                SignalType = signal.SignalType,
                Position = signal.Position,
                Description = signal.SignalType == "Migration"
                    ? "Docile herbivore movement pattern sensed."
                    : signal.Description
            };

            visibleSignals.Add(interpretedSignal);
        }

        return new AlienReality(visibleSignals);
    }
}