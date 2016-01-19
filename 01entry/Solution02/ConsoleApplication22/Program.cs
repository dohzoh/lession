using System;

namespace ConsoleApplication22
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
        public int day;
        public int month;
        public int year;

        public void setDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public void PrintDate()
        {
            Console.WriteLine("{0:D4}年{1:D2}月{2:D2}日", year, month, day);
        }
    }
}