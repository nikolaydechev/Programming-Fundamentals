using System;

namespace MaxMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            var BiggerNumber = GetMax(firstNumber, secondNumber);
            var BiggestNumber = GetMax(BiggerNumber, thirdNumber);

            Console.WriteLine(BiggestNumber);
            
        }

        public static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
