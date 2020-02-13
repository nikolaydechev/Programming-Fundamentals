namespace _3.MinerTask
{
    using System;
    using System.Collections.Generic;

    class MinerTask
    {
        public static void Main()
        {
            var resources = new Dictionary<string, decimal>();

            string inputText = Console.ReadLine();


            while (inputText != "stop")
            {
                decimal inputNumber = decimal.Parse(Console.ReadLine());

                if (resources.ContainsKey(inputText))
                {
                    resources[inputText] += inputNumber;
                }
                else
                {
                    resources.Add(inputText, inputNumber);
                }

                inputText = Console.ReadLine();
               
            }

            foreach (var item in resources)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
