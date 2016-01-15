using System;

namespace ConsoleApplication19
{
    internal class Program
    {
        /// <summary>
        ///     関数（値渡し）
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var num = 10;
            Add(num);
            Console.WriteLine(num);

            Console.ReadLine();
        }

        /// <summary>
        ///     入力値に１加える
        /// </summary>
        /// <param name="num">任意整数値</param>
        private static void Add(int num)
        {
            num += 1;
        }
    }
}