namespace _4.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FixEmails
    {
        public static void Main()
        {
            var emails = new Dictionary<string, string>();
            string name = Console.ReadLine();

            while (name != "stop")
            {
                var email = Console.ReadLine();
                emails[name] = email;
                
                name = Console.ReadLine();
            }

            var fixedEmails = emails
                .Where(a => !a.Value.EndsWith("us", StringComparison.OrdinalIgnoreCase) && !a.Value.ToLower().EndsWith("us", StringComparison.OrdinalIgnoreCase))
                .ToDictionary(p => p.Key, p => p.Value);

            foreach (var items in emails)
            {
                Console.WriteLine("{0} -> {1}", items.Key, items.Value);
            }
        }
    }
}
