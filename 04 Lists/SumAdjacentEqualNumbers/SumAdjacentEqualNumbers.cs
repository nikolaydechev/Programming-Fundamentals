namespace SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            var list = new List<decimal>();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (i > 0 && numbers[i] == numbers[i - 1])
                {
                    numbers[i - 1] = numbers[i] + numbers[i - 1];
                    numbers.RemoveAt(i);
                }
                else if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    if (i > 0)
                    {
                        i-=2;
                    }
                }

            }
                Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
