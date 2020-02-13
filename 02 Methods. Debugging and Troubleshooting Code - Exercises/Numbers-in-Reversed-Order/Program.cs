using System;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        public static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string reversed = ReversedNumber(number);
            Console.WriteLine(reversed);
        }

        public static string ReversedNumber(string number)
        {
            string result = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += number[i];
            }
            return result;
        }
    }
}
