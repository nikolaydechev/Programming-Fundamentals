using System;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var num = FactorialNumber(number);
            Console.WriteLine(num);
        }

        public static BigInteger FactorialNumber(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
