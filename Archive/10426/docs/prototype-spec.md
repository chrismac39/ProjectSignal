# Prototype Specification

> Status: Current acceptance contract for Prototype 0.

## Objective

Validate that one deterministic operational simulation can produce materially different, causally traceable Vanguard and Plastai understandings of the same objective events.

---

## Included

* Standalone `net8.0` console runtime
* Deterministic scripted WEGO turns
* One hand-authored operational area
* Wildlife and a Plastai ecological process
* One Vanguard route or industrial process
* Vanguard and Plastai collection capabilities
* Objective events with one-to-many physical signatures
* Faction-specific observations and reports
* One investigation choice that distinguishes plausible causes
* Immutable objective, Vanguard, and Plastai turn records
* JSON Lines technical artifacts
* Human-readable Markdown after-action report

Environmental events may be hand-authored for Prototype 0, but their objective causes and signatures must remain explicit. Autonomous population behavior is deferred to the roadmap's environment milestone.

---

## Excluded

* Combat
* Resources
* Production
* Logistics
* Titans
* Victory conditions
* Multiplayer
* AI opponents
* Visualization, map rendering, and interactive UI
* External scenario-definition language

---

## Success Criteria

A completed scripted scenario can:

1. Produce at least one objective event that creates several physical signatures.
2. Deliver different evidence to Vanguard and Plastai collectors for causal reasons.
3. Present at least two plausible explanations for an early observation.
4. Commit a consequential order before either side has complete information.
5. Use later collection or assessment to distinguish some explanations without automatically revealing truth.
6. Preserve strict isolation between faction-facing records and objective state.
7. Generate an AAR that reconstructs why the sides acted differently.
8. Produce equivalent chronological artifacts when rerun with the same inputs and seed.

The first acceptance scenario is `The Empty Corridor`, defined in [Scenario Design](scenario-design.md).

If this creates an interesting information decision in script and AAR form, proceed to Milestone 1.
If not, redesign before expanding scope.