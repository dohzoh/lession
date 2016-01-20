using System;

namespace ConsoleApplication03
{
    internal class Program
    {
        /// <summary>
        ///     与えられた数字のケタ数
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.WriteLine("整数を入力してください。");
            try
            {
                var read = Console.ReadLine();
                var input = int.Parse(read);
                if (input < 0) input *= -1;
                Console.WriteLine("入力値: " + input);

                // get digit
                var digit = input.ToString().Length;
                var digits = Math.Pow(10, (digit - 1));

                Console.WriteLine("{0}桁で最大桁は{1}の位です。", digit, digits);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //throw;
            }
            finally
            {
                Console.WriteLine("Finished");
                Console.ReadLine();
            }
        }
    }
}