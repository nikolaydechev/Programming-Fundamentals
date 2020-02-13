namespace RemoveNegatives_and_Reverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RemoveNegatives_and_Reverse
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var resultsList = new List<int>();

            for (int i = listOfNumbers.Count - 1; i >= 0; i--)
            {
                var currentElement = listOfNumbers[i];
                if (currentElement >= 0)
                {
                    resultsList.Add(currentElement);
                }
            }

            bool allNonNegative = resultsList.All(x => x < 0);

            if (allNonNegative)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", resultsList));
            }

        }
    }
}
