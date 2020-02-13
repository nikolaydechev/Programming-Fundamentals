using System;

namespace Math_Power
{
    class Program
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double output = MathPower(number, power);
            Console.WriteLine(output);
        }

        public static double MathPower(double number, double power)
        {
            double result = 0D;
            result = Math.Pow(number, power);

            return result;
        }
    }
}
