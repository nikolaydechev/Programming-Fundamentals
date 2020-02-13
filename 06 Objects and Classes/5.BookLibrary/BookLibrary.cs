namespace _5.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BookLibrary
    {
        public static void Main()
        {
            List<Book> books = GetBooksInfo();
            var authorAndSumOfPrices = new Dictionary<string, double>();

            foreach (string author in books.Select(x => x.Author).Distinct())
            {
                authorAndSumOfPrices.Add(author, books.Where(x => x.Author == author)
                                                      .Select(x => x.Price)
                                                      .Sum());
            }

            foreach (var KeyValuePair in authorAndSumOfPrices.OrderByDescending(x => x.Value)
                                                             .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{KeyValuePair.Key} -> {KeyValuePair.Value:f2}");
            }
        }

        public static List<Book> GetBooksInfo()
        {
            int n = int.Parse(Console.ReadLine());

            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                string[] bookInfo = Console.ReadLine().Split(' ');

                books.Add(new Book()
                {
                    Title = bookInfo[0],
                    Author = bookInfo[1],
                    Publisher = bookInfo[2],
                    ReleaseDate = DateTime.ParseExact(bookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = bookInfo[4],
                    Price = double.Parse(bookInfo[5])
                });
            }

            return books;

        }
    }
}
