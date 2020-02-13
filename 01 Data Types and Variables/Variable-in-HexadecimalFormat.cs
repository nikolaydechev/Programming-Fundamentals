using System;

namespace Variable_in_HexadecimalFormat
{
    class Program
    {
        public static void Main(string[] args)
        {
            string HexValue = Console.ReadLine();
            Console.WriteLine("{0}", Convert.ToInt32(HexValue, 16));
        }
    }
}
