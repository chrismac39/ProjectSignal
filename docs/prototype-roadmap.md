# Prototype Roadmap

> Status: Current planning sequence. Only Milestone 0 is active.

This roadmap keeps the headless simulation focused on information and asymmetric perception before combat or economy complexity.

## Milestone 0: Headless Information Loop
### Goal
Prove that objective, human, and alien records can diverge for traceable reasons and affect scripted operational decisions.

### Include
- Standalone .NET solution
- Deterministic WEGO turn sequence
- Hand-authored operational area
- Objective events and physical signatures
- Human and alien collection and reporting
- Scripted investigation and commitment
- JSON Lines run records and Markdown AAR

### Exclude
- No combat
- No full resource system
- No victory condition
- No visualization layer

### Exit Focus
- `The Empty Corridor` runs end to end, passes information-isolation and determinism tests, and produces a useful three-perspective AAR.

## Milestone 1: Signal Loop Prototype
### Include
- At least one implemented overlapping-cause false positive
- Delayed delivery and masked or missed collection
- Reusable collector capabilities beyond scenario-specific filtering
- Explicit report-to-observation provenance in artifacts
- Assessment evidence linked to prior orders

### Exit Focus
- The full Signal -> Investigation -> Confirmation -> Action -> Assessment loop is testable across more than one scenario mechanism.

## Milestone 2: Human Logistics Skeleton
### Include
- Physical depots, routes, and ammo/fuel movement
- Route disruption
- Basic fire support only when target confirmation exists

### Exit Focus
- Human capability is visibly tied to logistics health and information quality.

## Milestone 3: Alien Ecosystem Skeleton
### Include
- Wildlife populations
- Ecological harvesting and cultivation
- Basic alien adaptation logic
- Alien signal interpretation of human disturbance

### Exit Focus
- Alien growth depends on ecosystem state, not industrial extraction analogs.

## Milestone 4: Deception and Counter-Recon
### Include
- Decoy signals
- Scouting penetration
- Upkeep and leakage
- Replay review of deception outcomes

### Exit Focus
- Deception creates uncertainty and can be validated or disproven through recon.

## Milestone 5: First Playable Objective Race
### Include
- Simple independent objectives for both factions
- Basic conflict, disruption, and delay mechanics

### Guardrail
- Avoid annihilation victory as the core win condition.

## Cross-References
- [Headless Simulation Design](headless-simulation-design.md)
- [Design Principles](design/design-principles.md)
- [Information Model](information-model.md)
- [Human Faction](design/design-factions-human.md)
- [Alien Faction](design/design-factions-alien.md)
- [Replay System](replay-system.md)