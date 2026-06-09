# ProjectSignal Copilot Instructions

## Project Summary

ProjectSignal is a prototype operational strategy game focused on:

* Imperfect information
* Asymmetric perception
* Reconnaissance
* Deception
* Adaptation
* Replay analysis

The project is currently in design and Prototype 0 validation.

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
* Migration events
* Basic signal generation
* Human Reality layer
* Alien Reality layer
* Omniscient Reality layer
* Reality layer switching
* Replay timeline

Prototype 0 explicitly excludes:

* Combat
* Production
* Logistics systems
* Titans
* Victory conditions
* Multiplayer
* Large UI systems
* Advanced graphics
* Complex AI
* Save/load systems

When uncertain, choose the smallest implementation that advances Prototype 0.

---

## Current Implementation Status

Completed:

* Godot .NET setup
* Main scene
* Main.cs startup execution
* WorldState
* WildlifeEntity
* MigrationEvent
* SignalEvent
* Migration-generated signal event

Next priorities:

* HumanReality
* AlienReality
* OmniscientReality
* Basic reality layer switching
* ReplaySnapshot
* ReplayTimeline

Current priority is proving asymmetric perception.

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
↓
Human Perception Generator
↓
Human Reality

World State
↓
Alien Perception Generator
↓
Alien Reality

World State
↓
Replay Recorder
↓
Omniscient Reality

Prefer:

* Simple domain model classes
* Plain data structures
* Small incremental changes
* Readable C#
* Godot 4 C# conventions
* World State as the source of truth
* Pure simulation logic before visuals
* Explicit, understandable code

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

## Godot Implementation Guidance

Use Godot 4 with C#.

Prefer C# unless there is a compelling reason not to.

Do not generate large amounts of code by default.

Before creating new scenes, scripts, or systems, prefer the next smallest prototype step.

Do not create Godot Nodes unless they are needed for the current milestone.

For Prototype 0, domain model classes should usually be plain C# classes unless they need to interact directly with the Godot scene tree.

The first working path should be:

WorldState
→ Event
→ Signal
→ Perception Layer
→ Replay Snapshot

Visuals should come after the data/simulation model is proven.

---

## Documentation Authority

Before implementing significant features, consult:

* docs/design-principles.md
* docs/prototype-spec.md
* docs/prototype-roadmap.md
* docs/information-model.md
* docs/technical-architecture.md

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
