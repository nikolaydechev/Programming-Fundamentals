using System;

namespace PrintPart_of_the_ASCIITable
{
    class Program
    {
        public static void Main(string[] args)
        {
            int firstIndex = int.Parse(Console.ReadLine());
            int secondIndex = int.Parse(Console.ReadLine());

            char firstCharacter = (char)firstIndex;
            char secondCharacter = (char)secondIndex;

            for (char i = firstCharacter; i <= secondCharacter; i++)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
        }
    }
}
