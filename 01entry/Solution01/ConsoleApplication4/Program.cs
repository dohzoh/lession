using System;

namespace ConsoleApplication4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("平成　西暦　");
            var year = 1;
            while (year <= 16)
            {
                Console.WriteLine(" {0} {1} ", year, year + 1988);
                year = year + 1;
            }
        }
    }
}