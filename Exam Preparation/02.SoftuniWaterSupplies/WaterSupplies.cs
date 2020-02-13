namespace _02.SoftuniWaterSupplies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WaterSupplies
    {
        public static void Main()
        {
            var totalWater = double.Parse(Console.ReadLine());
            double[] bottlesToFill = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var bottleCapacity = double.Parse(Console.ReadLine());
            var bottlesLeft = 0;
            var withIndexes = new List<int>();
            var waterLeft = totalWater;
            double waterInNeed = 0;

            if (totalWater % 2 == 0)
            {
                for (int i = 0; i < bottlesToFill.Length; i++)
                {
                    DataProcessing(bottlesToFill, bottleCapacity, ref bottlesLeft, withIndexes, ref waterLeft, ref waterInNeed, i);
                }

                PrintingResults(bottlesLeft, withIndexes, waterLeft, waterInNeed);
            }
            else
            {
                for (int i = bottlesToFill.Length - 1; i >= 0; i--)
                {
                    DataProcessing(bottlesToFill, bottleCapacity, ref bottlesLeft, withIndexes, ref waterLeft, ref waterInNeed, i);
                }

                PrintingResults(bottlesLeft, withIndexes, waterLeft, waterInNeed);
            }
        }

        private static void PrintingResults(int bottlesLeft, List<int> withIndexes, double waterLeft, double waterInNeed)
        {
            if (waterInNeed == 0)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {waterLeft}l.");
            }
            else
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {bottlesLeft}");
                Console.Write("With indexes: ");
                Console.Write(string.Join(", ", withIndexes));
                Console.WriteLine();
                Console.WriteLine($"We need {waterInNeed} more liters!");
            }
        }

        private static void DataProcessing(double[] bottlesToFill, double bottleCapacity, ref int bottlesLeft, List<int> withIndexes, ref double waterLeft, ref double waterInNeed, int i)
        {
            if (bottlesToFill[i] < bottleCapacity && waterLeft >= bottleCapacity || waterLeft >= (bottleCapacity - bottlesToFill[i]))
            {
                var waterToFill = bottleCapacity - bottlesToFill[i];
                bottlesToFill[i] += waterToFill;
                waterLeft -= waterToFill;
            }
            if (bottlesToFill[i] < bottleCapacity && waterLeft < (bottleCapacity - bottlesToFill[i]))
            {
                var waterToFill = bottleCapacity - bottlesToFill[i];
                waterInNeed = bottleCapacity - (waterLeft + bottlesToFill[i]);
                bottlesLeft++;
                withIndexes.Add(i);
                waterLeft -= waterToFill;
            }
            else if (waterLeft <= 0 && bottlesToFill[i] != bottleCapacity)
            {
                bottlesLeft++;
                withIndexes.Add(i);
                waterInNeed += bottleCapacity;
            }
        }
    }
}
