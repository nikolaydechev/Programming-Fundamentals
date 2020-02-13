using System;

namespace Strings_and_Objects
{
    class Program
    {
        public static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World";

            object greeting = firstWord + " " + secondWord;

            string castedGreeting = (string)greeting;

            Console.WriteLine(castedGreeting);

        }
    }
}
