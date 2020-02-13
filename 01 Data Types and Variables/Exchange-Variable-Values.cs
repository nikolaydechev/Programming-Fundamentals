using System;

namespace Exchange_Variable_Values
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:\na = {0} \nb = {1}", a, b);
            Console.WriteLine("After:\na = {0} \nb = {1}", b, a);
        }
    }
}
