using System;

namespace Reverse_Characters
{
    class Program
    {
        public static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            Console.Write(thirdLetter);
            Console.Write(secondLetter);
            Console.WriteLine(firstLetter);
        }
    }
}
