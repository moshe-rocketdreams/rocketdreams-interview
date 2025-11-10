import express from 'express';
import betsRouter from './routes/bets';
import { prisma } from './database/connection';

const app = express();
const port = process.env.PORT || 3000;

app.use(express.json());
app.use('/api/bets', betsRouter);

const startServer = async () => {
  try {
    await prisma.$connect();
    console.log('Successfully connected to the database.');
    app.listen(port, () => {
      console.log(`Server is running on port ${port}`);
    });
  } catch (error) {
    console.error('Failed to connect to the database. Application is shutting down.', error);
    process.exit(1);
  }
};

startServer();
