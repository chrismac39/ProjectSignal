# Project Signal — Renderer Vision

## 1. Purpose

The renderer exists to make Project Signal’s simulation legible.

Its primary purpose is not visual spectacle. It communicates a large, changing world in a form the player can understand, interrogate, and act upon.

The renderer must help the player understand:

* geography
* distance
* movement
* logistics
* weather
* ecology
* signals
* faction knowledge
* uncertainty
* infrastructure
* regional activity
* strategic commitments

The renderer explains the world without pretending the player has omniscient access to it.

Project Signal may simulate far more than any player can or should see at once. The renderer therefore acts as an interpretation layer between simulation state and player knowledge.

---

## 2. Core Renderer Philosophy

**The simulation comes first. The renderer explains the simulation.**

Project Signal is designed so that its core game works as a 2D strategic experience.

The renderer does not determine what exists, what moves, what consumes resources, what is detected, or what happens during combat. Those systems belong to the simulation.

The renderer presents the consequences of those systems.

The design must resist pressure to reshape the simulation around:

* close-up tactical spectacle
* detailed 3D unit animation
* cinematic camera systems
* expensive bespoke assets
* individually rendering everything that exists
* visual complexity that obscures strategic information

A richer 3D presentation could theoretically exist in the future, but Project Signal must never depend on it.

The game must first succeed as an interactive strategic map representing a real simulation.

---

## 3. 2D First

**The initial renderer is 2D.**

This is a hard design rule.

2D is not a temporary placeholder for the real game. It is sufficient to express the game's primary interaction model.

The core player experience consists of:

* reading a massive map
* interpreting signals
* observing movement
* understanding logistics
* tracking changing world state
* managing incomplete knowledge
* making strategic commitments across distance and time

None of these require a three-dimensional tactical battlefield.

A 2D renderer must therefore be treated as a first-class presentation model rather than as a prototype limitation.

---

## 4. Strategic Scale

Project Signal operates across a theater approximately comparable in scale to Wyoming.

The renderer must continually reinforce that scale.

It must avoid conventions that make:

* 100 km feel like a short walk
* aircraft appear to cross the theater instantly
* mountain systems resemble decorative terrain bumps
* major rivers feel like minor map details
* infrastructure appear as isolated base props
* distant operations feel locally adjacent

Distance has strategic meaning.

Moving forces, transporting resources, projecting airpower, maintaining communications, supplying infrastructure, following migrations, responding to weather, and interpreting stale intelligence all depend on geographic separation.

The renderer must preserve this relationship between geography, distance, and time.

---

## 5. Map as Primary Interface

The world map is Project Signal's primary interaction surface.

The player spends most of the game understanding:

* regions
* corridors
* terrain
* infrastructure
* movement
* signals
* changing environmental state
* areas of uncertainty
* areas of strategic commitment

The map is not scenery beneath a conventional RTS interface.

It is the interface.

Important game state should therefore be spatial whenever practical.

When something matters because of where it is, the player should usually be able to understand it by looking at the relevant geography rather than by opening a detached statistics screen.

Panels, inspectors, timelines, alerts, and menus support the map.

They do not replace it.

---

## 6. Simulation State Versus Render State

Visual representation is not identical to simulation state.

The renderer may:

* aggregate
* simplify
* interpolate
* symbolize
* cluster
* hide detail
* exaggerate strategically important state

without changing what the simulation actually contains.

A simulated herd containing thousands of animals may appear as one strategic symbol.

A convoy containing many vehicles may appear as one moving logistics element.

A large Plastai concentration may appear as an uncertain activity region rather than as thousands of individual organisms.

An air operation may appear as a route, mission state, and aircraft group rather than every aircraft being independently represented at every zoom level.

This abstraction is expected.

The simulation determines truth.

The renderer determines the useful representation of truth or, during normal play, the useful representation of what the player's faction currently believes to be true.

---

## 7. Multiple Levels of Detail

The same world is presented differently at different scales.

At the widest theater scale, the player should primarily see:

* major geography
* large weather systems
* strategic regions
* major infrastructure networks
* broad movement
* major signals
* large ecological changes
* significant operational commitments

At intermediate scale, the player may see:

* movement corridors
* logistics routes
* regional infrastructure
* migration activity
* patrols
* sensor coverage
* communications coverage
* regional contacts
* local weather effects

At closer scale, the player may see:

* individual strategically relevant entities
* specific facilities
* detailed local terrain
* individual routes
* combat relationships
* detailed signal sources
* local infrastructure relationships

Exact zoom thresholds remain an implementation question.

---

## 8. Semantic Zoom

**Zoom changes information, not merely size.**

This is a core design principle.

Zooming inward should reveal different representations of the same underlying simulation.

Zooming outward should aggregate those representations into strategically useful higher-level information.

Examples include:

* individual wildlife groups becoming herd movement
* individual convoy vehicles becoming one logistics movement
* local rainfall becoming part of a regional weather system
* many detected contacts becoming one activity concentration
* road segments becoming a transportation corridor
* individual Plastai groups becoming regional biological activity
* several tactical engagements becoming one contested area

The renderer should display the abstraction appropriate to the current strategic scale.

Zoom must therefore behave more like changing analytical resolution than magnifying a photograph.

---

## 9. Terrain Presentation

Terrain must communicate strategic geography quickly.

The player should be able to distinguish:

* elevation
* mountain systems
* valleys
* plains
* forests
* wetlands
* deserts
* rivers
* lakes
* coastlines where present

The map should communicate broad physical structure before fine detail.

A player looking at a region should be able to understand why movement, settlement, logistics, ecology, detection, or combat might behave differently there.

Terrain must remain visually coherent even when additional strategic overlays are active.

---

## 10. Biome Presentation

Biomes should be visually distinct while remaining part of a continuous physical world.

Avoid:

* sharp checkerboard biome boundaries
* excessive saturation
* tile-like visual fragmentation
* arbitrary color changes disconnected from geography
* map presentation resembling a board-game grid unless an explicit overlay is active

Biome transitions should follow the logic established by the world simulation and map design.

Forests, alpine terrain, plains, wetlands, desert regions, and other environments should visually flow into one another rather than appearing as discrete painted game zones.

---

## 11. Elevation

Elevation must be strategically readable.

Possible presentation techniques include:

* shading
* contour lines
* relief
* subtle elevation coloring
* hillshading

No specific method is mandated yet.

Whatever method is chosen must clearly communicate:

* mountain barriers
* mountain passes
* valleys
* basins
* elevated plateaus
* high terrain

Elevation exists to explain geography and strategy, not merely to increase visual realism.

---

## 12. Water

Water must remain immediately legible.

This includes:

* rivers
* lakes
* wetlands
* springs
* coastlines where applicable

Water affects:

* movement
* logistics
* ecology
* Plastai activity
* aquifer relationships
* weather
* resource distribution

It must therefore never disappear into decorative terrain texture.

Water features should remain identifiable even when strategic overlays are active.

---

## 13. Surface and Subsurface Layers

Project Signal contains strategically meaningful surface and subsurface geography.

The renderer must eventually support visualization of:

* surface terrain
* hydrology
* underground aquifer structure

The aquifer layer does not automatically reveal complete underground truth.

What is visible depends upon faction knowledge.

Plastai may possess direct biological understanding of much of their nutrient network and aquifer access.

Vanguard understanding may instead consist of:

* surveyed information
* inferred structures
* probable connections
* detected activity
* uncertain subsurface regions

The same physical world can therefore produce different visual representations for each faction.

---

## 14. World Reality Versus Player View

**The renderer displays faction knowledge, not World Reality.**

This is a hard rule.

World Reality may contain the exact current state of every simulated object.

Normal gameplay does not.

If Vanguard last observed a suspected Plastai concentration in a valley three hours ago, the renderer presents that observation and its declining reliability.

It does not silently track the true current position.

The renderer must never leak World Reality through:

* hidden animation
* unexplained icon movement
* terrain effects visible without observation
* hidden activity indicators
* camera behavior
* automatic tracking
* overlays
* alerts

Information restrictions established by the signals system apply equally to presentation.

---

## 15. Uncertainty Visualization

Uncertainty must be visually understandable.

The renderer should make meaningful distinctions between information that is:

* confirmed
* likely
* uncertain
* stale

Possible techniques include:

* opacity
* blurred regions
* uncertain-position areas
* confidence bands
* dashed outlines
* approximate symbols
* timestamps
* fading
* classification labels
* incomplete shapes or boundaries

The final visual language remains unresolved.

However, uncertainty cannot depend entirely upon tiny text, percentages, or hidden tooltips.

The player should be able to glance at the map and recognize that one piece of information is less reliable than another.

---

## 16. Information Age Visualization

Old intelligence must not look equally authoritative as current observation.

Possible representations include:

* fading
* timestamps
* ghosted positions
* historical trails
* last-known markers
* age indicators
* expanding uncertainty regions

A contact seen thirty seconds ago and a contact seen six hours ago should not communicate the same certainty.

Information age is part of the strategic state.

The renderer must treat it accordingly.

---

## 17. Signal Visualization

Signals represent evidence.

They do not necessarily represent interpretation.

Signals may include evidence of:

* movement
* heat
* radio activity
* ecological disturbance
* construction
* transportation
* fires
* atmospheric anomalies
* water disturbance
* unknown biological activity

The renderer should communicate what was detected without automatically telling the player what caused it.

A movement signal should not automatically become an enemy unit icon.

A biological disturbance should not automatically become a confirmed brood site.

The distinction between evidence and interpretation is fundamental to Project Signal.

---

## 18. Contact Representation

Contacts may exist at several information states.

A contact might be:

* unknown activity
* probable category
* known faction
* identified type
* fully confirmed entity

The renderer should support visible progression through these states.

Identification should feel like information being acquired rather than icons simply becoming more detailed because the camera moved closer.

The exact icon taxonomy remains unresolved.

---

## 19. Player Annotation

Players should be able to annotate their interpretation of the world.

Possible annotations include:

* suspected brood site
* possible logistics route
* likely migration corridor
* danger zone
* planned reconnaissance area
* suspected airfield
* uncertain aquifer connection
* personal note
* expected enemy movement
* region requiring observation

Annotations belong to the player's interpretation layer.

They are not simulation truth.

The game should never silently validate a player's annotation merely because the player placed it.

---

## 20. Overlays

Project Signal should use optional overlays to expose complex systems without displaying everything simultaneously.

Potential overlays include:

* terrain
* elevation
* weather
* logistics
* roads
* rail
* aviation coverage
* sensor coverage
* communications
* migration
* ecology
* biomass
* water
* aquifers
* faction knowledge
* signals
* industrial activity
* combat ranges

Useful overlays may be composed together.

The player should not need to constantly cycle through dozens of obscure map modes just to understand normal gameplay.

---

## 21. Overlay Philosophy

**Every overlay should answer a strategic question.**

Examples include:

* Where can I currently project airpower?
* Where is my communications coverage weak?
* Which regions are biologically productive?
* Where is weather disrupting operations?
* Which intelligence is becoming stale?
* Where can nutrients currently move?
* Which transportation corridors are overloaded?
* What areas are currently observable?

An overlay does not deserve to exist merely because the simulation contains a variable.

If a visualization does not help the player make or understand a decision, it should probably remain a debug tool rather than a player-facing overlay.

---

## 22. Layer Priority

Not every visual layer deserves equal persistence.

Some information should remain visible across most relevant views, including:

* major geography
* critical alerts
* selected units or regions
* primary infrastructure
* active threats
* important player plans

Other information should appear only when requested or contextually relevant.

The renderer should aggressively resist visual overload.

Strategic relevance determines presentation priority.

---

## 23. Faction-Specific Presentation

Vanguard and Plastai observe the same physical world through different strategic priorities.

Vanguard presentation may emphasize:

* infrastructure
* sensors
* communications
* air coverage
* logistics
* industrial operations
* transportation
* technical contact classification

Plastai presentation may emphasize:

* aquifers
* biomass
* ecological productivity
* brood state
* nutrient flow
* developmental potential
* biological sensing
* environmental opportunity

The underlying world remains shared.

Faction-specific presentation should reinforce asymmetry by emphasizing different relationships with that world rather than creating two unrelated interface paradigms.

---

## 24. Vanguard Visual Language

Vanguard presentation should feel:

* technical
* networked
* operational
* structured
* telemetry-oriented

The interface should make human industrial systems easy to understand.

Networks, corridors, range, communications, industrial capacity, mission status, and infrastructure relationships should feel central.

This does not mandate a specific final art style.

---

## 25. Plastai Visual Language

Plastai presentation should feel:

* biological
* flowing
* ecological
* organic
* interconnected through living systems

Nutrient movement, biomass, brood potential, aquifers, phenotype distribution, and ecological state should feel natural to the faction.

The interface must not become unreadable merely to appear alien.

Strategic information remains the priority.

---

## 26. Movement Visualization

Movement must communicate both distance and intent.

Possible techniques include:

* route lines
* directional indicators
* estimated arrival
* movement corridors
* moving strategic symbols
* trails
* path previews

The player should understand:

* where something is going
* roughly when it will arrive
* what route it is taking
* what terrain or infrastructure it depends upon

Movement across a massive world must not appear instantaneous.

Distance must remain visible through time.

---

## 27. Logistics Visualization

Major logistical relationships must be visible.

Potential representations include:

* active routes
* throughput
* bottlenecks
* supply hubs
* rail corridors
* convoy movement
* airlift
* nutrient flow

The renderer should favor strategic aggregation over literal shipment visualization.

If hundreds of individual movements collectively represent one stable logistics route, the player should be able to understand that route without watching hundreds of separate icons.

---

## 28. Infrastructure Visualization

Infrastructure should visibly reshape the map.

Examples include:

* roads
* rail
* bridges
* airfields
* refineries
* depots
* communication sites
* brood sites
* aquifer entrances

Infrastructure represents long-term strategic commitment.

A heavily developed Vanguard corridor should visibly look different from an undeveloped region.

Likewise, sustained Plastai investment should create recognizable biological presence.

The map should accumulate the consequences of player investment.

---

## 29. Weather Visualization

Weather must be readable at strategic scale.

Potential visual elements include:

* storm fronts
* precipitation regions
* snow
* fog
* smoke
* wildfire
* flooding
* lightning activity

Weather should communicate operational consequences without obscuring the rest of the interface.

A dramatic storm may be visually impressive, but the player still needs to see:

* infrastructure
* routes
* units
* signals
* geography
* relevant operational state

Clarity takes precedence over cinematic realism.

---

## 30. Ecology Visualization

Ecological systems may be represented through:

* herd symbols
* migration flows
* predator territories
* biomass concentrations
* disturbed regions
* ecological activity
* changing habitat conditions

The renderer does not need to draw every simulated organism.

At strategic scale, ecological patterns matter more than individual animation.

Large ecological events should remain visually important because ecology is part of the strategic world rather than decorative ambience.

---

## 31. Migration Visualization

Migration must appear as movement through real geography.

At broad scale, migration may appear as:

* moving population concentrations
* directional flows
* corridor activity
* changing regional density

At closer scales, individual groups may become visible.

Migration should make the world feel alive while remaining readable.

It should also allow players to notice changes such as:

* a migration avoiding industrial activity
* populations concentrating around water
* movement responding to weather
* ecological disturbance caused by Plastai harvesting
* wildlife being displaced by combat

---

## 32. Combat Visualization

Combat presentation prioritizes:

* what is happening
* where firepower originates
* what enables it
* what is being damaged
* what the player currently knows

over elaborate animation.

Combat may still be visually satisfying.

Explosions, impacts, fires, bio-weapons, artillery, aircraft activity, and large biological events can provide spectacle.

However, spectacle must communicate strategic cause and effect.

The player should understand why something happened.

---

## 33. Long-Range Fire Visualization

Artillery, missiles, airstrikes, and similar systems must communicate geographic relationships.

The player should understand:

* where the attack originated
* what systems enabled the attack
* what range constraints applied
* what target was engaged
* why the target was vulnerable
* what information supported the strike

Long-range fire should not feel like unexplained damage appearing somewhere on the map.

Its relationship to reconnaissance, logistics, basing, range, and support should remain visible.

---

## 34. Aviation Visualization

Aircraft must remain physical participants in the world.

The renderer should communicate:

* basing
* mission routes
* operational range
* coverage
* current location where appropriate
* travel
* sortie availability
* weather limitations

Aircraft should not become abstract global abilities.

A bomber attacking a distant target implies a base, travel time, range, support infrastructure, and operational commitment.

The map should communicate those relationships.

---

## 35. Plastai Emergence Visualization

Major Plastai emergence may be dramatic.

However, the final event should feel connected to earlier simulation state.

The renderer should support prior clues such as:

* indirect biological signals
* local ecological changes
* unusual movement
* terrain disturbance
* aquifer activity where known
* surface preparation
* growing uncertainty

The reveal should feel like the culmination of something that existed in the world rather than a scripted enemy spawn.

---

## 36. Scale of Entities

Visual scale does not equal physical scale.

Strategically important entities may require symbolic exaggeration.

A:

* train
* aircraft
* herd
* convoy
* brood
* Titan
* refinery
* signal source

may appear significantly larger than its literal map-scale dimensions.

This is acceptable.

The player should not need to zoom to microscopic scale to discover strategically significant objects.

---

## 37. Icons and Symbols

Icons should communicate important state quickly.

They may communicate:

* entity type
* faction
* activity
* information confidence
* current state
* strategic importance

The system should favor fast recognition over excessive symbolic complexity.

Project Signal should not automatically become a dense military symbology simulator.

If more elaborate symbology proves useful, it can emerge through playtesting.

---

## 38. Animation

Animation exists to communicate state change.

Useful animation may represent:

* movement
* construction
* material or nutrient flow
* weather
* fire
* combat
* emergence
* infrastructure activity
* changing detection
* environmental transformation

Animation that communicates nothing should be questioned.

Constant motion across the entire interface would make meaningful motion harder to notice.

---

## 39. Color

Color should communicate intentionally.

Possible uses include:

* faction
* state
* warning
* environment
* confidence
* overlay values
* selection
* information age

The same colors should not accumulate many contradictory meanings.

Terrain must remain readable beneath analytical overlays.

No final palette is established here.

---

## 40. Selection and Focus

Players may need to select:

* units
* facilities
* regions
* signals
* routes
* herds
* infrastructure projects
* strategic groups

Selection should expose relevant context while preserving the map.

The interface should resist replacing the world with giant property panels every time something is selected.

The spatial relationship remains important even while examining detailed information.

---

## 41. Regions as Interaction Targets

The map is too large for every interaction to depend on individual objects.

Players should often interact with:

* regions
* corridors
* networks
* groups

rather than isolated entities.

Examples may include:

* assigning reconnaissance to a valley
* defining an infrastructure corridor
* increasing patrol activity across a region
* observing a migration zone
* planning activity around an aquifer system
* establishing broad logistical intent

Strategic-scale selection is a core requirement.

---

## 42. Routes and Plans

Planned actions should be visible before execution where useful.

Examples include:

* movement routes
* construction corridors
* planned rail
* reconnaissance paths
* air missions
* anticipated logistics routes
* planned concentration areas

The map should communicate intended future state as well as current state.

This is especially important in a game where decisions may take substantial simulated time to execute.

---

## 43. Timeline Integration

Spatial and temporal information should reinforce one another.

The renderer should communicate:

* current simulated time
* estimated arrival
* construction completion
* intelligence age
* forecasts
* project progress
* maturation where relevant
* expected operational windows

A route is not merely a line.

It is a line plus travel time.

A construction site is not merely a location.

It is a location plus progress.

A contact is not merely a marker.

It is a marker plus observation history.

---

## 44. Time Compression Feedback

The player must always understand:

* current simulation speed
* whether simulation is paused
* why time slowed
* why time stopped
* what event triggered attention

A player moving rapidly through hours or days of simulation must never suddenly discover that time changed for mysterious reasons.

Automatic slow or pause behavior exists to focus attention.

The renderer must clearly identify the event responsible.

---

## 45. Alerts

Alerts should direct attention toward strategically meaningful map state.

A useful alert generally:

* identifies a region
* explains what was observed
* preserves uncertainty
* allows immediate focus
* avoids revealing information the faction does not possess

Alerts should help manage a continent-scale simulation without turning into an omniscient event feed.

---

## 46. Event History

Players should be able to inspect significant historical state.

Potential presentations include:

* map history
* event timelines
* signal history
* previous positions
* replay snapshots
* prior infrastructure state
* changing intelligence

Historical visibility allows players to understand patterns rather than treating every observation as isolated.

Exact implementation remains unresolved.

---

## 47. Replay

Replay is a natural extension of the simulation-driven renderer.

A replay system may show:

* world development
* movement
* changing signals
* changing faction knowledge
* infrastructure growth
* ecological changes
* weather events
* combat
* major emergence events

A post-game omniscient mode may eventually allow players to compare their beliefs against actual World Reality.

Active gameplay remains knowledge-limited.

---

## 48. Information Density

Project Signal may simulate vastly more state than can usefully appear on screen.

The renderer must rely upon:

* aggregation
* prioritization
* filtering
* semantic zoom
* overlays
* clustering
* contextual visibility

Rendering more data is not automatically better.

The renderer succeeds when the player sees the information needed to understand the current strategic situation.

---

## 49. Visual Clutter

Avoid:

* labels on everything
* hundreds of overlapping icons
* permanent range circles
* every route visible simultaneously
* every animal represented individually
* every sensor ping displayed independently
* constant animation everywhere
* every simulation variable being given its own map layer

Complexity belongs in the simulation.

The renderer must make that complexity understandable rather than reproducing it literally.

---

## 50. Labels

Labels should be contextual.

Likely candidates include:

* major regions
* important facilities
* selected entities
* player annotations
* high-priority contacts
* major infrastructure
* geographic landmarks

Minor entities should not all be permanently labeled.

Label density should adapt to zoom and context.

---

## 51. Strategic Readability Before Beauty

**When realism conflicts with strategic readability, readability wins.**

Examples include:

* exaggerating roads so they remain visible
* enlarging strategically important symbols
* simplifying forest texture
* emphasizing rivers
* abstracting physical unit size
* reducing weather opacity
* exaggerating infrastructure boundaries
* simplifying movement into readable flows

Project Signal should still pursue a coherent and attractive visual identity.

But visual realism cannot be allowed to hide strategically important information.

---

## 52. The Renderer Should Show Consequences

The world should visibly change when systems change.

Examples include:

* infrastructure appearing
* road systems expanding
* rail networks extending
* forests burning
* snow accumulating
* wetlands expanding
* bridges being destroyed
* migration changing
* regions becoming depleted
* brood sites developing
* battle damage remaining
* ecological activity shifting

The map should not feel like a static background on which icons move.

It should accumulate the history of the campaign.

---

## 53. Persistent World Damage

Where appropriate, consequences should remain visible.

Examples include:

* destroyed infrastructure
* burned regions
* damaged terrain
* abandoned sites
* damaged bridges
* battlefield scars
* ecological depletion

Persistence reinforces the idea that campaigns create history.

The player should be able to look at a region late in a campaign and recognize what has happened there.

---

## 54. Strategic Presence

The player should feel that each faction has **presence in the world**.

Vanguard presence is expressed through:

* corridors
* roads
* rail
* airfields
* sensors
* industrial sites
* communications
* logistics activity

Plastai presence is expressed through:

* brood sites
* aquifer access
* ecological activity
* nutrient networks
* phenotype concentrations
* biological alteration
* altered patterns of wildlife and biomass

Presence emerges from strategic systems.

It should not depend upon filling the map with decorative base structures.

---

## 55. Infrastructure Placement Scale

Construction should operate at geographic scale.

The Vanguard player may define or place:

* logistics spokes
* facilities
* routes
* regional infrastructure
* transportation corridors

without turning the game into:

> Move this building two tiles left.

The player should express strategic intent.

Exact placement may matter where geography genuinely matters, but placement precision should not become a dominant mechanical challenge.

---

## 56. No Tile Obsession

The implementation may internally use:

* grids
* chunks
* cells
* coordinates
* spatial partitions

The player does not need to experience the world as a collection of tiles.

Project Signal operates at geographic scale.

A grid may exist as an analytical or debug representation, but ordinary terrain should feel continuous.

Tile-perfect placement should not become the core interaction model.

---

## 57. World Coordinates

Project Signal requires a coherent spatial world.

Distances should have consistent meaning.

The coordinate model supports:

* movement
* range
* logistics
* weather
* signals
* map scale
* travel time
* strategic geography

No exact coordinate system, projection, or internal unit is mandated by this document.

The design requirement is consistent spatial relationships.

---

## 58. Smooth Versus Discrete Representation

The simulation may internally divide space into:

* regions
* grids
* cells
* chunks
* graph nodes

while the renderer presents continuous geography.

Simulation discretization should not automatically dictate visual form.

A weather cell does not need to look like a square.

A biomass region does not need to expose its computational boundary.

An aquifer graph does not need to appear as a literal node graph unless that is strategically useful.

---

## 59. Debug Visualization

Development builds should support explicit diagnostic layers.

Potential debug views include:

* World Reality
* Vanguard Knowledge
* Plastai Knowledge
* aquifer structure
* simulation regions
* migration paths
* weather state
* logistics state
* resource distributions
* entity movement
* signal generation

Debug visuals may be ugly, literal, highly technical, and information-dense.

They should remain distinct from final player-facing presentation.

---

## 60. Omniscient Development View

The renderer should eventually provide a developer-only omniscient mode.

It may expose:

* actual entity state
* Vanguard knowledge
* Plastai knowledge
* hidden movement
* generated signals
* detection relationships
* world systems
* resource state
* simulation boundaries

This is essential for validating whether the simulation behaves correctly.

A developer must be able to compare:

**what actually happened**

against:

**what each faction was capable of knowing.**

Omniscient information must never accidentally leak into normal gameplay.

---

## 61. Renderer Independence

Simulation logic should remain independent from the renderer.

The game should be capable of:

* running simulation without drawing every entity
* running simulation without rendering at all
* changing visual representations
* aggregating differently by zoom
* supporting alternate debug views
* potentially replacing rendering technology later

without altering core simulation rules.

The renderer consumes simulation state.

The simulation does not exist to feed sprites.

This separation protects Project Signal from future presentation changes and prevents visual implementation decisions from distorting the underlying game.

---

## 62. Prototype Renderer Scope

The first renderer does not need:

* high-end art
* sophisticated animation
* detailed units
* cinematic effects
* 3D terrain
* photorealistic environments
* elaborate combat spectacle

It needs to show:

* the world map
* terrain
* entities or aggregated groups
* movement
* simulation time
* signals
* faction knowledge
* a small set of useful overlays
* changing world state

The first renderer succeeds when the simulation becomes understandable.

An ugly but legible simulation viewer is more valuable than an attractive renderer attached to shallow systems.

---

## 63. Engine Agnosticism

This document does not mandate:

* PixiJS
* Godot
* Unity
* Unreal
* WebGPU
* a custom engine
* any other specific rendering technology

Those are architecture decisions.

The design requirement is a performant 2D strategic renderer capable of representing the necessary world, information layers, interaction model, and semantic zoom.

Technology serves the renderer doctrine.

It does not define it.

---

## 64. Performance Philosophy

The renderer must represent a massive simulated world without attempting to draw every simulated object individually at all times.

Aggregation and level-of-detail are therefore fundamental requirements rather than optional optimizations.

A simulation containing thousands or potentially much larger numbers of objects does not imply thousands of independently rendered entities at theater scale.

Presentation load should depend on what must currently be communicated.

The exact technical performance budget remains unresolved.

---

## 65. Emergent Narrative Through Presentation

The renderer should make systemic history visible.

Examples include:

* watching rail infrastructure gradually extend across the map
* seeing a migration bend around a growing industrial corridor
* noticing a weather system approaching an airfield
* watching old intelligence fade while new signals emerge elsewhere
* observing a quiet region suddenly erupt into Plastai activity
* seeing wildfire reshape an entire valley
* watching infrastructure slowly transform previously empty geography
* observing weeks of logistical buildup culminate in a concentrated offensive
* watching ecological systems recover or collapse after disruption
* realizing that apparently unrelated signals formed a larger pattern

These are not scripted cinematic moments.

They are stories produced by the simulation and made understandable by the renderer.

---

## 66. What the Renderer Must Never Become

The renderer must not become:

* dependent on 3D
* primarily a close-up tactical battlefield viewer
* visual spectacle at the expense of information
* a giant wall of icons
* a literal rendering of every simulated entity
* a tile-placement puzzle
* a system that leaks omniscient information
* a static background map
* a system where zoom merely changes icon size
* dozens of mandatory map modes
* overlays that expose information the faction does not possess
* a renderer so tightly coupled to simulation that representation changes gameplay rules
* an interface requiring constant manual panning to discover critical events
* a system treating all simulated state as equally important
* a game whose strategic scale disappears when zooming inward
* an animation showcase where movement lacks informational meaning
* an interface where uncertainty exists mathematically but is visually invisible
* a map where terrain is aesthetically attractive but strategically unreadable
* a collection of disconnected HUD panels that make the map secondary
* a simulation forced to model only what can conveniently be animated
* an engine-development project disguised as game development

Project Signal is not defined by rendering technology.

The world simulation, information model, and strategic decisions remain primary.

---

## 67. Open Design Questions

The following renderer questions remain unresolved:

* exact renderer technology
* PixiJS versus another 2D solution
* exact art style
* exact camera behavior
* exact minimum and maximum zoom
* exact terrain rendering technique
* exact unit and icon style
* exact surface-to-subsurface transition
* exact overlay interface
* exact label-density rules
* exact animation scope
* exact representation of extremely large battles
* whether the closest zoom ever becomes semi-tactical
* exact replay presentation
* exact degree of faction-specific interface differentiation
* exact uncertainty visual language
* exact method for rendering continuous geography from discrete simulation structures
* exact interaction between region selection and individual entity selection

These are implementation and presentation questions.

They do not reopen the established principles that:

* the game is simulation-first
* the map is the primary interface
* the initial renderer is 2D
* strategic readability takes precedence
* faction knowledge limits what the renderer may reveal
* semantic zoom changes representation
* rendering remains separate from simulation state

---

## 68. Renderer Design Test

Any future renderer feature should be tested against the following questions:

* Does this make the simulation easier to understand?
* Does it preserve strategic scale?
* Does it show faction knowledge rather than omniscient truth?
* Does it communicate uncertainty?
* Does semantic zoom change the appropriate level of abstraction?
* Does it avoid unnecessary visual clutter?
* Does geography remain readable?
* Does movement communicate distance and time?
* Does infrastructure visibly create faction presence?
* Can major logistics relationships be understood?
* Can weather and ecology be read without overwhelming the map?
* Does it reinforce meaningful faction asymmetry?
* Can the same simulation state be represented differently at different scales?
* Does this work without requiring 3D?
* Does this expose useful strategic information rather than merely another simulation variable?
* Does it preserve the distinction between evidence and interpretation?
* Does it help the player understand consequences?
* Does it make the evolving history of the world visible?
* Is the simulation still independent from this representation?
* Is this solving a strategic readability problem or merely adding visual complexity?

The final test is simpler:

**The renderer does not create the world. It makes the world understandable.**
