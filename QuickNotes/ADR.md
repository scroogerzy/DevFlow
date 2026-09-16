## ADR: Use BCrypt with 10 Work Factor
## Title

Use BCrypt with a work factor of 10 for password hashing.

## Status

Accepted

## Context

QuickNotes needs to store user passwords securely. Passwords should never be stored as plain text because a database compromise could expose user credentials.

## Decision

Use BCrypt with a work factor of 10 when creating password hashes.

## Consequences

Passwords are stored as hashes instead of plain text, improving account security.

The work factor increases the computational effort required to crack passwords. However, password hashing also requires additional processing time during account registration. This is an acceptable security trade-off for protecting user credentials.