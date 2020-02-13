using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            double X3 = double.Parse(Console.ReadLine());
            double Y3 = double.Parse(Console.ReadLine());
            double X4 = double.Parse(Console.ReadLine());
            double Y4 = double.Parse(Console.ReadLine());

            double firstLineLenght = LongerLine(X1, Y1, X2, Y2);
            double secondLineLenght = LongerLine(X3, Y3, X4, Y4);

            if (firstLineLenght > secondLineLenght)
            {
                PrintPoint(X1, Y1, X2, Y2);
            }
            else if (firstLineLenght < secondLineLenght)
            {
                PrintPoint(X3, Y3, X4, Y4);
            }
            else if (firstLineLenght == secondLineLenght)
            {
                PrintPoint(X1, Y1, X2, Y2);
            }

        }

        public static double LongerLine(double X1, double Y1, double X2, double Y2)
        {
            var distance = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));
            return distance;
        }

        public static void PrintPoint(double X1, double Y1, double X2, double Y2)
        {
            double firstPointsDistanceToZero = LongerLine(X1, Y1, 0, 0);
            double secondPointsDistanceToZero = LongerLine(X2, Y2, 0, 0);

            if (firstPointsDistanceToZero <= secondPointsDistanceToZero)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", X1, Y1, X2, Y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", X2, Y2, X1, Y1);
            }
        }

    }
}
