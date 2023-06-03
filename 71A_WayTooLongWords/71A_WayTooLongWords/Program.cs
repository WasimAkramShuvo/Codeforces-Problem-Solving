using System;

namespace _71A_WayTooLongWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                var abbreviation = GetAbbreviation(word);
                Console.WriteLine(abbreviation);
            }
        }

        public static string GetAbbreviation(string word)
        {
            if (word.Length > 10)
            {
                return $"{word[0]}{word.Length - 2}{word[^1]}";
            }
            else
            {
                return word;
            }
        }
    }
}
