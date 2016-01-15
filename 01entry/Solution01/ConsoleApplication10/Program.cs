using System;

namespace ConsoleApplication10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var nums = new int[10];
            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] = i*i;
            }
            for (var i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("{0}", nums[i]);
            }

            Console.ReadLine();
        }
    }
}