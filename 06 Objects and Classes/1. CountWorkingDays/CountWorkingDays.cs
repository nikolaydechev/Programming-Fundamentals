namespace _1.CountWorkingDays
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class CountWorkingDays
    {
        public static void Main()
        {
            string firstDate = Console.ReadLine();
            var startDate = DateTime.ParseExact(firstDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            string secondDate = Console.ReadLine();
            var endDate = DateTime.ParseExact(secondDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int workingDaysCounter = 0;

            DateTime[] officialHolidays = new DateTime[11]
            {
                DateTime.ParseExact("01-01-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            };
            
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1.0))
            {
                var checkDate = new DateTime(2000, i.Month, i.Day);

                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !officialHolidays.Contains(checkDate))
                {
                    workingDaysCounter++;
                }
            }
            Console.WriteLine(workingDaysCounter);
        }
    }
}
