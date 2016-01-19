using System;

namespace ConsoleApplication35
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var tri = new Triangle(10, 4);
            Console.WriteLine(tri.getArea());

            var rec = new Rectangle(10, 4);
            Console.WriteLine(rec.getArea());

            Console.ReadLine();
        }
    }

    internal class Shape
    {
        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double X { get; protected set; }
        public double Y { get; protected set; }
    }

    /// <summary>
    ///     get area for triangle
    /// </summary>
    internal class Triangle : Shape
    {
        public Triangle(int x, int y) : base(x, y)
        {
        }

        public double getArea()
        {
            return X*Y/2;
        }
    }

    /// <summary>
    ///     get area for triangle
    /// </summary>
    internal class Rectangle : Shape
    {
        public Rectangle(int x, int y) : base(x, y)
        {
        }

        public double getArea()
        {
            return X*Y;
        }
    }
}