using System;

namespace _231A_Team
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Int32.Parse(Console.ReadLine());
            var finalResult = 0;

            for(int i = 0; i < n; i++)
            {
                var options = Console.ReadLine().Split();

                var petya = Int32.Parse(options[0]);
                var vasya = Int32.Parse(options[1]);
                var tonya = Int32.Parse(options[2]);

                if(petya + vasya + tonya >= 2)
                {
                    finalResult++;
                }
            }

            Console.WriteLine(finalResult);
        }
    }
}
