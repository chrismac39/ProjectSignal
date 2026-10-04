# ProjectSignal North Star

> Status: North star. This document changes only when the enduring product identity changes.

## Purpose

This document defines the enduring identity of ProjectSignal. It should change rarely. Specifications, scenarios, and implementation choices may evolve, but they should remain compatible with these principles.

## Core Thesis

The Vanguard fights an intelligence war against an unknown biological system.

The Plastai fight an evolutionary war against an industrial system.

ProjectSignal is an operational command simulation about making consequential decisions from incomplete, asymmetric, and sometimes misleading evidence.

## Faction Names

**Vanguard** is the proper name of the human expeditionary faction. **Plastai** is the proper name of the native alien civilization whose members consciously shape living systems.

Use these names for organized command factions, commanders, players, units, actions, objectives, records, and information layers. Use **human** and **alien** only for biological or descriptive categories. Not every alien organism belongs to the Plastai, just as not every future human presence is part of the Vanguard.

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

There is one objective world state. The Vanguard and Plastai do not receive filtered copies of it. Each faction constructs its situation from evidence acquired through its own collectors, access, expertise, and reporting delays.

### Evidence is not a conclusion

The simulation presents observations and reports. It does not assign confidence, probability, threat, importance, or recommended action. Interpretations belong to commanders.

### Asymmetry comes from ways of knowing

The Vanguard is fluent in industrial systems and comparatively weak at ecological interpretation. The Plastai are fluent in ecological systems and comparatively weak at industrial interpretation.

The factions should differ in what distinctions they can perceive, what relationships they notice, how they move through the world, and what signatures their own activity creates. They should not be symmetric rulesets with renamed resources.

### Uncertainty must be causal

Ambiguity comes from missed collection, limited access, overlapping signatures, delay, masking, deception, or missing concepts. The engine does not inject arbitrary misinformation merely to preserve uncertainty.

### Investigation is a decision

Reconnaissance is not a button that reveals truth. It is the commitment of time, position, assets, and exposure to acquire discriminating evidence. Good investigations test competing explanations.

### The world acts independently

Wildlife, ecology, weather, terrain, and other processes create real events and signatures without serving either faction. Environmental activity is not decorative noise; it participates in causality and can alter operations.

ProjectSignal is therefore a three-sided world with two command factions. Vanguard and Plastai commanders issue strategic orders. The environment has no unified commander or victory condition, but its organisms and systems act from their own drives and can oppose, assist, expose, or outlast either faction.

The Plastai are native and ecologically fluent, not owners of the biosphere. The Vanguard is newly arrived and industrially capable, not limited to passive observation. Both factions can observe, avoid, deter, fight, redirect, exploit, and protect environmental life. Their methods, costs, knowledge, and consequences differ.

Alien control of an organism must be caused by a specific biological mechanism and paid for through collection, cultivation, or adaptation. Human alteration of an ecosystem must likewise be caused by physical activity such as extraction, fencing, clearance, containment, transport, or habitat modification.

### Action creates information

Movement, collection, concealment, logistics, and intervention all leave physical consequences. A faction may learn about an opponent from how that opponent investigates, not only from what the opponent attacks.

### Resources exist in the world

ProjectSignal has no magical resource pool, abstract mana, or inventory detached from location.

Material, biomass, water, fuel, ammunition, construction inputs, specimens, personnel, and other consumed resources exist in objective state. They must be gathered or produced, stored, moved through a route, and delivered where they are used. They can be observed, delayed, diverted, captured, spoiled, destroyed, or cut off.

The simulation may aggregate physical flows at operational scale. It must not erase the location, movement, dependency, or disruption that gives logistics strategic meaning.

Knowledge, designs, and learned genetic possibilities are not consumable resources. Acquiring them still requires physical observation, specimens, experimentation, infrastructure, and time.

### Deception obeys the world

A decoy is a real arrangement that reproduces some signatures at a cost. It may omit secondary signatures, create new ones, or teach the observer about the deceiver. Deception shapes evidence; it does not directly edit an opponent's beliefs.

### Replay completes the design

The after-action report is part of the core experience, not a debugging appendix. It should reveal what happened, what each side could observe, what each side claimed, what each side ordered, and how those differences mattered.

### Combat remains subordinate

Combat, logistics, production, and adaptation exist to create and resolve information problems. They should not displace the signal, investigation, commitment, and assessment loop.

### Victory ends foundational dependence

The Vanguard is an expeditionary human force. It seeks to construct a planet-space interface capable of establishing a secure, sustained connection for future colonists. The exact architecture may vary, but victory means humanity is no longer an isolated and replaceability-limited foothold.

The Plastai seek to consciously design and mature a Titan-scale organism. Genetic assimilation can unlock unknown traits and alter the design, but the project remains an intentional strategic undertaking. A mature Titan gives the Plastai permanent advantage over the environment and enough power to clear opposing forces if they choose. Extermination is a possible consequence of that power, not the victory requirement.

Neither side wins primarily by annihilating the other. Both may advance their strategic projects with limited direct conflict, but their extraction, cultivation, logistics, and construction disturb the same world and expose opportunities for interference.

### Completion creates a terminal crisis

Strategic projects produce ambiguous precursor signatures while they are being assembled. Entering final commissioning or maturation produces an unmistakable global signal and begins a bounded last-response phase.

The opposing faction receives a real but finite opportunity to neutralize, disable, starve, delay, or otherwise break the terminal process. The window follows physical conditions such as launch preparation, structural commissioning, biological maturation, and continued supply. It is not an unexplained game timer and cannot be extended indefinitely through trivial harassment.

If the terminal process survives the response window, the project completes and the constructing faction wins.

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