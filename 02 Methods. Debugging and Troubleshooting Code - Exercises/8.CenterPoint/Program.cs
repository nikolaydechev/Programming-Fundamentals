using System;

namespace _8.CenterPoint
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            CenterPoint();
        }

        static void CenterPoint()
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            double firstNumber = Math.Abs(X1) + Math.Abs(Y1);
            double secondNumber = Math.Abs(X2) + Math.Abs(Y2);

            if (firstNumber >= secondNumber)
            {
                Console.WriteLine("({0}, {1})", X2, Y2);
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine("({0}, {1})", X1, Y1);
            }
            
        }
    }
}
