using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace ADI
{
    class NominalData
    {
        public bool moreData;
        public string nominalCode;
        public double homeNetValue;
        public string lineDetail;
        public string taxCode;
        public double homeTaxValue;
        public string transactionUserKey1;
        public string transactionUserKey2;
        public string transactionUserKey3;
        public double currencyTaxVlaue;

        public decimal exchangeRate = Convert.ToDecimal(ConfigurationManager.AppSettings["ExchangeRate"]);

        public int lineNumber;
        private List<string[]> csvList;

        public void CsvToList()
        {   
            if(csvList == null)
                csvList = ReadCsv();
            
            if(lineNumber <= csvList.Count)
            {
                nominalCode = csvList[lineNumber][0].ToString();
                homeNetValue = Convert.ToDouble(csvList[lineNumber][0].ToString());
                lineDetail = csvList[lineNumber][0].ToString();
                taxCode = csvList[lineNumber][0].ToString();
                homeNetValue = Convert.ToDouble(csvList[lineNumber][0].ToString());
                transactionUserKey1 = csvList[lineNumber][0].ToString();
                transactionUserKey2 = csvList[lineNumber][0].ToString();
                transactionUserKey3 = csvList[lineNumber][0].ToString();
            }
            else
            {
                moreData = false;
                lineNumber = 0;
            }
            /*
            nominalCode = "0003199100";
            homeNetValue = 10.00;
            lineDetail = "CONCATENATION of DATA";
            taxCode = "S7";
            homeNetValue = 0.23;
            transactionUserKey1 = "abc";
            transactionUserKey2 = "xyz";
            transactionUserKey3 = "qwe";
            */
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
