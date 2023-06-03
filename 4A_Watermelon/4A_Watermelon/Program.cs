using System;

namespace _4A_Watermelon
{
    class Program
    {
        public static void Main(string[] args)
        {
            var n = Int32.Parse(Console.ReadLine());

            if (n % 2 == 0 && n > 2 && (n - 2) % 2 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
