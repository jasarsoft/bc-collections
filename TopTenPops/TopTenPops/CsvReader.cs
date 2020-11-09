using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TopTenPops
{
    class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            this._csvFilePath = csvFilePath;
        }

        public Country[] ReadFirstNCountries(int nCountries)
        {
            return null;
        }
    }
}
