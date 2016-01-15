using System;

namespace ConsoleApplication12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var s1 = "C#World";
            for (var i = 0; i < s1.Length; i++)
            {
                var ch = s1[i];
                Console.WriteLine(ch);
            }

            var s2 = "メルマガ";
            for (var i = 0; i < s2.Length; i++)
            {
                var ch = s2[i];
                Console.WriteLine(ch);
            }

            Console.ReadLine();
        }
    }
}