# QuickNotes API Documentation

## POST /api/signup

### Description

Creates a new QuickNotes user account and sends an email verification message.

## Authentication

No authentication is required because this endpoint is used to create a new account.

## Request Body

{
  "email": "user@example.com",
  "password": "password123"
}

| Parameter | Type   | Required | Description                         |
| --------- | ------ | -------- | ----------------------------------- |
| email     | string | Yes      | User's email address                |
| password  | string | Yes      | Password with at least 8 characters |

## Responses

201 Created

Returned when the account is successfully created.

{
  "id": 123
}

400 Bad Request

Returned when the email is invalid or the password is shorter than eight characters.

{
  "error": "invalid"
}

409 Conflict

Returned when an account with the email address already exists.

{
  "error": "exists"
}
