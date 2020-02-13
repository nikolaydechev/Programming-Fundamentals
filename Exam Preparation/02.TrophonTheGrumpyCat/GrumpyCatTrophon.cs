using System;
using System.Linq;

namespace _02.TrophonTheGrumpyCat
{
    public class GrumpyCatTrophon
    {
        public static void Main()
        {
            var priceRatings = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var entryPoint = int.Parse(Console.ReadLine());
            var typeOfItems = Console.ReadLine();
            var typeOfPriceRatings = Console.ReadLine();

            long entryPointValue = priceRatings.ElementAt(entryPoint);
            
            long leftSum = 0;
            long rightSum = 0;

            for (int i = 0; i < entryPoint; i++)
            {
                if (typeOfItems == "cheap" && priceRatings[i] < entryPointValue && typeOfPriceRatings == "all")
                {
                    leftSum += priceRatings[i];
                }
                else if (typeOfItems == "expensive" && priceRatings[i] >= entryPointValue && typeOfPriceRatings == "all")
                {
                    leftSum += priceRatings[i];
                }
                else if (typeOfItems == "cheap" && priceRatings[i] < entryPointValue && typeOfPriceRatings == "positive" && priceRatings[i] >= 0)
                {
                    leftSum += priceRatings[i];
                }
                else if (typeOfItems == "cheap" && priceRatings[i] < entryPointValue && typeOfPriceRatings == "negative" && priceRatings[i] < 0)
                {
                    leftSum += priceRatings[i];
                }
                else if (typeOfItems == "expensive" && priceRatings[i] >= entryPointValue && typeOfPriceRatings == "positive" && priceRatings[i] >= 0)
                {
                    leftSum += priceRatings[i];
                }
                else if (typeOfItems == "expensive" && priceRatings[i] >= entryPointValue && typeOfPriceRatings == "negative" && priceRatings[i] < 0)
                {
                    leftSum += priceRatings[i];
                }
            }

            for (int i = entryPoint + 1; i < priceRatings.Length; i++)
            {
                if (typeOfItems == "cheap" && priceRatings[i] < entryPointValue && typeOfPriceRatings == "all")
                {
                    rightSum += priceRatings[i];
                }
                else if (typeOfItems == "expensive" && priceRatings[i] >= entryPointValue && typeOfPriceRatings == "all")
                {
                    rightSum += priceRatings[i];
                }
                else if (typeOfItems == "cheap" && priceRatings[i] < entryPointValue && typeOfPriceRatings == "positive" && priceRatings[i] >= 0)
                {
                    rightSum += priceRatings[i];
                }
                else if (typeOfItems == "cheap" && priceRatings[i] < entryPointValue && typeOfPriceRatings == "negative" && priceRatings[i] < 0)
                {
                    rightSum += priceRatings[i];
                }
                else if (typeOfItems == "expensive" && priceRatings[i] >= entryPointValue && typeOfPriceRatings == "positive" && priceRatings[i] >= 0)
                {
                    rightSum += priceRatings[i];
                }
                else if (typeOfItems == "expensive" && priceRatings[i] >= entryPointValue && typeOfPriceRatings == "negative" && priceRatings[i] < 0)
                {
                    rightSum += priceRatings[i];
                }
            }
            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }
    }
}
