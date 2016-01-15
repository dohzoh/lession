using System;

namespace ConsoleApplication13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const char slash = '/';
            const int capacity = 5;

            var s = Console.ReadLine();
            var col = 0;
            var buf = "";

            foreach (var ch in s)
            {
                col++;
                if (col > capacity)
                {
                    buf += slash;
                    col = 1;
                }
                buf += ch;
            }

            Console.WriteLine(buf);
            Console.ReadLine();
        }
    }
}