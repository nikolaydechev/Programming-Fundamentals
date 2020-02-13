using System;

namespace _12.MasterNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigits(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPalindrome(int num)
        {
            bool Palindrome = true;
            var n = num;
            var rev = 0;

            while (num > 0)
            {
                var dig = num % 10;
                rev = rev * 10 + dig;
                num = num / 10;
            }

            if (n == rev)
            {
                Palindrome = true;
            }
            else
            {
                Palindrome = false;
            }

            return Palindrome;
        }

        public static bool SumOfDigits(int num)
        {
            bool sevenDivider = true;
            var temp = 0;
            while (num > 0 && sevenDivider == true)
            {
                var digit = num % 10;
                temp = temp + digit;
                num = num / 10;
            }
            if (temp % 7 == 0)
            {
                sevenDivider = true;
            }
            else
            {
                sevenDivider = false;
            }
            return sevenDivider;
        }

        public static bool ContainsEvenDigits(int num)
        {
            bool EvenDigit = true;

            while (num > 0)
            {
                var digit = num % 10;

                num = num / 10;
                if (digit % 2 == 0)
                {
                    EvenDigit = true;
                    break;
                }
                else
                {
                    EvenDigit = false;
                }
            }
            return EvenDigit;
        }
    }
}
