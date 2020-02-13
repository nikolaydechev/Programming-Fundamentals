namespace _2.PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
   
    class PhoneBookUpgrade
    {
        public static void Main()
        {
            var phoneBook = new SortedDictionary<string, string>();
            string input = Console.ReadLine();

            while (!input.Equals("END"))
            {
                string[] inputElements = input.Split(' ');

                if (inputElements[0].Equals("A"))
                {
                    string contact = inputElements[1];
                    string number = inputElements[2];
                    if (!phoneBook.ContainsKey(contact))
                    {
                        phoneBook.Add(contact, number);
                    }
                    else
                    {
                        phoneBook[contact] = number;
                    }
                }
                else if (inputElements[0].Equals("S"))
                {
                    string contact = inputElements[1];

                    if (phoneBook.ContainsKey(contact))
                    {
                        Console.WriteLine("{0} -> {1}", contact, phoneBook[contact]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", contact);
                    }
                }
                if (input.Equals("ListAll"))
                {
                    foreach (var info in phoneBook)
                    {
                        Console.WriteLine("{0} -> {1}", info.Key, info.Value);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
