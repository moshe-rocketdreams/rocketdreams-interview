// This is your Prisma configuration file.
// Learn more about it in the docs: https://pris.ly/d/prisma-config
import "dotenv/config";

import { PrismaClient } from '@prisma/client'

declare global {
  var prisma: PrismaClient;
}

import { defineConfig, env } from "prisma/config";

export default defineConfig({
  schema: "prisma/schema.prisma",
  migrations: {
    path: "prisma/migrations",
  },
  engine: "classic",
  datasource: {
    url: env("DATABASE_URL"),
  },
});
