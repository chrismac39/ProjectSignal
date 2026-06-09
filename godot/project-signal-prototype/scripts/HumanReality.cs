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
            var interpretedSignal = new SignalEvent
            {
                Id = signal.Id,
                EventType = signal.EventType,
                SignalType = signal.SignalType,
                Position = signal.Position,
                Description = BuildHumanDescription(signal.EventType)
            };

            visibleSignals.Add(interpretedSignal);
        }

        return new HumanReality(visibleSignals);
    }

    private static string BuildHumanDescription(WorldEventType eventType)
    {
        switch (eventType)
        {
            case WorldEventType.HerbivoreMigration:
                return "Large animal movement observed.";
            case WorldEventType.AlienWarriorMovement:
                return "Large animal movement observed.";
            case WorldEventType.HumanConvoyMovement:
                return "Fuel convoy departed refinery.";
            case WorldEventType.RefineryStartup:
                return "Refinery construction completed.";
            case WorldEventType.IndustrialActivity:
                return "Refinery construction completed.";
            case WorldEventType.UnknownDisturbance:
                return "Unclassified disturbance detected.";
            default:
                return "Unclassified disturbance detected.";
        }
    }
}