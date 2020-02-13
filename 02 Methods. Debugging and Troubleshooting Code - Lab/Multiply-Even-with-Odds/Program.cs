using System;

namespace Multiply_Even_with_Odds
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int output = GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(output);
        }

        public static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumOdds = GetSumOfOddDigits(n);
            int sumEvens = GetSumOfEvenDigits(n);
            return sumOdds * sumEvens;
        }

        public static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n = n / 10; // n /= 10;
            }

            return sum;
        }

        public static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }

            return sum;
        }
    }
}

