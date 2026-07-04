# Research: MVP RSS Reader

## Research Goals

Resolve the remaining implementation questions needed to deliver the MVP with the existing project constraints.

## Decisions

- Decision: Use a simple REST contract with one endpoint to add subscriptions and one endpoint to list them.
  - Rationale: The MVP requirement is limited to adding and viewing subscriptions, so a minimal API keeps the implementation straightforward and easy to verify.
  - Alternatives considered: A single-page-only implementation without an API, and a more elaborate event-driven architecture. Both were rejected because the project goals and the chosen ASP.NET Core + Blazor stack make a small API contract the clearest path.

- Decision: Represent subscriptions as a minimal model with an identifier and a feed URL.
  - Rationale: The MVP does not require richer metadata or parsing.
  - Alternatives considered: A richer model with title, description, and last updated fields. This was rejected as premature complexity.

- Decision: Keep data in memory for the MVP.
  - Rationale: The stakeholder documents explicitly allow in-memory storage and the MVP scope excludes persistence.
  - Alternatives considered: SQLite or a database-backed repository. These were deferred because they are unnecessary for the current proof-of-concept.

## Open Questions Resolved

- How should the user interact with the app? Through a single page that supports entering a feed URL and showing the current list.
- How should the UI and backend communicate? Through a simple JSON API using HttpClient from the Blazor client.
- What validation is required? The UI and API should reject empty or whitespace-only input and avoid creating malformed subscriptions.
