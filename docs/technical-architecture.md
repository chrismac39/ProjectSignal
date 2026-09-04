# Technical Architecture

> Status: Current specification.

## Purpose

ProjectSignal is organized to enforce one rule: faction decision code cannot access objective reality.

The runtime is a standalone `net8.0` console application. Domain logic has no dependency on a game engine, renderer, terminal UI, or filesystem. See [Headless Simulation Design](headless-simulation-design.md) for the product and scenario rules.

## Runtime Components

### Domain

Owns deterministic value types and rules:

* Turn and location
* World state
* Orders and validation
* Objective events and outcomes
* Physical signatures
* Collection capabilities and observations
* Faction reports

The domain does not print or serialize itself.

### Simulation

Owns WEGO orchestration:

`Situation -> Orders -> Commit -> Execution -> Signatures -> Collection -> Interpretation -> Assessment -> Record`

The simulation receives a scenario and scripted orders, advances one turn at a time, and returns a run record. Randomness is explicit and seeded. Stable identifiers and iteration order are required for deterministic output.

See [Operational Turn Model](operational-turn-model.md) for the canonical phase and information-timing contract.

### Scenarios

Owns hand-authored initial state, faction objectives, prior assumptions, and scripted decisions. Prototype scenarios are C# fixtures while the model is changing. External scenario schemas are deferred until several scenarios prove which fields are stable.

### Artifacts

Owns serialization of the completed run into JSON Lines technical logs and a Markdown AAR. Artifact writers may consume objective and faction records only after a turn is resolved. They do not participate in adjudication.

### Tests

Owns invariant, unit, determinism, information-isolation, artifact, and scenario characterization tests.

## Information Boundaries

The runtime uses distinct types for each stage:

1. `ObjectiveEvent` describes an authoritative occurrence.
2. `PhysicalSignature` describes a detectable consequence without granting knowledge of its cause.
3. `Observation` records what a particular collector encountered.
4. `FactionReport` translates observations into faction-legible evidence.
5. `FactionSituation` contains only reports delivered by that turn plus faction-owned objectives and working interpretations.

Objective IDs must not be reused as faction report IDs. Faction code must not correlate reports through hidden shared identity.

## Environmental Actor Boundary

`Faction` represents command and knowledge ownership and therefore remains `Human` or `Alien`. The environment should not be added as `Faction.Environment` because it does not submit strategic orders, receive reports, form a unified situation, or share knowledge.

Future autonomous-environment work should instead add objective-state concepts for environmental actors and processes. Those concepts need to represent:

* Species or process identity in objective reality.
* Local state and drives.
* Relationships such as predation, competition, symbiosis, containment, influence, and direct control.
* Conditions that trigger behavior or state transitions.
* Objective events and physical signatures produced by environmental action.

Directly controlled organisms belong to the controlling faction for order validation while retaining their biological identity in objective state. Influenced, attracted, cultivated, or contained organisms remain environmental actors.

This model is not implemented in the current generic domain records. It is planned for the Autonomous Environment milestone and should be introduced through a focused scenario rather than a universal ecology framework.

## Dependency Direction

`Scenarios -> Simulation -> Domain`

`Console -> Scenarios + Simulation + Artifacts`

`Artifacts -> Simulation records + Domain values`

`Tests -> all standalone projects`

Nothing in `Domain`, `Simulation`, or `Scenarios` references the archived Godot prototype.

## State And Replay

World state is authoritative and mutable only through adjudication. Each completed turn emits an immutable turn record containing:

* Committed orders
* Objective events
* Generated signatures
* Collected observations
* Delivered faction reports
* Turn-boundary snapshot

Replay is record-based, not UI-based. Re-simulation from the same versioned inputs is a determinism check; snapshots and chronological records are the durable analysis source.

## Prototype 0 Boundary

Included:

* Deterministic multi-turn WEGO orchestration
* Small hand-authored geography
* Scripted Vanguard and Plastai orders
* Wildlife and one biological process
* One human industrial or logistics process
* Signatures, collection, and expertise-driven reports
* Objective, human, and alien chronological records
* Markdown AAR generation

Excluded:

* Visualization and interactive UI
* Combat resolution
* Production economy
* Full logistics network simulation
* Victory conditions
* Multiplayer
* Procedural geography
* Complex AI

## Core Principle

World state creates events. Events create signatures. Collectors create observations. Expertise creates reports. Commanders create interpretations and orders.

Skipping any boundary makes information leakage or arbitrary misinformation likely.