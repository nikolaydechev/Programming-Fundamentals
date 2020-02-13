namespace _04.SoftuniCoffeeSupplies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CoffeeSuplies
    {
        public static void Main()
        {
            string[] delimiters = Console.ReadLine().Split();
            var firstDelimiter = delimiters[0];
            var secondDelimiter = delimiters[1];

            var NameAndCoffeetype = new Dictionary<string, string>();
            var CoffetypeAndQuantity = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (!input.Equals("end of info"))
            {
                if (input.Contains(firstDelimiter))
                {
                    int indexOfDelimiter = input.IndexOf(firstDelimiter);
                    string personName = input.Substring(0, indexOfDelimiter);
                    string coffeeType = input.Substring(indexOfDelimiter + firstDelimiter.Length);

                    //Second Split Option
                    //input = input.Replace(firstDelimiter, " ").Split();

                    if (NameAndCoffeetype.ContainsKey(personName))
                    {
                        NameAndCoffeetype[personName] = coffeeType;
                    }
                    else
                    {
                        NameAndCoffeetype.Add(personName, coffeeType);
                    }

                    if (!CoffetypeAndQuantity.ContainsKey(coffeeType))
                    {
                        CoffetypeAndQuantity.Add(coffeeType, 0);
                    }
                }
                else
                {
                    int indexOfDelimiter = input.IndexOf(secondDelimiter);
                    string coffeeName = input.Substring(0, indexOfDelimiter);
                    int quantity = int.Parse(input.Substring(indexOfDelimiter + secondDelimiter.Length));

                    if (CoffetypeAndQuantity.ContainsKey(coffeeName))
                    {
                        CoffetypeAndQuantity[coffeeName] += quantity;
                    }
                    else
                    {
                        CoffetypeAndQuantity.Add(coffeeName, quantity);
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var coffeeType in CoffetypeAndQuantity)
            {
                if (coffeeType.Value <= 0)
                {
                    Console.WriteLine("Out of {0}", coffeeType.Key);
                }
            }
            input = Console.ReadLine();
            while (!input.Equals("end of week"))
            {
                string[] inputText = input.Split(' ').ToArray();
                var PersonName = inputText[0];
                var drinksCount = int.Parse(inputText[1]);

                string coffeeType = NameAndCoffeetype[PersonName];
                CoffetypeAndQuantity[coffeeType] -= drinksCount;

                if (CoffetypeAndQuantity[coffeeType] <= 0)
                {
                    Console.WriteLine($"Out of {coffeeType}");
                }

                input = Console.ReadLine();
            }


            //PRINTING

            PrintReports(NameAndCoffeetype, CoffetypeAndQuantity);
            //PrintReportsOtherSolution(NameAndCoffeetype, CoffetypeAndQuantity);

        }


        private static void PrintReports(Dictionary<string, string> nameAndCoffeetype, Dictionary<string, int> coffetypeAndQuantity)
        {
            Console.WriteLine("Coffee Left:");

            var filteredCoffeeTypes = coffetypeAndQuantity.Where(coffeeType => coffeeType.Value > 0);

            foreach (var filteredCoffeetype in filteredCoffeeTypes.OrderByDescending(coffeeType => coffeeType.Value))
            {
                Console.WriteLine($"{filteredCoffeetype.Key} {filteredCoffeetype.Value}");
            }

            Console.WriteLine("For:");
            var ForDict = new Dictionary<string, string>();
            foreach (var person in nameAndCoffeetype)
            {
                foreach (var coffee in filteredCoffeeTypes)
                {
                    if (nameAndCoffeetype[person.Key].Contains(coffee.Key))
                    {
                        ForDict.Add(person.Key, coffee.Key);
                    }
                }
            }
            foreach (var pair in ForDict.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }

        }


        private static void PrintReportsOtherSolution(Dictionary<string, string> nameAndCoffeetype, Dictionary<string, int> coffetypeAndQuantity)
        {
            Console.WriteLine("Coffee Left:");

            var filteredCoffeeTypes = coffetypeAndQuantity
                .Where(coffeeType => coffeeType.Value > 0)
                .ToDictionary(coffeeType => coffeeType.Key, coffeeType => coffeeType.Value);

            foreach (var filteredCoffeetype in filteredCoffeeTypes.OrderByDescending(coffeeType => coffeeType.Value))
            {
                Console.WriteLine($"{filteredCoffeetype.Key} {filteredCoffeetype.Value}");
            }

            Console.WriteLine("For:");

            var coffeeLeftForPeople = nameAndCoffeetype
                .Where(person => filteredCoffeeTypes.ContainsKey(person.Value))
                .OrderBy(person => person.Value)
                .ThenByDescending(person => person.Key);

            foreach (var KeyValuePair in coffeeLeftForPeople)
            {
                Console.WriteLine("{0} {1}", KeyValuePair.Key, KeyValuePair.Value);
            }
        }
    }
}
