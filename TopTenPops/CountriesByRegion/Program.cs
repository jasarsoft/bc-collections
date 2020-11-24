using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using TopTenPops;

namespace CountriesByRegion
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../../Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            Dictionary<string, List<Country>> countries = reader.ReadAllCountriesRegion();
            foreach (var region in countries.Keys)
            {
                Console.WriteLine(region);
            }

            Console.Write("Which of the above regions do you want? ");
            string chosenRegion = Console.ReadLine();

            if (countries.ContainsKey(chosenRegion))
            {
                foreach (var country in countries[chosenRegion].Take(10))
                {
                    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
                }
            }
            else
            {
                Console.WriteLine("That is not a valid region");
            }
        }
    }
}
