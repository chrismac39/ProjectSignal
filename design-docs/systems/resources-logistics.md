# Project Signal — Resources and Logistics

## 1. Purpose

Resources and logistics exist to make geography, distance, preparation, and sustainment matter at the scale of the campaign.

They are not primarily systems for build-order optimization. They exist so that military and strategic capability depends on physical systems embedded in the game world.

Resources and logistics should:

* make distance matter
* create strategic commitments
* create vulnerable networks
* constrain power projection
* support faction asymmetry
* make regional geography meaningful
* force prioritization
* generate observable signals
* create opportunities for disruption and deception

The central rule is:

**Resources create capability, but logistics determines where and when that capability can actually exist.**

---

## 2. Core Design Philosophy

**Status: Established design principle**

Project Signal is not Factorio.

The economic game operates at theater scale across a world hundreds of kilometers across. Player agency should center on selecting regions, activating infrastructure, developing corridors, concentrating resources, establishing hubs, and deciding where limited capacity is committed.

Players make decisions about:

* regions
* corridors
* infrastructure
* throughput
* storage
* extraction
* transport
* concentration of resources
* competing priorities

Players should not spend most of their time:

* placing individual conveyors
* manually routing every crate
* optimizing tiny machine chains
* positioning individual extractors
* designing tile-scale factory layouts
* manually supervising repetitive shipments

Infrastructure remains physically present in the world, but the **unit of player decision is the site, corridor, hub, region, or network**, not the individual meter of road, pipe, or rail.

The simulation may contain considerable underlying detail. The player interacts with that detail through strategically meaningful abstractions.

---

## 3. Logistics Creates Power

**Status: Hard rule**

Neither faction possesses useful power independently of the systems that sustain it.

For Vanguard, power depends on combinations of:

* industrial production
* orbital delivery
* fuel
* energy
* ammunition
* maintenance
* transportation
* communications
* infrastructure
* personnel support

For Plastai, power depends on combinations of:

* biomass
* nutrient conversion
* nutrient storage
* aquifer transport
* brood development
* ecological access
* biological preparation
* developmental time

The factions solve the same strategic problem through fundamentally different logistical systems.

A powerful army located somewhere that cannot sustain it is not equivalent to a powerful army supported by a mature regional network.

---

## 4. Resource Categories

**Status: Partially established; exact categories remain unresolved**

Resources should be few enough to remain legible but distinct enough to produce meaningful constraints and competing priorities.

Project Signal should not contain a giant catalog of slightly different crafting materials.

Broad economic roles include:

### Vanguard

* raw extraction inputs
* energy and fuel
* processed industrial materials
* locally manufactured equipment and infrastructure
* advanced orbital-delivered systems
* personnel and specialist capacity
* transport capacity
* maintenance capacity
* infrastructure capacity

### Plastai

* ecological biomass
* converted nutrients
* stored nutrients
* developmental capacity
* biological specialization
* aquifer transport capacity
* brood capacity
* ecological access

Some of these may ultimately be modeled as capacities or constraints rather than stockpiled currencies.

Human personnel are not a currency.

Biomass is not generic alien money.

Transport capacity is not necessarily a resource counter.

The exact abstractions remain subject to later design.

---

## 5. Resource Geography

**Status: Established design principle**

Resources belong to geography.

The world is not a flat economic board covered with interchangeable resource nodes.

Resource availability is influenced by:

* terrain
* geology
* water
* aquifers
* ecology
* biome
* climate and weather
* session variability
* infrastructure access
* distance from existing networks

A resource is strategically useful only when it can be:

* discovered
* reached
* exploited
* transported
* defended
* integrated into the wider network

A huge resource deposit in inaccessible terrain can be less useful than a modest deposit already adjacent to a mature transport corridor.

A rich ecological region far from useful aquifer access may similarly be less valuable to the Plastai than a smaller resource base already integrated into their nutrient network.

---

## 6. Resource Discovery

**Status: Hard rule**

Exact valuable resource locations must not become permanently solved coordinates.

The underlying terrain is largely persistent and learnable. Strategic resource geography varies between sessions.

The intended hierarchy is:

> **Terrain defines possibility. Parameters define probability. The session seed defines reality. Recon defines knowledge.**

The authored world contains plausible candidate regions rather than permanently fixed jackpot locations.

Examples include:

* geological regions capable of containing hydrocarbons
* mineral-bearing formations
* suitable industrial sites
* viable transport corridors
* productive grazing regions
* wetlands
* migration corridors
* aquifer systems
* aquifer access points
* brood-compatible regions

Session generation varies properties such as:

* presence
* richness
* density
* quality
* extent
* accessibility
* connectivity
* population
* seasonal behavior

Players may understand that a region is promising without knowing its exact value.

Vanguard geological or orbital survey may identify a likely hydrocarbon basin without revealing its exact reserves.

Plastai familiarity with an ecosystem may identify a productive watershed without revealing the exact future location or size of migratory herds.

Geographic knowledge helps.

It does not solve the opening.

---

## 7. Strategic Scale of Extraction

**Status: Established design principle**

Extraction is a regional commitment rather than a repetitive placement exercise.

Players think in terms of:

* establishing a mine
* exploiting a mineral province
* opening an oil or fuel region
* harvesting a productive ecological zone
* establishing a processing hub
* developing a regional resource network

A single resource province may contain multiple viable extraction or access locations.

Development therefore still contains player agency.

The player may choose between:

* a highly productive site that is difficult to connect
* a smaller site near existing infrastructure
* several dispersed operations
* one heavily developed regional complex
* redundancy
* concentration

Extraction should generate physical consequences:

* traffic
* infrastructure
* activity
* signals
* defense requirements
* ecological effects
* maintenance requirements
* long-term commitments

---

## 8. Throughput

**Status: Hard rule**

Throughput matters at least as much as total stockpile size.

A faction may possess large quantities of resources globally while being unable to support a distant operation effectively.

Relevant constraints include:

* corridor capacity
* transport capacity
* storage
* bottlenecks
* loading and unloading
* route reliability
* distance
* disruption
* travel time
* regional infrastructure

This principle applies to both factions.

A Vanguard force cannot consume supplies merely because those supplies exist somewhere on the map.

A Plastai brood cannot draw unlimited nutrients merely because those nutrients exist somewhere within the broader biological network.

---

## 9. Storage

**Status: Established design principle**

Storage creates temporal flexibility.

It allows players to separate the time at which resources are produced from the time at which they are consumed.

Storage can:

* buffer temporary interruptions
* support remote regions
* prepare major offensives
* accumulate capacity before expansion
* allow emergency response
* reduce vulnerability to short disruptions
* create strategic reserves
* create valuable targets
* reveal future intent through buildup

Storage should exist at meaningful hubs rather than through constant inventory micromanagement.

Large concentrations of stored capability should have strategic consequences.

A depot filled before an offensive is useful.

It is also a target and a signal.

---

## 10. Logistics Corridors

**Status: Major established system**

Long-distance logistics are organized around strategic corridors.

Relevant Vanguard corridors include:

* roads
* rail
* river transport where appropriate
* air routes
* orbital receiving networks
* supporting communications and power infrastructure

Relevant Plastai corridors include:

* aquifer connections
* nutrient circulation routes
* surface collection routes
* links between brood sites and aquifer access points

Corridors:

* emerge from geography
* create strategic value
* create vulnerabilities
* shape expansion
* affect operational range
* generate observable activity

A corridor matters because meaningful portions of a faction's capability depend on it.

---

## 11. Chokepoints and Redundancy

**Status: Hard rule**

The world contains chokepoints, but it must also contain alternatives.

Potential chokepoints include:

* bridges
* mountain passes
* rail junctions
* depots
* terminals
* airfields
* orbital receiving sites
* aquifer access points
* constrained aquifer connections
* narrow valleys
* major logistics hubs

The map should not contain one permanently optimal bridge, pass, extraction site, or aquifer entrance whose location becomes a memorized solution.

The full-scale map contains many potential sites and routes.

Players determine which of those become strategically important through their own development decisions and through session-specific resource geography.

The fundamental tradeoff is often:

**efficiency versus resilience**

One high-capacity route may be extremely efficient.

Several lower-capacity routes may be much harder to cripple.

---

## 12. Distance and Cost

**Status: Hard rule**

Moving resources across hundreds of kilometers has real consequences.

Relevant costs may include:

* travel time
* fuel
* capacity usage
* maintenance
* exposure
* delay
* infrastructure
* personnel requirements
* route congestion

Where physical systems naturally create the cost, Project Signal should avoid arbitrary distance penalties.

Distance matters because things physically have to move.

---

## 13. Logistics and Time Compression

**Status: Established design principle**

Logistics continues during compressed time.

Transport takes meaningful simulated time but does not require continuous player supervision.

Shipments, convoys, trains, nutrient movement, brood development, maintenance, extraction, and other routine activity continue while simulation time advances.

The system should demand attention when something strategically important occurs, such as:

* a corridor becoming disrupted
* critical capacity falling below demand
* a major shipment being threatened
* a region becoming isolated
* a resource discovery changing strategic priorities
* a large concentration of enemy activity being detected

The player commands the system.

The player does not drive every truck.

---

## 14. Logistics as Signal

**Status: Core design principle**

Logistics creates evidence.

Major activity cannot occur without leaving some form of footprint.

Vanguard logistical signals can include:

* convoy frequency
* rail traffic
* aircraft movement
* road use
* construction
* power demand
* storage buildup
* orbital deliveries
* increased maintenance activity
* communications traffic

Plastai logistical signals can include:

* biomass concentration
* biomass depletion
* unusual fauna pressure
* nutrient rerouting
* repeated movement around water systems
* brood activity
* unusual activity around aquifer access
* large regional organism movements
* ecological disturbance

Players should be able to infer possible strategic intent from logistical behavior.

They should not receive automatic certainty.

---

## 15. Plausible Non-Combat Interpretation

**Status: Hard rule**

Logistical activity does not automatically indicate military preparation.

Increased Vanguard rail traffic may support:

* industrial expansion
* extraction
* construction
* relocation
* offensive preparation

Increased airlift may represent:

* maintenance
* personnel movement
* emergency resupply
* construction
* combat preparation

Plastai nutrient concentration may support:

* brood development
* migration
* recovery
* ecological exploitation
* expansion
* preparation of military organisms
* large biological projects

The same signal should often permit multiple plausible interpretations.

This reinforces the core information game.

---

## 16. Vanguard Resource Model

**Status: Established faction identity**

The Vanguard operates an industrial network economy.

Its capability depends on connecting extraction, processing, infrastructure, orbital supply, transportation, maintenance, energy, and scarce human expertise.

A simplified strategic relationship is:

**survey → extraction → processing → transport → sustainment → capability**

This is not intended to become a detailed factory production chain.

The important question is not exactly which intermediate component enters which machine.

The important question is whether the industrial and logistical network can support what the Vanguard player wants to do, where they want to do it.

---

## 17. Vanguard Local Production

**Status: Partially established**

Local production provides sustainment and scale.

Likely locally produced categories include:

* bulk materials
* fuel
* repairs
* common machinery
* infrastructure components
* construction materials
* ammunition where appropriate

Local industry allows the expedition to transform local resources into increasing strategic independence.

However, local production does not make the expedition fully self-sufficient.

The exact boundary between locally manufacturable systems and orbital-delivered systems remains unresolved.

---

## 18. Vanguard Orbital Supply

**Status: Established design principle**

Orbital delivery provides access to capabilities that cannot be trivially recreated from local industry.

Potential orbital-delivered categories include:

* advanced electronics
* specialized systems
* rare components
* high-end machinery
* specialized vehicles
* unique weapons
* personnel
* mission-critical equipment

Orbital delivery is:

* limited
* delayed
* visible
* infrastructure-dependent
* strategically valuable

It is not an unlimited catalog from which the player purchases anything whenever sufficient generic resources exist.

Orbital capacity itself creates prioritization.

Sending one form of capability means not sending something else.

---

## 19. Vanguard Fuel and Energy

**Status: Concept established; exact abstraction unresolved**

Fuel and energy support industrial and military reach.

They may constrain:

* aircraft
* ground vehicles
* industry
* power generation
* remote facilities
* transportation
* extraction

Fuel should matter because it shapes logistics and geography, not because the player is expected to manage dozens of tiny fuel inventories.

A major fuel-producing region can become strategically important.

So can the infrastructure connecting it to the rest of the network.

Reduced local fuel availability should create alternative strategies and logistical pressure rather than simply disabling aircraft or other core capabilities.

---

## 20. Vanguard Maintenance

**Status: Established design principle**

Advanced machinery requires sustained maintenance.

Maintenance may depend on:

* repair facilities
* spare capacity
* specialized components
* human expertise
* transportation
* time

Maintenance provides a natural constraint on operational tempo.

A vehicle existing does not mean it can operate indefinitely at full intensity.

Remote operations impose higher logistical burdens because damage, wear, spare parts, recovery, and specialist support must all reach them.

Maintenance must not become individual durability-bar micromanagement.

---

## 21. Vanguard Personnel as a Strategic Resource

**Status: Hard faction rule**

Human personnel are limited and strategically precious.

They are not a spendable currency.

Their constraint arises from:

* limited numbers
* specialization
* assignment requirements
* exposure to danger
* replacement difficulty
* transportation
* the need for human presence in particular facilities or operations

Automation allows Vanguard infrastructure to operate with far fewer people than a contemporary industrial system would require.

It does not eliminate humans from the system.

The player may possess enough machinery to establish another operation while lacking enough qualified personnel to safely supervise it.

Committing humans to remote sites therefore creates strategic exposure.

Loss of specialized personnel can matter far more than destruction of an equivalent number of unmanned systems.

---

## 22. Vanguard Road Logistics

**Status: Established intended behavior**

Roads provide the Vanguard's flexible surface distribution network.

They support:

* dispersed extraction sites
* construction
* mobile forces
* moderate freight throughput
* regional distribution
* access to areas not worth connecting by rail

Roads are generally easier to establish and use than rail.

They are less efficient for sustained extreme heavy throughput.

At the scale of Project Signal, the player should not manually draw every bend in every road.

The world contains many geographically plausible route alignments and corridor options.

The player chooses which connections to establish, improve, maintain, or abandon.

---

## 23. Vanguard Rail Logistics

**Status: Major established system**

Rail is the Vanguard's high-throughput long-distance surface logistics system.

Rail is:

* high-throughput
* infrastructure-heavy
* efficient over long distances
* strategically visible
* vulnerable to disruption
* dependent on bridges
* dependent on track
* dependent on terminals
* dependent on maintenance

Rail enables industrial and military operations that would be much harder to sustain through roads alone.

It also represents commitment.

A heavily developed rail corridor visibly tells the opponent that the Vanguard considers the regions it connects important.

The player should choose among predefined or terrain-derived plausible rail corridors rather than manually laying every piece of track.

The strategic decision is:

> **Which continental-scale connections are worth building?**

not:

> **Which tile should the next rail segment occupy?**

---

## 24. Vanguard Air Logistics

**Status: Established intended behavior**

Air transport provides speed and flexibility rather than bulk efficiency.

Potential uses include:

* high-priority cargo
* personnel
* emergency resupply
* remote operations
* rapid relocation
* support of isolated positions

Air transport is:

* fast
* flexible
* expensive
* capacity-limited
* weather-sensitive
* fuel-dependent
* dependent on airfields or suitable landing infrastructure

Air transport complements ground logistics.

It does not replace them.

---

## 25. Plastai Resource Model

**Status: Established faction identity**

The Plastai economy is ecological and biological rather than industrial.

Its major elements are:

* ecological biomass
* nutrient conversion
* nutrient storage
* aquifer connectivity
* brood development
* biological specialization
* developmental time

The Plastai do not operate organic mines and factories that merely duplicate Vanguard industry with different art.

Their economic geography is built around ecosystems, water systems, brood regions, and the concentration and movement of biological potential.

---

## 26. Biomass Acquisition

**Status: Established principle; exact mechanics unresolved**

The Plastai obtain useful biological material from the living world.

Potential sources include:

* fauna
* megafauna
* vegetation
* carrion
* other productive ecological systems

The value of an ecological region depends on:

* available biomass
* ecological productivity
* season
* water
* transport
* competition
* depletion
* access to the nutrient network

Fauna are not static resource nodes.

Populations occupy ecosystems, move through migration corridors, reproduce, decline, and respond to world conditions.

A productive grazing basin may support immense biomass in one session and a significantly different population in another.

Biomass gathered at the surface does not instantly become globally spendable Plastai resources.

---

## 27. Nutrient Conversion

**Status: Established design principle**

Biomass and usable stored nutrients are distinct concepts.

Biological material must be:

* collected
* processed or converted
* stored
* routed
* allocated

This creates a real logistical chain without reproducing a machine-by-machine factory game.

The exact biological mechanism remains intentionally abstract until later faction-system design requires more detail.

---

## 28. Plastai Nutrient Network

**Status: Core faction system**

The underground aquifer nutrient network is the Plastai equivalent of strategic logistics infrastructure.

Surface sites collect biological material.

Brood regions and associated biological infrastructure convert, store, and move nutrients.

Aquifer connections allow resources to move between geographically separated brood systems.

The network supports:

* underground nutrient circulation
* movement between brood sites
* storage
* regional concentration
* strategic redistribution
* expansion through new access points

Its advantages are that it can be:

* concealed
* distributed
* biologically integrated
* difficult for Vanguard reconnaissance to fully understand

Its constraints include:

* geography
* aquifer connectivity
* throughput
* distance
* development
* access points
* storage
* regional concentration

The nutrient network does **not** provide unrestricted teleportation.

Large resource movements require real network capacity and simulated time.

The location and connectivity of useful aquifer systems vary with the world and session state rather than being permanently solved map coordinates.

---

## 29. Nutrient Allocation

**Status: Established intended gameplay**

A major part of Plastai economic play is deciding where accumulated biological capacity goes.

Competing uses may include:

* establishing new broods
* maturing organisms
* developing specialized forms
* producing infrastructure organisms
* expanding aquifer access
* recovering damaged regions
* maintaining reserves
* preparing large strategic organisms
* environmental manipulation

The central decision is not how to optimize a biological assembly line.

It is:

> **Where should the faction's accumulated biological potential be committed?**

---

## 30. Brood Development as Logistics

**Status: Hard faction rule**

Plastai unit creation is part of the logistics system.

Broods require:

* nutrients
* developmental capacity
* time
* suitable location
* supporting biological infrastructure

A mature force represents prior logistical investment.

A large concentration of organisms cannot simply appear because a global biomass counter is high.

The resources must have reached an appropriate developmental system, and development must already have occurred.

This distinguishes Plastai production from conventional RTS queues.

---

## 31. Dormancy and Prepositioned Capacity

**Status: Established concept**

Mature or nearly mature organisms may be prepared and held dormant or in stasis.

This allows:

* advance preparation
* delayed deployment
* hidden reserve capacity
* triggered emergence
* strategic surprise

Dormancy requires prior investment.

It depends on:

* nutrients
* developmental time
* suitable locations
* brood capacity

Dormancy stores prepared capability.

It does not create free units.

This also creates an important intelligence problem: a seemingly quiet region may contain substantial previously prepared capability.

---

## 32. Large Biological Projects

**Status: Established strategic direction; exact implementation unresolved**

Very large biological projects require extraordinary resource concentration.

These include:

* megafauna-scale organisms
* Titan-scale organisms
* large brood systems
* major environmental transformation

Such projects require sustained nutrient investment over meaningful time.

They directly compete with:

* ordinary military maturation
* expansion
* recovery
* reserve building
* ecological development

A Titan-scale organism is therefore not simply the result of reaching a high technology tier and clicking a production button.

Its existence represents an enormous logistical event.

Preparing such an organism should itself create indirect signals even when the actual developmental site remains concealed.

---

## 33. Resource Competition

**Status: Hard design principle**

Economic depth comes from competing priorities rather than the number of currencies.

Examples include:

* expansion versus defense
* immediate force versus infrastructure
* local strength versus distant reach
* reserves versus active deployment
* many ordinary Plastai broods versus one massive biological project
* road flexibility versus rail investment
* industrial expansion versus military sustainment
* aircraft support versus other Vanguard logistical demands
* orbital allocation toward one strategic system versus another

A good resource system regularly presents situations where several investments are desirable and all cannot be pursued at maximum intensity simultaneously.

---

## 34. Strategic Scarcity

**Status: Hard design principle**

Scarcity should arise primarily from systemic constraints.

Important constraints include:

* distance
* throughput
* ecological productivity
* human population
* specialist availability
* transport capacity
* aquifer capacity
* orbital delivery limits
* developmental time
* maintenance
* physical geography

Hard caps may exist where they naturally make sense.

The game should not rely primarily on arbitrary population caps, storage caps, or percentage penalties to restrain growth.

---

## 35. Expansion

**Status: Established design principle**

Economic expansion means extending a faction's functional network into new geography.

For Vanguard, expansion may require:

* roads
* rail
* power
* communications
* extraction
* depots
* industrial hubs
* airfields
* personnel support

For Plastai, expansion may require:

* aquifer access
* brood sites
* biomass access
* nutrient circulation
* ecological reach
* suitable developmental environments

Expansion changes which parts of the map a faction can effectively exploit and sustain.

The map can contain dozens of candidate industrial sites, transport connections, brood regions, and aquifer access points.

The player decides which ones become important.

---

## 36. Overextension

**Status: Major hard rule**

Both factions can expand faster than their logistical systems can support.

Vanguard overextension may emerge through:

* long supply lines
* insufficient maintenance
* sparse personnel
* weak communications
* exposed transport corridors
* inadequate fuel distribution
* insufficient transport throughput

Plastai overextension may emerge through:

* stretched nutrient networks
* inadequate biomass
* limited aquifer throughput
* vulnerable access points
* insufficient brood capacity
* too many simultaneous developmental commitments

There is no need for a generic "overextension meter."

Overextension should be visible through the actual strain experienced by the network.

---

## 37. Logistics Disruption

**Status: Established design principle**

Destroying or disrupting sustainment can be more important than destroying frontline forces.

Potential Vanguard targets against Plastai include:

* brood sites
* aquifer entrances
* surface biomass concentrations
* nutrient hubs
* emergence areas
* ecological regions supporting major harvesting

Potential Plastai targets against Vanguard include:

* roads
* rail
* bridges
* depots
* airfields
* extraction sites
* industrial hubs
* communications
* human personnel

The opponent should often have several possible points of intervention rather than one scripted weak point.

---

## 38. Recovery and Rerouting

**Status: Hard rule**

Logistical systems must contain enough resilience to produce adaptation rather than instant collapse.

Players can respond through:

* rerouting
* repair
* substitution
* stockpiling
* redundancy
* relocation
* temporary reduction in operational tempo

One destroyed bridge, depot, brood site, or aquifer access point should not automatically end the game.

A faction that deliberately built a brittle network may nevertheless suffer catastrophic consequences when its few critical links are lost.

---

## 39. Logistics and Deception

**Status: Established design principle**

Deception should emerge from real logistical actions.

Examples include:

* stockpiling in one region while intending to operate elsewhere
* routing shipments through misleading hubs
* constructing apparently important infrastructure
* maintaining redundant corridors
* rerouting nutrients
* exposing one aquifer access point while another performs the important transfer
* preparing dormant organisms away from their eventual emergence area
* creating visible industrial activity that masks another commitment

False signals should usually cost something real.

Deception is more interesting when the player manipulates an actual system rather than activating a generic "create fake signal" ability.

---

## 40. Logistics and Weather

**Status: Cross-system dependency**

Weather affects logistics through the physical world.

Potential consequences include:

* aircraft grounding
* flooded roads
* bridge damage
* snow
* mud
* wildfire
* reduced visibility
* altered river conditions
* altered aquifer conditions
* changed ecological productivity
* changed biomass availability

The result depends on existing world state.

The same weather event can therefore affect different sessions differently.

This document defines the logistical consequences only. Detailed weather behavior belongs in `world/weather.md`.

---

## 41. Logistics and Ecology

**Status: Cross-system dependency**

Ecology is part of the resource landscape.

Examples include:

* migration changing biomass geography
* overharvesting reducing future availability
* fire destroying biomass
* flooding creating or removing productive ecological zones
* Vanguard infrastructure disrupting migration corridors
* water availability changing regional carrying capacity
* seasonal abundance creating temporary Plastai opportunities

The Plastai economy in particular depends on a world whose ecology remains spatial and temporal rather than becoming static resource deposits.

Detailed ecological behavior belongs in `world/ecology.md`.

---

## 42. Logistics and Information

**Status: Core design principle**

Large operations leave logistical fingerprints.

Players may infer strategic activity from:

* unusual regional supply demand
* increasing rail throughput
* repeated orbital deliveries
* new storage construction
* construction of large transport hubs
* new roads or rail connections
* unusual biomass depletion
* recurring organism movement
* nutrient concentration toward a previously quiet area
* repeated convoy patterns
* changes in air transport

These clues do not automatically reveal intent.

They provide evidence.

The player interprets that evidence.

---

## 43. Strategic Reserves

**Status: Established intended behavior**

Holding resources in reserve provides flexibility.

Reserves can enable:

* emergency response
* exploitation of unexpected opportunities
* rapid reinforcement
* recovery from disruption
* major offensive preparation
* deception
* survival through temporary logistical isolation

Excessive reserves also represent unused potential.

Resources sitting safely in storage are resources not currently expanding infrastructure, generating forces, or extending strategic reach.

---

## 44. Economic Tempo

**Status: Established design principle**

Both factions have rhythms of investment and payoff.

Typical patterns include:

* building infrastructure before expansion
* surveying before committing to extraction
* accumulating resources before an offensive
* preparing brood capacity before mass maturation
* recovering after a major operation
* investing in long-term capacity at the expense of present strength
* temporarily reducing operational tempo after heavy losses

These rhythms emerge from logistics and development time.

They are not rigid scripted economic phases.

---

## 45. Session-Variable Resource Geography

**Status: Hard rule**

The physical map is authored.

The strategic resource map is partially generated each session.

Project Signal uses **fixed plausible geography with variable strategic realization**.

The authored map determines where resources and infrastructure could plausibly exist.

Session parameters and seeded generation determine what actually becomes valuable.

For a potential Vanguard resource region, generation may vary:

* whether a meaningful deposit exists
* deposit size
* richness
* quality
* extraction difficulty
* depth
* geographic extent

For ecological resources, generation may vary:

* population density
* species distribution
* herd size
* migration routes
* seasonal range
* ecological productivity

For aquifer systems, generation may vary:

* water level
* productive access points
* connectivity
* throughput potential
* regional extent

Resource distributions should have shape.

A hydrocarbon resource can occupy a basin rather than a single node.

A herbivore population can occupy a seasonal range rather than a fixed spawn point.

An aquifer can form a connected underground region with several surface access opportunities.

This prevents memorized map openings while retaining geographic coherence.

---

## 46. Session Parameters and Resources

**Status: Established system relationship**

Session variability modifies the physical world first.

Economic and logistical consequences emerge from that world state.

Three distinct systems contribute to session variation:

### Random World Condition

A strong, non-votable session condition affects the physical world for both factions.

Examples may alter:

* water abundance
* climate
* terrain accessibility
* ecological productivity
* fauna distribution
* aquifer state

These conditions should never arbitrarily remove a faction's fundamental strategic vocabulary.

A dry world does not mean that Plastai cannot use aquifers.

A resource-poor region does not mean Vanguard aircraft become impossible.

Instead, opportunity costs and strategic geography change.

### Public World Modifier Votes

Players can influence weaker world-generation parameters that are visible to both sides.

These modify probability and distribution rather than selecting exact outcomes.

A modifier may increase the prevalence of:

* wetlands
* migratory fauna
* mineral-rich regions
* particular terrain forms
* shallow groundwater
* particular ecological conditions

Knowing the modifier does not reveal where the resulting opportunities actually exist.

### Secret Faction Selection

Each faction also possesses hidden session-specific faction flavor or subfaction-style choices.

These are not simple percentage bonuses.

They may gate specialized capabilities, developmental paths, expedition packages, biological repertoires, or strategic tools.

Their detailed design belongs primarily in the faction documents rather than this logistics doctrine.

Their logistical behavior should nevertheless create signals through which the opposing player may infer what was selected.

---

## 47. World Generation Guardrails

**Status: Established intended behavior**

Randomized resource geography must produce uncertainty without creating arbitrary unwinnable starts.

The generator should ensure that:

* faction-critical resource classes exist in multiple viable regions
* no fundamental capability depends on one permanently unique resource site
* both factions have reasonable early expansion opportunities
* major exceptional opportunities encourage exploration
* strategic resources remain distributed enough to create choices
* exact high-value concentrations cannot simply be memorized

Randomness should determine **where the best opportunities are**, not whether a faction is permitted to function.

A poor survey result should create adaptation.

It should not mean that the session seed removed a major part of the faction.

---

## 48. Latent Infrastructure Geography

**Status: Established design direction**

Vanguard logistics uses a broad network of geographically plausible potential infrastructure rather than unrestricted tile-by-tile construction.

The map can contain many potential:

* road alignments
* rail corridors
* passes
* bridge locations
* industrial sites
* extraction sites
* airfield sites
* regional hubs

Only a subset becomes important in a given session.

The player chooses which possibilities to activate and develop.

This allows infrastructure to have a strong physical presence in the world while avoiding low-level construction micromanagement.

The same principle applies differently to Plastai geography through:

* multiple aquifer access points
* multiple brood-compatible regions
* multiple ecological harvesting regions
* alternative underground connections

The strategic network is therefore **constructed through choices among many plausible options**, not predetermined by a handful of permanent chokepoints.

---

## 49. What the Resource and Logistics System Must Never Become

**Status: Hard guardrails**

The resource and logistics system must never become:

* Factorio
* conveyor-belt micromanagement
* a giant crafting tree
* dozens of interchangeable currencies
* tile-scale industrial layout as the primary economic game
* a system where every resource instantly teleports globally
* a system where stockpile size is the only economic consideration
* a system where logistics is decorative
* a system where roads and rail are merely cosmetic movement-speed upgrades
* infinite orbital supply
* unrestricted Plastai aquifer teleportation
* biomass as generic money
* humans as generic currency
* a system with solved permanent resource coordinates
* a game of manually supervising every shipment
* an economy balanced primarily through arbitrary caps or percentage modifiers
* a system where random generation simply removes core faction capabilities
* a system where one memorized bridge, basin, aquifer point, or migration route solves the map
* a system where faction asymmetry consists only of renamed versions of the same production chain
* complexity added merely for the sake of appearing deep

Strategic complexity should emerge from geography, competing priorities, imperfect information, logistics, time, and player commitment.

---

## 50. Open Design Questions

**Status: Unresolved**

The following remain genuine design questions:

* exact Vanguard resource categories
* exact scope of local manufacturing
* exact division between local production and orbital delivery
* exact orbital delivery limits and cadence
* exact abstraction of fuel
* exact abstraction of power generation
* exact role of ammunition
* exact road throughput model
* exact rail throughput model
* exact convoy abstraction
* exact degree of automated route selection
* exact interaction between predefined corridors and player-created infrastructure
* exact Plastai biomass conversion mechanics
* exact nutrient storage representation
* exact aquifer throughput representation
* exact brood-development capacity model
* exact degree to which ecological harvesting can be intensified or deliberately conserved
* exact economic reconnaissance mechanics
* exact resource-generation validation rules
* exact economic and logistics UI
* exact number and nature of secret faction packages
* which specialized faction capabilities are permanently gated by secret selection versus obtainable during play

These questions should be resolved only when implementation or adjacent design systems require them.

---

## 51. Resources and Logistics Design Test

Any future resource, production, infrastructure, or logistics mechanic should be evaluated against the following questions:

* Does distance matter?
* Does geography matter?
* Does this create a meaningful logistical commitment?
* Does power depend on sustainment?
* Does it create observable signals?
* Can the opponent disrupt or exploit it?
* Does it reinforce faction asymmetry?
* Is the decision strategic rather than tile-scale micromanagement?
* Does it create a real tradeoff between competing priorities?
* Can the system become overextended?
* Can the player build resilience or redundancy?
* Does it interact with weather, ecology, and the map?
* Does it preserve uncertainty between sessions?
* Does map knowledge help without solving resource locations?
* Does it create player agency without demanding repetitive labor?
* Is the physical infrastructure visible enough to matter in the world?
* Does the mechanic create a decision rather than merely remove one?
* Does it avoid becoming a generic resource-counter system?
* Could the same effect emerge more naturally from geography, throughput, time, or logistics rather than an arbitrary numerical modifier?

The final test is:

> **Resources create capability, but logistics determines where and when that capability can actually exist.**
