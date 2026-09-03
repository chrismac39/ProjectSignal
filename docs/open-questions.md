# Open Questions

> Status: Current decision log. Resolved items link to their owning specification where possible.

## Resolved For Prototype 0

- Turn model: deterministic WEGO. See [Operational Turn Model](operational-turn-model.md).
- Runtime: standalone .NET console application. See [Technical Architecture](technical-architecture.md).
- Presentation: technical logs and Markdown AAR; no visualization layer. See [Replay System](replay-system.md).
- Scenario authoring: C# fixtures until repeated scenarios reveal a stable external schema.
- Player control: scripted decisions before an interactive commander interface.
- Replay granularity: immutable chronological turn records plus turn-boundary snapshots.
- Initial scenario scale: three abstract operational turns and named areas; a turn has no fixed real-world duration.
- Initial collection conditions: direct access, remote pass, dwell time, and partial coverage are scenario-owned facts.
- Working interpretations: explicit faction records kept separate from immutable reports.

## Still Open

### Prototype 0

- Which collection rules should become engine-owned after the next scenarios: range, occlusion, dwell time, access, masking, or delay?
- Which objective state belongs in snapshots versus reconstructable chronological records?
- How should phase transitions be recorded without duplicating the turn record?
- What minimum false-positive scenario proves overlapping causes rather than alternate wording?

### Future Product

- When does accumulated faction knowledge become institutional adaptation rather than scenario setup?
- What operational geography model should follow named areas: graph, grid, continuous coordinates, or another representation?
- What purpose do Titans serve in the information game?
- What are the distinct human and alien strategic objectives?
- When, if ever, should interactive command, AI opponents, or multiplayer enter the roadmap?
- What depth of wildlife simulation produces meaningful evidence without becoming an ecology project for its own sake?