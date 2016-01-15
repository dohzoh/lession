using System;

namespace ConsoleApplication5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("平成　西暦　");
            for (var year = 1; year <= 16; year++)
            {
                Console.WriteLine(" {0} {1}", year, year + 1988);
            }
        }
    }
}