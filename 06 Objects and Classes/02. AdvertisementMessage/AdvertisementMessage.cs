namespace _02.AdvertisementMessage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AdvertisementMessage
    {
        public static void Main()
        {
            var numberOfMessages = int.Parse(Console.ReadLine());

            string[] separators = { "," };
            string firstMessages = "Excellent product.,Such a great product.,I always use that product.,Best product of its category.,Exceptional product.,I can’t live without this product.";
            string[] phrases = firstMessages.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string secondMessages = "Now I feel good.,I have succeeded with this product.,Makes miracles. I am happy of the results!,I cannot believe but now I feel awesome.,Try it yourself,I am very satisfied.,I feel great!";
            string[] events = secondMessages.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string thirdMessages = "Diana,Petya,Stella,Elena,Katya,Iva,Annie,Eva";
            string[] author = thirdMessages.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string fourthMessages = "Burgas,Sofia,Plovdiv,Varna,Ruse";
            string[] cities = fourthMessages.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            
            for (int i = 1; i <= numberOfMessages; i++)
            {
                var randomPhrase = RandomText(phrases);
                var randomEvent = RandomText(events);
                var randomAuthor = RandomText(author);
                var randomCity = RandomText(cities);
                Console.WriteLine($"{randomPhrase} {randomEvent} {randomAuthor} - {randomCity}");
            }
            
        }

        public static string RandomText(string[] TypeOfMessages)
        {
            var random = new Random();

            var randomIndex = random.Next(TypeOfMessages.Length);
            return TypeOfMessages[randomIndex];
        }
    }
}
