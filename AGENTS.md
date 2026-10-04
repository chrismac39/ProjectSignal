# Project Signal Agent Guidance

## Source of Truth

`VISION.md` is the governing product and design document.

Before proposing or implementing changes that affect gameplay, simulation,
architecture, user interaction, terminology, scope, or priorities, consult
`VISION.md`.

When requirements are ambiguous:

1. Prefer the interpretation most consistent with `VISION.md`.
2. Preserve the core loop:
   **Observe -> Interpret -> Prepare -> Commit -> Reveal -> Adapt**
3. Favor systems that strengthen information, logistics, ecology, distance,
   deception, preparation, and deep faction asymmetry.
4. Apply the "Project Signal Test" in section 30 of `VISION.md`.
5. Ask for clarification when multiple materially different options remain.

Do not import conventional RTS mechanics unless they serve the vision. Use the
simplest simulation capable of proving the intended strategic behavior.

## Repository State

`Archive/` contains historical prototypes and documentation. Treat it as
reference material, not the current implementation or an authoritative source.
Do not modify archived content unless explicitly requested.

`VISION.md` overrides conflicting archived documents.

## Development

New detailed design documents should elaborate on `VISION.md`, not silently
contradict it. Surface any meaningful conflict before implementation.

Keep changes focused and validate executable changes with the narrowest
relevant test or build.