using System;

namespace ConsoleApplication29
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var count1 = new Counter();
            var count2 = new Counter();

            Console.WriteLine(Counter.InstanceCount);
            Console.ReadLine();
        }
    }

    internal class Counter
    {
        public Counter()
        {
            InstanceCount++;
        }

        public static int InstanceCount { get; private set; }
    }
}