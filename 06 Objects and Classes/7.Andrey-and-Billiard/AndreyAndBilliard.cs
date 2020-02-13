namespace _7.Andrey_and_Billiard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AndreyAndBilliard
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var beverageAndPrice = Console.ReadLine();
            var menu = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] beverageAndPriceSplitter = beverageAndPrice.Split('-');
                if (!menu.ContainsKey(beverageAndPriceSplitter[0]))
                {
                    menu.Add(beverageAndPriceSplitter[0], decimal.Parse(beverageAndPriceSplitter[1]));
                }
                else
                {
                    menu[beverageAndPriceSplitter[0]] = decimal.Parse(beverageAndPriceSplitter[1]);
                }
                if (i == n - 1)
                {
                    break;
                }
                beverageAndPrice = Console.ReadLine();
            }

            List<Customer> OrdersList = new List<Customer>();
            beverageAndPrice = Console.ReadLine();


            while (!beverageAndPrice.Equals("end of clients"))
            {
                var DrinkAndQuantity = new Dictionary<string, int>();

                string[] clientOrder = beverageAndPrice.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var clientName = clientOrder[0];
                var clientProduct = clientOrder[1];
                var quantity = int.Parse(clientOrder[2]);

                if (menu.ContainsKey(clientProduct))
                {
                    if (OrdersList.Any(x => x.Name == clientName))
                    {
                        Customer existingCustomer = OrdersList.First(c => c.Name == clientName);
                        if (existingCustomer.ShopList.ContainsKey(clientProduct))
                        {
                            existingCustomer.ShopList[clientProduct] += quantity;
                        }
                        else
                        {
                            existingCustomer.ShopList.Add(clientProduct, quantity);
                        }
                    }
                    else
                    {
                        DrinkAndQuantity.Add(clientProduct, quantity);

                        OrdersList.Add(new Customer() { Name = clientName, ShopList = DrinkAndQuantity });

                        //Customer customer = new Customer();
                        //customer.Name = clientName;
                        //customer.ShopList = new Dictionary<string, int>();
                        //customer.ShopList.Add(clientProduct, quantity);
                    }
                }



                beverageAndPrice = Console.ReadLine();
            }
            //BILL
            foreach (var customer in OrdersList)
            {
                foreach (var item in customer.ShopList)
                {
                    foreach (var product in menu)
                    {
                        if (item.Key == product.Key)
                        {
                            customer.Bill += item.Value * product.Value;
                        }
                    }
                }
            }

            //SORT
            var ordered = OrdersList.OrderBy(x => x.Name)
                                    .ThenBy(x => x.Bill)
                                    .ToList();


            //PRINTING
            foreach (var customer in ordered)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, int> item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
            }

            Console.WriteLine("Total bill: {0:f2}", OrdersList.Sum(c => c.Bill));
        }
    }
}
