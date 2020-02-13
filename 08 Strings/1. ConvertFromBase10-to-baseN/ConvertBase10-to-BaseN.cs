namespace _1.ConvertFromBase10_to_baseN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class ConvertBase10_to_BaseN
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').ToArray();

            var remStack = new List<string>();

            var baseN = BigInteger.Parse(numbers[0]);
            var decimalNumber = BigInteger.Parse(numbers[1]);

            BigInteger remainder = 0;

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % baseN;
                remStack.Add(remainder.ToString());
                decimalNumber = decimalNumber / baseN;
            }

            for (int i = remStack.Count - 1; i >= 0; i--)
            {
                Console.Write(remStack[i]);
            }
            Console.WriteLine();
        }
    }
}
