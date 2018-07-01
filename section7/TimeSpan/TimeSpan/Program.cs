using System;

namespace TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var timespan = new TimeSpan(1, 2, 3);
            var timespan1 = new TimeSpan(1, 0, 0);
            var timespan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("Duration: ", duration);

            // Properties
            Console.WriteLine("Minutes: ", timespan.Minutes);
            Console.WriteLine("Total Minutes: ", timespan.TotalMinutes);

        }
    }
}
