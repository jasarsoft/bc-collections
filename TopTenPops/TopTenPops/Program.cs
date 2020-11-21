using System;
using System.Collections.Generic;

namespace TopTenPops
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            Dictionary<string, Country> countriesDict = reader.ReadAllCountriesDict();
            Console.WriteLine("Which country code do you want to look you?");
            string userInput = Console.ReadLine();

            bool gotCountry = countriesDict.TryGetValue(userInput, out Country countryDict);
            if (!gotCountry)
            {
                Console.WriteLine($"Sorry, there is no country  with code {userInput}");
            }
            else
            {
                Console.WriteLine($@"{countryDict.Name} has population {PopulationFormatter.FormatPopulation(countryDict.Population)}");
            }

            //Country[] countries = reader.ReadFirstNCountries(10);
            List<Country> countries = reader.ReadAllCountries();
            Country lilliput = new Country("Lilliput", "LIL", "Somewhare", 2_000_000);
            int lilliputIndex = countries.FindIndex(x => x.Population < 2_000_000);
            countries.Insert(lilliputIndex, lilliput);
            countries.RemoveAt(lilliputIndex);

            foreach (var country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }

            Console.WriteLine($"{countries.Count} countries");
        }
    }
}
