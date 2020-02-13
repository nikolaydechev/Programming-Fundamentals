using System;

namespace _11.GeometryCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            string Figure = Console.ReadLine();

            if (Figure == "triangle")
            {
                Triangle();
            }
            else if (Figure == "square")
            {
                Square();
            }
            else if (Figure == "rectangle")
            {
                Rectangle();
            }
            else if (Figure == "circle")
            {
                Circle();
            }
        }

        public static void Triangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double areaTriangle = (height * side) / 2;
            Console.WriteLine("{0:f2}", areaTriangle);
        }

        public static void Square()
        {
            double side = double.Parse(Console.ReadLine());

            double areaSquare = Math.Pow(side, 2);
            Console.WriteLine("{0:f2}", areaSquare);
        }

        public static void Rectangle()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double areaRectangle = width * height;
            Console.WriteLine("{0:f2}", areaRectangle);
        }

        public static void Circle()
        {
            double radius = double.Parse(Console.ReadLine());

            double areaCircle = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("{0:f2}", areaCircle);
        }
    }
}
