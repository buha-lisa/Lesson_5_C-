namespace cs5.Task2.Rectangle
{
    internal class Figures
    {
        public void Rectangle()
        {
            Console.WriteLine("Rectangle");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }
    }
}
