using System;

namespace ConsoleApplication21
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dates = new MyDate[2];
            dates[0] = new MyDate();
            dates[0].year = 2004;
            dates[0].month = 12;
            dates[0].day = 27;
            dates[1] = new MyDate();
            dates[1].year = 2005;
            dates[1].month = 1;
            dates[1].day = 10;
            foreach (var dt in dates)
                PrintDate(dt);
        }

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