using System;

namespace Hello_name_
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            NameOfSomebody(name);
        }

        public static string NameOfSomebody(string name)
        {
            Console.WriteLine($"Hello, {name}!");
            return name;
        }
    }
}
