public enum ObserverFaction
{
    Human,
    Alien
}

public enum ExpertiseLevel
{
    Low,
    Moderate,
    High
}

public static class ObserverExpertise
{
    public static ExpertiseLevel GetExpertise(ObserverFaction observer, EventCategory category)
    {
        if (observer == ObserverFaction.Human)
        {
            return GetHumanExpertise(category);
        }

        return GetAlienExpertise(category);
    }

    private static ExpertiseLevel GetHumanExpertise(EventCategory category)
    {
        switch (category)
        {
            case EventCategory.HumanCivilization:
                return ExpertiseLevel.High;
            case EventCategory.Natural:
                return ExpertiseLevel.Moderate;
            case EventCategory.AlienCivilization:
                return ExpertiseLevel.Low;
            case EventCategory.Unknown:
                return ExpertiseLevel.Low;
            default:
                return ExpertiseLevel.Moderate;
        }
    }

    private static ExpertiseLevel GetAlienExpertise(EventCategory category)
    {
        switch (category)
        {
            case EventCategory.Natural:
            case EventCategory.AlienCivilization:
                return ExpertiseLevel.High;
            case EventCategory.HumanCivilization:
                return ExpertiseLevel.Low;
            case EventCategory.Unknown:
                return ExpertiseLevel.Moderate;
            default:
                return ExpertiseLevel.Moderate;
        }
    }
}