using System;

namespace _15.Substring
{
    class Program
    {
        public class Example
        {
            public static void Main()
            {
                String header = "* A Short String. *";
                Console.WriteLine(header);
                Console.WriteLine(header.Trim(new Char[] { ' ', '*', '.' }));
            }
        }

    }
}
