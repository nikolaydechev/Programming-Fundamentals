namespace _7.PopulationCounter
{
    using System;
    using System.Collections.Generic;
   
    class PopulationCounter
    {
        public static void Main()
        {
            var countryCityPopulation = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine();

            while (!input.Equals("report"))
            {
                var inputInfo = input.Split('|');

                var countryName = inputInfo[1];
                var cityName = inputInfo[0];
                var population = long.Parse(inputInfo[2]);

                if (!countryCityPopulation.ContainsKey(countryName))
                {
                    countryCityPopulation[countryName] = new Dictionary<string, long>();
                    countryCityPopulation[countryName].Add("totalPopulation", 0);
                }
                if (!countryCityPopulation[countryName].ContainsKey(cityName))
                {
                    countryCityPopulation[countryName].Add(cityName, population);
                    countryCityPopulation[countryName]["totalPopulation"] += population;
                }

                input = Console.ReadLine();
            }
            //SORT (BUBBLE SORT)
            //PRlong
            var countryPopulation = new List<KeyValuePair<string, long>>();

            foreach (var countryOtherData in countryCityPopulation)
            {
                countryPopulation.Add(new KeyValuePair<string, long>(countryOtherData.Key, countryCityPopulation[countryOtherData.Key]["totalPopulation"]));
            }

            SortKeyValuePairs(countryPopulation);

            foreach (var KeyValuePair in countryPopulation)
            {
                Console.WriteLine($"{KeyValuePair.Key} (total population: {KeyValuePair.Value})");  //PRINTING

                var cityPopulation = new List<KeyValuePair<string, long>>(); //CREATING NEW LIST FOR CITIES AND POPULATION

                foreach (var city_population in countryCityPopulation[KeyValuePair.Key])    //ADDING DATA TO THE LIST
                {
                    cityPopulation.Add(new KeyValuePair<string, long>(city_population.Key, city_population.Value));
                }

                SortKeyValuePairs(cityPopulation); //SORTING THE LIST

                foreach (var valuePair in cityPopulation) //PRINTING
                {
                    if (valuePair.Key != "totalPopulation")
                    {
                        Console.WriteLine($"=>{valuePair.Key}: {valuePair.Value}");
                    }
                }
            }

        }

        private static void SortKeyValuePairs(List<KeyValuePair<string, long>> countryPopulation)
        {
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = true;

                for (int i = 0; i < countryPopulation.Count - 1; i++)
                {
                    if (countryPopulation[i].Value < countryPopulation[i + 1].Value)
                    {
                        Swap(countryPopulation, i, i + 1);
                        isSorted = false;
                    }
                }
            }
        }

        private static void Swap(List<KeyValuePair<string, long>> countryPopulation, int i, int v)
        {
            var temp = countryPopulation[i];
            countryPopulation[i] = countryPopulation[v];
            countryPopulation[v] = temp;
        }
    }
}