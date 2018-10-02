using System;

namespace CreateAbstractClasses
{
    abstract class Polygon
    {
        public double Length { get; protected set; }
        public double Width { get; protected set; }
        abstract public double GetArea();
    }

    class Rectangle : Polygon
    {
        public Rectangle(double length, double width) // constructor
        {
            Length = length; // Length (with capital L) is defined in Polygon class!!
            Width = width;
        }
        public override double GetArea()
        {
            return Width * Length;
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
            Rectangle rect = new Rectangle(10, 20);
            Console.WriteLine(
                "Width={0}, Length={1}, Area = {2}",
                rect.Width, rect.Length, rect.GetArea());
        }
    }
}
