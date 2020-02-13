namespace _6.UsersLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class UsersLogs
    {
        public static void Main()
        {
            
            var userLogs = new SortedDictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();
            var countMessages = 1;

            while (!input.Equals("end"))
            {
                var inputInfo = input.Split(' ', '=').ToArray();

                var IP = inputInfo[1];
                var userName = inputInfo[5];
                
                if (!userLogs.ContainsKey(userName))
                {
                    userLogs[userName] = new Dictionary<string, int>();
                    userLogs[userName].Add(IP, countMessages);
                }
                else
                {
                    if (userLogs[userName].ContainsKey(IP))
                    {
                        userLogs[userName][IP]++;
                    }
                    else
                    {
                        userLogs[userName].Add(IP, countMessages);
                    }
                }
                
                input = Console.ReadLine();
            }
            
            foreach (var user in userLogs)
            {
                Console.WriteLine($"{user.Key}: ");
                foreach (var log in user.Value)
                {
                    var thing = log.Key;
                    if (log.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{log.Key} => {log.Value}.");
                    }
                }
            }
        }
    }
}
