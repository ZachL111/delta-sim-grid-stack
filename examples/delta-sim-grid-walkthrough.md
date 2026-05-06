# Delta Sim Grid Stack Walkthrough

This walk-through keeps the domain vocabulary close to the data instead of burying it in prose.

| Case | Focus | Score | Lane |
| --- | --- | ---: | --- |
| baseline | input pressure | 158 | ship |
| stress | state drift | 100 | hold |
| edge | review cost | 170 | ship |
| recovery | decision risk | 217 | ship |
| stale | input pressure | 150 | ship |

Start with `recovery` and `stress`. They create the widest contrast in this repository's fixture set, which makes them better review anchors than the middle cases.

`recovery` is the optimistic case; use it to make sure the scoring path still rewards strong signal.
