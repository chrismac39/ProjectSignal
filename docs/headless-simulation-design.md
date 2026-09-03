# Headless Simulation Design

## Decision

ProjectSignal is a headless operational simulation.

The simulation runs as a deterministic .NET program. It does not depend on Godot, Unity, Unreal, a map renderer, or any other visualization layer. Its primary outputs are machine-readable run artifacts and a human-readable after-action report.

The existing Godot prototype is historical validation work. It may be used as migration reference, but it is not the foundation of the authoritative runtime.

## Product Thesis

ProjectSignal is a command simulation about acting on incomplete, asymmetric, and sometimes misleading evidence.

Humans fight an intelligence war against an unknown biological system.

Aliens fight an evolutionary war against an industrial system.

The simulation is not primarily about moving pieces. It is about how each side:

1. Produces signatures through its actions.
2. Collects only some of those signatures.
3. Describes collected evidence through faction expertise.
4. Forms a working interpretation without access to objective reality.
5. Commits orders based on that interpretation.
6. Learns from delayed and incomplete assessment.

## Non-Negotiable Rules

### One objective reality

One authoritative world state owns entities, terrain, processes, orders, events, and outcomes. Faction systems cannot read this state directly.

### Evidence before interpretation

The simulation must preserve this chain:

`World process -> objective event -> physical signature -> collection -> observation -> interpretation -> decision -> outcome -> assessment`

These terms are not interchangeable:

* An **objective event** is what occurred in the world.
* A **signature** is a physical consequence that could be detected.
* A **collection attempt** is a sensor, scout, organism, patrol, or network trying to encounter a signature.
* An **observation** is the evidence actually made available to a faction.
* An **interpretation** is a faction-legible account of that evidence.
* An **assessment** is later evidence about the effects of an order.

An event can create several signatures. A signature can be missed, detected late, attributed incorrectly, or explained differently by each faction.

### No answer key during play

Faction outputs must not contain:

* Confidence scores
* Probability values
* Threat ratings
* Importance ratings
* Reliability scores
* Automated recommendations
* Hidden objective identifiers that let players correlate reports perfectly

The simulation may model concrete physical quantities internally. It must not turn those quantities into an oracle that tells a player what to believe or do.

### Expertise changes vocabulary, not truth

Faction expertise controls which distinctions can be observed and how evidence can be described. It does not apply an arbitrary accuracy percentage.

Humans can distinguish industrial processes, machinery, emissions, communications, and logistics patterns more precisely than alien ecology.

Aliens can distinguish biological state, ecological relationships, stress, migration, propagation, and habitat change more precisely than human industry.

Low expertise should produce coarser but still evidential descriptions. It must not automatically produce random falsehoods.

### Misinterpretation has a cause

False conclusions should emerge from one or more traceable causes:

* A signature was never collected.
* Collection resolution was insufficient to distinguish causes.
* Several causes produced materially similar signatures.
* A faction lacked the concepts needed to describe a distinction.
* A decoy reproduced some signatures but failed to reproduce others.
* Evidence arrived late, out of order, or after conditions changed.
* A prior working model caused the same evidence to be read differently.

Randomly replacing a correct report with an incorrect report is not an acceptable perception model.

## Operational Turn

Prototype 0 uses deterministic WEGO turns. Both factions commit orders without seeing the other faction's current orders. The simulation then adjudicates all orders in a stable sequence.

Each turn contains these phases:

1. **Situation** - expose only reports and assessments already available to each faction.
2. **Orders** - accept scripted orders for both factions.
3. **Commit** - validate orders and prevent later changes.
4. **Execution** - advance movement, tasks, ecological processes, and industrial processes in deterministic substeps.
5. **Signature generation** - derive physical effects from objective events.
6. **Collection** - determine which collectors encounter which signatures.
7. **Interpretation** - translate collected evidence into faction-specific reports.
8. **Assessment** - deliver eligible delayed reports and evidence of prior outcomes.
9. **Record** - persist the turn record and snapshots needed for replay.

Simultaneous intent does not require simultaneous physical resolution. The adjudication sequence must be explicit and stable so identical inputs and seeds produce identical artifacts.

## Time And Scale

Prototype 0 models operational turns rather than continuous time or tactical seconds.

The exact duration represented by one turn is scenario-defined. A scenario may describe a turn as hours or days, but all systems within that scenario use the same turn clock.

Prototype 0 uses a small, hand-authored area model. Geography exists to support movement, access, collection, masking, and ecological or industrial relationships. It is not intended to support tactical pathfinding or visual terrain rendering.

## Three Perspective Records

Every completed run produces three records.

### Objective record

The objective record contains the initial state, committed orders, adjudicated events, generated signatures, actual outcomes, and authoritative snapshots. It is available only to replay analysis, tests, and debugging.

### Human record

The human record contains only information delivered through human collection and interpretation. It uses human terminology and preserves report timing, source class, location precision, and observable details.

### Alien record

The alien record contains only information delivered through alien collection and interpretation. It uses alien terminology and preserves report timing, source class, location precision, and observable details.

Faction records are projections built from authorized observations. They are not filtered copies of the objective record.

## Player Knowledge Model

The simulation distinguishes three forms of faction knowledge:

* **Reports** are immutable records of what was observed at a particular time.
* **Working interpretations** are explicit scenario or player assertions about what reports mean.
* **Institutional memory** records concepts or distinctions learned across repeated encounters.

Prototype 0 implements reports and scripted working interpretations. Institutional adaptation is represented in scenario design but deferred until repeated encounters can be evaluated without leaking objective truth.

The engine must never silently rewrite an old report when better evidence arrives. A later report may contradict or refine it. The AAR should make that evolution visible.

## Scenario Design Standard

A scenario is not complete merely because the human, alien, and objective descriptions use different words. It must create a consequential divergence in what the sides can reasonably infer or choose to investigate.

Every scenario definition must state:

* The objective situation and active processes.
* What each side is trying to accomplish.
* What each side currently believes or assumes.
* Which actions produce signatures.
* Which collection capabilities can encounter each signature.
* How human and alien expertise describe collected evidence.
* At least two materially plausible explanations for key early evidence.
* Which follow-up action could distinguish those explanations.
* What decision each side makes under incomplete information.
* What later evidence assesses that decision.
* What the objective record reveals in the AAR.

### Scenario quality tests

A strong ProjectSignal scenario passes all of these tests:

1. **Same cause, different legibility** - at least one objective process is legible to one faction and coarse or ambiguous to the other.
2. **Different causes, similar signature** - at least one observation has multiple plausible objective causes.
3. **Actionable uncertainty** - a commander can spend time, exposure, position, or resources to investigate.
4. **Consequential commitment** - acting before confirmation has a meaningful possible benefit and cost.
5. **No privileged narrator** - faction reports do not explain what the player should conclude.
6. **Traceable divergence** - the AAR can trace different beliefs back to specific signatures, collection conditions, and expertise.
7. **Counterfactual value** - replay can show how a different collection or order choice could have exposed other evidence.

## Initial Scenario Suite

The first suite should cover distinct mechanisms rather than retell one migration event.

### 1. The Empty Corridor

**Objective reality:** Herbivores abandon a valley because alien nursery growth changes soil chemistry. A human convoy is scheduled to cross the valley.

**Human view:** Sparse animal movement, intermittent sensor returns, and an unusually quiet corridor. The evidence does not identify the nursery growth.

**Alien view:** A normal nursery-driven trophic displacement moving through a known ecological sequence. Human route preparation appears as repeated hard-surface disturbance.

**Decision pressure:** Humans must choose whether the quiet corridor is safe, environmentally unstable, or deliberately cleared. Alien forces must decide whether the industrial disturbance is transit, extraction, or preparation for habitat destruction.

**Discriminating investigation:** Soil sampling exposes the chemical gradient; persistent observation of the human route exposes convoy periodicity.

### 2. Ashfall Ledger

**Objective reality:** A lightning fire damages alien feeding growth near a human refinery. Refinery emissions and ash overlap in time and area.

**Human view:** Thermal activity, particulate density, and altered animal movement resemble industrial sabotage or a secondary refinery incident.

**Alien view:** Fire stress and feeding-growth collapse are clear. The nearby refinery is perceived as a persistent, poorly differentiated source of heat and contamination.

**Decision pressure:** Humans can halt production and expose repair teams, while aliens can divert organisms to attack an industrial site that did not cause the fire.

**Discriminating investigation:** Chemical residue separates combustion sources; ecological recovery patterns separate acute fire damage from chronic industrial effects.

### 3. The False Artery

**Objective reality:** Humans operate a decoy supply route while moving critical material through a low-throughput alternate path.

**Human view:** Route schedules, transponder traffic, and stock movements clearly identify the deception plan and its leakage risks.

**Alien view:** Both routes are recurring lines of compression, vibration, waste, and habitat interruption. The decoy is busier, but its flows do not sustain the surrounding industrial ecology in the expected way.

**Decision pressure:** Aliens must choose which disturbance to constrict. Humans must decide how much real activity the decoy needs to remain biologically convincing.

**Discriminating investigation:** Long observation of waste, maintenance, and return traffic reveals that the busy route has little metabolic equivalent of consumption.

### 4. Nursery Echo

**Objective reality:** Alien scouts seed harmless organisms that mimic the early ecological effects of nursery establishment. The real nursery develops elsewhere.

**Human view:** Two areas show vegetation loss, animal displacement, and unusual moisture change. Available sensors cannot initially separate mimic growth from nursery support organisms.

**Alien view:** The mimic and nursery are categorically different living systems. Human reconnaissance patterns reveal which signatures humans consider meaningful.

**Decision pressure:** Humans must split reconnaissance or commit against one site. Aliens must balance the decoy's value against what human collection behavior teaches them.

**Discriminating investigation:** Repeated samples reveal no maturation sequence at the mimic site; alien counter-recon can infer human sensor priorities from dwell time and approach direction.

### 5. Broken Cadence

**Objective reality:** A human maintenance failure interrupts pumping at a remote station. The interruption changes water flow, machinery vibration, vehicle visits, and local wildlife behavior.

**Human view:** The failure mode and repair burden are recognizable, but the ecological consequences are not.

**Alien view:** A familiar pulse in the watershed stops, several species redistribute, and human activity converges on the station. Whether this is failure, abandonment, or a trap is unclear.

**Decision pressure:** Aliens can exploit the disruption, observe the response, or avoid a possible ambush. Humans can perform a fast exposed repair or a slower concealed one.

**Discriminating investigation:** Observing replacement-part handling distinguishes repair from military concentration; downstream species response reveals the station's hidden ecological reach.

### 6. Lessons That Do Not Transfer

**Objective reality:** After prior encounters, each faction applies a previously useful explanation to a new event with a different cause.

**Human view:** A migration pattern resembles an earlier nursery event but is now caused by seasonal pressure.

**Alien view:** A logistics signature resembles an earlier offensive buildup but is now evacuation and salvage.

**Decision pressure:** Both sides benefit from adaptation, but overgeneralizing learned patterns creates new blind spots.

**Discriminating investigation:** Each side must seek a second signature that its prior model did not require.

## Run Artifacts

Each run writes a versioned artifact directory containing:

* `manifest.json` - scenario ID, schema version, engine version, seed, and run status.
* `orders.jsonl` - committed faction orders in adjudication order.
* `objective-events.jsonl` - objective events and outcomes.
* `signatures.jsonl` - generated physical signatures and their causes.
* `human-reports.jsonl` - reports delivered to the human side.
* `alien-reports.jsonl` - reports delivered to the alien side.
* `snapshots.jsonl` - authoritative turn-boundary state for replay and debugging.
* `aar.md` - a human-readable after-action report generated from the completed run.

JSON Lines is preferred for chronological records because it is diffable, streamable, and easy to inspect with scripts. Scenario definitions should begin as code-owned fixtures until the domain stabilizes; a data format should be introduced only after repeated scenarios reveal a stable schema.

## After-Action Report

The AAR is the primary human-facing output. It is generated after a run and may use objective information.

The AAR contains:

1. Scenario intent and outcome.
2. A turn-by-turn three-column comparison of objective events, human reports, and alien reports.
3. The orders each faction committed with the information then available.
4. Key divergences between observation, working interpretation, and reality.
5. Evidence that was missed, delayed, masked, or misclassified and the concrete reason why.
6. Decision consequences, including effects that remained unknown to the acting faction.
7. Counterfactual collection opportunities grounded in legal alternative orders.

The AAR must explain causality without grading players through a single score.

## Determinism And Isolation

A run is reproducible from its scenario version, engine version, scripted orders, and random seed.

The architecture enforces information isolation:

* Adjudication code may read objective state.
* Signature generation may read objective events and state.
* Collection code may read signatures and collector capabilities, but not hidden causes.
* Interpretation code may read collected evidence and faction knowledge, but not objective events.
* Faction decision code may read only that faction's delivered reports, working interpretations, objectives, and legal-order rules.
* AAR code may read all run artifacts only after adjudication is complete.

Tests must fail if a faction-facing type exposes an objective event reference, hidden cause, opposing order, or authoritative entity identifier without an in-world collection reason.

## Prototype 0 Completion Criteria

Prototype 0 is complete when a standalone .NET console command can:

1. Run one deterministic, scripted, multi-turn scenario without a game engine.
2. Resolve committed orders through an explicit WEGO turn sequence.
3. Generate objective events and one-to-many physical signatures.
4. Collect different evidence for human and alien observers.
5. Produce faction reports whose differences follow from collection and expertise.
6. Preserve objective, human, and alien records without information leakage.
7. Generate the complete artifact set and a readable AAR.
8. Re-run with the same inputs and produce equivalent chronological records.
9. Demonstrate at least one missed signal, one ambiguous shared signature, one expertise-driven distinction, and one consequential decision made before confirmation.

Combat, production economies, strategic victory conditions, multiplayer, procedural maps, and visualization remain outside Prototype 0.

## Implementation Sequence

1. Establish a standalone solution with domain, console runner, and test projects.
2. Define turn, faction, location, order, objective event, signature, observation, report, and run-record types.
3. Implement deterministic turn orchestration and artifact recording.
4. Migrate the existing migration example as a characterization test.
5. Implement `The Empty Corridor` as the first complete multi-turn vertical slice.
6. Generate the first three-perspective AAR.
7. Add scenarios one mechanism at a time: overlapping causes, logistics deception, counter-recon, then repeated-encounter adaptation.
8. Archive the Godot prototype after the headless characterization tests pass.