# Headless Simulation Design

> Status: Current design rationale for the Prototype 0 headless pivot. Focused specifications own subsystem details.

## Decision

ProjectSignal is a headless operational simulation.

The simulation runs as a deterministic .NET program. It does not depend on Godot, Unity, Unreal, a map renderer, or any other visualization layer. Its primary outputs are machine-readable run artifacts and a human-readable after-action report.

The existing Godot prototype is historical validation work. It may be used as migration reference, but it is not the foundation of the authoritative runtime.

## Product Thesis

ProjectSignal is a command simulation about acting on incomplete, asymmetric, and sometimes misleading evidence.

The Vanguard fights an intelligence war against an unknown biological system.

The Plastai fight an evolutionary war against an industrial system.

The simulation is not primarily about moving pieces. It is about how each side:

1. Produces signatures through its actions.
2. Collects only some of those signatures.
3. Describes collected evidence through faction expertise.
4. Forms a working interpretation without access to objective reality.
5. Commits orders based on that interpretation.
6. Learns from delayed and incomplete assessment.

## Non-Negotiable Rules

### One objective reality

One authoritative world state owns entities, terrain, processes, orders, events, and outcomes. Faction systems cannot read this state directly.

### Evidence before interpretation

The simulation must preserve this chain:

`World process -> objective event -> physical signature -> collection -> observation -> interpretation -> decision -> outcome -> assessment`

These terms are not interchangeable:

* An **objective event** is what occurred in the world.
* A **signature** is a physical consequence that could be detected.
* A **collection attempt** is a sensor, scout, organism, patrol, or network trying to encounter a signature.
* An **observation** is the evidence actually made available to a faction.
* An **interpretation** is a faction-legible account of that evidence.
* An **assessment** is later evidence about the effects of an order.

An event can create several signatures. A signature can be missed, detected late, attributed incorrectly, or explained differently by each faction.

### No answer key during play

Faction outputs must not contain:

* Confidence scores
* Probability values
* Threat ratings
* Importance ratings
* Reliability scores
* Automated recommendations
* Hidden objective identifiers that let players correlate reports perfectly

The simulation may model concrete physical quantities internally. It must not turn those quantities into an oracle that tells a player what to believe or do.

### Expertise changes vocabulary, not truth

Faction expertise controls which distinctions can be observed and how evidence can be described. It does not apply an arbitrary accuracy percentage.

The Vanguard can distinguish industrial processes, machinery, emissions, communications, and logistics patterns more precisely than alien ecology.

The Plastai can distinguish biological state, ecological relationships, stress, migration, propagation, and habitat change more precisely than human industry.

Low expertise should produce coarser but still evidential descriptions. It must not automatically produce random falsehoods.

### Misinterpretation has a cause

False conclusions should emerge from one or more traceable causes:

* A signature was never collected.
* Collection resolution was insufficient to distinguish causes.
* Several causes produced materially similar signatures.
* A faction lacked the concepts needed to describe a distinction.
* A decoy reproduced some signatures but failed to reproduce others.
* Evidence arrived late, out of order, or after conditions changed.
* A prior working model caused the same evidence to be read differently.

Randomly replacing a correct report with an incorrect report is not an acceptable perception model.

## Operational Turn

The canonical phase and timing contract is [Operational Turn Model](operational-turn-model.md).

Prototype 0 uses deterministic WEGO turns. Both factions commit orders without seeing the other faction's current orders. The simulation then adjudicates all orders in a stable sequence.

Each turn contains these phases:

1. **Situation** - expose only reports and assessments already available to each faction.
2. **Orders** - accept scripted orders for both factions.
3. **Commit** - validate orders and prevent later changes.
4. **Execution** - advance movement, tasks, ecological processes, and industrial processes in deterministic substeps.
5. **Signature generation** - derive physical effects from objective events.
6. **Collection** - determine which collectors encounter which signatures.
7. **Interpretation** - translate collected evidence into faction-specific reports.
8. **Assessment** - deliver eligible delayed reports and evidence of prior outcomes.
9. **Record** - persist the turn record and snapshots needed for replay.

Simultaneous intent does not require simultaneous physical resolution. The adjudication sequence must be explicit and stable so identical inputs and seeds produce identical artifacts.

## Time And Scale

Prototype 0 models operational turns rather than continuous time or tactical seconds.

The exact duration represented by one turn is scenario-defined. A scenario may describe a turn as hours or days, but all systems within that scenario use the same turn clock.

Prototype 0 uses a small, hand-authored area model. Geography exists to support movement, access, collection, masking, and ecological or industrial relationships. It is not intended to support tactical pathfinding or visual terrain rendering.

## Three Perspective Records

Every completed run produces three records.

### Objective record

The objective record contains the initial state, committed orders, adjudicated events, generated signatures, actual outcomes, and authoritative snapshots. It is available only to replay analysis, tests, and debugging.

### Vanguard record

The Vanguard record contains only information delivered through Vanguard collection and interpretation. It uses human industrial terminology and preserves report timing, source class, location precision, and observable details.

### Plastai record

The Plastai record contains only information delivered through Plastai collection and interpretation. It uses Plastai ecological terminology and preserves report timing, source class, location precision, and observable details.

Faction records are projections built from authorized observations. They are not filtered copies of the objective record.

## Player Knowledge Model

The simulation distinguishes three forms of faction knowledge:

* **Reports** are immutable records of what was observed at a particular time.
* **Working interpretations** are explicit scenario or player assertions about what reports mean.
* **Institutional memory** records concepts or distinctions learned across repeated encounters.

Prototype 0 implements reports and scripted working interpretations. Institutional adaptation is represented in scenario design but deferred until repeated encounters can be evaluated without leaking objective truth.

The engine must never silently rewrite an old report when better evidence arrives. A later report may contradict or refine it. The AAR should make that evolution visible.

## Scenario Design Standard

Different wording alone is not sufficient. Scenarios must create consequential, causally traceable differences in what each faction can collect and reasonably infer.

[Scenario Design](scenario-design.md) owns the scenario checklist, active acceptance scenario, and future catalog.

## Focused Specifications

The pivot established the overall direction. Current implementation contracts are maintained in focused documents:

* [Prototype 0 Specification](prototype-spec.md) owns scope and acceptance.
* [Technical Architecture](technical-architecture.md) owns runtime boundaries.
* [Information Model](information-model.md) owns evidence and knowledge vocabulary.
* [Operational Turn Model](operational-turn-model.md) owns WEGO timing and ordering.
* [Replay System](replay-system.md) owns artifacts and AAR requirements.
* [Implementation Status](implementation-status.md) records what is complete and what comes next.

## Determinism And Isolation

A run is reproducible from its scenario version, engine version, scripted orders, and random seed.

The architecture enforces information isolation:

* Adjudication code may read objective state.
* Signature generation may read objective events and state.
* Collection code may read signatures and collector capabilities, but not hidden causes.
* Interpretation code may read collected evidence and faction knowledge, but not objective events.
* Faction decision code may read only that faction's delivered reports, working interpretations, objectives, and legal-order rules.
* AAR code may read all run artifacts only after adjudication is complete.

Tests must fail if a faction-facing type exposes an objective event reference, hidden cause, opposing order, or authoritative entity identifier without an in-world collection reason.

## Current State

The standalone solution, deterministic engine, first vertical slice, artifacts, AAR, and focused tests now exist. See [Implementation Status](implementation-status.md) for the verified inventory and next priorities.