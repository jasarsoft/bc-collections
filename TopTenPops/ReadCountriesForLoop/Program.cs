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

            for (int i = 0; i < countries.Count; i++)
            {
                var country = countries[i];
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }

            Console.WriteLine($"{countries.Count} countries");
        }
    }
}
