import express from 'express';
import betsRouter from './routes/bets';

const app = express();
const port = process.env.PORT || 3000;

app.use(express.json());
app.use('/api/bets', betsRouter);

app.listen(port, () => {
  console.log(`Server is running on port ${port}`);
});
