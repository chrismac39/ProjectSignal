# Information Model

## Purpose
Define how knowledge is represented, updated, and acted on without giving players automated strategic recommendations.

## Battlefield Realities
### Omniscient Reality
- True simulation state.
- Used for replay, spectating, development, and analysis.
- Not exposed during normal play.

### Human Reality
- What the human commander currently believes.
- Built from sensors, reports, logistics telemetry, and reconnaissance.

### Alien Reality
- What the alien intelligence currently believes.
- Built from ecological signals, disturbance patterns, and alien scouting.

## Core Knowledge Units
Represent observations as uncertain records rather than facts.

### Recommended Fields
- Signal type
- Location
- Time observed
- Freshness
- Confidence
- Source quality
- Owning reality layer (human or alien)
- Status: uninvestigated, investigated, confirmed, disproven, stale

## Core Loop Mapping
### Signal
- A lead appears, not proof.
- Includes noise and ambiguity.

### Investigation
- Player assigns attention and assets.
- Investigation narrows interpretations.

### Confirmation
- Dedicated scouting or corroboration verifies or disproves.
- Confirmation may still decay over time.

### Action
- Orders are issued based on current belief, not omniscient truth.

### Assessment
- Outcomes are evaluated.
- Knowledge state is updated.

## Signal Sources
### Human-Side Signals
- Wildlife anomalies
- Thermal signatures
- Sensor contacts
- Destroyed outposts
- Missing convoys

### Alien-Side Signals
- Migration disruption
- Ecological silence
- Habitat collapse
- Persistent heat
- Mechanical vibration
- Nutrient disruption

## Noise and False Positives
Model natural and incidental events that can be misread:
- Natural fires
- Storms
- Predator migrations
- Seasonal die-offs
- Geological heat
- Abandoned sites

## UI and Decision Support Constraints
- Present observations, confidence, and freshness.
- Do not tell players what to do.
- Do not provide checklist reminders as a crutch.
- Allow players to fail through missed signals and poor prioritization.

## Cross-System Dependencies
- Mobility and access constraints shape what can be investigated: see [Mobility and Terrain](mobility-and-terrain.md).
- Decoys and counter-recon alter confidence and interpretation: see [Deception and Recon](deception-and-recon.md).
- Replay compares belief layers against truth: see [Replay System](replay-system.md).
