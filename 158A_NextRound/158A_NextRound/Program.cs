using System;

namespace _158A_NextRound
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split();
            var n = int.Parse(input1[0]);
            var k = int.Parse(input1[1]);

            var input2 = Console.ReadLine().Split();
            var scores = new int[n];

            for (int i = 0; i < n; i++)
            {
                scores[i] = int.Parse(input2[i]);
            }

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (scores[i] > 0 && scores[i] >= scores[k - 1])
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
