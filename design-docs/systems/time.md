# Project Signal — Time, Time Compression, and Command Attention

## 1. Purpose

Time in Project Signal must support radically different scales of activity within one continuous world.

The game needs to represent:

* seconds and minutes during combat
* minutes and hours during reconnaissance
* hours during movement and logistics
* days during construction and expansion
* days or weeks during biological development
* potentially weeks or months across the full campaign

These scales should not be separated into disconnected tactical and strategic games.

The central rule is:

> **Project Signal is one continuous simulation. The player controls the temporal resolution at which they experience and command it.**

---

## 2. Core Time Model

**Status: Established design principle**

Project Signal uses a **continuous-time, tick-based simulation with pause and variable time compression**.

The simulation may internally resolve activity through deterministic ticks, but those ticks are an implementation detail.

The player does not primarily experience:

> Turn 43
> Turn 44
> Turn 45

The player experiences:

> Day 12 — 14:37

The world continues to exist and change according to simulated time.

Movement, sensing, communications, logistics, construction, weather, ecology, harvesting, biological development, combat, and other systems all operate against the same underlying campaign clock.

There is no separate tactical clock and strategic clock.

---

## 3. Why Project Signal Is Not Conventionally Turn-Based

**Status: Established design decision**

Conventional turns were considered because they simplify command and simulation.

They were rejected as the primary player-facing time model.

A conventional structure such as:

> inspect world → analyze every signal → issue all orders → end turn

creates several problems.

It gives the player effectively unlimited opportunity to exhaustively analyze every available signal before anything changes.

This weakens the intended uncertainty and interpretation problem.

It also forces systems operating on radically different temporal scales into the same arbitrary turn duration.

A firefight may require decisions within seconds.

A reconnaissance patrol may operate for hours.

A refinery may require days to establish.

A Plastai developmental commitment may take considerably longer.

One universal player-facing turn length cannot represent all of these naturally.

Project Signal therefore retains the advantages of deterministic simulation ticks without requiring conventional gameplay turns.

---

## 4. Time Compression

**Status: Core system**

The player can control simulation speed.

Exact speed multipliers remain an implementation and playtesting question.

Conceptually, the available range must support:

* pause
* near-real-time tactical operation
* accelerated tactical time
* operational time
* strategic time
* very high compression during quiet periods

For example, the eventual interface might expose speeds conceptually equivalent to:

> Pause → 1× → 5× → 20× → 100×

These values are illustrative rather than final.

The important rule is:

> **Changing time compression does not change the simulation. It only changes how quickly simulated time passes for the player.**

A convoy requiring four simulated hours still requires four simulated hours.

A brood requiring three simulated days to develop still requires three simulated days.

A weapon requiring several seconds to engage still requires those seconds.

The same physical world operates at every compression level.

---

## 5. Natural Command Tempo

**Status: Core gameplay principle**

The intended temporal rhythm is:

> **Strategic compression → weak signals → emerging pattern → increased attention → commitment → tactical climax → consequences → recovery → strategic compression**

During quiet periods, the player may operate at very high compression.

During this time:

* infrastructure develops
* resources are extracted
* logistics networks operate
* convoys travel
* wildlife migrates
* ecological systems change
* Plastai gather biomass
* nutrients move through aquifer networks
* nymphs develop
* patrols conduct routine operations
* reconnaissance continues
* weather develops and moves
* long-duration orders progress

The player does not need to manually supervise every minute of these processes.

As uncertainty or danger increases, the player reduces time compression.

A situation may naturally move from:

> hours → tens of minutes → minutes → seconds

After the crisis passes, the player increases compression again.

This allows long-term strategic development and short-duration tactical events to coexist without separate gameplay layers.

---

## 6. Example Temporal Escalation

A Vanguard player may be operating at high compression while constructing a refinery.

During several simulated hours:

* refinery construction progresses
* fuel infrastructure develops
* a convoy moves toward another site
* reconnaissance patrols continue
* local wildlife moves through the region
* Plastai activity elsewhere continues unseen

A refinery sensor reports an unidentified contact.

The player may choose to ignore it.

Additional detections appear.

The number of contacts increases.

Observed movement begins trending toward the refinery.

The player reduces time compression.

A reconnaissance asset is redirected.

Further observations indicate that the movement may be deliberate.

The player reduces compression again.

Eventually the situation develops into direct contact and combat.

The game is now operating near tactical time.

The refinery matters because it is not an arbitrary combat objective.

It is physical infrastructure the player spent several simulated days establishing and integrating into their logistical network.

Once the situation resolves, the campaign naturally returns toward higher time compression.

---

## 7. Pause

**Status: Hard rule**

The player may pause the simulation.

Project Signal is intended to test:

* interpretation
* prioritization
* planning
* judgment
* reconnaissance
* prediction

It is not primarily intended to test actions per minute.

The player may therefore spend as much real-world time as desired examining the information currently available.

However:

> **Pausing stops the production of new information.**

If the simulation is paused at 14:32, the player possesses only the information their faction had acquired by 14:32.

Thinking for thirty real-world minutes does not cause:

* another sensor reading
* another reconnaissance image
* a patrol to arrive
* a contact to move
* an identification to improve
* a weapon to become ready
* reinforcements to arrive

To obtain more evidence, the player must allow simulated time to advance.

---

## 8. Time as the Cost of Information

**Status: Core design principle**

Information gathering takes simulated time.

A player confronting an uncertain signal may have options such as:

* immediately act on incomplete information
* redirect a nearby sensor
* send reconnaissance
* wait for another observation
* reposition a patrol
* request another form of surveillance
* ignore the signal

These options have temporal consequences.

A reconnaissance aircraft may need eight minutes to reach the area.

A ground patrol may require an hour.

Another sensor observation may not occur for twenty minutes.

Waiting therefore has a real cost.

During that time:

* the suspected enemy continues acting
* logistics continue moving
* construction continues
* other threats continue developing
* opportunities may disappear
* the information itself may become obsolete

The intended pressure is therefore not:

> **Can the player think quickly enough?**

It is:

> **Is the player willing to allow more simulated time to pass before making a decision?**

---

## 9. Signals Do Not Normally Control Time

**Status: Hard rule**

Ordinary signals should not automatically pause or slow the simulation.

Signals enter the faction's information environment while time continues.

These may include:

* visual contacts
* acoustic detections
* seismic observations
* radar or equivalent sensor contacts
* communications
* missing reports
* wildlife behavior
* infrastructure events
* detected weapons fire
* logistical observations
* faction-specific sensory information

Automatically interrupting the player for every potentially important signal would create excessive interruptions.

It would also leak information.

If the game consistently pauses for important signals, then:

> **the fact that the game paused becomes information.**

The player would learn that an observation matters before interpreting the observation itself.

Project Signal should avoid creating this unintended omniscient channel.

---

## 10. Missing a Pattern Is Valid Gameplay

**Status: Established design principle**

At high time compression, the player may fail to recognize the significance of available information.

This is intentional.

For example:

> 08:13 — herbivore movement west
> 09:44 — additional herd movement west
> 11:07 — intermittent acoustic anomaly
> 12:31 — patrol misses scheduled report
> 14:02 — refinery sensor detects large organism

Individually, these observations may have several plausible explanations.

Together, they may indicate something significant.

The player may recognize the pattern immediately.

The player may recognize it hours later.

The player may never recognize it.

The simulation did not cheat.

The information existed.

The player failed to interpret it before the situation developed further.

This is a legitimate command failure and an important part of Project Signal's intended skill expression.

---

## 11. Player-Configured Time Triggers

**Status: Major established system**

Players can configure conditions under which their command systems automatically alter time compression.

These rules are distinct from difficulty assistance.

Conceptually:

> **IF observable condition → THEN time-control action**

Possible actions include:

* reduce to a selected compression level
* reduce to near-real-time
* pause

Example Vanguard rules might include:

> IF confirmed contact enters visual range of Refinery Alpha
> THEN pause

or:

> IF multiple unidentified contacts within 5 km of Refinery Alpha have a closing trajectory
> THEN reduce to 5×

or:

> IF Recon Group 3 reports confirmed hostile contact
> THEN pause

Equivalent Plastai systems should express the same command concept through Plastai sensory and biological infrastructure rather than merely duplicating Vanguard terminology.

For example:

> IF sensory organism detects repeated artificial vibration inside Harvest Region 7
> THEN reduce to 10×

The exact trigger-building interface remains unresolved.

---

## 12. Time Triggers Are Command Doctrine

**Status: Core design principle**

Player-configured triggers are not generic game settings.

They represent **command doctrine**.

The player is deciding:

> What kinds of information deserve my immediate attention?

As the player's faction expands, manually watching every location becomes impossible.

The player therefore develops an information-management system.

An experienced player may create doctrine that distinguishes between:

* routine contacts
* unusual contacts
* probable threats
* direct threats to critical infrastructure
* reconnaissance discoveries
* logistical emergencies
* combat
* strategically important changes

Player mastery should increasingly involve determining which situations deserve interruption and which should be allowed to continue without direct supervision.

---

## 13. Triggers May Only Use Known Information

**Status: Hard rule**

Player-configured triggers operate only on information legitimately available to the player's faction.

They may not query omniscient world state.

A rule such as:

> IF hostile contact comes within 3 km of refinery
> THEN pause

does not create an invisible omniscient detection radius.

The refinery, another sensor, or some connected faction capability must actually detect and classify the contact sufficiently for the condition to become true from the faction's perspective.

If the contact approaches through terrain the relevant sensors cannot observe, the rule does not fire.

If communications are disrupted and the observation cannot reach the command system, the rule may not fire.

If the contact is incorrectly classified, a rule requiring confirmed hostile classification may not fire.

Automation therefore remains downstream of:

* sensing
* classification
* communications
* infrastructure
* faction knowledge

There is no magical global alert system.

---

## 14. Physical Infrastructure Determines Trigger Capability

**Status: Established design direction**

The conditions available to automation should depend partly on the information the faction's physical systems are capable of producing.

A simple sensor might provide:

* contact detected
* approximate range
* crude classification

A more sophisticated surveillance system might provide:

* heading
* speed
* estimated contact count
* trajectory
* signature class
* repeated detection
* cross-sensor correlation
* probable weapon activity
* behavioral classification

Improving surveillance therefore does more than increase a hidden detection percentage.

It can expand the **information vocabulary available to player doctrine**.

This creates a direct relationship between:

> physical infrastructure → better information → better automation → improved command attention

---

## 15. Assisted and Unassisted Command

**Status: Established difficulty model**

Project Signal should initially use two broad difficulty experiences:

* **Assisted Command**
* **Unassisted Command**

These are primarily differences in **time-compression assistance and signal interpretation assistance**.

They should not represent different physical simulations.

---

## 16. Assisted Command

**Status: Established design direction**

Assisted Command is intended for:

* new players
* players learning faction signals
* players who prefer reduced attention-management burden

In Assisted Command, the game may automatically reduce simulation speed or pause when important situations develop.

Unlike player-configured triggers, this assistance may consult **omniscient simulation state**.

This is a deliberate accessibility and difficulty mechanism.

However, omniscient assistance should reveal as little hidden information as possible.

The system should prefer behavior such as:

> simulation automatically reduces from high compression to lower compression

rather than:

> WARNING: 37 PLASTAI WARRIORS ARE APPROACHING REFINERY ALPHA FROM THE NORTH

The first tells the player:

> **Something may deserve your attention.**

The second provides intelligence their faction may not possess.

Assisted Command should function more like an invisible command aide tapping the player on the shoulder than an omniscient reconnaissance system.

---

## 17. Assisted Command as Teaching

**Status: Intended behavior**

Assisted time management can teach the player what kinds of situations matter.

A beginner may experience:

1. the simulation automatically slows;
2. the player investigates why;
3. the player discovers several recent signals;
4. the player recognizes the developing pattern;
5. repeated experience teaches the player to recognize similar patterns earlier.

Eventually, the player may begin manually reducing compression before the assistance intervenes.

They may also create player-configured trigger doctrine for situations they have learned to recognize.

Assisted Command therefore teaches the information game without requiring a fundamentally easier simulation.

---

## 18. Unassisted Command

**Status: Hard difficulty rule**

Unassisted Command removes omniscient time-management assistance.

The simulation changes speed only because:

1. the player manually changes it; or
2. a player-configured trigger fires using legitimate faction information.

The game does not protect the player from overlooking a developing situation.

If the player operates at extreme compression while focusing elsewhere, events continue.

A refinery may come under attack.

A convoy may disappear.

A brood region may be discovered.

A reconnaissance opportunity may pass.

The information required to anticipate the event may already have existed.

The player simply failed to act on it.

This is intended gameplay.

---

## 19. Unassisted Does Not Mean Unautomated

**Status: Important distinction**

An expert Unassisted player may use **more automation** than a beginner.

The distinction is the source of that automation.

Assisted Command provides game-level intervention.

Unassisted Command permits player-authored doctrine operating on legitimate information.

An experienced player might configure rules such as:

* pause on confirmed visual contact near critical infrastructure
* slow when multiple sensors correlate the same unknown contact
* slow when an important patrol misses repeated reports
* pause on confirmed weapons fire
* ignore routine wildlife contacts near established operations
* slow when logistical throughput falls below a chosen threshold
* pause when a major reconnaissance asset identifies a previously unknown capability

This represents expertise.

The player is building an increasingly sophisticated command-and-information architecture.

---

## 20. Difficulty Does Not Change Physical Rules

**Status: Hard rule**

Project Signal should not manufacture difficulty through magical AI or simulation bonuses.

Assisted and Unassisted Command should not primarily change:

* unit health
* weapon damage
* armor
* movement speed
* construction speed
* resource production
* biological development speed
* logistics throughput
* sensor performance
* enemy resource income
* enemy production efficiency
* arbitrary combat modifiers

The same weapon should behave according to the same physical rules.

The same organism should possess the same biological capabilities.

The same refinery should require the same construction process.

The same nymph should require the same development.

The same logistics network should possess the same capacity.

Difficulty changes the amount of assistance the player receives in **managing time and interpreting the information environment**.

It does not change the laws of the world.

---

## 21. AI Information Fairness

**Status: Hard rule**

AI-controlled factions must make decisions using information legitimately available to that faction.

The AI must not use omniscient simulation state to determine ordinary strategic or tactical behavior.

If the Plastai have not detected a Vanguard force, Plastai decision-making should not know that force exists.

If Vanguard sensors incorrectly classify a Plastai organism, Vanguard-controlled systems should reason from the available classification rather than secretly using its true identity.

The intended separation is:

> **Omniscient state resolves reality.**

> **Faction-specific state informs decisions.**

This distinction is foundational to:

* reconnaissance
* concealment
* deception
* surprise
* misclassification
* false inference
* signal interpretation
* fair AI behavior

The omniscient layer may be used for explicitly defined meta-systems such as Assisted Command time intervention.

It must not silently become the normal information source for faction AI.

---

## 22. Persistent Orders

**Status: Established design direction**

High time compression requires units and infrastructure to operate without constant player input.

Orders should therefore generally persist until:

* completed
* cancelled
* superseded
* invalidated
* interrupted by conditions defined by the order or doctrine

The player should be able to issue intentions such as:

* patrol this corridor
* maintain reconnaissance over this region
* transport resources between these hubs
* continue refinery construction
* harvest this ecological region
* maintain this logistics route
* develop this brood
* monitor this area
* hold this defensive position

The player should not need to reissue routine orders every few simulated minutes.

This is necessary for meaningful strategic time compression.

---

## 23. Time and Logistics

**Status: Cross-system dependency**

Logistics continues normally during compressed time.

Shipments, convoys, trains, aircraft, nutrient movement, extraction, maintenance, construction, brood development, and other routine processes continue according to simulated time.

Time compression does not teleport resources or eliminate travel.

A shipment requiring six simulated hours still requires six simulated hours regardless of how quickly those hours pass for the player.

This reinforces the logistics principle:

> **Resources create capability, but logistics determines where and when that capability can actually exist.**

Distance matters because things physically require time to move.

---

## 24. Time and Ecology

**Status: Cross-system dependency**

Ecological processes continue during compressed time.

Depending on the final ecology model, this may include:

* migration
* grazing
* reproduction
* depletion
* recovery
* predator-prey interaction
* seasonal movement
* weather response
* fire response
* water-driven movement

High compression therefore does not merely advance player construction queues.

It advances the world.

A player who advances several days to complete infrastructure also allows several days of ecological and enemy activity to occur.

---

## 25. Time and Plastai Development

**Status: Cross-system dependency**

Plastai biological capability depends heavily on developmental time.

Processes may include:

* nutrient accumulation
* nymph development
* cocoon development
* maturation
* biological specialization
* brood expansion
* preparation of dormant organisms
* large biological projects

Time compression allows these processes to operate over strategically meaningful periods without requiring hundreds of repetitive turns.

Developmental time remains real.

A player cannot bypass it merely by operating at high compression because the opposing faction and the rest of the world receive the same simulated time.

---

## 26. Time and Vanguard Development

**Status: Cross-system dependency**

Vanguard strategic development also requires simulated time.

Processes may include:

* surveying
* extraction development
* construction
* road development
* rail development
* industrial expansion
* maintenance
* repair
* orbital delivery
* movement of personnel
* deployment of equipment
* logistics buildup

High compression allows these long-duration processes to coexist with detailed tactical events.

Again, compression does not make the process cheaper or physically faster relative to the world.

Everything receives the same elapsed simulated time.

---

## 27. Time and Weather

**Status: Cross-system dependency**

Weather develops according to simulated time.

A player advancing several hours or days may encounter changing:

* precipitation
* storms
* wind
* visibility
* snow
* flooding
* wildfire conditions
* water availability
* movement conditions

Weather should not freeze simply because the player is focused on strategic development.

Likewise, slowing to tactical time does not alter weather rules.

Detailed weather behavior belongs in `world/weather.md`.

---

## 28. Time and Signal History

**Status: Established design direction**

Signals should remain reviewable after they occur.

This is important because the player may recognize patterns retrospectively.

A player should be able to examine historical observations and reconstruct sequences such as:

> wildlife movement → unusual acoustic activity → missing patrol → confirmed contact

Historical review does not provide omniscient truth.

It shows what the faction actually observed at the time.

The ability to reconstruct events from incomplete historical evidence reinforces Project Signal's intelligence and interpretation gameplay.

Exact retention, filtering, visualization, and annotation mechanics remain UI questions.

---

## 29. Attention Is Not an Abstract Resource

**Status: Hard design principle**

Project Signal should not introduce an abstract attention meter merely to limit player awareness.

Player attention is already constrained naturally by:

* map scale
* simultaneous activity
* imperfect information
* sensor limitations
* communications
* physical distance
* competing priorities
* the volume of signals
* the passage of simulated time

As the player's network expands, the information-management problem grows naturally.

The player's response is to develop:

* better sensing
* better communications
* persistent orders
* alert doctrine
* better infrastructure
* better understanding of signal patterns

Attention management emerges from the simulation.

It is not another currency.

---

## 30. Intended Player Skill Progression

**Status: Established intended behavior**

Player expertise should progress from direct reaction toward interpretation and doctrine.

A new player may:

* depend heavily on Assisted Command
* manually inspect many individual signals
* pause frequently
* react after threats become obvious

An intermediate player may:

* recognize recurring patterns
* reduce compression before assistance intervenes
* configure useful alert rules
* understand which signals can safely be ignored

An expert player may:

* operate primarily in Unassisted Command
* recognize weak patterns early
* build sophisticated trigger doctrine
* maintain high compression safely during routine operations
* know when uncertainty itself warrants slowing down
* allow large portions of the world to operate through persistent orders

The skill ceiling should come from **situational awareness and judgment**, not click speed.

---

## 31. What the Time System Must Never Become

**Status: Hard guardrails**

The time system must never become:

* conventional board-game turns imposed on every system
* an APM test
* constant notification spam
* automatic pausing for every signal
* a system where every interruption secretly identifies important information
* separate disconnected strategic and tactical worlds
* instant strategic movement during compressed time
* free information while paused
* an abstract attention-point economy
* difficulty through arbitrary enemy stat bonuses
* difficulty through omniscient enemy AI
* a system where the player must manually supervise every routine process
* a system where high compression makes the physical world irrelevant
* a system where pause allows additional intelligence to appear without simulated time passing

Time should create decisions.

It should not merely delay them.

---

## 32. Open Design Questions

**Status: Unresolved**

The following remain implementation or playtesting questions:

* exact internal simulation tick size
* exact available time-compression multipliers
* whether compression levels are fixed or partially dynamic
* maximum useful compression
* exact tactical minimum speed
* whether pause is instantaneous or subject to any presentation transition
* exact trigger-building interface
* exact number of player-configurable triggers
* whether triggers are global, regional, asset-specific, unit-specific, or some combination
* whether trigger templates exist
* how faction-specific trigger vocabulary differs
* which sensor capabilities expose which trigger conditions
* exact Assisted Command intervention thresholds
* whether Assisted Command has configurable assistance strength
* how much omniscient state Assisted Command may consult
* how Assisted Command signals a slowdown without revealing hidden information
* exact persistent-order vocabulary
* exact historical signal-log interface
* signal filtering and prioritization UI
* how overlapping trigger conditions resolve
* whether players can temporarily suppress particular trigger classes
* how time compression interacts with cinematic or presentation effects
* exact expected campaign duration in simulated time
* exact expected campaign duration in real player time

These should be resolved through implementation and playtesting rather than prematurely fixed.

---

## 33. Time System Design Test

Any future mechanic involving time, alerts, pausing, automation, or simulation speed should be evaluated against the following questions:

* Does the underlying world continue to obey the same rules at every compression level?
* Does obtaining new information require simulated time to pass?
* Can the player pause to think without gaining free intelligence?
* Does the mechanic preserve uncertainty?
* Does it avoid turning ordinary signals into automatic warnings?
* Is player-configured automation based only on legitimately known information?
* Does sensing infrastructure physically support the information used by the trigger?
* Can communications failure meaningfully affect the system?
* Does Assisted Command help attention without unnecessarily revealing hidden truth?
* Does Unassisted Command remain fair?
* Does faction AI operate only from faction-available information?
* Can long-duration processes operate without repetitive player input?
* Do persistent orders reduce micromanagement?
* Does time compression preserve real travel, construction, development, and logistics time?
* Can the same world support both strategic development and second-by-second tactical events?
* Does the system reward interpretation rather than APM?
* Can player expertise reduce dependence on game-provided assistance?
* Does automation represent player doctrine rather than omniscient convenience?
* Does the mechanic create meaningful consequences for waiting?
* Does the player sometimes have to decide whether additional information is worth the time required to obtain it?

The final test is:

> **The player may stop time to think, but must spend time to learn.**
