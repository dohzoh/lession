using System;

namespace ConsoleApplication18
{
    internal class Program
    {
        /// <summary>
        ///     関数
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var yard = double.Parse(s);
            var meter = YardToMeter(yard);

            Console.WriteLine(meter);

            Console.ReadLine();
        }


        private static double YardToMeter(double yd)
        {
            var meter = yd*0.9144;
            return meter;
        }
    }
}