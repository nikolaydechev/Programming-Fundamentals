namespace _6.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BookLibraryModification
    {
        public static void Main()
        {
            List<Book> bookList = GetBooks();
            DateTime dateInput = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            DateTime[] resultReleaseDates = bookList.Where(x => x.ReleaseDate > dateInput)
                                                    .Select(x => x.ReleaseDate).Distinct()
                                                    .OrderBy(x => x)
                                                    .ToArray();

            foreach (DateTime releaseDate in resultReleaseDates)
            {
                string[] releaseDateTitles = bookList.Where(x => x.ReleaseDate == releaseDate)
                                                     .Select(x => x.Title).Distinct()
                                                     .OrderBy(x => x)
                                                     .ToArray();
                foreach (var title in releaseDateTitles)
                {
                    Console.WriteLine($"{title} -> {releaseDate:dd.MM.yyyy}");
                }
            }
            
        }

        public static List<Book> GetBooks()
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
