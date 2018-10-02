using System;

namespace CopyValueAndReferenceTypes
{
    class Rectangle
    {
        public static string ShapeName
        {
            get { return "Rectangle"; }
        }

        public double Length { get; set; }
        public double Width { get; set; }
        public double GetArea()
        {
            return this.Length * this.Width;
        }
    }

    struct Point
    {
        public double X, Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 20;
            Point p2 = p1;
            p2.X = 100;
            Console.WriteLine("p1.X = {0}", p1.X);
            Rectangle rect1 = new Rectangle
                { Length = 10.0, Width = 20.0 };
            Rectangle rect2 = rect1;
            rect2.Length = 100.0;
            Console.WriteLine("rect1.Length = {0}",
                rect1.Length);
        }
    }
}
