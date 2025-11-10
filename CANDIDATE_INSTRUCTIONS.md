# Backend Developer Coding Challenge

Welcome to the coding challenge!

You'll have 40 minutes to implement a betting API endpoint. Feel free to use any AI coding assistant - we're interested in seeing how you leverage AI tools to solve problems efficiently.

Let's start by exploring the codebase structure. You can choose either the C# (.NET) or Node.js/TypeScript template. Please refer to the `README.md` file within your chosen project folder for detailed setup instructions.

Good luck!

---

## Your Task: Implement a Betting API

Your goal is to implement a betting API endpoint that allows players to place bets. The endpoint must validate that the player has a sufficient balance, deduct the bet amount, and create a transaction record. All of these operations must be atomic (i.e., they all succeed or all fail together).

### API Endpoint Requirements

**Request:** `POST /api/bets`

**Request Body:**
```json
{
  "playerId": "guid",
  "amount": 100.50,
  "gameId": "guid",
  "betType": "straight"
}
```

**Success Response (HTTP 200 OK):**
```json
{
  "betId": "guid",
  "playerId": "guid",
  "amount": 100.50,
  "remainingBalance": 899.50,
  "timestamp": "2025-01-15T10:30:00Z"
}
```

**Error Responses:**
-   **400 Bad Request**: Invalid request (e.g., missing fields, negative amount).
-   **404 Not Found**: Player not found.
-   **409 Conflict**: Insufficient balance.
-   **500 Internal Server Error**: Any other server-side error.

---

### Business Rules

1.  The player must exist in the database.
2.  The player's balance must be greater than or equal to the bet amount.
3.  The balance deduction and the creation of the transaction record must be atomic.
4.  The minimum bet amount is **$1.00**.
5.  The maximum bet amount is **$10,000.00**.
