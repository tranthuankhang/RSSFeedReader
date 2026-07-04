# Subscription API Contract

## Endpoints

### POST /api/subscriptions

Adds a new subscription.

#### Request Body

```json
{
  "feedUrl": "https://example.com/feed"
}
```

#### Success Response

- Status: 200 OK
- Body:

```json
{
  "id": "1",
  "feedUrl": "https://example.com/feed"
}
```

#### Validation Errors

- Status: 400 Bad Request when the feed URL is empty or whitespace-only.

### GET /api/subscriptions

Returns the current list of subscriptions.

#### Success Response

- Status: 200 OK
- Body:

```json
[
  {
    "id": "1",
    "feedUrl": "https://example.com/feed"
  }
]
```
