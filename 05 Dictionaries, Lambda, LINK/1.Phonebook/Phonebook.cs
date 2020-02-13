namespace _1.Phonebook
{
    using System;
    using System.Collections.Generic;

    class Phonebook
    {
        public static void Main()
        {
            var phoneBook = new Dictionary<string, string>();
            string input = Console.ReadLine();

            while (!input.Equals("END"))
            {
                string[] inputArguments = input.Split(' ');

                if (inputArguments[0].Equals("A"))
                {
                    string contactName = inputArguments[1];
                    string number = inputArguments[2];

                    phoneBook[contactName] = number;
                }

                else if (inputArguments[0].Equals("S"))
                {
                    string contactName = inputArguments[1];

                    if (phoneBook.ContainsKey(contactName))
                    {
                        Console.WriteLine("{0} -> {1}", contactName, phoneBook[contactName]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", contactName);
                    }
                }

                input = Console.ReadLine();
            }

        }
    }
}
