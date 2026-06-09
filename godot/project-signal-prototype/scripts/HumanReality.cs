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
            var expertise = ObserverExpertise.GetExpertise(ObserverFaction.Human, signal.Category);

            var interpretedSignal = new SignalEvent
            {
                Id = signal.Id,
                EventType = signal.EventType,
                Category = signal.Category,
                Clarity = signal.Clarity,
                SignalType = signal.SignalType,
                Position = signal.Position,
                Description = BuildHumanDescription(signal.EventType, signal.Clarity, expertise)
            };

            visibleSignals.Add(interpretedSignal);
        }

        return new HumanReality(visibleSignals);
    }

    private static string BuildHumanDescription(
        WorldEventType eventType,
        EventClarity clarity,
        ExpertiseLevel expertise)
    {
        switch (eventType)
        {
            case WorldEventType.HerbivoreMigration:
                return "Herd movement detected.";
            case WorldEventType.AlienResourceGathering:
                return "Intense fauna activity detected in valley.";
            case WorldEventType.AlienWarriorMovement:
                return "Organized fauna activity detected.";
            case WorldEventType.TitanNursery:
                return "Massive biome restructuring observed.";
            case WorldEventType.HumanConvoyMovement:
                return "Fuel convoy departed refinery.";
            case WorldEventType.RefineryStartup:
                return "Refinery construction completed.";
            case WorldEventType.HumanIndustrialExpansion:
                return "Industrial expansion activity confirmed.";
            case WorldEventType.MajorHumanFacility:
                return "Major infrastructure node established.";
            case WorldEventType.IndustrialActivity:
                return "Refinery construction completed.";
            case WorldEventType.UnknownDisturbance:
                return "Severe atmospheric anomaly detected.";
            default:
                return BuildFallbackDescription(clarity, expertise, "ecological disturbance", "infrastructure disturbance");
        }
    }

    private static string BuildFallbackDescription(
        EventClarity clarity,
        ExpertiseLevel expertise,
        string ecologicalNoun,
        string industrialNoun)
    {
        if (expertise == ExpertiseLevel.High)
        {
            return $"Confirmed {industrialNoun}.";
        }

        switch (clarity)
        {
            case EventClarity.HighAmbiguity:
                return $"Potential {ecologicalNoun} detected.";
            case EventClarity.ModerateAmbiguity:
                return $"Persistent {industrialNoun} detected.";
            case EventClarity.LowAmbiguity:
                return $"Organized {industrialNoun} pattern detected.";
            case EventClarity.Clear:
                return $"Confirmed {industrialNoun}.";
            default:
                return "Unclassified disturbance detected.";
        }
    }
}