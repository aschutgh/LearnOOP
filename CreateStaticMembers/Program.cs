using System;

namespace CreateStaticMembers
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

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle
            { Length = 10.0, Width = 20.0 };
            Console.WriteLine("Shape Name: {0}, Area: {1}",
                Rectangle.ShapeName,
                rect.GetArea());
        }
    }
}
