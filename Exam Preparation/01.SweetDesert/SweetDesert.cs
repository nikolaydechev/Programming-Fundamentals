using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDesert
{
    public class SweetDesert
    {
        public static void Main()
        {
            var cash = double.Parse(Console.ReadLine());
            var guests = double.Parse(Console.ReadLine());
            var bananaPrice = double.Parse(Console.ReadLine());
            var eggPrice = double.Parse(Console.ReadLine());
            var berriesKiloPrice = double.Parse(Console.ReadLine());

            var portions = Math.Ceiling(guests / 6);
            var neededProduct = portions * (2 * bananaPrice) + portions * (4 * eggPrice) + portions * (0.2 * berriesKiloPrice);

            if (neededProduct <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededProduct:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededProduct-cash:f2}lv more.");
            }
        }
    }
}
