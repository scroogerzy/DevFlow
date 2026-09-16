# ADR 001: Use a Shared Backend API

## Status

Accepted

## Context

DevFlow is planned to support a browser application and potentially a future mobile application. Both clients need access to the same users, boards, columns, cards, and application logic.

Using separate backend logic for each client could create duplicated functionality and make the system harder to maintain.

## Decision

DevFlow will use a shared backend API as the communication layer between the browser application, future mobile application, and database.

The clients will communicate with the backend API, while the API will handle business logic and database communication.

## Consequences

### Positive

* The browser and future mobile application can use the same backend services.
* Business logic can be maintained in one place.
* The architecture is easier to extend to additional clients in the future.
* Database access remains controlled through the backend API.

### Negative

* The API becomes an important dependency for all clients.
* Changes to the API must be managed carefully to avoid breaking clients.
* Additional API development and testing will be required.
