using System.Collections.Generic;
using Godot;

public class OmniscientReality
{
    public List<WildlifeEntity> Wildlife { get; }
    public List<SignalEvent> Signals { get; }

    private OmniscientReality(List<WildlifeEntity> wildlife, List<SignalEvent> signals)
    {
        Wildlife = wildlife;
        Signals = signals;
    }

    public static OmniscientReality GenerateFrom(WorldState worldState)
    {
        var wildlife = new List<WildlifeEntity>();

        foreach (var entity in worldState.Wildlife)
        {
            wildlife.Add(new WildlifeEntity
            {
                Id = entity.Id,
                Species = entity.Species,
                Position = entity.Position
            });
        }

        var signals = new List<SignalEvent>();

        foreach (var signal in worldState.Signals)
        {
            signals.Add(new SignalEvent
            {
                Id = signal.Id,
                EventType = signal.EventType,
                Category = signal.Category,
                Clarity = signal.Clarity,
                SignalType = signal.SignalType,
                Position = signal.Position,
                Description = BuildOmniscientDescription(signal)
            });
        }

        return new OmniscientReality(wildlife, signals);
    }

    private static string BuildOmniscientDescription(SignalEvent signal)
    {
        switch (signal.EventType)
        {
            case WorldEventType.HerbivoreMigration:
                return "10 herbivores migrated east.";
            case WorldEventType.AlienResourceGathering:
                return "Alien resource-gathering organisms harvesting biomass.";
            case WorldEventType.AlienWarriorMovement:
                return "20 warrior organisms moving toward refinery.";
            case WorldEventType.TitanNursery:
                return "Titan nursery under active biome restructuring.";
            case WorldEventType.HumanConvoyMovement:
                return "Fuel convoy departed refinery carrying supplies.";
            case WorldEventType.RefineryStartup:
                return "Refinery online and producing fuel.";
            case WorldEventType.HumanIndustrialExpansion:
                return "Human industrial zone expanded with new structures.";
            case WorldEventType.MajorHumanFacility:
                return "Major human infrastructure complex established.";
            case WorldEventType.IndustrialActivity:
                return "Refinery online and producing fuel.";
            case WorldEventType.UnknownDisturbance:
                return "Unknown atmospheric event damaged the valley ecosystem.";
            default:
                return "Unknown atmospheric event damaged the valley ecosystem.";
        }
    }
}