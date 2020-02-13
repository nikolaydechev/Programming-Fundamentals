namespace Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Append_Lists
    {
        public static void Main()
        {
            var tokens = Console.ReadLine().Split('|');
            var result = new List<string>();
            
            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                var token = tokens[i].Split(' ');

                foreach (var num in token)
                {
                    result.Add(num);
                    result.RemoveAll(x => x == "");
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

