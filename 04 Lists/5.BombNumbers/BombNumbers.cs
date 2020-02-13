namespace _5.BombNumbers
{
    using System;
    using System.Linq;

    class BombNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombNumberAndPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            while (numbers.Contains(bombNumberAndPower[0]))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    var bombRange = bombNumberAndPower[1] * 2 + 1;
                    var currentNumber = numbers[i];
                    var startIndex = Math.Max(0, i - bombNumberAndPower[1]);
                    var count = Math.Min(bombRange, numbers.Count - startIndex);

                    if (currentNumber == bombNumberAndPower[0])
                    {
                        numbers.RemoveRange(startIndex, count);
                    }
                }
            }

            var sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
