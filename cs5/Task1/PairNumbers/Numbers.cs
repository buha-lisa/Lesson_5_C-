﻿namespace cs5.Task1.PairNumbers
{
    internal class Numbers
    {
        public void Pair()
        {
            Console.WriteLine("Pair Numbres:");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
