namespace _9.MelrahShake
{
    using System;
    using System.Text.RegularExpressions;

    public class HarlemShake
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                var match = input;
                input = Regex.Replace(input, pattern, "");

                if (input.Equals(match))
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(match);
                    break;
                }

                Console.WriteLine("Shaked it.");
                pattern = pattern.Remove(pattern.Length / 2, 1);

            }
        }
    }
}