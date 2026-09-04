# Design Summary

> Status: Current orientation. The [ProjectSignal North Star](../north-star.md) is authoritative.

ProjectSignal is a deterministic, headless operational command simulation about asymmetric perception.

The Vanguard fights an intelligence war against an unknown biological system.

The Plastai fight an evolutionary war against an industrial system.

## Core Loop

`Signal -> Investigation -> Confirmation -> Action -> Assessment`

One authoritative world produces objective events and physical signatures. The Vanguard and Plastai collect different subsets of those signatures and describe them through different expertise. Commanders act on faction reports and explicit working interpretations, never objective state.

The world is strategically three-sided but has only two command factions. Independent organisms and ecological processes act from their own conditions. The Vanguard and Plastai both observe, avoid, fight, redirect, exploit, and protect environmental life through different methods.

Future logistics remain physical: resources exist at places, move through interruptible routes, and are consumed by situated processes. The Vanguard ultimately seeks a sustained planet-space connection for colonists; the Plastai seek a consciously designed Titan that secures permanent ecological advantage. Either project's terminal phase becomes unmistakable and grants the opponent a bounded final counter-operation.

## Current Product

Prototype 0 is a standalone .NET console simulation with deterministic WEGO turns. It produces JSON Lines technical records and a Markdown after-action report comparing:

* What objectively happened.
* What the Vanguard observed and claimed.
* What the Plastai observed and claimed.
* Which orders each side committed from that information.
* Which later evidence exposed the consequences.

There is no visualization layer, combat system, economy, or interactive commander interface in current scope.

## Design Standard

A useful scenario creates different faction understanding through collection, expertise, timing, ecology, or deception. Different prose alone is not sufficient.

The first implemented scenario, `The Empty Corridor`, tests whether ecological and industrial expertise produce different but reasonable investigations and commitments.

## Read Next

* [North Star](../north-star.md)
* [Prototype 0 Specification](../prototype-spec.md)
* [Scenario Design](../scenario-design.md)
* [Strategic Objectives and Physical Economy](design-strategic-objectives-and-physical-economy.md)
* [Implementation Status](../implementation-status.md)