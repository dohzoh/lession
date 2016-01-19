using System;

namespace ConsoleApplication27
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dates = new MyDate[2];
            dates[0] = new MyDate(2004, 12, 27);
            dates[1] = new MyDate(2005, 1, 7);
            foreach (var dt in dates)
                dt.PrintDate();

            Console.ReadLine();
        }
    }

    internal class MyDate
    {
        public MyDate(int y, int m, int d)
        {
            Year = y;
            Month = m;
            Day = d;
        }

        public int Year { get; }
        public int Month { get; }
        public int Day { get; }

        private string Format()
        {
            return string.Format("{0:D4}/{1:D2}/{2:D2}", Year, Month, Day);
        }

        public void PrintDate()
        {
            Console.WriteLine(Format());
        }
    }
}