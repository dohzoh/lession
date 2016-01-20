using System;
using System.Text;

namespace ConsoleApplication01
{
    internal class Program
    {
        /// <summary>
        ///     ピラミッドを作る
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("整数を入力してください。");
                var read = Console.ReadLine();
                var input = int.Parse(read);
                if (input < 0) input *= -1;

                for (var i = 1; i <= input; i++)
                {
                    var line = "";
                    // write space
                    line += new string(' ', input - i);

                    // write star
                    var max = 1 + 2 * (i - 1);
                    line += new string('*', max);

                    Console.WriteLine(line);
                }
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