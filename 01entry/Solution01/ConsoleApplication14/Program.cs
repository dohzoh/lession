using System;

namespace ConsoleApplication14
{
    internal class Program
    {
        /// <summary>
        ///     キャストについて
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var a = 10;
            var b = 4;
            var n1 = a/b;

            double n2 = a/b;
            var n3 = (double) a/b;

            Console.WriteLine("{0}, {1}, {2}", n1, n2, n3);
            Console.ReadLine();
        }
    }
}