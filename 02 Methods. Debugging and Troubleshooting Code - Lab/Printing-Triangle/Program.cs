using System;

namespace Printing_Triangle
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TriangleOfNumbers(n);
        }

        public static void PrintColumns(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write("{0} ", col);
            }
            Console.WriteLine();
        }

        public static void TriangleOfNumbers(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                PrintColumns(row);
            }

            for (int row = number - 1; row > 0; row--)
            {
                PrintColumns(row);
            }
        }
        
    }
}
