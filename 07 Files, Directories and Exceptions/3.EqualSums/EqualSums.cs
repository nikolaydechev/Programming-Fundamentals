namespace _3.EqualSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class EqualSums
    {
        public static void Main()
        {
            var input = File.ReadAllLines(@"..\..\input.txt");

            foreach (var line in input)
            {
                int[] numbers = line.Split(' ').Select(int.Parse).ToArray();

                bool indexFound = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    string number = "";
                    var leftSum = 0;
                    var rightSum = 0;
                    for (int a = i + 1; a < numbers.Length; a++)
                    {
                        rightSum += numbers[a];
                    }
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += numbers[j];
                    }
                    if (rightSum == leftSum)
                    {
                        number = string.Format("{0}", i);
                        indexFound = true;
                        File.AppendAllText(@"..\..\output.txt", number + Environment.NewLine);
                        break;
                    }
                }

                if (indexFound != true)
                {
                    File.AppendAllText(@"..\..\output.txt", "no" + Environment.NewLine);
                }
            }
        }
    }
}
