# C# (.NET) Betting API Interview Template

This is a starter template for the AI-assisted coding challenge.

## Setup Instructions

1.  **Prerequisites**:
    *   .NET 9 SDK
    *   Docker Desktop

2.  **Run the database**:
    Open a terminal in the `backend-interview-csharp` directory and run:
    ```bash
    docker-compose up -d
    ```

3.  **Run the application**:
    Navigate to `src/BettingAPI` and run:
    ```bash
    dotnet run
    ```

4.  **API Documentation**:
    Once the application is running, you can access the Swagger UI for API documentation and testing at:
    `https://localhost:<port>/swagger` (check the terminal output for the correct port).

## API Testing

You can use the Swagger UI or a tool like Postman to send requests to the API.

**Example `POST /api/bets` request:**

```json
{
  "playerId": "a0eebc99-9c0b-4ef8-bb6d-6bb9bd380a11",
  "amount": 100.50,
  "gameId": "a0eebc99-9c0b-4ef8-bb6d-6bb9bd380a12",
  "betType": "straight"
}
```
