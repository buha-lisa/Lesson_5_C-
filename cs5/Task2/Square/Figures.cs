namespace cs5.Task2.Square
{
    internal class Figures
    {
        public void Square()
        {
            Console.WriteLine("Square");
            for (int i = 0; i < 10; i++)
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
