# Operational Turn Model

> Status: Current specification for Prototype 0.

## Purpose

Prototype 0 uses deterministic WEGO turns. Both factions choose orders from their own situation records before either receives evidence produced during that turn.

WEGO means simultaneous commitment, not physically simultaneous resolution. The engine uses an explicit and stable adjudication sequence.

## Turn Phases

1. **Situation** - construct each faction's decision-time view from reports whose delivery turn has arrived and that faction's working interpretations.
2. **Orders** - request scripted orders independently from each faction situation.
3. **Commit** - validate all orders and freeze them for the turn.
4. **Execution** - advance faction actions and independent world processes in scenario-defined deterministic order.
5. **Signature generation** - derive physical consequences from objective events.
6. **Collection** - determine which signatures each collector encounters under concrete conditions.
7. **Interpretation** - transform observations into faction-legible reports without exposing hidden causes.
8. **Assessment** - deliver eligible reports and update explicit working interpretations.
9. **Record** - capture orders, events, signatures, observations, reports, interpretations, and the turn-boundary snapshot.

## Information Timing

Orders for turn $t$ may use only reports delivered by the Situation phase of turn $t$. Evidence generated during turn $t$ cannot retroactively alter those orders.

The current scripted engine delivers observations in the turn they are collected. The model includes separate observation and delivery turns so delayed reporting can be added without changing the faction-facing contract.

## Deterministic Ordering

For identical scenario code, initial state, scripted decisions, seed, and engine version, a run must produce equivalent chronological records.

Determinism requires:

* Stable order and event identifiers.
* Stable iteration and serialization order.
* Explicit seeded randomness when randomness exists.
* No wall-clock input, background mutation, or unrecorded external state.
* Scenario adjudication that documents any meaningful substep ordering.

Faction priority must not be hidden inside incidental collection ordering. If order interactions require initiative or simultaneous-effect rules, those rules must become explicit scenario-independent policy before use.

## Environmental Resolution

The environment does not submit commander orders. Environmental actors resolve from their current state, local drives, and conditions during Execution.

A scenario must state the ordering whenever faction action and environmental reaction could change the result. A useful default sequence for future generalization is:

1. Apply committed interventions that change immediate conditions.
2. Resolve environmental processes and organism responses from those conditions.
3. Resolve continuing faction tasks and movement affected by that response.
4. Generate signatures from every resulting objective event.

This is not yet a universal engine rule. It is a requirement that scenarios avoid unexplained ordering until repeated cases justify one.

## Order Validation

The current engine validates that every committed order targets the active turn and that order IDs are unique within the turn.

Future shared validation may include ownership, legal destination, action capability, and resource availability. Scenario code may validate scenario-specific preconditions, but it must fail explicitly rather than silently reinterpret an illegal order.

## Prototype 0 Boundary

Prototype 0 does not yet define a universal action-point economy, initiative system, movement rate, or order taxonomy. `The Empty Corridor` uses three scripted turns and scenario-owned order kinds to prove information flow.

Those mechanics should be generalized only after additional scenarios reveal repeated rules.