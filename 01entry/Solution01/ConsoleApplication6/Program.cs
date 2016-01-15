using System;

namespace ConsoleApplication6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (var i = 1; i <= 50; i++)
            {
                if ((i%4 == 0) && (i%6 != 0))
                    Console.WriteLine("{0}", i);
            }
        }
    }
}