namespace cs5.Task1.PrimeNumbers
{
    internal class Numbers
    {
        public static bool IsPrimeNumber(int n)
        {
            bool result = true;
            if (n > 1)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        public void Prime()
        {
            Console.WriteLine("Prime Numbres:");
            for (int i = 0; i < 100; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
