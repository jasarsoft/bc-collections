using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using TopTenPops;

namespace ReadAllCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../../Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);
            IList<Country> countries = reader.ReadAllCountries();

            var filteredCountries = countries.Where(x => !x.Name.Contains(','));
            var filteredCountries2 = from country in countries
                where !country.Name.Contains(',')
                select country;

            foreach (var country in filteredCountries2 )
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
