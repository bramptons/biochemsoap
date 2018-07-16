using System;
using System.Collections.Generic;
using ADI.CredentialService;
using ADI.NominalLedger;
using System.Configuration;

namespace ADI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(FetchTicket());
            NominalTransactionUpdateResponse response = new NominalTransactionUpdateResponse();
            response = NominalTransaction();

            if(response.ErrorID > 0)
            {
                Console.WriteLine(response.ErrorMessage);
            }
            else
            {
                Console.WriteLine(response.Transaction.HeaderAuditNo.ToString());
            }
        }

        public static string FetchTicket()
        {
            CredentialsServiceClient client = new CredentialsServiceClient();
            DimensionsLogonObject logonObject = new DimensionsLogonObject
            {
                Database = ConfigurationManager.AppSettings["Database"],
                UserID = ConfigurationManager.AppSettings["UserID"],
                UserName = ConfigurationManager.AppSettings["UserName"],
                Password = ConfigurationManager.AppSettings["Password"],
                Server = ConfigurationManager.AppSettings["Password"],
                SiteReference = ConfigurationManager.AppSettings["SiteReference"]
            };
            try
            {
                string ticket = client.CreateNewTicket(logonObject);
                return ticket;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static NominalTransactionUpdateResponse NominalTransaction()
        {
            NominalLedgerServiceClient serviceClient = new NominalLedgerServiceClient();
            NominalTaxJournalUpdateRequest request = new NominalTaxJournalUpdateRequest();
            List<NominalTaxJournalDetail> taxJournalDetails = new List<NominalTaxJournalDetail>();
            NominalTaxJournal journal = new NominalTaxJournal
            {
                Ledger = modEnumsNominalLedgerType.Cashbook,
                IsPayment = true
            };
            NominalTaxJournalDetail journalDetail = new NominalTaxJournalDetail();
            NominalTransactionUpdateResponse response = new NominalTransactionUpdateResponse();

            NominalData nominal = new NominalData();

            char currency = nominal.ReturnCurrency();
            nominal.moreData = true;
            do
            {
                nominal.CsvToList();

                switch (currency)
                {
                    case 's':
                        Console.WriteLine("Currency selected: Sterling GBP, line  number {0}", nominal.lineNumber);
                        taxJournalDetails.Add(new NominalTaxJournalDetail()
                        {
                            NominalCode = nominal.nominalCode,
                            HomeNetValue = nominal.homeNetValue,
                            LineDetail = nominal.lineDetail,
                            TaxCode = nominal.taxCode,
                            HomeTaxValue = nominal.homeTaxValue,
                            TransactionUserKey1 = nominal.transactionUserKey1,
                            TransactionUserKey2 = nominal.transactionUserKey2,
                            TransactionUserKey3 = nominal.transactionUserKey3
                        });
                        if(journal.GrossContraNominalCode == null)
                        {
                            journal.GrossContraNominalCode = ConfigurationManager.AppSettings["GCNC GBP"];
                            journal.TaxContraNominalCode = ConfigurationManager.AppSettings["TCNC GBP"];
                        }
                        break;
                    case 'd':
                        taxJournalDetails.Add(new NominalTaxJournalDetail()
                        {
                            NominalCode = "0502945USD",
                            HomeNetValue = 10.00,
                            LineDetail = "CONCATENATION of DATA",
                            TaxCode = "S7",
                            CurrencyTaxValue = 0.23,
                            TransactionUserKey1 = "abc",
                            TransactionUserKey2 = "xyz",
                            TransactionUserKey3 = "www"
                        });
                        if(journal.GrossContraNominalCode == null)
                        {
                            journal.GrossContraNominalCode = ConfigurationManager.AppSettings["GCNC GBP"];
                            journal.TaxContraNominalCode = ConfigurationManager.AppSettings["TCNC USD"];
                            journal.CurrencyCode = ConfigurationManager.AppSettings["CCODE USD"];
                            //journal.ExchangeRate = Convert.ToDecimal(ConfigurationManager.AppSettings["ExchangeRate"]);
                        }
                        break;
                    case 'e':
                        taxJournalDetails.Add(new NominalTaxJournalDetail()
                        {
                            NominalCode = "0502945EUR",
                            HomeNetValue = 10.00,
                            LineDetail = "CONCATENATION of DATA",
                            TaxCode = "S7",
                            CurrencyTaxValue = 0.23,
                            TransactionUserKey1 = "abc",
                            TransactionUserKey2 = "xyz",
                            TransactionUserKey3 = "www"
                        });
                        if(journal.GrossContraNominalCode == null)
                        {
                            journal.GrossContraNominalCode = ConfigurationManager.AppSettings["GCNC EUR"];
                            journal.TaxContraNominalCode = ConfigurationManager.AppSettings["TCNC EUR"];
                            journal.CurrencyCode = ConfigurationManager.AppSettings["CCODE EUR"];
                            //journal.ExchangeRate = Convert.ToDecimal(ConfigurationManager.AppSettings["ExchangeRate"]);
                        }
                        break;
                }
                nominal.lineNumber++;
            }
            while (nominal.moreData == true);
            //switch for header information based on currency switch
            Console.WriteLine(string.Format("A total of {0} lines has been read", nominal.lineNumber));
            nominal.lineNumber = 0;

            journal.DetailLines = taxJournalDetails.ToArray();
            journal.Reference = "VOUCHERREF";
            journal.BatchReference = "FONTEVA";
            journal.PostingDate = DateTime.Now;
            journal.HeaderDebitCreditFlag = modEnumsDebitCreditType.Credit;
            journal.Description = "Membership Import Journal";
            journal.PostLive = false;

            request.Ticket = FetchTicket();
            request.Transaction = journal;
            if(request.Ticket == null)
            {
                Environment.Exit(0);
                return null;
            }
            else
            {
                try
                {
                    Console.WriteLine("trying to make a request");
                    response = serviceClient.NominalTaxJournalUpdate(request);
                    return response;
                }
                catch (Exception e)
                {
                    Console.WriteLine("The following error has occured:\n" + e);
                    return null;
                }
            }
        }
    }
}
