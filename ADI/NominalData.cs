﻿using System;
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
            Console.WriteLine("Just type in: \"sterling, dollar or euro\" as the application is in test mode");
            //logic will be entered here in order to discern the report that is being read and then auto populating the the 'path string' to return the correct char switch
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
                    if(path == "euro")
                    {
                        return 'e';
                    }
                    else
                    {
                        Console.WriteLine("No currency selected reuturning failure flag");
                        return 'f';
                    }
                }
            }
        }
    }
}
