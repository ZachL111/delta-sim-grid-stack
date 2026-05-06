# delta-sim-grid-stack

`delta-sim-grid-stack` keeps a focused C# implementation around simulations. The project goal is to create a C# reference implementation for grid workflows, centered on security rule linting, safe and unsafe fixtures, and remediation hints.

## Why This Exists

The project exists to keep a narrow engineering decision visible and testable. For this repo, that decision is how input pressure and review cost should influence a review result.

## Delta Sim Grid Stack Review Notes

`recovery` and `stress` are the cases worth reading first. They show the optimistic and cautious ends of the fixture.

## Capabilities

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/delta-sim-grid-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `decision risk` and `state drift`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## Implementation Shape

The repository has two validation layers: the original compact policy fixture and the domain review fixture. They are separate so one can change without hiding failures in the other.

The added C# path is deliberately direct, with fixtures doing most of the explaining.

## Local Usage

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Verification

The verifier is intentionally local. It should fail if the fixture score math, lane assignment, or language-specific test drifts.

## Roadmap

No external service is required. A deeper version would add more negative cases and a clearer boundary around invalid input.
