using System;

namespace ComparingFloats
{
    class Program
    {
        public static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            if (numberA > numberB)
            {
                if (numberA - numberB > 0.000001)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    Console.WriteLine("True");
                }
            }
            if (numberA < numberB)
            {
                if (numberB - numberA > 0.000001)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    Console.WriteLine("True");
                }
            }

        }
    }
}
