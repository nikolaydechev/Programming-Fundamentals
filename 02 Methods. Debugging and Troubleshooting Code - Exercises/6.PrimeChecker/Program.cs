using System;

namespace _6.PrimeChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            if (IsPrime(number))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static bool IsPrime(long n)
        {
            if (n == 1)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            
            for (int i = 3; i <= Math.Sqrt(n); i+=2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
