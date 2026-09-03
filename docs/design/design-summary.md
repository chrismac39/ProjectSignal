# Design Summary

> Status: Current orientation. The [ProjectSignal North Star](../north-star.md) is authoritative.

ProjectSignal is a deterministic, headless operational command simulation about asymmetric perception.

Humans fight an intelligence war against an unknown biological system.

Aliens fight an evolutionary war against an industrial system.

## Core Loop

`Signal -> Investigation -> Confirmation -> Action -> Assessment`

One authoritative world produces objective events and physical signatures. Humans and aliens collect different subsets of those signatures and describe them through different expertise. Commanders act on faction reports and explicit working interpretations, never objective state.

## Current Product

Prototype 0 is a standalone .NET console simulation with deterministic WEGO turns. It produces JSON Lines technical records and a Markdown after-action report comparing:

* What objectively happened.
* What humans observed and claimed.
* What aliens observed and claimed.
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
* [Implementation Status](../implementation-status.md)