namespace _4.SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SumReversedNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int Reverse = 0;
            var sumOfNumbers = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                while (numbers[i] > 0)
                {
                    int remainder = numbers[i] % 10;
                    Reverse = (Reverse * 10) + remainder;
                    numbers[i] = numbers[i] / 10;

                }
                sumOfNumbers += Reverse;
                Reverse = 0;

            }
            Console.WriteLine(sumOfNumbers);
            
        }
    }
}
