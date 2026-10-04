# Project Signal — Weather Design

## 1. Purpose

Weather in Project Signal is part of the simulated world state.

It is not decorative ambience and it is not a random buff/debuff system applied directly to units or factions.

Weather exists to:

* materially alter the world state,
* interact with terrain, climate, ecology, and prior conditions,
* affect the Vanguard and Plastai differently through their existing systems,
* influence logistics, mobility, sensing, ecology, fire, water, and combat,
* create uncertainty without feeling arbitrary,
* generate temporary opportunities as well as setbacks,
* leave persistent consequences after major events,
* reinforce the core signal, interpretation, deception, and adaptation loop.

**Established principle:** weather acts on the world state, and the resulting world state affects the factions.

---

## 2. Weather Design Philosophy

Project Signal requires believable weather, not high-fidelity atmospheric simulation.

The weather system favors:

* plausible regional behavior,
* probabilistic events,
* persistent environmental consequences,
* interaction with geography,
* interaction with existing world state,
* partial predictability,
* readable causes and consequences,
* meaningful strategic effects.

Weather does not need to simulate atmospheric physics in detail to feel real.

A storm is meaningful because it exists somewhere, has duration and severity, interacts with terrain and current conditions, and changes the world while it is present and after it has passed.

**Hard rules:**

* Weather is not purely cosmetic.
* Weather is not a collection of direct faction stat modifiers.
* Weather is not perfectly predictable.
* Weather is not completely arbitrary.
* Weather does not require a real-world meteorological simulation.
* Weather consequences must follow from conditions in the world whenever practical.

---

## 3. World State + Weather = Outcome

The effect of a weather event depends on the state of the world when that event occurs.

The same weather event does not always produce the same result.

Conceptually:

**Weather Event + Global World State + Local Conditions + Recent Weather + Terrain = Outcome**

A thunderstorm on a wet world may primarily produce:

* grounded or restricted aviation,
* reduced visibility,
* elevated rivers,
* additional soil saturation,
* little meaningful wildfire risk.

The same thunderstorm on a dry world may produce:

* the same aviation disruption,
* temporary concealment,
* lightning ignition,
* rapidly spreading wildfire,
* herd displacement,
* destruction of biomass,
* long-lived smoke and burned terrain.

Heavy rain over already saturated ground may produce flooding.

Heavy rain after a prolonged dry period may instead primarily restore water availability, reduce fire risk, and alter vegetation conditions.

Snow at high elevation may accumulate and persist while the same regional weather produces rain or mixed precipitation at lower elevation.

Strong wind over wet vegetation may have limited ecological consequences. Strong wind over dry vegetation can turn a small fire into a major event.

**Hard rule:** weather acts on environmental systems first. Faction consequences emerge from those environmental changes.

---

## 4. Weather as Shared Reality

Both factions experience the same weather system.

There is no Vanguard weather system and no Plastai weather system.

A storm exists in the world independently of who benefits from it.

The factions experience different consequences because they differ in:

* technology,
* biology,
* infrastructure,
* mobility,
* sensing,
* ecology,
* logistics,
* dependence on the surface environment,
* dependence on aviation and constructed networks.

A thunderstorm may ground Vanguard aircraft while simultaneously giving Plastai surface movement temporary protection from aerial observation.

That does not mean the thunderstorm grants the Plastai a bonus.

It means the Vanguard's aviation system cannot operate normally under those conditions.

Likewise, wildfire may destroy vegetation and animal populations important to Plastai biomass acquisition while threatening Vanguard infrastructure in a completely different way.

**Established principle:** asymmetric consequences emerge from a shared world state.

---

## 5. Weather Generation

Weather emerges from a simplified set of coherent conditions.

Relevant inputs may include:

* geographic region,
* elevation,
* season,
* temperature,
* atmospheric moisture,
* prevailing conditions,
* recent precipitation,
* recent temperature history,
* persistent wet or dry periods,
* local terrain,
* global world-state modifiers.

Weather generation may use probabilistic concepts such as:

* mean time to precipitation,
* storm likelihood,
* seasonal event probability,
* regional weather tendencies,
* persistent wet phases,
* persistent dry phases,
* event severity distributions.

The system does not require exact atmospheric modeling.

A region can have a probability of receiving precipitation without simulating individual cloud formation.

Once precipitation occurs, the existing temperature, elevation, climate state, and local conditions determine whether it manifests as rain, snow, mixed precipitation, or another appropriate form.

**Intended gameplay behavior:** players experience coherent weather patterns without being able to predict every event exactly.

---

## 6. Weather Predictability

Weather is partially predictable.

Players may receive or infer:

* broad forecasts,
* expected regional conditions,
* storm indications,
* changing temperature trends,
* cloud development,
* wind changes,
* precipitation likelihood,
* broad uncertainty ranges,
* signs that severe conditions are developing.

Players should often be able to understand why an event occurred after the fact.

They should also frequently have enough information beforehand to make an informed decision.

They should not know:

* the exact future path of every storm,
* the exact time precipitation begins and ends,
* every lightning ignition,
* every flood outcome,
* every local severity change.

This creates planning without deterministic certainty.

A player may know that a severe thunderstorm system is approaching a region without knowing whether it will pass directly over a specific valley or how long Vanguard aviation will remain unavailable.

**Hard rule:** weather is neither perfectly known nor random noise.

---

## 7. Precipitation

Precipitation is an active world-state process.

Relevant characteristics include:

* type,
* intensity,
* duration,
* accumulation,
* temperature,
* geographic extent.

Precipitation can influence:

* soil moisture,
* snowpack,
* runoff,
* river levels,
* wetlands,
* vegetation,
* visibility,
* terrain mobility,
* infrastructure,
* wildlife behavior,
* ecological productivity,
* wildfire conditions.

Precipitation is not represented merely as a temporary movement penalty.

Its effects can persist long after precipitation ends.

---

## 8. Rain

Rain can produce both positive and negative consequences.

Possible effects include:

* increased surface water,
* improved vegetation conditions,
* improved future biomass productivity,
* lower wildfire risk,
* soil saturation,
* mud,
* reduced ground mobility,
* reduced visibility,
* degraded optical sensing,
* altered river flow,
* temporary wetland expansion,
* flooding under appropriate conditions,
* wildlife movement or concentration,
* changes to routes and crossings.

Light rain and prolonged heavy rain are not equivalent.

Rain falling onto dry ground is not equivalent to rain falling onto already saturated ground.

Rain should therefore modify environmental variables rather than trigger one universal effect.

---

## 9. Snow

Snow is both weather and persistent terrain state.

Snow can affect:

* ground movement,
* surface access,
* visibility,
* aviation,
* concealment,
* seasonal migration,
* forage availability,
* wildlife concentration,
* infrastructure,
* road and rail operations,
* water storage,
* later runoff,
* ecological productivity,
* local temperature conditions.

Snow accumulation varies by:

* elevation,
* temperature,
* storm intensity,
* duration,
* wind,
* terrain,
* world state.

Snow can remain after a storm and become part of the environment.

Later warming can convert accumulated snow into runoff, flooding, wet ground, and increased water availability.

**Hard rule:** snow does not disappear when the snowfall event ends.

---

## 10. Thunderstorms

Thunderstorms are major compound weather events.

A thunderstorm may combine:

* heavy rain,
* strong wind,
* lightning,
* reduced visibility,
* rapid local temperature changes,
* communications disruption,
* sensor degradation,
* aviation restrictions,
* flooding risk,
* wildfire ignition risk,
* ecological disturbance.

Thunderstorms are particularly important because they can change the local balance between the factions without directly modifying faction statistics.

A strong electrical storm may ground Vanguard aircraft.

This can create a temporary opportunity for Plastai forces to:

* reposition,
* cross exposed terrain,
* approach infrastructure,
* emerge in areas normally covered by aviation,
* exploit reduced reconnaissance.

However, this benefit is not guaranteed to remain positive.

On a dry world or during a prolonged dry period, lightning from the same storm may ignite wildfire.

That wildfire may:

* destroy vegetation,
* kill wildlife,
* scatter major herds,
* remove future biomass,
* force Plastai relocation.

The same thunderstorm can therefore create an immediate tactical advantage for the Plastai while creating a longer-term ecological loss.

On a wet world, the fire risk may be negligible, allowing the same storm to produce a substantially different strategic result.

**Established principle:** thunderstorms demonstrate that weather effects are produced by the combination of event and world state.

---

## 11. Lightning

Lightning has physical consequences.

Possible effects include:

* wildfire ignition,
* infrastructure damage,
* disruption to exposed systems,
* local sensor interference,
* temporary communications disruption,
* ecological disturbance,
* risk to exposed units or installations.

Lightning does not automatically produce catastrophic outcomes.

Fire ignition depends on conditions such as:

* fuel dryness,
* fuel density,
* recent precipitation,
* temperature,
* wind,
* existing moisture state.

Repeated catastrophic lightning strikes should remain uncommon unless world conditions strongly support them.

Lightning remains dangerous because it can trigger secondary systems rather than because every strike causes direct destruction.

---

## 12. Wind

Wind interacts with multiple systems.

Strong wind can affect:

* Vanguard aviation,
* airborne or gliding organisms,
* wildfire spread,
* smoke movement,
* dust,
* precipitation behavior,
* sensor quality,
* visibility,
* vegetation,
* weather movement,
* exposed infrastructure.

Wind effects are context dependent.

Strong wind across wet terrain may mainly restrict aviation.

The same wind across dry burning vegetation may become a major wildfire driver.

Strong wind during snowfall may create severe visibility loss and drifting snow.

Wind should therefore combine with other environmental states rather than exist as a generic penalty.

---

## 13. Fog and Low Visibility

Fog and low cloud can materially alter information warfare.

Potential effects include:

* reduced visual sensing,
* reduced reconnaissance range,
* uncertain identification,
* degraded targeting,
* aviation restrictions,
* slower movement in difficult terrain,
* reduced confirmation of detected signals,
* greater concealment for surface activity.

Fog should occur where geography and climate plausibly support it.

Relevant environments may include:

* valleys,
* wetlands,
* river corridors,
* lake regions,
* saturated terrain,
* regions experiencing appropriate temperature and moisture conditions.

Fog is particularly valuable to the signal system because it can reduce confidence without eliminating information completely.

---

## 14. Cold Events

Cold events include:

* cold snaps,
* prolonged freezing conditions,
* severe winter storms,
* icing,
* extreme snowfall,
* blizzard conditions.

Possible environmental consequences include:

* frozen surface water,
* accumulated snow,
* ice,
* reduced ground mobility,
* altered wildlife movement,
* concentrated animal populations,
* increased biological energy demand,
* reduced forage access,
* later snowmelt runoff.

Vanguard consequences may emerge through:

* aviation restrictions,
* icing,
* mechanical reliability,
* increased power demand,
* road and rail conditions,
* infrastructure exposure.

Plastai consequences may emerge through:

* phenotype suitability,
* metabolic burden,
* reduced surface biomass,
* altered prey distribution,
* surface movement difficulty,
* changes in emergence conditions.

Cold weather does not apply arbitrary penalties to either faction.

Its effects follow from what each faction physically depends upon.

---

## 15. Heat and Drought

Heat and drought are persistent environmental states rather than instant debuffs.

They can affect:

* vegetation,
* surface water,
* river levels,
* wetland extent,
* wildlife migration,
* biomass availability,
* wildfire risk,
* dust,
* visibility,
* soil moisture,
* ecological productivity.

For the Plastai, prolonged drought can reduce or relocate the surface biological resources they depend upon.

For the Vanguard, heat and drought can alter:

* cooling demands,
* dust exposure,
* water-dependent infrastructure where relevant,
* wildfire exposure,
* transportation conditions,
* visibility,
* operational conditions for personnel and equipment.

Drought can also create later vulnerability to thunderstorms by leaving large quantities of dry fuel available for lightning ignition.

---

## 16. Wildfire

Wildfire is an emergent environmental process.

It is not simply a scripted weather hazard.

Wildfire can arise from combinations of:

* dry vegetation,
* heat,
* drought,
* lightning,
* existing fire,
* wind,
* fuel density.

Wildfire can:

* destroy vegetation,
* reduce accessible biomass,
* kill wildlife,
* scatter herds,
* change migration routes,
* damage infrastructure,
* threaten roads and installations,
* produce smoke,
* reduce visibility,
* alter sensing,
* expose previously concealed terrain,
* create temporary impassable areas,
* force relocation,
* alter future ecological productivity.

Fire consequences persist after the active flames disappear.

Burned terrain becomes a new ecological condition.

Over time, fire may also create new growth patterns or different ecological opportunities.

**Hard rule:** wildfire results from environmental conditions and propagates through the world state. It is not randomly spawned because the game decides a faction needs a setback.

---

## 17. Flooding

Flooding can emerge from:

* heavy precipitation,
* repeated precipitation,
* saturated soil,
* river rise,
* snowmelt,
* terrain concentration,
* existing high-water conditions.

Possible consequences include:

* lowland inundation,
* temporary wetland expansion,
* road disruption,
* bridge risk,
* altered crossings,
* slowed logistics,
* changes in wildlife distribution,
* concentrated animals on high ground,
* increased aquatic productivity,
* altered vegetation conditions,
* interaction with aquifer-connected ecology where appropriate.

Flooding does not require fully simulated hydrology.

The system needs only enough hydrological logic for flooding to occur in plausible places and to leave meaningful consequences.

---

## 18. Weather Persistence

Weather has duration and memory.

A storm does not:

1. begin,
2. apply a temporary effect,
3. disappear,
4. restore the world immediately to its prior state.

Weather may leave behind:

* wet soil,
* snowpack,
* ice,
* smoke,
* flooded terrain,
* elevated rivers,
* drought relief,
* fire damage,
* damaged infrastructure,
* altered vegetation,
* changed wildlife movement.

Recent weather becomes an input into future weather consequences.

Three days of rain can make the fourth storm more dangerous because the soil is already saturated.

Several dry weeks can make a later electrical storm more dangerous because vegetation has become combustible.

This persistence is necessary for weather to become strategically meaningful.

---

## 19. Regional Weather

The world map is large enough for multiple weather conditions to exist simultaneously.

One region may experience:

* heavy rain,

while another experiences:

* clear skies,

and another experiences:

* snow,
* drought,
* fog,
* strong wind,
* thunderstorms.

Weather is regional rather than universally map-wide.

Storms and weather systems may move through multiple regions over time.

This creates geographically limited operational windows.

A storm may ground Vanguard aviation over one valley while aircraft remain fully operational elsewhere.

The Plastai may therefore have a temporary safe movement opportunity in one region without gaining global protection.

**Hard rule:** weather does not apply uniformly across the entire map unless a genuinely map-scale condition warrants it.

---

## 20. Terrain Interaction

Weather is shaped by geography.

Relevant terrain includes:

* mountain ranges,
* valleys,
* elevation,
* forests,
* plains,
* wetlands,
* dry basins,
* rivers,
* lakes,
* other large bodies of water.

Terrain may influence:

* precipitation,
* rain versus snow,
* snow accumulation,
* fog,
* wind exposure,
* wildfire behavior,
* flood risk,
* runoff,
* local moisture.

A high mountain region behaves differently from a dry interior basin even when both are under the same broader weather system.

The map therefore provides constraints and tendencies rather than serving merely as a background beneath weather effects.

---

## 21. Seasonal Weather

Seasons influence weather probability and environmental response.

Seasonal changes may affect:

* temperature,
* snowfall,
* rainfall,
* storm types,
* drought probability,
* wildfire risk,
* vegetation,
* migration,
* river levels,
* snowpack,
* snowmelt.

Seasonality should remain strong enough to support the baseline alpine and continental identity of the world.

World-state modifiers such as hot or cold world alter seasonal expression without eliminating seasonal variety.

A hot world can still experience snowfall and cold high-elevation weather.

A cold world can still experience warm periods, rain, storms, wetlands, grasslands, and productive lowlands.

**Hard rule:** major world modifiers shift distributions and boundaries rather than eliminating ecological or climatic variety.

---

## 22. Weather and the Vanguard

Weather affects the Vanguard through the systems the Vanguard actually uses.

Relevant systems include:

* aircraft,
* VTOL operations,
* airfields,
* optical sensors,
* communications,
* targeting,
* reconnaissance,
* roads,
* rail,
* bridges,
* construction,
* fuel logistics,
* power systems,
* exposed installations.

Examples:

A thunderstorm can ground aviation because flying becomes unsafe.

Flooding can sever logistics because a bridge or road becomes unusable.

Fog can reduce targeting confidence because sensors cannot clearly observe a target.

Snow can slow logistics because routes require clearing or become difficult to traverse.

Wildfire can threaten infrastructure because fire physically reaches it.

The Vanguard does not receive arbitrary effects such as:

**Rain: -20% efficiency.**

Consequences should follow from affected physical and technological systems.

---

## 23. Weather and the Plastai

Weather affects the Plastai through their biology and ecological dependence.

Relevant systems include:

* surface biomass,
* wildlife populations,
* surface mobility,
* water availability,
* wetlands,
* aquifer-connected ecological conditions,
* emergence,
* migration,
* concealment,
* phenotype suitability,
* fire vulnerability,
* ecological productivity.

Examples:

Rain may improve future vegetation and biomass.

Drought may reduce available surface biomass.

Wildfire may destroy prey and vegetation.

Fog may provide concealment.

Snow may impede some surface forms while favoring cold-adapted phenotypes.

Flooding may disrupt surface movement while improving aquatic or wetland conditions.

Again, the system does not apply direct Plastai bonuses or penalties.

The environment changes, and Plastai capabilities interact with that environment.

---

## 24. Asymmetric Consequences

Weather does not require a single winner.

A weather event may:

* help one faction and hurt the other,
* hurt both,
* help both,
* create a short-term advantage followed by a long-term disadvantage,
* produce different effects in different regions.

This asymmetry is intentional.

A severe thunderstorm may ground Vanguard aircraft.

That gives the Plastai a temporary opportunity to move through exposed terrain.

If the same storm ignites a wildfire in a dry valley, the Plastai may subsequently lose the herd or vegetation they intended to harvest.

The Vanguard may therefore suffer the immediate tactical cost while the Plastai suffer the later ecological cost.

Conversely, heavy rain may make Vanguard ground logistics difficult while increasing biomass and water availability for the Plastai.

Flooding may then become severe enough to interfere with both factions.

**Established principle:** weather does not seek symmetrical balance. It creates a shared situation that each faction experiences differently.

---

## 25. Weather and Information

Weather participates directly in the signal system.

Weather can:

* reduce sensor quality,
* obscure movement,
* reduce visual confirmation,
* interfere with communications,
* create atmospheric noise,
* delay reconnaissance,
* alter wildlife behavior,
* reduce confidence in interpretation.

Weather also creates signals of its own.

Examples include:

* lightning,
* smoke,
* fire,
* unusual animal movement,
* flood displacement,
* dust,
* atmospheric disturbance.

Environmental activity can complicate interpretation of enemy activity.

Players should sometimes struggle to determine whether a detected signal represents:

* hostile movement,
* displaced wildlife,
* fire,
* weather,
* damaged infrastructure,
* some combination of these.

This reinforces Project Signal's core uncertainty loop.

---

## 26. Weather and Deception

Players do not need direct control over weather to exploit it.

Weather creates operational windows.

Players may:

* move under storm cover,
* exploit grounded aviation,
* reposition through fog,
* conceal activity behind smoke,
* cross exposed ground during low visibility,
* use snow conditions for concealment,
* time operations around flooding,
* alter routes because of fire or weather damage.

Weather becomes part of planning and deception because players understand its likely consequences without controlling it directly.

**Hard rule:** no magical player-controlled weather mechanics are assumed by the core design.

---

## 27. Weather and Time Compression

Weather continues to evolve while time is compressed.

The simulation should resolve weather at a level appropriate to the passage of game time.

Several hours or days may pass without requiring the player to observe every individual shower or temperature change.

Minor weather should generally progress without interrupting play.

Strategically important conditions can trigger attention.

Examples include:

* major storm arrival,
* aviation shutdown,
* wildfire near important assets,
* severe flooding,
* extreme snowfall,
* major logistics disruption.

Player-configurable attention rules may determine which events slow or interrupt accelerated time.

Weather must remain part of the simulation even when the player is not observing it directly.

A storm resolved during compressed time still leaves:

* snow,
* mud,
* flooding,
* fire,
* smoke,
* altered wildlife,
* damaged infrastructure.

---

## 28. Weather Forecasting

Neither faction has perfect knowledge of future weather.

The Vanguard may possess stronger technical forecasting capabilities through:

* sensors,
* atmospheric observation,
* instrumentation,
* predictive systems.

The Plastai may infer developing weather through environmental or biological cues.

The exact faction-specific forecasting systems remain unresolved.

Regardless of implementation:

* forecasts are probabilistic,
* forecast certainty varies,
* severe systems may be detectable before arrival,
* exact local outcomes remain uncertain,
* players should be able to plan without knowing the future precisely.

Forecasting should provide information, not omniscience.

---

## 29. Weather Severity

Weather events have meaningful intensity.

A light rain event is not equivalent to a severe storm.

Relevant severity dimensions may include:

* duration,
* precipitation quantity,
* wind,
* temperature,
* lightning activity,
* visibility,
* geographic extent.

Severity should be detailed only where it creates meaningful differences in outcome.

The system does not require dozens of nearly identical storm categories.

A manageable range of event severities is preferable to unnecessary granularity.

---

## 30. Weather Event Frequency

Weather should matter without becoming constant chaos.

Ordinary weather provides:

* environmental texture,
* gradual moisture changes,
* changing visibility,
* seasonal progression,
* ecological variation.

Severe weather creates moments that demand adaptation.

Severe events should occur infrequently enough that they remain strategically meaningful.

If catastrophic weather is constant, it stops being an event and becomes background noise.

World-state conditions may substantially alter event frequency.

A wet world may experience more frequent precipitation.

A dry world may experience longer intervals between storms and greater wildfire risk when storms finally arrive.

Weather frequency therefore responds to the broader world rather than following one universal schedule.

---

## 31. Weather and Emergent Narrative

Weather should create memorable situations through system interaction.

Examples include:

* Vanguard aircraft becoming grounded during a Plastai offensive,
* Plastai moving through a valley while storms suppress aerial reconnaissance,
* lightning igniting the same biologically rich valley both factions intended to exploit,
* wildfire scattering a major herbivore population,
* flooding severing a critical Vanguard logistics route,
* snowfall hiding movement that would otherwise have been detected,
* smoke causing a reconnaissance contact to be misinterpreted,
* a storm producing temporary concealment followed by catastrophic ecological damage,
* repeated rain turning an ordinary river into a major operational obstacle.

These stories are not scripted scenarios.

They emerge because weather, ecology, terrain, information, and faction systems interact.

---

## 32. What the Weather System Must Never Become

The weather system must not become:

* a random buff/debuff generator,
* purely cosmetic ambience,
* a perfect meteorological simulator,
* globally uniform,
* a system that directly targets factions,
* arbitrary punishment,
* constant catastrophic events,
* perfectly predictable,
* completely unknowable,
* independent of terrain,
* independent of climate,
* independent of recent weather,
* independent of existing world state,
* a system where every thunderstorm produces the same result,
* a system where every rainstorm creates mud,
* a system where every lightning strike creates wildfire,
* a system where weather consequences disappear immediately when the event ends,
* a collection of faction-specific scripted bonuses,
* an excuse for excessive simulation complexity,
* a replacement for the underlying ecological simulation.

The system should remain deep because its components interact, not because every atmospheric process is individually simulated.

---

## 33. Open Design Questions

The following remain unresolved:

* Exact seasonal cadence.
* Exact weather-generation model.
* Exact use of mean-time-to-event systems.
* Exact scale and definition of weather regions.
* Whether major storm fronts are explicitly represented as moving entities or inferred through regional transitions.
* Exact forecast accuracy.
* Exact difference between Vanguard and Plastai forecasting.
* Exact duration and decay of soil moisture.
* Exact persistence and melt behavior of snowpack.
* Exact representation of smoke.
* Exact level of flood simulation.
* Exact interaction between surface precipitation and aquifer conditions.
* Exact weather alert thresholds during time compression.
* Exact severity scales for major weather types.
* Exact rules governing local variation inside larger regional weather systems.

These questions should be resolved only when required by gameplay or implementation.

---

## 34. Weather Design Test

Any future weather mechanic should be evaluated against the following questions:

* Does this modify the world rather than directly modify faction statistics?
* Does its outcome depend on existing world state?
* Does recent weather matter where appropriate?
* Does geography matter?
* Does climate matter?
* Can the same event produce different outcomes under different conditions?
* Can both factions experience different consequences from the same event?
* Do those differences emerge naturally from faction design?
* Does the event create a strategic decision or operational window?
* Does it affect signals, sensing, or interpretation where appropriate?
* Does it persist long enough to matter when persistence is physically meaningful?
* Is it partially predictable without being perfectly known?
* Does it create opportunities as well as problems?
* Can its secondary consequences matter more than its immediate effects?
* Does it avoid unnecessary simulation complexity?
* Could this interaction create an emergent story?

The central rule remains:

**Weather acts on the world state, and the resulting world state affects the factions.**
