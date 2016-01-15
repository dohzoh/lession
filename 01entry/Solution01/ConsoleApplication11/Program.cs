using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] {0, 2, 4, 6, 8, 10,};

            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
