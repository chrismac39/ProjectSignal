# Replay System

## Purpose
Provide post-simulation truth so players and designers can compare objective events, collected evidence, working interpretations, orders, and outcomes.

## Core Requirements
- Omniscient replay reveals the true battlefield after the match.
- Replay shows what each side knew at the time.
- Replay shows what each side missed.
- Replay shows where assumptions were wrong.

## Records
### Objective Record
- True simulation events, signatures, orders, outcomes, and snapshots.

### Human Record
- Reports and scripted working interpretations available to humans at each decision point.

### Alien Record
- Reports and scripted working interpretations available to aliens at each decision point.

## Artifact Expectations
- Versioned manifest with scenario, engine, schema, seed, and run status.
- JSON Lines logs for orders, objective events, signatures, faction reports, and snapshots.
- Stable chronological ordering within every turn.
- Markdown AAR with a turn-by-turn three-perspective comparison.
- Traceability from every faction report to its observations and collection conditions.
- Traceability from signatures to causes only in the objective record.

## Analysis Use Cases
- Identify missed opportunities.
- Identify interpretations that outlived the evidence supporting them.
- Identify successful or failed deception.
- Understand why an order was reasonable, reckless, or ineffective given information available at commitment time.
- Compare legal alternative collection choices without pretending there was one required move.

## Constraints
- No omniscient hints during gameplay.
- Any highlight of missed actions belongs postgame only.
- AAR analysis may use objective state only after the run is complete.
- Replay is record-based in Prototype 0; it does not require a visual or scrubbable interface.

## Related Documents
- [Information Model](information-model.md)
- [Deception and Recon](design/design-deception-and-recon.md)
- [Headless Simulation Design](headless-simulation-design.md)
- [Design Principles](design/design-principles.md)
