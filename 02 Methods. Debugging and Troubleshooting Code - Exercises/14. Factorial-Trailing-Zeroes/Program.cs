using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = FactorialNumber(number);
            int count = TrailingZeroesCount(factorial);
            Console.WriteLine(count);
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

        public static int TrailingZeroesCount(BigInteger num)
        {
            var count = 0;
            bool hasZeroes = true;
            
            while (hasZeroes == true)
            {
                BigInteger digit = num % 10;
                num = num / 10;
                if (digit == 0)
                {
                count++;
                }
                else
                {
                    hasZeroes = false;
                }
            }
            return count;
        }
    }
}
