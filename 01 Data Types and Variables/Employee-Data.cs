using System;

namespace Employee_Data
{
    class Program
    {
        public static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            long personalID = long.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {secondName}");
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine("Personal ID: {0}",personalID);
            Console.WriteLine("Unique Employee number: {0}", employeeNumber);
        }
    }
}
