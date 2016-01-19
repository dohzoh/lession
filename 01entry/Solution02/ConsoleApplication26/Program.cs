using System;

namespace ConsoleApplication26
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sc = new SampleClass();
            Console.WriteLine(sc.MaxNumber(10, 20));
            Console.WriteLine(sc.MaxNumber(10, 20, 30));
            int[] nums = {10, 5, 40, 8, 30, 10};
            Console.WriteLine(sc.MaxNumber(nums));

            Console.ReadLine();
        }
    }

    internal class SampleClass
    {
        public int MaxNumber(int x, int y)
        {
            return x > y ? x : y;
        }

        public int MaxNumber(int x, int y, int z)
        {
            if (x > y)
                return x > z ? x : z;
            return y > z ? y : z;
        }

        public int MaxNumber(int[] nums)
        {
            var m = nums[0];
            for (var i = 0; i < nums.Length; i++)
            {
                m = MaxNumber(m, nums[i]);
            }
            return m;
        }
    }
}