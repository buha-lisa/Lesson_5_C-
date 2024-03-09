using T = cs5.Task2.Triangle;
using R = cs5.Task2.Rectangle;
using S = cs5.Task2.Square;
using F = cs5.Task1.Fibanachi;
using Pair = cs5.Task1.PairNumbers;
using Unpair = cs5.Task1.UnpairNumbers;
using Prime = cs5.Task1.PrimeNumbers;

namespace cs5
{
    internal class Program
    {
        static void Main()
        {
            while (true) 
            { 
                Console.Write("Choose number of task(1-4)\n0 to exit\nChoice: ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task) 
                {
                    case 1:
                        {
                            Pair.Numbers pair = new Pair.Numbers();
                            pair.Pair();
                            Unpair.Numbers unpair = new Unpair.Numbers();
                            unpair.UnPair();
                            Prime.Numbers prime = new Prime.Numbers();
                            prime.Prime();
                            F.Numbers fibanachi = new F.Numbers();
                            fibanachi.Fibanachi();

                            break;
                        }
                    case 2:
                        {
                            T.Figures triangle = new T.Figures();
                            triangle.Triangle();
                            R.Figures rectangle = new R.Figures();
                            rectangle.Rectangle();
                            S.Figures square = new S.Figures();
                            square.Square();

                            break;
                        }
                    case 3:
                        {
                            GuessNumber guess = new GuessNumber();
                            guess.Guess();

                            break;
                        }
                    case 4:
                        {
                            Pseudotext text = new Pseudotext();
                            text.ShowText();

                            break;
                        }
                }
                if (task == 0) break;
            }
        }
    }
}
