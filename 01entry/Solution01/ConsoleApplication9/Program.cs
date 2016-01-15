using System;

namespace ConsoleApplication9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var s = Console.ReadLine();
            while (true)
            {
                if (s == "quit")
                    break;

                Console.WriteLine(s.Length);
                s = Console.ReadLine();
            }

            for (var i = 0; i < 100; i++)
            {
                if (i%13 != 0)
                    continue;
                Console.WriteLine("{0}は13で割り切れる数です", i);
            }
        }
    }
}