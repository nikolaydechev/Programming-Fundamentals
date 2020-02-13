using System;

namespace _7.Primes_in_GivenRange
{
    class Program
    {
        public static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            bool Primer = false;
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i) && Primer == false)
                {
                    Console.Write("{0}", i);
                    Primer = true;
                }
                else if (IsPrime(i) && Primer == true)
                {
                    Console.Write(", {0}", i);
                }
            }
            Console.WriteLine();
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

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
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
