namespace cs5
{
    internal class Pseudotext
    {
        public void ShowText()
        {
            Console.Write("Enter the amount of vowels in a word: ");
            int.TryParse(Console.ReadLine(), out int maxVowels);

            Console.Write("Enter the amount of consonants in a word: ");
            int.TryParse(Console.ReadLine(), out int maxConsonants);

            Console.Write("Enter the number of words to generate: ");
            int.TryParse(Console.ReadLine(), out int numWords);

            string pseudoText = GenerateText(maxVowels, maxConsonants, numWords);

            Console.WriteLine("Generated pseudo-text:");
            Console.WriteLine(pseudoText);
        }
        public string GenerateText(int Vowels, int Consonants, int numWords)
        {
            Random random = new Random();
            string vowels = "aeiou";
            string consonants = "bcdfghjklmnpqrstvwxyz";
            string pseudoText = "";

            for (int i = 0; i < numWords; i++)
            {
                int wordLength = random.Next(1, Vowels + Consonants + 1);
                string word = "";

                for (int j = 0; j < wordLength; j++)
                {
                    if (random.Next(2) == 0 && Vowels > 0)
                    {
                        word += vowels[random.Next(vowels.Length)];
                        Vowels--;
                    }
                    else if (Consonants > 0)
                    {
                        word += consonants[random.Next(consonants.Length)];
                        Consonants--;
                    }
                    else
                    {
                        word += vowels[random.Next(vowels.Length)];
                        Vowels--;
                    }
                }
                pseudoText += word + " ";
            }

            return pseudoText;
        }
    }
}
