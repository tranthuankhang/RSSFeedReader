# Tasks: MVP RSS Reader

**Input**: Design documents from `/specs/001-rss-reader/`

**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md, contracts/

**Organization**: Tasks are grouped by user story to enable independent implementation and testing of each story.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (e.g., US1, US2)
- Include exact file paths in descriptions

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Create the project structure and baseline configuration for the MVP.

- [x] T001 Create backend and frontend project directories per the implementation plan
- [x] T002 Initialize the ASP.NET Core Web API backend project with the required dependencies
- [x] T003 [P] Initialize the Blazor WebAssembly frontend project with the required dependencies
- [x] T004 [P] Configure solution-level project references and basic launch settings for local development

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Create the shared infrastructure that the MVP depends on before any story implementation begins.

- [x] T005 Create the subscription model in backend/src/Models/Subscription.cs
- [x] T006 Create an in-memory subscription service in backend/src/Services/SubscriptionService.cs
- [x] T007 Implement the backend API controller for subscriptions in backend/src/Controllers/SubscriptionsController.cs
- [x] T008 Configure backend routing and minimal JSON response behavior in backend/src/Program.cs
- [x] T009 [P] Configure frontend API client and base URL settings in frontend/src/Services/SubscriptionApiClient.cs and frontend/src/wwwroot/appsettings.json
- [x] T010 [P] Create the main subscription page component in frontend/src/Pages/Subscriptions.razor

**Checkpoint**: Foundation ready - the MVP subscription flow can now be implemented.

---

## Phase 3: User Story 1 - Add a feed subscription (Priority: P1) 🎯 MVP

**Goal**: Let a user add a subscription and see it appear in the UI list.

**Independent Test**: A user can enter a feed URL, submit it, and see the new subscription appear immediately in the app.

### Tests for User Story 1

- [x] T011 [P] [US1] Add a backend unit test for valid subscription creation in backend/tests/SubscriptionServiceTests.cs
- [x] T012 [P] [US1] Add a backend unit test for rejecting empty input in backend/tests/SubscriptionServiceTests.cs

### Implementation for User Story 1

- [x] T013 [US1] Implement subscription creation logic in backend/src/Services/SubscriptionService.cs
- [x] T014 [US1] Implement POST /api/subscriptions in backend/src/Controllers/SubscriptionsController.cs
- [x] T015 [US1] Implement frontend form submission and local state updates in frontend/src/Pages/Subscriptions.razor
- [x] T016 [US1] Implement frontend loading of the current subscription list in frontend/src/Pages/Subscriptions.razor
- [x] T017 [US1] Add basic empty-state messaging in frontend/src/Pages/Subscriptions.razor

**Checkpoint**: User Story 1 should now be fully functional and independently testable.

---

## Phase 4: Polish & Cross-Cutting Concerns

**Purpose**: Improve consistency and verify the MVP end to end.

- [x] T018 [P] Update documentation in README.md and the feature quickstart guide
- [x] T019 Run the backend and frontend locally and verify the add-subscription flow end to end
- [x] T020 Refactor for clarity and remove any temporary placeholder code in the backend and frontend projects

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies - can start immediately
- **Foundational (Phase 2)**: Depends on Setup completion - BLOCKS the story implementation
- **User Story 1 (Phase 3)**: Depends on Foundational completion
- **Polish (Phase 4)**: Depends on User Story 1 completion

### Parallel Opportunities

- T003 and T004 can be completed in parallel during setup
- T009 and T010 can be completed in parallel during foundational work
- T011 and T012 can be completed in parallel during test creation

## Implementation Strategy

### MVP First

1. Complete Phase 1: Setup
2. Complete Phase 2: Foundational
3. Complete Phase 3: User Story 1
4. Stop and validate the add-subscription flow end to end
5. Complete Phase 4: Polish only after the MVP is working
