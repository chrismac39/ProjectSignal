# World and Ecology

> Status: Future design reference. Prototype 0 currently models only the ecological behavior required by its active scenario.

## Core Principle

The world is not a backdrop.

The world is an active system that exists independently of either faction.

The planet possesses:

* Ecosystems
* Wildlife
* Migration patterns
* Predators
* Climate
* Geography
* Biological cycles

The world continues functioning whether players interact with it or not.

The battlefield emerges from the interaction of the Vanguard, the Plastai, and the environment.

---

## A Three-Sided World

ProjectSignal has two command factions and an autonomous environmental force.

The environment is faction-like in its strategic weight, persistence, and ability to initiate events. It is not a conventional faction because it has:

* No unified commander.
* No shared strategic objective.
* No global allegiance.
* No omniscient coordination between species.
* No victory condition.

Environmental actors include individual organisms, populations, habitats, ecological relationships, weather systems, and other natural processes. Each follows local drives and conditions rather than a single plan.

This distinction matters. A predator defending territory, a herd following forage, and a forest responding to drought may work against the same faction without cooperating. The other faction cannot assume that environmental resistance indicates enemy control.

The environment should be able to:

* Initiate movement, conflict, scarcity, and opportunity.
* Interrupt either faction's plans.
* React to disturbance and exploitation.
* Carry evidence of faction activity.
* Be manipulated without becoming perfectly obedient.
* Produce second-order effects after the initiating faction has left.

---

## Environmental Agency

Each modeled species or process needs only enough behavior to create operational consequences. It does not need commander-level planning.

Useful environmental drives include:

* Feeding and resource seeking.
* Avoiding danger or disturbance.
* Defending territory, offspring, or nesting sites.
* Migrating between seasonal conditions.
* Competing with or preying upon other species.
* Following water, temperature, nutrients, or shelter.
* Recovering from fire, extraction, contamination, or overharvest.

These drives create objective events whether or not either command faction observes them.

Environmental behavior should be condition-driven rather than scripted as disguised enemy action. Scenario scripts may establish conditions and pressures, but the resulting event should have a traceable ecological cause.

---

## Independence, Influence, And Control

Native origin does not grant Plastai ownership. Industrial capability does not grant Vanguard mastery. Relationships with environmental organisms exist on a spectrum:

### Independent

The organism follows its own drives. Either faction may observe, avoid, fight, exploit, or alter its conditions.

### Habituated or deterred

Repeated exposure changes how an organism responds to a faction, route, structure, signal, or area. The organism remains autonomous.

### Attracted or redirected

A faction changes incentives or conditions so that likely behavior shifts. Examples include food, sound, pheromones, barriers, water access, fire, or habitat disturbance. Redirection can fail or create unintended movement.

### Contained or cultivated

A faction invests in physical infrastructure or biological relationships that constrain access and reproduction. Fences, reserves, nursery habitats, feeding grounds, and managed migration corridors belong here. Escape, disease, predation, and ecological spillover remain possible.

### Influenced

Plastai biology alters signaling, development, or behavior through an explicit mechanism. Influence may bias a species toward scouting, transport, defense, distraction, or resource production, but the mechanism has range, upkeep, and failure conditions.

### Directly controlled

An organism is part of a faction's command system and can receive orders. This is exceptional. Plastai castes and deliberately integrated organisms may qualify; ordinary wildlife does not. Direct control must be represented in objective state and produce physical signatures.

The state must never change from independent to controlled merely because the Plastai have ecological expertise. Knowledge makes manipulation more precise; it does not replace mechanism or cost.

### Compatibility limits

Not every species can occupy every relationship state.

* Some organisms can be harvested but not behaviorally influenced.
* Some can be redirected through ordinary ecological incentives but cannot be biologically integrated.
* Some can sustain symbiosis or cultivation while retaining independent behavior.
* Only biologically compatible organisms with a dedicated integration mechanism can become directly controlled.
* A species cannot be made to ignore its basic habitat and metabolic constraints merely because it is influenced.

Compatibility is a property of the species, mechanism, and current condition. It is not overcome by paying an arbitrarily large generic cost.

### Persistence and failure

Every non-independent relationship states what sustains it and how it ends.

* Habituation and deterrence weaken when repeated stimuli stop or conditions change.
* Attraction and redirection persist only while the altered incentive remains relevant.
* Containment depends on maintained barriers, habitat, and supply.
* Cultivation depends on the health of the managed ecological relationship.
* Plastai influence depends on a living mechanism, compatible organism, and continued biological support.
* Direct integration may persist without continuous command contact, but damage, disease, adaptation, or severed support can degrade command response.

Failure does not restore a neutral game piece. An escaped, starving, injured, displaced, or suddenly unguided organism resumes behavior from its resulting condition.

Transitions and failures create signatures. Barriers leave geometry and traffic; chemical influence leaves residue and behavioral discontinuity; broken control may create disorganized movement, renewed territorial behavior, or collapse of a dependent population.

---

## Shared Environmental Interaction Loop

Both command factions use the same broad loop when environmental life affects an operation:

`Observe -> Interpret -> Choose posture -> Act -> Assess ecological response`

Shared postures include:

* **Observe** - collect evidence about presence, movement, condition, and relationships.
* **Avoid** - change route, timing, signature, or operating pattern to reduce contact.
* **Deter** - make an area or target less attractive without seeking destruction.
* **Contain** - constrain movement or access through a persistent intervention.
* **Redirect** - alter conditions so likely movement or behavior shifts elsewhere.
* **Fight** - use force against an organism that directly contests an objective.
* **Exploit** - obtain material, access, labor, information, or strategic effect from environmental life.
* **Protect** - preserve an organism, population, or habitat because it supports a current objective.

Neither faction receives an automatic moral alignment with protection or exploitation. Both can preserve one ecological relationship while destroying another.

Direct environmental combat should use the same information rules as faction conflict. Commanders may not know population size, behavior triggers, reproductive importance, or whether observed aggression is territorial, predatory, displaced, or enemy-influenced.

---

## Asymmetric Environmental Methods

The shared verbs should not collapse faction identity.

| Interaction | Vanguard method | Plastai method |
| --- | --- | --- |
| Observe | Remote sensors, samples, tags, patrols, telemetry | Chemical traces, symbiotic observers, ecological relationships, local organisms |
| Avoid | Route planning, schedules, vehicles, hardened shelter | Ecological corridors, timing with biological cycles, adaptive forms |
| Deter | Noise, light, repellents, patrols, controlled fire | Predatory cues, pheromones, competitor introduction, territorial organisms |
| Contain | Fences, trenches, sealed storage, reserves, checkpoints | Cultivated barriers, binding organisms, habitat shaping, reproductive constraints |
| Redirect | Bait, water control, clearance, artificial corridors | Feeding relationships, scent trails, breeding pressure, altered habitat signals |
| Fight | Weapons, vehicles, traps, area denial | Castes, toxins, predators, parasitic or competitive organisms |
| Exploit | Extraction, capture, farming, labor, habitat conversion | Harvest, symbiosis, gene acquisition, nursery feeding, ecological leverage |
| Protect | Exclusion zones, veterinary intervention, habitat management | Mutualism, cultivation, predator balancing, biological shelter |

These are design families, not a promise that every listed mechanic will be implemented.

When both factions use the same interaction verb, their methods should differ in four ways:

1. **Prerequisite** - infrastructure, access, ecological relationship, specimen knowledge, or adaptation.
2. **Cost and time** - what must be committed and how quickly the effect can begin.
3. **Limits and failure** - which organisms and conditions the method can affect.
4. **Signatures** - what the action reveals to the opposing faction and environment.

No faction should be generally better at environmental interaction. The Vanguard tends toward broad remote collection, precise instruments, rapid physical intervention, and durable infrastructure. The Plastai tend toward local ecological baseline awareness, subtle redirection, living systems, and adaptation. Vanguard methods become costly away from logistics; Plastai methods become weak outside compatible ecologies and biological support.

### Complementary collection strengths

Environmental asymmetry includes access as well as interpretation, but it should not become universal Plastai information superiority.

The Vanguard tends to excel at:

* Broad-area remote surveys outside established ecological networks.
* Precise physical and chemical measurement once a sample is acquired.
* Durable records, instrumentation, and comparison across distant locations.
* Intensive forensic investigation of a chosen specimen, site, or event.

These methods can reach unfamiliar areas and produce exact measurements, but ground truth often requires exposed personnel, logistics, and deliberate tasking.

The Plastai tend to excel at:

* Detecting departures from a familiar local ecological baseline.
* Continuous sensing through established living relationships.
* Reading behavior, stress, reproduction, and trophic connections in compatible ecosystems.
* Collecting through organisms that blend into local biological activity.

These methods provide rich local context, but coverage depends on living access and compatible relationships. Industrial internals, distant sterile areas, abrupt novel technology, and conditions outside the network remain difficult.

Scenario balance comes from which evidence matters, where it exists, and what each faction must risk to acquire it. It does not require equal sensor range, equal report counts, or identical observation timing.

### Resource pathways

Resources are not universally faction-locked, but each faction has a primary conversion pathway.

* The Vanguard efficiently converts minerals, fuels, water, land, and manufactured inputs through extraction, logistics, and industry.
* The Plastai efficiently convert biomass, living relationships, nutrients, and genetic traits through harvest, cultivation, and growth.
* Both may use water, territory, organisms, and captured opposing material, but doing so outside their native pathway is slower, narrower, or requires specialized capability.

This is an asymmetry of systems and dependencies rather than an arbitrary prohibition. Vanguard personnel can farm native life, but cannot instantly integrate its genes into new units. A Plastai entity can disrupt or repurpose Vanguard material, but cannot automatically operate an industrial supply chain.

---

## Plastai Exploitation Of Life

Plastai ecological fluency enables unique biological uses, but the Plastai remain exploitative.

### Harvest

The Plastai may consume organisms or populations for biomass and nursery support. Harvest changes population structure, predator-prey relationships, movement, remains, and nutrient flow. Those changes create signatures that the Vanguard may observe without understanding the cause.

### Genetic acquisition

The Plastai may collect biological material to unlock or refine adaptations. Acquisition should depend on access to particular organisms or traits, not an abstract universal research resource. Removing rare or ecologically important organisms may have consequences beyond the immediate gain.

### Nursery cultivation

Nurseries may require living inputs, habitat conditions, symbiotic species, or protected trophic relationships. A nursery is therefore embedded in an ecosystem rather than functioning as a biological factory placed on empty ground.

### Titan growth

Titan growth may demand biomass, genetic diversity, ecological stability, or controlled transformation at a scale that alters the surrounding world. This makes Titan development legible through indirect ecological consequences before the Titan itself is understood.

### Symbiosis without benevolence

The Plastai can sustain or protect species that serve them. That relationship may be mutually beneficial, coercive, selectively bred, or parasitic. Native status does not make Plastai action ecologically neutral.

---

## Vanguard Exploitation Of Life And Habitat

Vanguard environmental interaction is not limited to suffering hazards.

### Resource extraction

Mining, water withdrawal, logging, fuel collection, and soil use alter habitat and ecological flows. The Vanguard understands the industrial output precisely while often understanding indirect biological consequences poorly.

### Barriers and access control

Fences, trenches, roads, culverts, lights, acoustic deterrents, and cleared corridors can protect infrastructure or redirect organisms. They can also divide migration routes, concentrate predators, create choke points, and expose Vanguard priorities.

### Capture and study

The Vanguard may tag, contain, sample, breed, or study organisms to improve taxonomy and operational knowledge. Captivity can distort behavior, and a local sample may not explain a population-scale process.

### Habitat engineering

Drainage, controlled burns, water management, contamination control, reserves, and restoration can make an area more usable. These actions create persistent signatures and may help some species while harming others.

### Industrial domestication

The Vanguard may eventually use native organisms for food, materials, detection, transport, or environmental management. Domestication is slow, infrastructure-dependent, and distinct from Plastai biological integration.

---

## Ecological Feedback And Cost

Environmental interaction should create chains, not isolated transactions.

Examples:

* Killing predators increases grazing pressure near a Vanguard route.
* Fencing protects a depot but funnels a migrating herd toward another facility.
* Plastai harvest deprives a nursery's symbiont of prey and changes its emitted chemistry.
* Protecting one species reveals what a faction values.
* Resource extraction lowers water availability and makes normally separate populations converge.
* Redirecting dangerous wildlife pushes it into the opposing faction's area, where it may be mistaken for deliberate attack.

The purpose is not to build a complete ecology simulator. The purpose is to make environmental choices produce observable, delayed, and sometimes misunderstood operational consequences.

---

## A Living Planet

If both factions were removed from the simulation, the world should still appear alive.

Examples:

* Animals migrate.
* Predators hunt prey.
* Populations fluctuate.
* Forests expand and contract.
* Breeding cycles occur.
* Species compete for territory.
* Seasonal changes alter behavior.

The planet should never feel like empty terrain waiting for players.

---

## Large Operational Scale

The simulated geography represents operational rather than tactical space.

Example target scale:

* 100 km x 100 km

The operational area should be large enough that:

* Reconnaissance matters.
* Logistics matter.
* Movement decisions matter.
* Entire regions remain poorly understood.
* Players cannot observe everything.

Uncertainty is a feature, not a limitation.

---

## Geography Matters

Operational areas should contain meaningful geographic features.

Examples:

* Mountain systems
* Valleys
* Forests
* Wetlands
* Rivers
* Lakes
* Coastlines
* Islands
* Grasslands
* Tundra
* Deserts

Geography should influence:

* Vanguard logistics
* Plastai ecology
* Expansion
* Mobility
* Reconnaissance
* Resource acquisition

---

## Vanguard Taxonomy Blindness

The Vanguard arrives with limited biological knowledge.

Prior to arrival, the Vanguard possesses only:

* Orbital imagery
* Spectral analysis
* Atmospheric readings
* Long-range observation

The Vanguard knows the planet contains extensive life.

The Vanguard does not possess a complete biological catalog.

The Vanguard cannot automatically distinguish:

* Native wildlife
* Plastai castes
* Ecological disturbances
* Plastai biological infrastructure
* Naturally occurring behavior
* Artificially influenced behavior

Vanguard sensors detect observations rather than classifications.

Examples:

* Movement detected
* Heat source detected
* Biological activity detected
* Infrastructure damage detected

Not:

* Plastai scout detected
* Plastai soldier detected
* Plastai structure detected

The Vanguard observes phenomena and must infer causes.

---

## Signal Equivalence

Different causes may generate identical observations.

Examples:

Movement detected:

* Wildlife migration
* Predator activity
* Plastai scout movement

Infrastructure damage:

* Predator attack
* Stampede
* Plastai assault

Population shifts:

* Natural ecological change
* Plastai harvesting
* Environmental pressure

Players should frequently ask:

"What am I actually looking at?"

rather than immediately concluding:

"This is enemy activity."

---

## Wildlife Is Not Decoration

Wildlife exists for gameplay reasons.

Wildlife may influence:

* Reconnaissance
* Expansion
* Logistics
* Resource collection
* False positives
* Ecological disturbances
* Information gathering

Wildlife creates information, uncertainty, opportunity, and risk.

---

## Biodiversity

The world contains many forms of life.

Examples:

* Grazers
* Predators
* Burrowers
* Flyers
* Aquatic species
* Territorial organisms
* Migratory megafauna
* Apex predators

The ecosystem should feel rich enough that the Vanguard cannot realistically catalog everything.

The existence of large numbers of species reinforces uncertainty.

---

## Ecology As Expansion Gating

Expansion is restricted by ecology as well as distance.

Certain regions may be difficult to enter because of:

* Territorial predators
* Migration corridors
* Breeding grounds
* Environmental hazards
* Hostile megafauna

The planet itself creates barriers to expansion.

---

## Species-Specific Hostility

Hostility is not universal.

Some species may:

* Threaten the Vanguard only.
* Threaten the Plastai only.
* Threaten both factions.
* Ignore both factions.

This creates asymmetric geography.

A region that is dangerous for the Vanguard may be relatively safe for the Plastai.

A region that is safe for the Vanguard may be avoided by the Plastai.

The same geography is understood differently by each faction.

---

## Native Megafauna

The planet contains large native organisms capable of affecting operations.

These organisms are not a third playable faction.

They possess their own needs, behaviors, and territories.

Examples:

* Territorial megafauna
* Migratory herd species
* Apex predators
* Environmentally disruptive organisms

These species may occasionally create meaningful strategic problems for either faction.

---

## The Plastai Relationship To The Ecosystem

The Plastai are native to the planet.

They possess extensive ecological knowledge.

They understand:

* Species behavior
* Migration routes
* Predator territories
* Nutrient flows
* Ecological relationships

However, they are not masters of the ecosystem.

The ecosystem continues functioning independently of Plastai desires.

Native organisms maintain their own behaviors and needs.

---

## Plastai Castes And Wildlife

The Plastai possess directly controlled units.

These units are referred to as Castes.

Castes are distinct from ordinary wildlife.

The simulation knows the difference.

The Vanguard generally does not.

Plastai Castes should blend naturally into the broader biosphere.

The Vanguard should not be able to reliably identify Plastai Castes at long range through appearance alone.

---

## Ecological Influence

Any native species may be strategically relevant, but only biologically compatible species are candidates for Plastai influence or integration.

Influence is not magical.

Influence consumes real biological resources and requires physical mechanisms within the world.

Depending on its biology and the available mechanism, a species may be exploited as:

* A threat
* A resource
* A sensor network
* A distraction
* A weapon

The Plastai cannot exploit every opportunity simultaneously.

Compatibility, access, ecological consequence, upkeep, and opportunity cost all constrain the relationship.

---

## Ecological Noise

Not every observation should be caused by player action.

Examples:

* Seasonal migration
* Predator activity
* Population shifts
* Drought
* Wildfire
* Breeding cycles

The world naturally generates signals.

This prevents players from assuming:

Observation = Enemy

---

## Vanguard Relationship To The World

The Vanguard views the planet as:

* Terrain
* Resources
* Infrastructure opportunities
* Hazards
* Unknown biological systems

The Vanguard seeks to understand and exploit the environment.

---

## Plastai Relationship To The World

The Plastai view the planet as:

* Habitat
* Nutrient flow
* Genetic opportunity
* Ecological connectivity
* Biomass

The Plastai seek to harvest, influence, and reshape the ecosystem in service of the Titan.

---

## Asymmetric Knowledge

The Vanguard understands industry and technology.

The Plastai understand ecology and biology.

Neither faction possesses perfect information.

Each faction receives signals from the world and attempts to interpret those signals.

Both factions may deliberately manipulate the signals observed by the other.

This asymmetry is central to Project Signal.

---

## The World Creates Stories

Important events should emerge naturally from interactions between:

* Vanguard
* Plastai
* Wildlife
* Geography
* Climate

Examples:

* A migration reveals a Plastai operation.
* A predator population disrupts reconnaissance.
* A drought changes expansion priorities.
* A dangerous species creates a temporary frontier.
* A false signal causes an overreaction.

The world should generate situations rather than merely host them.
