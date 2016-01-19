using System;

namespace ConsoleApplication24
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dates = new MyDate[2];
            dates[0] = new MyDate();
            dates[0].setDate(2004, 12, 27);
            dates[1] = new MyDate();
            dates[1].setDate(2005, 1, 7);
            foreach (var dt in dates)
                dt.PrintDate();
        }
    }

    /// <summary>
    ///     date object
    /// </summary>
    internal class MyDate
    {
        public int Year { get; private set; }

        public int Month { get; private set; }

        public int Day { get; private set; }

        public void setDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public void PrintDate()
        {
            Console.WriteLine(Format());
        }

        public string Format()
        {
            return string.Format("{0:D4}年{1:D2}月{2:D2}日", Year, Month, Day);
        }
    }
}