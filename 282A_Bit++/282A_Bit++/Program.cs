using System;

namespace _282A_Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Int32.Parse(Console.ReadLine());
            int x = 0;

            for (int i = 0; i < n; i++)
            {
                var statements = Console.ReadLine();

                if (statements == "X++" || statements == "++X")
                    x++;
                else if (statements == "X--" || statements == "--X")
                    x--;
            }

            Console.WriteLine(x);
        }
    }
}
