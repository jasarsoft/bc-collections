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
                "Wednsday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine(("Before:"));
            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            daysOfWeek[2] = "Wednesday";

            Console.WriteLine("\r\nAfter:");
            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("Which day do you want to display?");
            Console.Write("(Monday = 1, etc) > ");
            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = daysOfWeek[iDay - 1];
            Console.WriteLine($"That day is {chosenDay}");
        }
    }
}
