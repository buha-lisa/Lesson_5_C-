namespace cs5
{
    internal class GuessNumber
    {
        public void Guess()
        {
            Console.Write("Enter your number: ");
            int guess = int.Parse(Console.ReadLine());
            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {
                Random rnd = new Random();
                int guessNumber = rnd.Next(1, 10);
                Console.Write("Guess: ");
                Console.WriteLine(guessNumber);
                if (guess > guessNumber)
                {
                    Console.WriteLine("Too low!\n");
                }
                else if (guess < guessNumber)
                {
                    Console.WriteLine("Too high!\n");
                }
                else
                {
                    Console.WriteLine("Congratulations!");
                    guessedCorrectly = true;
                }
            }
            Console.WriteLine("\n");
        }     
    }
}
