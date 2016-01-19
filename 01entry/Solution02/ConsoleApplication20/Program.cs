using System;

namespace ConsoleApplication20
{
    internal class Program
    {
        /// <summary>
        ///     クラスの利用
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            MyDate date;
            date = new MyDate();
            date.year = 2004;
            date.month = 2;
            date.day = 7;
            PrintDate(date);
        }

        /// <summary>
        ///     display date
        /// </summary>
        /// <param name="date">MyDate Class</param>
        private static void PrintDate(MyDate date)
        {
            Console.WriteLine("{0:D4}年{1:D2}月{2:D2}日", date.year, date.month, date.day);
        }
    }

    /// <summary>
    ///     date object
    /// </summary>
    internal class MyDate
    {
        public int day;
        public int month;
        public int year;
    }
}