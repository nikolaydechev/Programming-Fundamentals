using System;

namespace Draw_a_FilledSquare
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            PrintMiddleRow(n);
            PrintHeaderRow(n);
        }

        public static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        public static void PrintMiddleRow(int n)
        {
            for (int row = 1; row <= n - 2; row++)
            {
                Console.Write('-');

                for (int i = 1; i < n; i++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine('-');
            }
        }
    }
}
