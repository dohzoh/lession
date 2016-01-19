using System;

namespace ConsoleApplication28
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var year = int.Parse(s);
            if (MyDate.IsLeapYear(year))
                Console.WriteLine("{0}年は閏年です。", year);
            else
                Console.WriteLine("{0}年は閏年ではありません。", year);

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

        public static bool IsLeapYear(int year)
        {
            return (year%4 == 0) &&
                   ((year%100 != 0) || (year%400 == 0));
        }

        public bool IsLeapYear()
        {
            return IsLeapYear(Year);
        }
    }
}