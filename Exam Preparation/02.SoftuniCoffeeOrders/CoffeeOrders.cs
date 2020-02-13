using System;
using System.Linq;

namespace _02.SoftuniCoffeeOrders
{
    public class CoffeeOrders
    {
        public static void Main()
        {
            var orders = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;
            for (int i = 0; i < orders; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = Console.ReadLine().Split('/').ToArray();
                var capsulesCount = long.Parse(Console.ReadLine());
                var year = int.Parse(orderDate[2]);
                var month = int.Parse(orderDate[1]);
                var daysInMonth = DateTime.DaysInMonth(year, month);

                decimal price = daysInMonth * capsulesCount * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
