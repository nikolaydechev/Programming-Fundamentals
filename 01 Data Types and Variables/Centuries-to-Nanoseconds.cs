using System;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        public static void Main(string[] args)
        {
            var century = int.Parse(Console.ReadLine());

            int years = century * 100;
            double days = Math.Floor(years * 365.242);
            int hours = (int)days * 24;
            int minutes = (int)hours * 60;
            long seconds = (long)minutes * 60;
            long milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds* 1000;

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");


        }
    }
}
