using System;
using System.Collections.Generic;
using TopTenPops;

namespace ReadCountriesForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../../Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);
            List<Country> countries = reader.ReadAllCountries();

            Console.Write("Enter no. of countries to display> ");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if (!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must type in a integer. Exiting");
                return;
            }

            int maxToDisplay = Math.Min(userInput, countries.Count);
            for (int i = 0; i < maxToDisplay; i++)
            {
                var country = countries[i];
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }

            Console.WriteLine($"{countries.Count} countries");
        }
    }
}
