namespace cs5.Task1.UnpairNumbers
{
    internal class Numbers
    {
        public void UnPair()
        {
            Console.WriteLine("Unpair Numbres:");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
