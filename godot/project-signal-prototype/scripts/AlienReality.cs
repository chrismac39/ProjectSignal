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
                EventType = signal.EventType,
                SignalType = signal.SignalType,
                Position = signal.Position,
                Description = BuildAlienDescription(signal.EventType)
            };

            visibleSignals.Add(interpretedSignal);
        }

        return new AlienReality(visibleSignals);
    }

    private static string BuildAlienDescription(WorldEventType eventType)
    {
        switch (eventType)
        {
            case WorldEventType.HerbivoreMigration:
                return "Docile herbivore migration detected.";
            case WorldEventType.AlienWarriorMovement:
                return "Warrior caste movement.";
            case WorldEventType.IndustrialActivity:
                return "Persistent industrial disturbance detected.";
            case WorldEventType.UnknownDisturbance:
                return "Unknown environmental anomaly sensed.";
            default:
                return "Unknown environmental anomaly sensed.";
        }
    }
}