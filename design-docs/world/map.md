# Project Signal — Map and World Design

## 1. Purpose

The map is a core strategic system in Project Signal, not merely a battlefield backdrop.

Geography determines what each faction can know, reach, exploit, defend, conceal, and influence. The world creates strategic problems through physical distance and regional differences rather than simply providing visual variety.

The map supports:

* strategic distance;
* incomplete information;
* logistics;
* ecological variation;
* weather;
* infrastructure;
* migration;
* aquifers;
* regional specialization;
* asymmetric faction movement;
* deception;
* long-term planning.

The map is large enough that events occurring in one region may be effectively isolated from forces operating elsewhere. Terrain, transportation, weather, ecology, and information determine whether those events can be detected and influenced.

The central map principle is:

> **The world is a continent-scale strategic system whose geography makes distance, logistics, ecology, information, and asymmetric movement matter.**

---

## 2. Reference Scale

The playable world is approximately the scale of the full state of Wyoming.

Wyoming covers roughly 250,000 km² and provides the primary physical reference for the size of the Project Signal theater.

Earlier concepts using much smaller theaters are abandoned. The map operates at regional or small-country scale rather than conventional RTS scale.

Major distances remain physically meaningful. A kilometer remains approximately a kilometer. The world is not compressed so that distant mountain ranges, settlements, forests, or military positions are only minutes apart.

This scale has direct gameplay consequences:

* units cannot be everywhere;
* travel time matters;
* aircraft have finite coverage;
* artillery has finite reach;
* infrastructure changes practical accessibility;
* regional commitments matter;
* forward basing matters;
* reconnaissance cannot trivially cover the entire world;
* distant events may develop substantially before either faction can respond.

Wyoming provides both a scale reference and the starting geographic foundation for the prototype world. It does not constrain the final fictional geography.

---

## 3. Geographic Philosophy

The world begins with recognizable large-scale physical geography and modifies it according to the needs of Project Signal.

Geography remains physically coherent. Mountain systems create valleys and basins. Rivers create corridors and crossing problems. Wetlands influence movement and ecology. Large forests alter visibility and biomass distribution. Open plains create mobility while increasing exposure.

The map avoids:

* arbitrary biome checkerboards;
* isolated resource zones with no geographic context;
* terrain created solely to manufacture game lanes;
* overly regular distributions;
* tiny RTS terrain features enlarged visually to imply greater scale;
* geography whose only purpose is aesthetic variety.

Natural geography creates:

* corridors;
* barriers;
* watersheds;
* basins;
* valleys;
* passes;
* isolated regions;
* productive regions;
* exposed regions;
* concealed regions.

Gameplay then emerges from how the simulation and both factions interact with those features.

---

## 4. Wyoming as the Foundation

Prototype Theater 01 begins with **real Wyoming at approximately 1:1 physical scale as its initial terrain substrate**.

The initial reference provides real-world:

* mountain ranges;
* basins;
* plains;
* valleys;
* river systems;
* elevation changes;
* regional proportions;
* continental distances.

This gives the prototype a credible geographic foundation without requiring the project to invent continental-scale terrain relationships from nothing.

The final world is not literal Wyoming.

Real geography can be extended, exaggerated, removed, flooded, reshaped, or replaced where useful.

Acceptable transformations include:

* extending mountain systems;
* enlarging forests;
* introducing new lakes;
* creating major river systems;
* adding wetlands;
* adding deserts;
* altering elevation;
* flooding basins;
* widening valleys;
* introducing a coastline or inland sea;
* transforming inland mountains into coastal systems;
* reshaping regional biomes.

Real-world climate and vegetation do not constrain the fictional world. A dry Wyoming basin may become a forest, wetland, lake, agricultural region, or another environment entirely.

The goal is **believable large-scale geography, not geographic fidelity**.

A useful secondary scale reference is Montana, while Yellowstone provides a useful reference for the size and complexity of individual major geographic regions.

---

## 5. Terrain Scale

Terrain is understood primarily at regional scale.

The strategic map is composed of features such as:

* mountain ranges;
* valleys;
* plateaus;
* river basins;
* forest belts;
* plains;
* deserts;
* wetlands;
* major passes;
* coastlines;
* lake systems.

These features may extend for tens or hundreds of kilometers.

A major forest can cover thousands of square kilometers. A mountain system can occupy an entire portion of the theater. A river can cross several strategic regions. A biome transition can occur over tens of kilometers.

Local terrain still matters when activity resolves to operational or tactical scale. Hills, ridges, riverbanks, forests, roads, structures, and other local features can affect movement, observation, and combat.

However:

> **Strategic geography is primary. Local terrain exists within it rather than replacing it.**

The renderer may present this geography as true 3D terrain derived from heightmaps, contour data, elevation data, or similar sources. Hillshading, textured relief, contour layers, limited perspective, and constrained camera tilt may coexist with terrain geometry where they improve geographic readability.

This does not change the map into a conventional 3D RTS battlefield. Units and structures may remain sprites, icons, billboards, clusters, or simple meshes, while infrastructure and simulated systems remain primarily line-, region-, flow-, or overlay-driven. Terrain receives geometry because its form is strategic information.

---

## 6. Biome Painting Philosophy

The first playable world favors deliberate biome painting over unnecessary procedural realism.

Project Signal does not require a geology or climate simulator to justify every biome.

Biomes are placed and blended according to combinations of:

* elevation;
* moisture;
* broad climate assumptions;
* water access;
* terrain;
* gameplay needs.

Transitions remain plausible rather than mechanically abrupt.

A broad progression may resemble:

```text
Alpine
    ↓
Montane Forest
    ↓
Foothills
    ↓
Open Woodland
    ↓
Grassland
```

The exact transitions depend on regional conditions.

Biome design prioritizes:

* readable regional identity;
* believable transition zones;
* strategic consequences;

over simulation for simulation's sake.

---

## 7. Core Biome Families

The initial world draws from a relatively broad set of biome families rather than an exhaustive ecological catalog.

### Alpine and High-Altitude Snow

High mountain environments create difficult movement, severe weather, limited infrastructure routes, specialized wildlife habitat, and seasonal access problems.

### Montane Forest

Mountain forests combine rugged terrain with heavy vegetation, concealment, biomass, and limited transportation corridors.

### Foothills

Foothills form transitional regions between major mountain systems and lower terrain. They create broken sightlines, irregular routes, ecological diversity, and natural approaches into mountain regions.

### Temperate Forest

Large forests provide biomass, wildlife habitat, concealment, sensor ambiguity, wildfire potential, and difficult infrastructure development.

### Grassland and Open Plains

Open regions support long-distance movement, infrastructure, large wildlife populations, agriculture, and long sightlines while exposing movement to observation.

### Dry Steppe and Desert

Dry regions contain less distributed biomass and water, making access to productive corridors and water sources disproportionately important.

### Wetlands

Wetlands combine high biological productivity with difficult surface movement, concealment, water access, and potential relationships with the subterranean system.

### River Corridors

River environments concentrate water, vegetation, wildlife, settlement, transportation infrastructure, and crossings.

### Lake Environments

Large lakes alter regional ecology, transportation, settlement, weather, and Plastai access.

### Coastal or Inland-Sea Environments

If retained in the final geography, large coastal environments introduce major aquatic geography and create a strong physical boundary unlike any existing Wyoming terrain.

These categories establish strategic identities rather than exhaustive ecological definitions.

---

## 8. Water Systems

Water is a major world system.

The map contains interconnected combinations of:

* rivers;
* lakes;
* wetlands;
* springs;
* drainage systems;
* aquifers;
* potentially a coastline or inland sea;
* seasonal and world-state-dependent water conditions.

Water influences:

* movement;
* ecology;
* Plastai access;
* aquifer emergence;
* resource distribution;
* weather effects;
* regional productivity;
* chokepoints;
* infrastructure;
* wildlife distribution;
* settlement.

Water is therefore never merely decorative map texture.

Surface water and subterranean water form related but distinct geographic systems.

---

## 9. Rivers

Rivers operate as regional geographic corridors.

Large rivers influence:

* settlement;
* agriculture;
* wildlife;
* migration;
* roads;
* rail;
* industrial development;
* bridges;
* military movement;
* Plastai activity.

Major rivers create meaningful crossing problems.

A bridge can therefore be strategically important without functioning as an artificial RTS chokepoint. Destroying, defending, replacing, or bypassing a crossing can alter movement across an entire region.

River floodplains can provide productive ecological and agricultural zones while also producing seasonal hazards.

Rivers can additionally serve as signal corridors. Wildlife movement, settlement activity, damaged crossings, ecological disturbance, and Plastai exploitation can all generate observable patterns along them.

Large rivers meaningfully alter strategic movement and settlement.

---

## 10. Lakes, Wetlands, and Springs

Lakes, wetlands, and springs are active components of regional ecology and strategy.

They can concentrate:

* wildlife;
* biomass;
* vegetation;
* water-dependent activity;
* settlement;
* Plastai interest.

Wetlands can provide concealment and biological productivity while making conventional Vanguard movement and infrastructure difficult.

Lakes may influence transportation, settlement patterns, weather, aquatic ecology, and strategic access.

Springs are particularly important because they provide visible surface expressions of underground water systems.

These features may provide:

* Plastai emergence opportunities;
* aquifer access;
* concealed activity;
* biomass-rich harvesting regions;
* ecological concentration;
* strategic observation points.

Their value and behavior can change with environmental conditions.

---

## 11. Mountain Systems

Mountains divide the world into meaningful regions.

They affect:

* movement;
* passes;
* altitude;
* weather;
* transportation routes;
* sensor lines;
* aviation;
* infrastructure cost;
* wildlife niches;
* concealment;
* strategic isolation.

Mountain ranges do not simply apply movement penalties.

They create distinct sides of the world.

A force positioned on one side of a major range may be geographically close to an event while still requiring a long journey through available passes.

Mountain weather can interfere with aviation and observation.

High terrain can provide valuable sensor positions while simultaneously requiring expensive logistics.

Passes naturally concentrate roads, rail, wildlife migration, reconnaissance, and military movement.

Mountains therefore create strategic regions rather than decorative obstacles.

---

## 12. Valleys and Basins

Valleys and basins naturally concentrate activity.

Depending on local conditions, they may concentrate:

* water;
* wildlife;
* industry;
* roads;
* rail;
* settlement;
* agriculture;
* airfields;
* Plastai biomass activity;
* weather;
* signals.

Large valleys can become natural operational theaters because several systems independently favor the same geography.

A productive valley may contain Vanguard infrastructure, wildlife migration, a river corridor, agricultural development, and nearby Plastai activity simultaneously.

Basins may instead become isolated ecological systems, drylands, lakes, wetlands, or concealed regions depending on world design and session conditions.

---

## 13. Plains and Open Terrain

Large open regions favor movement but increase exposure.

Plains influence:

* long-distance movement;
* detection;
* aviation;
* logistics;
* infrastructure;
* wildlife migration;
* exposure;
* large formations.

Roads, rail, airfields, pipelines, and other infrastructure are easier to establish across suitable open terrain.

However, movement across open ground is easier to observe.

Large organisms, vehicle formations, industrial activity, dust, migration, and other signals may become detectable at greater distances.

Open terrain is therefore not automatically "easy terrain."

Its openness provides both **mobility and visibility**.

---

## 14. Forests and Dense Vegetation

Forests are strategic environments rather than simple movement penalties.

They affect:

* concealment;
* movement;
* sensors;
* biomass;
* wildfire;
* ecological richness;
* infrastructure;
* signal ambiguity.

Dense vegetation can degrade observation and make activity difficult to interpret.

A large forest may contain wildlife migration, Plastai harvesting, environmental disturbance, Vanguard patrols, and unrelated natural activity simultaneously.

This creates ambiguity.

Forests also contain substantial biomass and wildlife populations, making them potentially valuable Plastai regions.

Infrastructure penetrating large forests represents a meaningful investment and may itself become strategically important.

---

## 15. Drylands and Deserts

Dry regions create a different strategic environment rather than simply functioning as poor terrain.

They may feature:

* sparse biomass;
* limited water;
* long exposed distances;
* difficult logistics;
* heat;
* wildfire;
* dust;
* concentrated activity around scarce water;
* distinct wildlife distributions.

Water corridors become disproportionately important.

Movement may be physically straightforward across some dry terrain while logistics become increasingly difficult.

Sparse vegetation can improve observation while reducing concealment.

Drylands therefore create different movement, ecology, sensing, and resource problems from forests or wetlands.

---

## 16. Subterranean Geography

The world contains a second major geographic system beneath the surface.

The Plastai nutrient and movement system is associated with underground aquifer geography.

This includes:

* aquifer systems;
* underground connectivity;
* springs;
* lakes;
* wetlands;
* underground routes;
* access points;
* emergence regions.

The subterranean network has its **own geography**.

It does not function as a hidden copy of the Vanguard road network.

Surface distance alone does not determine subterranean connectivity.

Two distant surface regions may be strongly linked underground.

Two nearby surface locations may have no useful aquifer connection at all.

This creates a fundamentally different spatial logic for Plastai strategic movement and nutrient distribution.

---

## 17. Aquifer Mapping

Aquifer structure is not entirely fixed player knowledge.

The physical world establishes plausible underground systems, but session conditions can alter their quality, accessibility, and strategic usefulness.

Players cannot rely entirely on rote memorization of a permanently optimal underground network.

Possible variability includes:

* connectivity;
* water availability;
* aquifer quality;
* usable access points;
* regional productivity.

Discovery is part of play.

The Plastai understand and interact with this geography differently from Vanguard.

Vanguard may detect:

* unusual spring activity;
* recurring emergence;
* environmental changes;
* biological concentrations;
* unexpected Plastai movement patterns;

without fully understanding the underground system responsible.

Aquifer discovery therefore directly supports the information loop:

> **Signal → Investigate → Confirm → Act → Assess**

---

## 18. Surface–Subsurface Interaction

Surface geography and subterranean geography remain connected.

Important interfaces include:

* springs;
* lakes;
* wetlands;
* sink regions;
* river valleys;
* emergence points;
* brood locations;
* nutrient flow.

A wetland may be strategically important not merely because of its surface ecology but because it connects to a productive aquifer.

A lake may provide both ecological resources and underground access.

A brood site may become valuable because surface biomass can enter an underground nutrient network from that location.

The surface and subsurface systems therefore create interacting geography rather than two unrelated map layers.

---

## 19. World State Variability

The map provides stable recognizable geography while session conditions alter how that geography behaves.

Broader Session Variability rules are defined in `VISION.md`.

Map-relevant variability includes conditions such as:

* wet versus dry world;
* snow severity;
* wildfire risk;
* vegetation density;
* wildlife abundance;
* water availability;
* aquifer quality;
* regional productivity.

The same valley may therefore behave differently between sessions.

A wet-world valley may contain abundant water, vegetation, wildlife, and productive aquifers.

The same geography under dry conditions may contain reduced water, increased wildfire danger, concentrated wildlife, and more strategically valuable permanent water sources.

Stable geography provides familiarity.

Variable world state prevents that familiarity from becoming complete strategic certainty.

---

## 20. Resource Distribution

Important resources do not occupy permanently memorized optimal coordinates.

Geography establishes **regional resource character**.

Exact resource density, quality, accessibility, and value can vary between sessions.

Resource distribution reflects relevant combinations of:

* ecology;
* terrain;
* water;
* geology where appropriate;
* regional productivity;
* session conditions.

A region may consistently be promising without guaranteeing a specific resource at a specific coordinate.

Players therefore benefit from geographic knowledge while still needing to explore and interpret each session.

The map rewards experience without producing solved openings.

---

## 21. Wildlife Distribution and Migration

The map supports persistent animal populations and large-scale movement.

Spatial wildlife systems depend on:

* habitat;
* water;
* seasonal conditions;
* migration corridors;
* mountain passes;
* plains;
* river valleys;
* regional productivity.

Migration can move substantial biological resources between regions.

A valley that is relatively unimportant during one season may become strategically significant when large wildlife populations enter it.

Mountain passes and river corridors can concentrate movement.

Open plains can support enormous migrations.

Weather, water availability, ecological pressure, and faction activity may alter these patterns.

The map therefore provides the spatial structure required by the ecology simulation without duplicating the ecology rules themselves.

---

## 22. Weather Geography

Weather operates across real geography rather than uniformly across the world.

The map exposes conditions that allow weather systems to interact with:

* elevation;
* mountain systems;
* valleys;
* basins;
* forests;
* grasslands;
* dry regions;
* water bodies;
* regional moisture.

Mountains can alter precipitation and snowfall.

High elevations can retain snow when lower terrain does not.

Basins may become dry.

Storms can move across multiple strategic regions.

Valleys may concentrate or trap weather effects.

Lightning can interact with vegetation and world dryness to create different wildfire risks.

The map does not define the complete weather simulation.

It provides the physical geography that allows weather to produce regional consequences.

---

## 23. Faction Interaction With Geography

Both factions inhabit the same world.

There is no separate "Vanguard terrain" and "Plastai terrain."

The factions instead assign different strategic meaning to the same geography.

### Vanguard

Vanguard geography emphasizes:

* roads;
* rail;
* airfields;
* bridges;
* open routes;
* line of sight;
* communications;
* logistical accessibility;
* industrial sites;
* defensible infrastructure.

### Plastai

Plastai geography emphasizes:

* aquifers;
* water;
* biomass;
* concealment;
* ecological productivity;
* emergence sites;
* brood locations;
* terrain suitable for different biological forms.

A wetland may be a transportation problem for Vanguard and an extremely valuable Plastai access region.

A highway across open plains may be an excellent Vanguard logistics route while simultaneously creating an exposed and predictable movement corridor.

Faction asymmetry emerges from different relationships with the same physical world.

---

## 24. Strategic Corridors

Strategic corridors emerge from geography and infrastructure.

Examples include:

* mountain passes;
* river crossings;
* valleys;
* rail corridors;
* road corridors;
* migration corridors;
* aquifer corridors.

These systems overlap imperfectly.

A Vanguard logistics corridor may cross a Plastai nutrient route.

A wildlife migration corridor may intersect both.

A river valley may simultaneously contain:

* a highway;
* rail;
* wildlife migration;
* agricultural development;
* surface water;
* aquifer access.

These intersections naturally create strategically important locations without requiring arbitrary capture points.

---

## 25. Chokepoints

The world contains chokepoints, but it is not structured as a collection of RTS lanes.

Chokepoints emerge naturally from:

* mountains;
* rivers;
* bridges;
* passes;
* wetlands;
* infrastructure;
* aquifer access.

Because the world is enormous, alternative routes often exist.

The strategic problem is therefore frequently:

> **Is the alternate route worth the additional distance, time, logistical burden, and risk?**

A destroyed bridge does not necessarily make movement impossible.

It may instead turn a 40 km journey into a 130 km journey.

A blocked mountain pass may require an entirely different regional route.

This makes chokepoints consequential without making them absolute.

---

## 26. Strategic Regions

The world contains recognizable regions with distinct strategic identities.

Regions emerge from combinations of:

* geography;
* resources;
* water;
* wildlife;
* infrastructure;
* aquifers;
* weather;
* access;
* faction activity.

A region can become strategically important without being explicitly labeled as an objective.

Its importance may also change during a session.

A previously quiet valley may become critical because wildlife migrates into it.

A new rail connection may transform an isolated industrial region.

A productive aquifer may make an otherwise unremarkable wetland strategically important to the Plastai.

Strategic regions emerge from interacting systems rather than predetermined capture zones.

---

## 27. Player Knowledge of the Map

Project Signal distinguishes between permanent geographic knowledge and current world-state knowledge.

### Permanent Geographic Knowledge

Players may reasonably know:

* mountain locations;
* major valleys;
* rivers;
* lakes;
* coastlines;
* general terrain;
* established infrastructure where appropriate.

Learning the physical geography is allowed and desirable.

### Session-Variable Knowledge

Players still need to discover:

* current wildlife distributions;
* resource concentrations;
* aquifer conditions;
* enemy activity;
* temporary weather effects;
* ecological changes;
* regional productivity changes.

### Faction-Specific Knowledge

The two factions perceive and understand geography differently.

A feature obvious and meaningful to one faction may be poorly understood by the other.

### Unknown World State

Even familiar geography can contain unknown current activity.

Knowing where a forest is does not reveal what is happening inside it.

This distinction prevents rote memorization from solving the game without making geographic knowledge meaningless.

---

## 28. Map Readability

A Wyoming-scale map must remain understandable.

The player must be able to reason about:

* distance;
* terrain;
* water;
* elevation;
* regions;
* infrastructure;
* signals;
* logistics.

The map therefore supports multiple visual and informational layers rather than attempting to display every system simultaneously.

Potential conceptual layers include:

* physical terrain;
* infrastructure;
* logistics;
* sensing;
* ecology;
* weather;
* faction-specific information;
* subsurface information.

The exact renderer and interface implementation remain unresolved.

The design requirement is simply that the player can move between regional understanding and local investigation without losing geographic context.

---

## 29. Map and Time

Map scale and time compression are inseparable.

Long-distance movement takes meaningful simulated time.

The world supports processes such as:

* travel;
* relocation;
* construction;
* migration;
* weather movement;
* ecological change;
* resource extraction;
* brood development.

These processes occur at scales appropriate to the world.

A force hundreds of kilometers away cannot respond immediately because the player has accelerated time.

Time compression changes how quickly the player experiences waiting.

It does not erase physical travel time.

A huge map only matters if movement and time respect its size.

---

## 30. Map and Power Projection

Geography limits both factions' ability to project power.

### Vanguard

Vanguard power projection depends on:

* aircraft range;
* artillery range;
* logistics;
* infrastructure;
* basing;
* transportation;
* communications;
* reconnaissance.

Airpower is powerful because it can affect the ground rapidly across substantial distances.

It is not omnipresent.

Aircraft committed to one region cannot simultaneously dominate every other region in a Wyoming-scale world.

Ground forces face even stronger travel constraints.

### Plastai

Plastai power projection depends on:

* aquifer connectivity;
* emergence locations;
* nutrient transport;
* biomass access;
* terrain suitability;
* brood positioning;
* available biological forms.

The aquifer system provides powerful strategic mobility but does not function as unrestricted teleportation.

Its usefulness depends on actual subterranean geography.

Neither faction can ignore geography.

---

## 31. Map and Deception

The scale and complexity of the world create physical space for deception.

Geography supports:

* hidden valleys;
* alternate routes;
* ambiguous migration;
* concealed brood preparation;
* infrastructure whose purpose is unclear;
* activity beyond likely sensor coverage;
* underground movement;
* false concentration in one region while preparing another.

A visible activity does not automatically reveal its purpose.

A Vanguard construction project may indicate military expansion, industrial development, transportation investment, or another objective.

A Plastai concentration may represent harvesting, migration, brood preparation, wildlife conflict, or preparation for an attack.

Large distances allow actions to occur outside direct observation.

The map therefore provides room for maneuver and uncertainty rather than forcing every meaningful action into visible lanes.

---

## 32. Map and Emergent Narrative

The map creates stories through systems interacting with geography.

Examples include:

* a previously unimportant valley becoming strategically vital because wildlife migrated into it;
* a new bridge changing an entire logistics network;
* a mountain storm temporarily eliminating Vanguard air support from a region;
* an apparently quiet wetland becoming a major Plastai emergence zone;
* a long rail extension revealing a major Vanguard strategic commitment;
* an aquifer connection allowing Plastai pressure to emerge somewhere unexpected;
* wildfire removing biomass that a Plastai brood had expected to exploit;
* flooding changing crossings and movement throughout a river basin;
* a remote Vanguard installation being attacked while meaningful reinforcements remain hours away.

These events are not scripted solely to produce narrative.

They emerge because persistent systems share the same geography.

---

## 33. What the Map Must Never Become

The Project Signal map is:

* **not** a compact RTS battlefield;
* **not** a collection of symmetrical lanes;
* **not** a handcrafted collection of permanently solved resource nodes;
* **not** a biome checkerboard;
* **not** a literal Wyoming simulator;
* **not** procedural noise for its own sake;
* **not** a terrain system where every location requires equal simulation fidelity;
* **not** a world where geography becomes irrelevant because units move instantly;
* **not** a world where airpower ignores distance;
* **not** a world where artillery casually covers the entire theater;
* **not** a world where Plastai aquifers ignore underground geography;
* **not** a world where every session uses identical resource placement;
* **not** a world whose only purpose is visual variety;
* **not** a collection of artificial capture zones pretending to be geography;
* **not** a world where every forest, mountain, river, or desert is reduced to a single movement modifier;
* **not** a tactical map artificially enlarged while retaining tactical-map proportions.

The map exists to create strategic relationships between **distance, geography, information, ecology, infrastructure, and time**.

---

## 34. Open Design Questions

The following map decisions remain unresolved.

### Final Coastline

It is not yet decided whether Prototype Theater 01 includes:

* an ocean coastline;
* a major inland sea;
* only large inland lakes;
* some combination of these.

### Final Wyoming Transformation

The exact amount of recognizable real Wyoming geography retained in the finished world remains open.

The 1:1 Wyoming substrate is established.

How aggressively individual regions are transformed is not.

### Exact Biome Boundaries

The major biome families are established conceptually, but their final geographic boundaries are not.

### Elevation Modification

Mountain systems may be extended or altered, but the exact degree of elevation modification or exaggeration remains open.

### Aquifer Representation

Aquifers are a major strategic geography with session-variable properties.

Their exact representation, resolution, discovery model, and visualization remain unresolved.

### Resource Generation

Resources vary within geographically appropriate regions.

The exact generation rules and degree of session variability remain unresolved.

### Major Water Features

The exact number, scale, and placement of major rivers, lakes, wetlands, and springs remain unresolved.

### Coordinate System

The game preserves real physical scale, but the exact internal map projection and coordinate implementation remain technical decisions for later development.

### Authored Versus Variable Geography

The first map is predominantly authored and uses Wyoming as its foundation.

The exact boundary between permanent authored geography and session-variable environmental state remains to be refined.

---

## 35. Map Design Test

Future map features should be evaluated against the following questions:

* Does this reinforce strategic distance?
* Does geography meaningfully affect both factions?
* Does this create meaningful logistics decisions?
* Does it support signals and incomplete information?
* Does it create natural corridors without becoming lane-based?
* Does it interact with ecology?
* Does it interact with weather?
* Does it support aquifers and meaningful surface/subsurface relationships?
* Does it create recognizable regional identity?
* Does it allow session variability without destroying geographic familiarity?
* Does it create opportunities for deception and maneuver?
* Does it affect power projection?
* Does physical distance remain meaningful?
* Can players understand why this region matters?
* Can the region's importance change because of simulation state?
* Does this feature create different implications for Vanguard and Plastai?
* Does the map still matter when viewed at strategic scale?

Most importantly:

> **Does this make geography part of the strategy rather than merely the place where strategy happens?**

If the answer is no, the feature does not justify its place in the Project Signal map.
