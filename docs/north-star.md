# ProjectSignal North Star

> Status: North star. This document changes only when the enduring product identity changes.

## Purpose

This document defines the enduring identity of ProjectSignal. It should change rarely. Specifications, scenarios, and implementation choices may evolve, but they should remain compatible with these principles.

## Core Thesis

Humans fight an intelligence war against an unknown biological system.

Aliens fight an evolutionary war against an industrial system.

ProjectSignal is an operational command simulation about making consequential decisions from incomplete, asymmetric, and sometimes misleading evidence.

## The Central Experience

The player should repeatedly face this problem:

1. Something observable changes in the world.
2. Several causes remain plausible.
3. Investigation competes with time, access, exposure, and other priorities.
4. A decision must be made before every uncertainty is resolved.
5. Later evidence reveals consequences without necessarily explaining everything.
6. After-action analysis compares the decision-time picture with objective reality.

The simulation succeeds when a decision is understandable from the evidence available at the time, even when replay later shows that the decision was wrong.

## Enduring Principles

### One world, unequal access

There is one objective world state. Humans and aliens do not receive filtered copies of it. Each faction constructs its situation from evidence acquired through its own collectors, access, expertise, and reporting delays.

### Evidence is not a conclusion

The simulation presents observations and reports. It does not assign confidence, probability, threat, importance, or recommended action. Interpretations belong to commanders.

### Asymmetry comes from ways of knowing

Humans are fluent in industrial systems and comparatively weak at ecological interpretation. Aliens are fluent in ecological systems and comparatively weak at industrial interpretation.

The factions should differ in what distinctions they can perceive, what relationships they notice, how they move through the world, and what signatures their own activity creates. They should not be symmetric rulesets with renamed resources.

### Uncertainty must be causal

Ambiguity comes from missed collection, limited access, overlapping signatures, delay, masking, deception, or missing concepts. The engine does not inject arbitrary misinformation merely to preserve uncertainty.

### Investigation is a decision

Reconnaissance is not a button that reveals truth. It is the commitment of time, position, assets, and exposure to acquire discriminating evidence. Good investigations test competing explanations.

### The world acts independently

Wildlife, ecology, weather, terrain, and other processes create real events and signatures without serving either faction. Environmental activity is not decorative noise; it participates in causality and can alter operations.

### Action creates information

Movement, collection, concealment, logistics, and intervention all leave physical consequences. A faction may learn about an opponent from how that opponent investigates, not only from what the opponent attacks.

### Deception obeys the world

A decoy is a real arrangement that reproduces some signatures at a cost. It may omit secondary signatures, create new ones, or teach the observer about the deceiver. Deception shapes evidence; it does not directly edit an opponent's beliefs.

### Replay completes the design

The after-action report is part of the core experience, not a debugging appendix. It should reveal what happened, what each side could observe, what each side claimed, what each side ordered, and how those differences mattered.

### Combat remains subordinate

Combat, logistics, production, and adaptation exist to create and resolve information problems. They should not displace the signal, investigation, commitment, and assessment loop.

## Product Direction

The active product is a deterministic, headless .NET simulation. Structured run artifacts and a human-readable after-action report are the current interface.

No visualization layer is required to prove the design. A future interface may consume simulation records, but presentation must not become the source of game logic or privileged information.

## Design Test

Before adding a system, ask:

1. What new evidence does it create or collect?
2. What can each faction distinguish about it, and why?
3. Which competing explanations can a commander reasonably hold?
4. What does investigation cost?
5. What decision becomes more interesting because this system exists?
6. What will replay reveal that was unavailable at commitment time?

If those questions have weak answers, the system is probably premature or outside ProjectSignal's identity.