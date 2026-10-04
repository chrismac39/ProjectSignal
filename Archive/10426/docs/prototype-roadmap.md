# Prototype Roadmap

> Status: Current planning sequence. Only Milestone 0 is active.

This roadmap keeps the headless simulation focused on information and asymmetric perception before combat or economy complexity.

## Milestone 0: Headless Information Loop
### Goal
Prove that objective, Vanguard, and Plastai records can diverge for traceable reasons and affect scripted operational decisions.

### Include
- Standalone .NET solution
- Deterministic WEGO turn sequence
- Hand-authored operational area
- Objective events and physical signatures
- Vanguard and Plastai collection and reporting
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

## Milestone 2: Autonomous Environment Skeleton
### Include
- A small set of populations with independent drives
- Condition-driven migration, avoidance, territorial, and predatory behavior
- Shared faction interactions: observe, avoid, deter, contain, redirect, fight, exploit, and protect
- One Vanguard habitat intervention and one Plastai biological intervention
- Delayed ecological feedback visible in replay

### Exit Focus
- Environmental actors initiate and propagate operational consequences without functioning as Plastai units or random event tables.
- Both factions can solve similar environmental problems through materially different methods.

## Milestone 3: Human Logistics Skeleton
### Include
- Physical depots, routes, and ammo/fuel movement
- Located extraction, storage, shipment, delivery, and consumption records
- Transport capacity and handling time without individual-item bookkeeping
- Route disruption
- Basic fire support only when target confirmation exists

### Exit Focus
- Human capability is visibly tied to logistics health and information quality.
- No human action spends material from a locationless global pool.

## Milestone 4: Alien Cultivation And Adaptation Skeleton
### Include
- Physical biomass, nutrient, specimen, and living-transport flows
- Ecological harvesting, cultivation, nursery capacity, and population stewardship
- Deliberate alien adaptation using physically acquired compatible material
- Alien signal interpretation of human disturbance

### Exit Focus
- Plastai growth depends on ecosystem state, not industrial extraction analogs.
- Learned genetic possibilities remain distinct from material and nursery requirements.

## Milestone 5: Deception and Counter-Recon
### Include
- Decoy signals
- Scouting penetration
- Upkeep and leakage
- Replay review of deception outcomes

### Exit Focus
- Deception creates uncertainty and can be validated or disproven through recon.

## Milestone 6: First Playable Objective Race
### Include
- A simplified human planet-space interface project
- A simplified consciously designed alien Titan project
- Multiple physical dependencies for each project
- Ambiguous precursor signatures that reconnaissance can interpret
- Basic conflict, indirect disruption, and delay mechanics
- Unmistakable terminal commissioning and maturation signals
- A bounded final counter-operation window

### Guardrail
- Victory comes from completing a strategic project, not annihilating the opposing faction.
- The terminal window follows physical project conditions and cannot be extended indefinitely by superficial damage.

### Exit Focus
- A faction can discover and disrupt an opposing project through its physical dependencies rather than receiving a labeled objective marker.
- An undisrupted terminal project ends the game after a finite, comprehensible response opportunity.

## Cross-References
- [Headless Simulation Design](headless-simulation-design.md)
- [Design Principles](design/design-principles.md)
- [Information Model](information-model.md)
- [Vanguard](design/design-factions-vanguard.md)
- [Plastai](design/design-factions-plastai.md)
- [Strategic Objectives and Physical Economy](design/design-strategic-objectives-and-physical-economy.md)
- [Replay System](replay-system.md)