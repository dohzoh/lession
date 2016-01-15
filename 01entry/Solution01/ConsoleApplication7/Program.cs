using System;

namespace ConsoleApplication7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var num = int.Parse(str);

            switch (num)
            {
                case 1:
                    Console.WriteLine(num + "が入力されました");
                    break;
                case 2:
                    Console.WriteLine(num + "が入力されました");
                    break;
                case 3:
                    Console.WriteLine(num + "が入力されました");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(num + "が入力されました");
                    break;

                default:
                    Console.WriteLine("1-6以外が入力されました");
                    break;
            }
        }
    }
}