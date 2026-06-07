# Replay System

## Purpose
Provide postgame truth so players can compare what happened against what they believed happened.

## Core Requirements
- Omniscient replay reveals the true battlefield after the match.
- Replay shows what each side knew at the time.
- Replay shows what each side missed.
- Replay shows where assumptions were wrong.

## Views
### Omniscient View
- True simulation timeline.

### Human Knowledge View
- Human Reality state over time.

### Alien Knowledge View
- Alien Reality state over time.

## Timeline Expectations
- Scrubbable timeline for events and knowledge changes.
- Event markers for signal creation, investigation, confirmation, actions, and outcomes.
- Optional filters for deception events, recon penetrations, and route disruptions.

## Analysis Use Cases
- Identify missed opportunities.
- Identify overconfidence in stale or weak signals.
- Identify successful or failed deception.
- Understand objective progress versus battlefield attrition.

## Constraints
- No omniscient hints during gameplay.
- Any highlight of missed actions belongs postgame only.
- Replay is for learning and strategic killcam-style understanding, not in-match assistance.

## Related Documents
- [Information Model](information-model.md)
- [Deception and Recon](deception-and-recon.md)
- [Design Principles](design-principles.md)
