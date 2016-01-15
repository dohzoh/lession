using System;

namespace ConsoleApplication16
{
    internal class Program
    {
        /// <summary>
        ///     各種演算子
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var x = 4;
            var y = 8;

            Console.WriteLine(!(x == 4));
            Console.WriteLine((x == 4) ^ (y == 8));
            Console.WriteLine("{0:x8}", x ^ 7);
            Console.WriteLine("{0:x8}, {1:x8}", x, ~x);
            Console.WriteLine("{0:x8}", x & y);
            Console.WriteLine("{0:x8}", x | y);
            Console.WriteLine((x == 4) && (y == 8));
            Console.WriteLine((x == 4) || (y == 8));
            Console.WriteLine("{0:x8}", x << 1);
            Console.WriteLine("{0:x8}", x >> 1);

            Console.ReadLine();
        }
    }
}