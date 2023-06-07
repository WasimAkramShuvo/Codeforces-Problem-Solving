using System;

namespace _112A_PetyaAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Console.ReadLine();
            var y = Console.ReadLine();

            var result = String.Compare(x, y, StringComparison.OrdinalIgnoreCase);

            if(result < 0)
                Console.WriteLine(-1);
            else if(result > 0)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}
