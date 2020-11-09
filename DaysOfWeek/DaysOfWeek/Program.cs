using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string monday = "Monday";

            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
