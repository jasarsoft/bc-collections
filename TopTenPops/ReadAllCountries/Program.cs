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

            foreach (var country in countries.Where(x => !x.Name.Contains(',')).Take(20))
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }

            for (int i = 12; i < 14; i++)
            {
                Console.WriteLine(countries[i].Name);
            }
        }
    }
}
