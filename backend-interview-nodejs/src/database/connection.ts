// This is your Prisma configuration file.
// Learn more about it in the docs: https://pris.ly/d/prisma-config

import { PrismaClient } from '@prisma/client'

declare global {
  var prisma: PrismaClient | undefined
}

export const prisma =
  global.prisma ||
  new PrismaClient({
    log: ['query'],
  })

if (process.env.NODE_ENV !== 'production') {
  global.prisma = prisma
}
