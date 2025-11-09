# Node.js/TypeScript Betting API Interview Template

This is a starter template for the AI-assisted coding challenge.

## Setup Instructions

1.  **Prerequisites**:
    *   Node.js v18+
    *   Docker Desktop

2.  **Install dependencies**:
    Open a terminal in the `backend-interview-nodejs` directory and run:
    ```bash
    npm install
    ```

3.  **Run the database**:
    ```bash
    docker-compose up -d
    ```

4.  **Database migration**:
    ```bash
    npx prisma migrate dev --name init
    ```

5.  **Run the application**:
    ```bash
    npm run dev
    ```
    (You will need to add a `dev` script to `package.json`: `"dev": "nodemon src/index.ts"`)

6.  **API Documentation**:
    The API is running at `http://localhost:3000`.

## API Testing

You can use a tool like Postman or `curl` to send requests to the API.

**Example `POST /api/bets` request:**

```json
{
  "playerId": "a0eebc99-9c0b-4ef8-bb6d-6bb9bd380a11",
  "amount": 100.50,
  "gameId": "a0eebc99-9c0b-4ef8-bb6d-6bb9bd380a12",
  "betType": "straight"
}
```
