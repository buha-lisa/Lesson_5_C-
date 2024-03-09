namespace cs5.Task1.Fibanachi
{
    internal class Numbers
    {
        public long fibonacci(long entered_number)
        {
            if (entered_number == 1 || entered_number == 2)
                return entered_number - 1;
            return fibonacci(entered_number - 1) +
                fibonacci(entered_number - 2);
        }
        public void Fibanachi()
        {
            Console.WriteLine("Fibanachi Numbres:");
            long entered_number = 12;
            for (int i = 1; i <= entered_number; i++)
            {
                Console.Write(fibonacci(i) + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
