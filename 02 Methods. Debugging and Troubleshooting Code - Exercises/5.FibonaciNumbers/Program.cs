using System;

namespace _5.FibonaciNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var result = Fib(number);
            Console.WriteLine(result);
        }

        static int Fib(int n)
        {
            int a = 0, b = 1;
            
            for (int i = 0; i <= n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
