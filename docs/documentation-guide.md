# Documentation Guide

> Status: Current documentation policy and authority map.

## Purpose

ProjectSignal documentation separates enduring intent, current specifications, implementation status, future design, and illustrative examples. This prevents an old idea or example from silently becoming an implementation requirement.

## Authority Order

When documents disagree, use this order:

1. [North Star](north-star.md) - enduring product identity and design principles.
2. [Prototype 0 Specification](prototype-spec.md) - current scope and acceptance criteria.
3. [Technical Architecture](technical-architecture.md), [Information Model](information-model.md), [Operational Turn Model](operational-turn-model.md), and [Replay System](replay-system.md) - current subsystem contracts.
4. [Implementation Status](implementation-status.md) - what exists now and what is next.
5. Future design references under `docs/design/` - direction that is not necessarily scheduled or implemented.
6. Examples under `docs/examples/` - illustrations that are never normative by themselves.

The [Headless Simulation Design](headless-simulation-design.md) records the major Prototype 0 pivot and scenario rationale. Where it duplicates a focused specification, the focused specification owns implementation detail.

## Document Status Labels

Every substantial document should identify one of these statuses near its title:

* **North star** - enduring principles; changes require a deliberate product decision.
* **Current specification** - behavior the active implementation should satisfy.
* **Current status** - verified implementation state and immediate work.
* **Future design reference** - plausible later direction, not current scope.
* **Illustrative example** - explanatory narrative, not an implemented promise.
* **Historical reference** - retained context that is no longer authoritative.

## Canonical Ownership

| Concept | Canonical document |
| --- | --- |
| Product identity and enduring principles | [North Star](north-star.md) |
| Prototype 0 scope and acceptance | [Prototype 0 Specification](prototype-spec.md) |
| Runtime boundaries and dependencies | [Technical Architecture](technical-architecture.md) |
| Events, signatures, observations, reports, and interpretations | [Information Model](information-model.md) |
| WEGO phases and ordering | [Operational Turn Model](operational-turn-model.md) |
| Records, artifacts, and AAR purpose | [Replay System](replay-system.md) |
| Scenario quality and catalog | [Scenario Design](scenario-design.md) |
| Completed and next work | [Implementation Status](implementation-status.md) |
| Deferred decisions | [Open Questions](open-questions.md) |

Other documents should link to these definitions rather than create competing versions.

## Maintenance Rules

When implementation changes:

1. Update [Implementation Status](implementation-status.md).
2. Update a specification only if the contract changed.
3. Add or revise a test for the changed contract.
4. Update examples only when they would otherwise teach the wrong model.

When design direction changes:

1. Check the change against the [North Star](north-star.md).
2. Record a resolved decision in [Open Questions](open-questions.md) when appropriate.
3. Update the owning specification and links to it.
4. Remove or label contradictory future-design material.

Documentation describes observable behavior and ownership boundaries. It should avoid prescribing speculative class hierarchies, numeric formulas, or data schemas before scenarios demonstrate that they are needed.