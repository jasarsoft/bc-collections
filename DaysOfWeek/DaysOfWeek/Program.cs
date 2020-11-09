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

            Console.WriteLine("Which day do you want to display?");
            Console.Write("(Monday = 1, etc) > ");
            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = daysOfWeek[iDay];
            Console.WriteLine($"That day is {chosenDay}");
        }
    }
}
