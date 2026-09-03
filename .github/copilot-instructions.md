# ProjectSignal Copilot Instructions

## Project Summary

ProjectSignal is a headless operational strategy simulation focused on:

* Imperfect information
* Asymmetric perception
* Reconnaissance
* Deception
* Adaptation
* Replay analysis

The project is currently in design and Prototype 0 validation. The active runtime target is a deterministic standalone .NET console application with no visualization layer.

The goal is to prove the information model before implementing complex gameplay systems.

---

## Core Thesis

Humans fight an intelligence war against an unknown biological system.

Aliens fight an evolutionary war against an industrial system.

---

## Core Gameplay Loop

Signal
→ Investigation
→ Confirmation
→ Action
→ Assessment

Signals are observations.

Signals are not conclusions.

Players must determine meaning themselves.

The game should not provide automated strategic recommendations.

---

## Perception Asymmetry Rule

Faction asymmetry comes from expertise and interpretation, not arbitrary confidence scores.

Do not add:

* Confidence scores
* Probability values
* Threat ratings
* Importance ratings
* Reliability scores
* Automated recommendations

The player must determine confidence, importance, and threat level themselves.

Humans are strong at interpreting industrial systems and weak at interpreting ecological or alien biological systems.

Aliens are strong at interpreting ecological systems and weak at interpreting industrial systems.

The same World Event should produce different interpretations depending on faction expertise.

Example:

* Omniscient Reality: 10 herbivores migrated east.
* Human Reality: Large animal movement observed.
* Alien Reality: Docile herbivore migration detected.

Example:

* Omniscient Reality: Refinery online and producing fuel.
* Human Reality: Refinery construction completed.
* Alien Reality: Persistent industrial disturbance detected.

---

## Battlefield Realities

The game contains:

* Human Reality
* Alien Reality
* Omniscient Reality

Human Reality and Alien Reality are different interpretations of the same World State.

Players never access Omniscient Reality during gameplay.

Omniscient Reality exists only for replay, debugging, and analysis.

Replay should reveal the difference between perception and reality.

---

## Prototype 0 Scope

Current implementation phase is Prototype 0.

Prototype 0 must prove:

* One World State
* Wildlife entities
* Deterministic WEGO turns
* Objective events and physical signatures
* Human and alien collection
* Faction-specific observations and reports
* Objective, human, and alien chronological records
* Human-readable after-action report

Prototype 0 explicitly excludes:

* Combat
* Production
* Logistics systems
* Titans
* Victory conditions
* Multiplayer
* Visualization and interactive UI
* Complex AI
* Save/load systems

When uncertain, choose the smallest implementation that advances Prototype 0.

---

## Current Implementation Status

The Godot implementation is historical validation work and migration reference. It is not the active runtime foundation.

Current priorities:

* Standalone .NET domain, console runner, and tests
* Deterministic WEGO turn orchestration
* Objective event -> physical signature -> collection -> observation -> faction report pipeline
* `The Empty Corridor` multi-turn vertical slice
* JSON Lines technical artifacts
* Markdown AAR comparing objective, human, and alien records

---

## Design Priorities

1. Information quality
2. Reconnaissance
3. Signal interpretation
4. Deception
5. Replay analysis
6. Adaptation
7. Logistics
8. Combat

Combat exists to support the information game, not replace it.

Do not implement combat until the information model is proven.

---

## Technical Architecture

Authoritative architecture:

World State
-> Objective Event
-> Physical Signature
-> Faction Collection
-> Observation
-> Faction Report
-> Scripted Decision
-> Order
-> World State

Prefer:

* Simple domain model classes
* Plain data structures
* Small incremental changes
* Readable C#
* World State as the source of truth
* Pure `net8.0` simulation logic
* Explicit, understandable code
* Deterministic runs and stable artifact ordering
* Separate types for objective events, signatures, observations, and faction reports

Avoid:

* Service locators
* Dependency injection frameworks
* Manager proliferation
* ECS architectures
* Complex inheritance hierarchies
* Premature optimization
* Large gameplay frameworks
* Multiplayer architecture
* Advanced rendering systems
* Procedural map systems before Prototype 0 is proven

The project should remain understandable by a single developer.

---

## Headless Implementation Guidance

Use a standalone .NET 8 solution with plain C# domain classes.

Do not add a game engine, rendering framework, interactive UI, or visualization dependency.

Do not generate large amounts of framework code by default. Prefer the smallest deterministic scenario behavior that proves one information mechanism.

The first working path should be:

WorldState
-> ObjectiveEvent
-> PhysicalSignature
-> Collection
-> Observation
-> FactionReport
-> RunRecord
-> AfterActionReport

Faction code must never receive objective events, hidden causes, opposing orders, or authoritative identifiers without an in-world collection reason.

---

## Documentation Authority

Before implementing significant features, consult:

* docs/design/design-principles.md
* docs/headless-simulation-design.md
* docs/prototype-spec.md
* docs/prototype-roadmap.md
* docs/information-model.md
* docs/technical-architecture.md
* docs/implementation-status.md

Always consult docs/implementation-status.md for the latest completed and next Prototype 0 items.

The documentation is authoritative.

If generated code conflicts with the documentation, follow the documentation.

If the documentation and implementation disagree, stop and ask for clarification rather than inventing a new direction.

---

## Design Constraints

Avoid:

* Perfect information
* Symmetrical faction design
* RTS unit micro focus
* Territory painting gameplay
* Constant reminders and notifications
* Automated strategic recommendations
* Systems that tell the player what to do
* Early combat-first implementation
* Early logistics-first implementation
* Early production systems

Favor:

* Command decisions
* Uncertainty
* Misunderstood information
* Reconnaissance tradeoffs
* Asymmetric perception
* Faction-specific assumptions
* Replay-driven learning
* Signals that require interpretation
* World state separated from perceived reality

---

## Before Implementing Features

Consider:

* Does this improve the information game?
* Does this create meaningful uncertainty?
* Does this reinforce faction asymmetry?
* Does this improve replay analysis?
* Does this create interesting decisions?
* Does this preserve the distinction between World State and perceived reality?
* Is this necessary for Prototype 0?
* Can this be implemented in a smaller way?

If not, reconsider the feature.

When in doubt, reduce scope.
