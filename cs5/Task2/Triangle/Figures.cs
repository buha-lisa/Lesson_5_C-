namespace cs5.Task2.Triangle
{
    internal class Figures
    {
        public void Triangle()
        {
            Console.WriteLine("Triangle");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
    }
}
