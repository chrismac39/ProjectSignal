# Replay System

> Status: Current specification for run records, technical artifacts, and after-action analysis.

## Purpose
Provide post-simulation truth so players and designers can compare objective events, collected evidence, working interpretations, orders, and outcomes.

## Core Requirements
- Omniscient replay reveals the objective record after the run.
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

## Implemented Artifact Contract

Each completed run currently writes:

* `manifest.json` - schema version, engine label, scenario identity, seed, turn count, and status.
* `orders.jsonl` - committed human and alien orders.
* `objective-events.jsonl` - authoritative events and summaries.
* `signatures.jsonl` - physical signatures with objective source-event links.
* `human-reports.jsonl` - reports delivered to humans.
* `alien-reports.jsonl` - reports delivered to aliens.
* `snapshots.jsonl` - objective facts at each turn boundary.
* `aar.md` - three-perspective timeline, decisions, working interpretations, and findings.

Records are written in stable chronological order. Faction report artifacts include faction-local IDs, observation and delivery turns, source class, location, description, and collection conditions. They do not expose objective event or signature IDs.

## Required Evolution

The in-memory turn record contains observations and working interpretations, but the artifact writer does not yet serialize them as independent chronological logs. Explicit report-to-observation provenance, engine versioning, replay loading, and re-simulation from an artifact manifest remain future work.

## Analysis Use Cases
- Identify missed opportunities.
- Identify interpretations that outlived the evidence supporting them.
- Identify successful or failed deception.
- Understand why an order was reasonable, reckless, or ineffective given information available at commitment time.
- Compare legal alternative collection choices without pretending there was one required move.

## Constraints
- No omniscient hints during a run.
- Any highlight of missed actions belongs in post-run analysis only.
- AAR analysis may use objective state only after the run is complete.
- Replay is record-based in Prototype 0; it does not require a visual or scrubbable interface.

## Related Documents
- [Information Model](information-model.md)
- [Deception and Reconnaissance](design/design-deception-and-recon.md)
- [Headless Simulation Design](headless-simulation-design.md)
- [Design Principles](design/design-principles.md)
