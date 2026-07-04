# RSS Feed Reader Constitution
<!--
Sync Impact Report
- Version change: 0.1.0 -> 1.0.0
- Modified principles: none; created a project-specific constitution from the template
- Added sections: Core Principles, Additional Constraints, Development Workflow, Governance
- Removed sections: none
- Templates requiring updates: ✅ .specify/templates/plan-template.md, ✅ .specify/templates/spec-template.md, ✅ .specify/templates/tasks-template.md, ⚠ README.md (optional runtime guidance reference)
- Follow-up TODOs: none
-->

## Core Principles

### I. MVP-First Scope Discipline
All work MUST remain within the documented MVP scope unless the scope is explicitly expanded by a reviewed change request. Features that are not required to add a subscription and display the subscription list are deferred to Extended-MVP or later. This rule prevents scope creep and keeps the codebase small, understandable, and maintainable.

### II. Secure and Safe Input Handling
User-provided feed URLs and any other text input MUST be treated as untrusted data. The application MUST avoid executing or rendering untrusted content, MUST not assume a URL is valid, and MUST keep a clear separation between UI entry points and downstream processing. For this MVP, the implementation MUST not introduce unsafe content rendering or arbitrary network behavior.

### III. Maintainable Architecture Boundaries
The backend API and Blazor UI MUST remain separated by clear contracts and responsibilities. State changes, subscription management logic, and configuration access MUST be isolated from UI components so the MVP can evolve into persistence or richer feed features without a rewrite. Complex behavior MUST live in dedicated services or models rather than directly inside page code.

### IV. Quality and Verification Gates
Every change MUST build successfully and pass a relevant verification step before it is considered complete. For this project, that includes confirming the frontend and backend start without routing or configuration errors, the add-subscription flow works end to end, and no regression appears in the basic subscription experience. New behavior that changes state or integration points MUST be covered by automated tests when the project already has test infrastructure in place.

### V. Incremental Extensibility
The implementation MUST stay simple enough for the current MVP while remaining compatible with future phases such as feed fetching, persistence, and background polling. New abstractions, libraries, or patterns are allowed only when they directly support the next planned phase or clearly reduce maintenance cost. Premature complexity is prohibited.

## Additional Constraints
The project MUST use ASP.NET Core Web API for the backend and Blazor WebAssembly for the frontend unless a future change is explicitly approved. Configuration values such as API base URLs, ports, and CORS origins MUST be stored in configuration rather than hardcoded in multiple places. In-memory storage is acceptable for the MVP, but storage access MUST be encapsulated so it can be replaced later with persistence without changing the UI contract.

## Development Workflow
All work MUST begin from the current project goals, app features, and technology constraints before implementation starts. Each feature or fix MUST include a clear acceptance check that confirms the MVP behavior still works after the change. Changes to API contracts, routing, or configuration MUST be reviewed for compatibility with the existing frontend and backend setup before they are merged.

## Governance
This constitution supersedes local shortcuts or ad hoc practices when they conflict with these principles. Amendments MUST update this constitution and any affected planning, specification, or task artifacts. Each amendment MUST document the rationale, the new version number, and the date of change. Compliance with these principles MUST be reviewed during implementation planning and before a change is considered complete.

**Version**: 1.0.0 | **Ratified**: 2026-07-04 | **Last Amended**: 2026-07-04
