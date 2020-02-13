using System;

namespace Calculate_Triangle_Area
{
    class Program
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = TriangleArea(width, height);
            Console.WriteLine(area);
        }

        public static double TriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
