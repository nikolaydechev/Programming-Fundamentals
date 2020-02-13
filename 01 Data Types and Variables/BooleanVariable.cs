using System;

namespace BooleanVariable
{
    class Program
    {
        public static void Main(string[] args)
        {
            string stringName = Console.ReadLine();

            bool booleanName = Convert.ToBoolean(stringName);

            if (booleanName)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
