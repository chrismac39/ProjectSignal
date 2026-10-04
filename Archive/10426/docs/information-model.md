# Information Model

> Status: Current specification.

## Purpose
Define how knowledge is represented, updated, and acted on without giving players automated strategic recommendations.

This document owns the vocabulary for the evidence pipeline. See [Technical Architecture](technical-architecture.md) for type boundaries and [North Star](north-star.md) for the design rationale.

## Battlefield Realities
### Omniscient Reality
- True simulation state.
- Used for replay, spectating, development, and analysis.
- Not exposed during normal play.

### Vanguard Reality
- Reports and explicit working interpretations available to the Vanguard commander.
- Built from Vanguard observations, logistics telemetry, and reconnaissance.

### Plastai Reality
- Reports and explicit working interpretations available to the Plastai intelligence.
- Built from Plastai observations, disturbance patterns, and scouting.

## Core Knowledge Units
Do not use one generic signal record for every stage. Preserve the causal chain so replay can explain where divergence occurred.

### Objective Event
- An occurrence in authoritative world state.
- Contains its actual participants, cause, time, and outcome.
- Never available to faction logic.
- May originate from Vanguard action, Plastai action, environmental behavior, or an interaction between them.
- Objective origin does not become faction knowledge unless collected evidence supports attribution.

### Physical Signature
- A detectable physical consequence of an objective event.
- Examples include heat, vibration, residue, movement, sound, chemical change, and species redistribution.
- Does not expose its hidden cause to collection or faction logic.

### Observation
- Evidence actually encountered by a faction collector.
- Records observed qualities, time, place, collector class, and collection conditions.
- Is immutable; later evidence does not rewrite it.

### Faction Report
- A faction-legible description produced from one or more observations.
- Uses distinctions available to that faction's expertise.
- May be delayed, coarse, incomplete, or compatible with several causes.

### Working Interpretation
- A player-authored or scenario-scripted claim about what reports mean.
- Remains separate from reports so the simulation never presents a conclusion as sensed fact.
- Is created by scenario logic in Prototype 0 and may become commander-authored in a future interactive system.
- Can combine several reports, preserve competing explanations, and state what remains unresolved.

Example:

* Report: "The sample contains an unfamiliar active biological compound."
* Working interpretation: "A biological process is changing the corridor; its source and intent remain unknown."

## Actor And Attribution Model

Objective reality distinguishes Vanguard personnel, Plastai entities, directly controlled organisms, and independent environmental actors.

The environment does not receive a faction reality, reports, or working interpretations. Its organisms and processes act from objective state and local behavior rules.

Faction reports should describe observed behavior and qualities before attribution. For example:

* "Large organisms converging on the fence line" is an observation.
* "The Plastai are driving organisms toward the depot" is a working interpretation unless discriminating evidence supports Plastai influence.

Plastai ecological expertise may allow a report to distinguish stress, migration, territorial defense, or known influence mechanisms. It does not reveal another organism's hidden cause or future behavior automatically.

### Recommended Fields
- Faction-local record ID
- Observed qualities
- Reported location or area
- Observation turn
- Delivery turn
- Concrete source class
- Collection method and relevant conditions
- Owning faction
- Links to faction-visible corroborating or contradicting reports

Age is derived from observation and current turns. The system does not convert age, source, or conditions into confidence, reliability, importance, or threat scores.

## Core Loop Mapping
### Signal
- `Signal` is the player-facing loop concept: one or more delivered reports that create a lead. It is not a domain record type and is not synonymous with `PhysicalSignature`.
- A lead appears, not proof.
- Includes noise and ambiguity.
- Should support multiple plausible explanations.
- Starts hypothesis generation, not conclusion.
- Signal variety should come from different causes and world states.
- Signal variety should come from different combinations of observations.
- Avoid generating variety through large synonym libraries alone.

### Investigation
- Player assigns attention and assets.
- Investigation narrows interpretations.
- Investigation tests hypotheses.

### Confirmation
- Dedicated scouting or corroboration acquires evidence that can discriminate between explanations.
- Confirmation means obtaining discriminating evidence, not filling a certainty meter.
- Working interpretations can be supported, contradicted, or left unresolved.
- Old reports remain historically true accounts of what was observed even when their interpretation changes.

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
- Present reports, timestamps, source classes, collection conditions, and explicit working interpretations.
- Do not tell players what to do.
- Do not provide checklist reminders as a crutch.
- Allow players to fail through missed signals and poor prioritization.

## Cross-System Dependencies
- Mobility and access constraints shape what can be investigated: see [Mobility and Terrain](mobility-and-terrain.md).
- Decoys and counter-recon alter available evidence and interpretation: see [Deception and Reconnaissance](design/design-deception-and-recon.md).
- Replay compares belief layers against truth: see [Replay System](replay-system.md).
