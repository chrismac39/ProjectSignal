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
            var expertise = ObserverExpertise.GetExpertise(ObserverFaction.Alien, signal.Category);

            var interpretedSignal = new SignalEvent
            {
                Id = signal.Id,
                EventType = signal.EventType,
                Category = signal.Category,
                Clarity = signal.Clarity,
                SignalType = signal.SignalType,
                Position = signal.Position,
                Description = BuildAlienDescription(signal.EventType, signal.Clarity, expertise)
            };

            visibleSignals.Add(interpretedSignal);
        }

        return new AlienReality(visibleSignals);
    }

    private static string BuildAlienDescription(
        WorldEventType eventType,
        EventClarity clarity,
        ExpertiseLevel expertise)
    {
        switch (eventType)
        {
            case WorldEventType.HerbivoreMigration:
                return "Herd migration route altered.";
            case WorldEventType.AlienResourceGathering:
                return "Multiple species avoiding the same region.";
            case WorldEventType.AlienWarriorMovement:
                return "Warrior caste movement detected.";
            case WorldEventType.TitanNursery:
                return "Titan nursery growth phase identified.";
            case WorldEventType.HumanConvoyMovement:
                return "Large ground disturbance detected.";
            case WorldEventType.RefineryStartup:
                return "Persistent industrial disturbance detected.";
            case WorldEventType.HumanIndustrialExpansion:
                return "Multiple herds fleeing a common origin point.";
            case WorldEventType.MajorHumanFacility:
                return "Large artificial structures observed.";
            case WorldEventType.IndustrialActivity:
                return "Persistent industrial disturbance detected.";
            case WorldEventType.UnknownDisturbance:
                return "Abnormal environmental disruption sensed.";
            default:
                return BuildFallbackDescription(clarity, expertise, "ecosystem anomaly", "industrial disturbance");
        }
    }

    private static string BuildFallbackDescription(
        EventClarity clarity,
        ExpertiseLevel expertise,
        string ecologicalNoun,
        string industrialNoun)
    {
        if (expertise == ExpertiseLevel.High && clarity == EventClarity.Clear)
        {
            return $"Confirmed {ecologicalNoun}.";
        }

        switch (clarity)
        {
            case EventClarity.HighAmbiguity:
                return $"Potential {ecologicalNoun} sensed.";
            case EventClarity.ModerateAmbiguity:
                return $"Persistent {industrialNoun} sensed.";
            case EventClarity.LowAmbiguity:
                return $"Organized {industrialNoun} pattern sensed.";
            case EventClarity.Clear:
                return $"Confirmed {industrialNoun}.";
            default:
                return "Unknown environmental anomaly sensed.";
        }
    }
}