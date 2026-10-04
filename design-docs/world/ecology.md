Use this in the ecology-design chat:

```text
I am rebuilding the Project Signal repo from scratch around the refined design we have developed in this GPT project.

I already have:
- a root-level VISION.md
- factions/plastai.md
- factions/vanguard.md
- world/map.md
- world/weather.md

I now need a repo-ready Markdown document for the ecology system that consolidates the concrete ecology-design decisions from this chat.

Create:

world/ecology.md

The goal is not to invent a full ecological simulator. The goal is to formalize the ecological philosophy, fauna behavior, biomass logic, migration, environmental productivity, faction interactions, and simulation constraints we have already established.

Write in assertive present tense.

Clearly distinguish between:
- established design principles
- hard rules
- intended gameplay behavior
- unresolved design questions

Do not turn this into a scientific ecology paper or a low-level implementation spec. This is a design doctrine document.

Use this structure:

# Project Signal — Ecology Design

## 1. Purpose

Explain why ecology exists in Project Signal.

The ecosystem is not decorative wildlife and not a static resource layer.

Ecology should:
- make the world feel independently alive
- create changing strategic conditions
- produce signals
- support Plastai biomass and biological progression
- create hazards and opportunities for Vanguard
- react to weather and terrain
- influence movement and logistics
- create migration and regional change
- generate emergent stories
- prevent the map from becoming a solved board

## 2. Ecology Design Philosophy

Document the core principle that ecology should be strategically believable without requiring a complete scientific simulation.

The system should favor:
- coherent habitats
- persistent populations
- regional productivity
- migration
- predator/prey relationships where useful
- environmental response
- interaction with weather
- interaction with geography
- readable strategic consequences

Avoid:
- simulating biology for its own sake
- requiring every individual animal to have a full life simulation
- static wildlife resource nodes
- random creature placement with no habitat logic
- ecology that exists only to feed the Plastai

## 3. A Living World Independent of the Players

This should be a major section.

Document that animals and ecological systems continue to exist and change whether either player interacts with them or not.

Wildlife may:
- migrate
- feed
- reproduce
- concentrate around water
- flee danger
- respond to fire
- respond to weather
- compete
- follow seasonal patterns
- shift habitat

The environment should be capable of producing meaningful events without either faction causing them.

## 4. Baseline Biosphere

Document the intended baseline feel of the world.

Include:
- a highly productive biosphere
- much greater megafaunal abundance than modern Earth
- broad inspiration from prehistoric Earth in terms of ecological richness
- large herbivore populations
- substantial predator populations
- diverse aquatic, terrestrial, and aerial life where appropriate

Clarify that this is not an attempt to recreate a specific geological period.

The goal is a rich alien biosphere capable of supporting both gameplay and the Plastai's biological civilization.

## 5. Species and Ecological Roles

Explain how species should be designed around ecological roles rather than as collectible monsters.

Potential roles include:
- large herbivores
- small herbivores
- browsers
- grazers
- predators
- scavengers
- aquatic species
- amphibious species
- aerial species
- burrowing species
- herd animals
- solitary megafauna

Do not create an exhaustive bestiary unless one has already been established.

The ecology document should define the system that species inhabit.

## 6. Population Scale

Document the intended scale of wildlife populations.

Animals should exist in numbers large enough to matter strategically.

Some regions may contain:
- major herds
- migration waves
- large predator territories
- dense aquatic populations
- concentrated breeding grounds

Avoid the common game pattern where the entire map contains a handful of decorative animals.

## 7. Habitat

Explain that species distributions should depend on habitat.

Potential variables include:
- biome
- elevation
- water
- temperature
- vegetation
- terrain
- season
- prey availability
- shelter
- world-state modifiers

Species should have plausible preferred regions without becoming perfectly predictable.

## 8. Regional Ecological Productivity

Document the concept that different areas of the map support different levels and kinds of biological productivity.

Productivity may depend on:
- rainfall
- surface water
- vegetation
- temperature
- soil/moisture conditions
- season
- biome
- recent fire
- drought
- flooding

High-productivity regions should naturally attract wildlife and Plastai interest.

The exact productivity of a familiar region may differ between sessions.

## 9. Vegetation and Biomass

Explain vegetation at the strategic level.

The system does not need to simulate every plant.

Vegetation should influence:
- herbivore carrying capacity
- Plastai biomass opportunity
- wildfire
- concealment
- movement
- habitat
- long-term ecological recovery

Biomass should represent living ecological capacity rather than generic green resource points.

## 10. Biomass as a Plastai Resource

This should be a major section.

Document how the Plastai depend on the biosphere for biological input.

Cover:
- wildlife harvesting
- vegetation where appropriate
- biomass conversion
- nutrient production
- regional productivity
- depletion
- recovery
- competition for ecological resources

Make clear that biomass is not simply “money growing on the map.”

The ecological system should determine how much biomass is available, where it is concentrated, and how exploitation changes future conditions.

## 11. Ecological Depletion

Explain that heavy exploitation should have consequences.

Possible consequences include:
- herd decline
- migration shifts
- predator changes
- reduced local productivity
- long recovery time
- altered habitat
- scarcity
- ecological collapse in extreme cases

Avoid making depletion so punitive that the Plastai cannot function.

The goal is to make resource use a strategic relationship with the world rather than consequence-free harvesting.

## 12. Recovery and Regrowth

Document ecological recovery.

Potential factors:
- time
- season
- weather
- remaining population
- habitat quality
- migration
- vegetation recovery

Recovery should be meaningful on the campaign timescale without requiring a full population genetics model.

## 13. Migration

This should be a major section.

Document wildlife migration as both ecological behavior and strategic system.

Migration may respond to:
- season
- water
- food
- weather
- predators
- fire
- human infrastructure
- Plastai activity
- conflict

Migration should:
- change resource geography
- create signals
- create uncertainty
- create temporary opportunities
- alter predator movement
- cross faction infrastructure
- make the world dynamic

## 14. Migration Corridors

Explain how geography shapes migration.

Potential corridors include:
- valleys
- river systems
- mountain passes
- plains
- wetlands
- coastal routes
- lake systems

Migration corridors should sometimes overlap with:
- Vanguard logistics
- Plastai nutrient access
- strategic chokepoints
- resource regions

This overlap should create natural conflict and ambiguity.

## 15. Predator–Prey Dynamics

Document only the level of predator/prey simulation necessary for strategic behavior.

Predators should influence:
- herd movement
- regional danger
- carcass availability
- signals
- migration
- Plastai harvesting opportunities
- Vanguard operations

Do not build a detailed trophic simulation unless it creates meaningful gameplay.

## 16. Megafauna

This should be a major section.

Document the role of very large native animals.

Megafauna can:
- shape migration
- consume large amounts of vegetation
- create major biomass opportunities
- threaten infrastructure
- alter terrain locally
- generate strong signals
- serve as ecological landmarks or hazards

They should feel like ordinary parts of this world rather than boss monsters.

## 17. Dangerous Wildlife

Explain how native fauna can threaten both factions.

Potential consequences:
- attacks on exposed Vanguard personnel
- damage to light infrastructure
- disruption of convoys
- predation on smaller fauna
- conflict with Plastai organisms
- territorial behavior

Dangerous wildlife should behave according to ecological motives rather than existing as random hostile mobs.

## 18. Wildlife and the Vanguard

Document how Vanguard experiences the ecosystem.

Potential interactions include:
- collision hazards
- attacks
- migration interfering with routes
- damage to infrastructure
- biological uncertainty
- reconnaissance signals
- ecological disruption caused by industry
- need to avoid or clear dangerous regions

The Vanguard should not automatically understand what every species is or how it behaves.

## 19. Wildlife and the Plastai

Document how Plastai interacts with the ecology.

Potential interactions include:
- harvesting
- observation
- manipulation
- assimilation opportunities
- ecological competition
- predation
- directing activity toward useful areas
- avoiding damaging the resource base

Do not imply that native wildlife automatically obeys the Plastai.

The Plastai are part of the ecosystem, not magical controllers of it.

## 20. Ecological Knowledge

Explain how each faction understands ecology differently.

Plastai may possess deeper native biological intuition and lived understanding.

Vanguard may possess advanced sensing but incomplete interpretation.

Neither faction should necessarily possess perfect information.

The exact asymmetry of ecological knowledge should support the broader Project Signal information model.

## 21. Ecology as Signal

This should be a major section.

Document how ecological change produces signals.

Examples:
- herd movement
- sudden absence of wildlife
- predator displacement
- carcass concentrations
- disturbed vegetation
- abnormal migration
- mass flight from a valley
- aquatic disturbance

These signals may indicate:
- weather
- fire
- predators
- Vanguard activity
- Plastai activity
- resource depletion
- unrelated ecological change

Ecological signals should often be ambiguous.

## 22. Plausible Non-Combat Interpretation

Document the principle that ecological observations should not automatically imply enemy action.

A herd leaving a region may indicate:
- approaching weather
- predators
- wildfire
- water scarcity
- seasonal migration
- industrial noise
- Plastai harvesting
- combat

This reinforces the core information loop.

## 23. Ecology and Weather

Document the major interactions with world/weather.md.

Weather may affect:
- water
- vegetation
- migration
- breeding
- herd concentration
- fire
- habitat
- mortality
- predator behavior

The ecology system should consume weather state rather than duplicate the weather simulation.

## 24. Ecology and Fire

Explain how wildfire affects ecosystems.

Potential effects:
- immediate mortality
- herd movement
- destroyed biomass
- altered habitat
- smoke
- predator displacement
- long-term regrowth
- newly opened terrain

Fire can be both destructive and ecologically transformative.

Avoid reducing it to simple permanent damage.

## 25. Ecology and Water

Document the importance of water.

Water availability should strongly influence:
- migration
- herd density
- breeding
- vegetation
- predators
- wetlands
- Plastai activity

Lakes, rivers, springs, and wetlands should naturally become ecological concentrations.

## 26. Ecology and Seasonal Change

Explain how seasons can alter:
- migration
- vegetation
- breeding
- water availability
- snow cover
- predator behavior
- regional productivity

Do not over-specify detailed breeding calendars unless established.

## 27. Ecology and the Aquifer System

Document where ecology intersects with Plastai aquifers.

Potential links include:
- springs
- wetlands
- productive areas
- aquatic species
- biomass concentration
- brood emergence
- nutrient movement

Do not make every productive ecological region automatically an aquifer hub.

The interaction should be important but not perfectly aligned.

## 28. Species Distribution as Session Variability

Document that exact species presence and density can vary between campaigns.

The player may know:
- what kinds of ecosystems a region can support

without knowing:
- exactly which species are present
- exact herd locations
- exact population size
- current migration state

This prevents rote memorization.

## 29. Hidden Ecological Conditions

Explain how some ecological conditions may be hidden at game start.

Examples:
- unusually large herd populations
- predator concentrations
- rare species
- altered migration
- high-productivity regions
- local ecological imbalance

These should be discovered through play.

## 30. Private World Vote Interaction

Reference the session variability system where appropriate.

Examples may include:
- guaranteed docile herbivore herds
- guaranteed predator populations
- other narrow ecological world-state choices

Clarify that these alter the shared ecology.

The opponent can also encounter and exploit the resulting condition.

The selecting player gains foreknowledge, not ownership.

## 31. Ecology and Infrastructure

Explain how Vanguard infrastructure affects wildlife.

Potential effects:
- roads disrupting migration
- rail corridors
- noise
- lights
- industrial pollution where appropriate
- barriers
- bridges
- water alteration

Avoid overcomplicating environmental impact simulation.

Only model consequences that create strategic behavior.

## 32. Ecology and Conflict

Document how combat can disturb ecosystems.

Potential effects:
- explosions
- fires
- fleeing wildlife
- carcasses
- destroyed habitat
- altered migration

Conflict should leave ecological evidence.

This can itself become a signal.

## 33. Ecology and Deception

Explain how natural ecological behavior can create cover for faction activity.

Examples:
- Plastai movement mixed with migration
- wildlife displacement misread as military activity
- Vanguard operations concealed by storms or migrations
- deliberately exploiting predictable herd movement

Avoid explicit fake-animal mechanics unless already established.

## 34. Ecological Events

Document the role of larger ecological events.

Potential examples:
- major migration
- herd collapse
- predator expansion
- population boom
- regional scarcity
- mass movement caused by fire
- aquatic concentration

These should usually arise from system state rather than arbitrary scripted events.

## 35. Ecology and Time Compression

Explain how ecological change functions during accelerated time.

The simulation should:
- continue while time advances
- avoid updating every animal at excessive detail
- surface only strategically meaningful events
- allow gradual migration and population change

The ecology system should support long campaign timescales without creating overwhelming notification noise.

## 36. Simulation Abstraction

This should be a strong design section.

Document that ecology should be simulated at the lowest level necessary to produce the desired strategic behavior.

Possible abstractions include:
- populations
- herds
- territories
- migration groups
- regional biomass
- habitat suitability

Individual entities may be represented where tactically or visually useful, but the entire biosphere does not need individual-agent simulation.

The design should remain free to mix population-level and entity-level simulation.

## 37. Strategic Consequences

Summarize the ways ecology should create decisions.

Examples:
- whether to exploit a herd now or preserve it
- whether to build through a migration corridor
- whether animal movement indicates enemy activity
- whether a wildfire has permanently altered a region
- whether to contest a productive valley
- whether to commit forces to protect or deny biomass

## 38. Emergent Narrative

Describe the kinds of stories ecology should generate.

Examples:
- a major herd unexpectedly shifting into a contested region
- predators scattering Vanguard workers
- Plastai overharvesting a valley and losing future biomass
- wildfire destroying an expected food source
- migration revealing hidden activity
- both players misreading a natural movement as enemy action
- a previously minor wetland becoming strategically important after prolonged rain

These stories should emerge from interacting systems.

## 39. What the Ecology System Must Never Become

Make this a strong guardrail section.

Include:
- not decorative wildlife
- not static resource nodes
- not a zoo collection game
- not a scientific ecosystem simulator for its own sake
- not a full individual-agent simulation of every creature
- not random hostile mobs
- not ecology that exists only for Plastai harvesting
- not perfectly predictable species placement
- not infinite renewable biomass with no consequences
- not an ecology where weather has no effect
- not a system where migration is purely cosmetic
- not a system where every animal movement indicates enemy activity
- not a system requiring excessive micromanagement

Add any other anti-patterns clearly established in this chat.

## 40. Open Design Questions

Collect only genuinely unresolved ecology questions from this chat.

Potential examples:
- exact population abstraction level
- exact herd simulation model
- how detailed predator/prey interactions should be
- exact biomass recovery rates
- exact seasonal migration logic
- how much individual animal simulation is needed
- exact aquatic ecology scope
- exact overharvesting consequences
- how species discovery works
- exact ecological knowledge differences between factions

Do not invent uncertainty where a decision has already been made.

## 41. Ecology Design Test

End with a concise checklist future ecology mechanics can be evaluated against.

Include questions such as:
- Does this make the world feel independently alive?
- Does it produce meaningful strategic change?
- Does geography matter?
- Does weather matter?
- Does it create signals?
- Can those signals have multiple interpretations?
- Does it support Plastai biomass without becoming a simple resource-node system?
- Does it create meaningful consequences for exploitation?
- Does it affect Vanguard operations?
- Does it support session variability?
- Is the simulation abstract enough to remain practical?
- Could this system create an emergent story?

Most important:
Use the full context of this ecology-design chat and consolidate what we actually decided.

Do not replace established ideas with generic survival-game wildlife systems.

Do not build a scientific ecology simulator for its own sake.

The central principle is:

**The ecosystem is an independent living system that both factions must read, exploit, survive, and adapt to.**

Output only the finished Markdown document, ready to paste directly into the repo.
```
