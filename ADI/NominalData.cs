using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace ADI
{
    class NominalData
    {
        public List<string[]> csvList;

        public void GetData()
        {   
            if(csvList == null)
                csvList = ReadCsv();
            //call to the api will be here
        }

        private static List<string[]> ReadCsv()
        {
            List<string[]> rows = new List<string[]>();
            var reader = new StreamReader(File.OpenRead(ConfigurationManager.AppSettings["Csv"]));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                rows.Add(line.Split(','));
            }

            return rows;
        }

        public char ReturnCurrency()
        {
            Console.WriteLine("Just type in: \"sterling\"");
            string path = Console.ReadLine();
            char currency;
            if (path == "sterling")
            {
                currency = 's';
                return currency;
            }
            else
            {
                return currency = ' ';
            }
        }
    }
}
