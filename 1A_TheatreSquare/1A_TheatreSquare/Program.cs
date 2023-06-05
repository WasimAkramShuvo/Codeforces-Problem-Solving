using System;

namespace _1A_TheatreSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split();
            var n = long.Parse(inputs[0]);
            var m = long.Parse(inputs[1]);
            var a = long.Parse(inputs[2]);

            var row = n/a;
            if(n%a != 0)
            {
                row++;
            }

            var col = m/a;
            if(m % a != 0)
            {
                col++;
            }

            Console.WriteLine(row*col);
        }
    }
}
