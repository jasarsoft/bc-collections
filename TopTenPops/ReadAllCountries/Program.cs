using System;
using System.Collections.Generic;
using System.Linq;
using TopTenPops;

namespace ReadAllCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../../Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);
            List<Country> countries = reader.ReadAllCountries();

            foreach (var country in countries.Take(10))
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
