# Technical Architecture

## Purpose

This document describes the intended architecture for ProjectSignal.

The architecture exists to support the core design principle:

Players do not interact with objective reality.

Players interact with their perception of reality.

The simulation should therefore be built around a single authoritative world state that generates multiple faction-specific views.

---

# Core Architecture

## One World

ProjectSignal contains a single authoritative simulation.

There is only one true battlefield.

Everything that exists in the game exists within this world.

Examples:

* Terrain
* Wildlife
* Human units
* Alien organisms
* Logistics routes
* Structures
* Ecosystems
* Reconnaissance assets
* Signals

The world state is the source of truth.

---

## Three Realities

The game presents three different realities.

### Omniscient Reality

The complete simulation.

Contains:

* All entities
* All events
* All movement
* All hidden information

Used for:

* Replay
* Development
* Debugging
* Spectating

Never available during normal gameplay.

---

### Human Reality

The battlefield as understood by the human commander.

Generated from:

* Sensors
* Reconnaissance
* Observation
* Reports
* Assumptions

May be incomplete.

May be incorrect.

---

### Alien Reality

The battlefield as understood by the alien intelligence.

Generated from:

* Ecological sensing
* Scout organisms
* Disturbances
* Observation
* Assumptions

May be incomplete.

May be incorrect.

---

# Information Flow

The simulation should follow the pattern:

World State

↓

Perception Systems

↓

Faction Reality

↓

Player Decisions

↓

Orders

↓

World State

The player never interacts directly with the World State.

The player interacts with a faction-specific interpretation of the World State.

---

# Perception Systems

## Human Perception Generator

Transforms objective events into human observations.

Examples:

World State:

* Wildlife migration

Human Reality:

* Large animal concentrations

---

World State:

* Alien activity

Human Reality:

* Thermal signature
* Sensor contact
* Reconnaissance report

The generator produces observations.

Not conclusions.

---

## Alien Perception Generator

Transforms objective events into alien observations.

Examples:

World State:

* Human logistics route

Alien Reality:

* Ecological disruption
* Mechanical vibration
* Wildlife avoidance

---

World State:

* Human refinery

Alien Reality:

* Persistent heat
* Habitat collapse
* Nutrient disruption

Again:

Observations.

Not conclusions.

---

# Signals

Signals are generated from world events.

Examples:

* Migration
* Heat
* Convoy movement
* Habitat disruption
* Predator activity
* Industrial activity

Signals are observations.

Signals are not strategic recommendations.

The game should never automatically conclude:

"Enemy activity detected."

The player performs the interpretation.

---

# Reconnaissance

Reconnaissance improves information quality.

It does not reveal objective reality instantly.

Examples:

Signal

↓

Scout

↓

Observation

↓

Understanding

Reconnaissance should generally provide:

* Better observations
* Better positioning
* Better targeting

It should not eliminate uncertainty completely.

---

# Deception

Deception exists within the World State.

Decoys are real entities.

Examples:

* Fake refinery
* Fake logistics activity
* Fake biological activity

The perception systems observe decoys exactly as they observe legitimate assets.

Players must determine the difference through investigation.

---

# Replay System

## Replay Recorder

The replay system records:

* World State events
* Perception events
* Orders
* Reconnaissance results

The replay should allow inspection of:

* Omniscient Reality
* Human Reality
* Alien Reality

for any point in time.

---

## Replay Purpose

The replay is not simply a combat log.

The replay exists to reveal:

* What happened.
* What each commander believed happened.
* Why decisions were made.

The replay is a learning tool.

---

# Separation Of Concerns

## Simulation Layer

Responsible for:

* World State
* Movement
* Ecology
* Logistics
* Combat
* Reconnaissance

Contains objective reality.

---

## Perception Layer

Responsible for:

* Human observations
* Alien observations
* Signal generation

Contains subjective reality.

---

## Presentation Layer

Responsible for:

* UI
* Map rendering
* Visual overlays
* Controls

Contains no game logic.

---

## Replay Layer

Responsible for:

* Historical recording
* Timeline playback
* Reality comparison

Contains no simulation logic.

---

# Prototype 0 Architecture

Prototype 0 should remain extremely small.

Included:

* Terrain
* Wildlife
* Human perception
* Alien perception
* Omniscient view
* Replay timeline

Excluded:

* Combat
* Production
* Logistics
* Victory conditions
* Titans
* Multiplayer

The goal is to validate the information model.

Nothing else.

---

# Core Principle

The most important architectural rule in ProjectSignal is:

There is one truth.

Every faction-specific experience is generated from that truth.

Players do not fight over the same information.

Players fight over their understanding of the same reality.
