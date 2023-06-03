using System;

namespace _50A_DominoPiling
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split();
            var m = Int32.Parse(dimensions[0]);
            var n = Int32.Parse(dimensions[1]);

            int result = (m * n) / 2;

            Console.WriteLine(result);
        }
    }
}
