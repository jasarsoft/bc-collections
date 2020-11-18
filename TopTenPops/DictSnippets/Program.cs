using System;
using System.Collections.Generic;
using TopTenPops;

namespace DictSnippets
{
    class Program
    {
        static void Main(string[] args)
        {
            Country norway = new Country("Norway", "NOR", "Europe", 5_282_223);
            Country finland = new Country("Finland", "FIN", "Europe", 5_511_303);

            var countries = new Dictionary<string, Country>
            {
                { norway.Code, norway },
                { finland.Code, finland }
            };

            Country selectedCountry = countries["NOR"];
            Console.WriteLine(selectedCountry.Name);

            foreach (var country in countries)
            {
                Console.WriteLine(country.Value.Name);
            }

            foreach (var country in countries.Values)
            {
                Console.WriteLine(country.Name);
            }

            var countriesDic = new Dictionary<string, Country>();
            countriesDic.Add(norway.Code, norway);
            countriesDic.Add(finland.Code, finland);

            Console.WriteLine(countriesDic["MUS"].Name);
        }
    }
}
