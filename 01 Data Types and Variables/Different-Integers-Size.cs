using System;

namespace Different_Integers_Size
{
    class Program
    {
        public static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            if (N < 0)
            {
                if (N >= -128)
                {
                    Console.WriteLine("{0} can fit in:\n* sbyte", N);
                }
                if (N >= -32768)
                {
                    Console.WriteLine("{0} can fit in:\n* sbyte\n* short", N);
                }
                if (N >= int.MinValue && N <=-128)
                {
                    Console.WriteLine("{0} can fit in:\n* sbyte\n* short\n* int", N);
                }
                else if (N >= int.MinValue && N <= short.MinValue)
                {
                    Console.WriteLine("{0} can fit in:\n* short\n* int", N);
                }
                else if (N >= int.MinValue && N < short.MinValue)
                {
                    Console.WriteLine("{0} can fit in:\n* int", N);
                }
            }
        }
    }
}
