namespace _04.PopulationAggregation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationAggregation
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var result = new Dictionary<string, long>();
            var CountryCitiesCounter = new SortedDictionary<string, int>();

            while (!input.Equals("stop"))
            {
                string[] inputSplit = input.Split('\\');
                string country;
                string city;
                var cityPopulation = long.Parse(inputSplit[2]);
                var cityCounter = 1;

                if (char.IsUpper(inputSplit[0].ElementAt(0)))
                {
                    country = inputSplit[0];
                    city = inputSplit[1];
                }
                else
                {
                    country = inputSplit[1];
                    city = inputSplit[0];
                }

                char[] removers = new char[] { '@', '$', '&', '#', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                string[] Temp = country.Split(removers, StringSplitOptions.RemoveEmptyEntries);
                string[] secondTemp = city.Split(removers, StringSplitOptions.RemoveEmptyEntries);
                country = String.Join("", Temp);
                city = String.Join("", secondTemp);

                if (!CountryCitiesCounter.ContainsKey(country))
                {
                    CountryCitiesCounter.Add(country, cityCounter);
                    result.Add(city, cityPopulation);
                }
                else if (result.ContainsKey(city))
                {
                    result[city] = cityPopulation;
                    CountryCitiesCounter[country] += cityCounter;
                }
                else
                {
                    result.Add(city, cityPopulation);
                    CountryCitiesCounter[country] += cityCounter;
                }
                input = Console.ReadLine();
            }

            //SORT
            //PRINTING

            foreach (var country in CountryCitiesCounter)
            {
                Console.WriteLine($"{country.Key} -> {country.Value}");
            }

            var sortedCitiesPopulation = result.OrderByDescending(x => x.Value).Take(3);

            foreach (var city in sortedCitiesPopulation)
            {
                Console.WriteLine($"{city.Key} -> {city.Value}");
            }
        }

        public static void OtherSolution()
        {
            string input = Console.ReadLine();

            var result = new Dictionary<string, Dictionary<string, long>>();
            var CountryCitiesCounter = new SortedDictionary<string, int>();

            while (!input.Equals("stop"))
            {
                string[] inputSplit = input.Split('\\');
                string country;
                string city;
                var cityPopulation = long.Parse(inputSplit[2]);
                var cityCounter = 1;

                if (char.IsUpper(inputSplit[0].ElementAt(0)))
                {
                    country = inputSplit[0];
                    city = inputSplit[1];
                }
                else
                {
                    country = inputSplit[1];
                    city = inputSplit[0];
                }

                char[] removers = new char[] { '@', '$', '&', '#', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                string[] Temp = country.Split(removers, StringSplitOptions.RemoveEmptyEntries);
                string[] secondTemp = city.Split(removers, StringSplitOptions.RemoveEmptyEntries);
                country = String.Join("", Temp);
                city = String.Join("", secondTemp);

                if (!result.ContainsKey(country))
                {
                    result[country] = new Dictionary<string, long>();
                    result[country].Add(city, cityPopulation);
                    CountryCitiesCounter.Add(country, cityCounter);
                }
                else if (result[country].ContainsKey(city))
                {
                    result[country][city] = cityPopulation;
                    CountryCitiesCounter[country] += cityCounter;
                }
                else
                {
                    result[country].Add(city, cityPopulation);
                    CountryCitiesCounter[country] += cityCounter;
                }
                input = Console.ReadLine();
            }

            //SORT
            //PRINTING

            foreach (var country in CountryCitiesCounter)
            {
                Console.WriteLine($"{country.Key} -> {country.Value}");
            }

            var city_population = new Dictionary<string, long>();
            foreach (var country in result)
            {
                var cityPopulation = new Dictionary<string, long>();
                foreach (var data in result[country.Key])
                {
                    cityPopulation.Add(data.Key, data.Value);
                }
                foreach (var item in cityPopulation)
                {
                    city_population.Add(item.Key, item.Value);
                }
            }
            foreach (var pair in city_population.OrderByDescending(x => x.Value).Take(3))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
