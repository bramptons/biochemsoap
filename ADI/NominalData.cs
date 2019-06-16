using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace ADI
{
    class NominalData
    {
        public List<string[]> csvList = ReadCsv();
        public char typeChar = ReturnCurrency();

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

        private static char ReturnCurrency()
        {
            Console.WriteLine("Just type in: \"sterling or dollar\"");
            string path = Console.ReadLine();
            if (path == "sterling")
            {
                return 's';
            }
            else
            {
                if(path == "dollar")
                {
                    return 'd';
                }
                else
                {
                    return 'e';
                }
            }
        }
    }
}
