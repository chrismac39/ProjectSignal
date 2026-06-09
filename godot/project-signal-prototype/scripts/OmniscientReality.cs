using System.Collections.Generic;

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
                SignalType = signal.SignalType,
                Position = signal.Position,
                Description = signal.Description
            });
        }

        return new OmniscientReality(wildlife, signals);
    }
}