using System;
using System.Linq;

namespace _5.Compare_CharsArrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split().Select(Char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split().Select(Char.Parse).ToArray();

            int smallerArrayLength = Math.Min(firstArray.Length, secondArray.Length);

            bool equal = false;

            for (int i = 0; i < smallerArrayLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    continue;
                }
                else
                {
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine(firstArray);
                        Console.WriteLine(secondArray);
                    }
                    else
                    {
                        Console.WriteLine(secondArray);
                        Console.WriteLine(firstArray);
                    }
                    equal = true;
                    break;
                }
            }

            if (!equal)
            {
                if (firstArray.Length <= secondArray.Length)
                {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secondArray);
                }
                else
                {
                    Console.WriteLine(secondArray);
                    Console.WriteLine(firstArray);
                }
            }

        }

        public static void OtherSolution()
        {
            char[] firstArray = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            string[] arrays = { new string(firstArray), new string(secondArray) };
            //Array.Sort(arrays)
            Console.WriteLine(string.Join("\n", arrays.OrderBy(str => str))); //or//Console.WriteLine(string.Join("\n", arrays));
        }
    }
}
