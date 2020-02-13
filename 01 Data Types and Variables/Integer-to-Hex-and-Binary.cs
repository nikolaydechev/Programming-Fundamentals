using System;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string hexValue = number.ToString("X");
            Console.WriteLine(hexValue);

            string binary = Convert.ToString(number, 2);
            Console.WriteLine(binary);
        }
    }
}
