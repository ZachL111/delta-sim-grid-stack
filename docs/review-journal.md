# Review Journal

This journal records the domain cases that matter before widening the public API.

The local checks classify each case as `ship`, `watch`, or `hold`. That gives the project a small review vocabulary that matches its simulations focus without claiming live deployment or external usage.

## Cases

- `baseline`: `input pressure`, score 158, lane `ship`
- `stress`: `state drift`, score 100, lane `hold`
- `edge`: `review cost`, score 170, lane `ship`
- `recovery`: `decision risk`, score 217, lane `ship`
- `stale`: `input pressure`, score 150, lane `ship`

## Note

A future change should add new cases before it changes the scoring rule.
