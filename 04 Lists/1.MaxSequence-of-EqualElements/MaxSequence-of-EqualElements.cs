namespace _1.MaxSequence_of_EqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MaxSequence_of_EqualElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var longestSubsequence = new List<int>();
            var currentSubsequence = new List<int>();

            currentSubsequence.Add(numbers[0]);

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == currentSubsequence[0])
                {
                    currentSubsequence.Add(numbers[i]);
                }
                else
                {
                    if (currentSubsequence.Count > longestSubsequence.Count)
                    {
                        longestSubsequence = new List<int>();

                        for (int j = 0; j < currentSubsequence.Count; j++)
                        {
                            longestSubsequence.Add(currentSubsequence[j]);
                        }
                    }
                    currentSubsequence = new List<int>();
                    currentSubsequence.Add(numbers[i]);
                }
            }

            if (currentSubsequence.Count > longestSubsequence.Count)
            {
                longestSubsequence = new List<int>();

                for (int j = 0; j < currentSubsequence.Count; j++)
                {
                    longestSubsequence.Add(currentSubsequence[j]);
                }
            }
            Console.WriteLine(string.Join(" ", longestSubsequence));
        }
    }

}



