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
            Console.WriteLine(FetchTicket());

            NominalTransaction();

            
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
                Server = ConfigurationManager.AppSettings["Server"],
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

        public static void NominalTransaction()
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

            int successLines = 0;
            int failureLines = 0;
            int rowIndex = 0;

            switch (nominal.typeChar)
            {
                case 's':
                    Console.WriteLine("Currency selected: Sterling GBP");
                    foreach (var row in nominal.csvList)
                    {
                        taxJournalDetails.Add(new NominalTaxJournalDetail()
                        {
                            NominalCode = row[0],
                            HomeNetValue = Convert.ToDouble(row[1]),
                            LineDetail = row[2],
                            TaxCode = row[3],
                            HomeTaxValue = Convert.ToDouble(row[4]),
                            TransactionUserKey1 = row[5],
                            TransactionUserKey2 = row[6],
                            TransactionUserKey3 = row[7]
                        });

                        journal.GrossContraNominalCode = ConfigurationManager.AppSettings["GCNC GBP"];
                        journal.TaxContraNominalCode = ConfigurationManager.AppSettings["TCNC GBP"];

                        journal.DetailLines = taxJournalDetails.ToArray();
                        journal.Reference = "VOUCHERREF";
                        journal.BatchReference = "FONTEVA";
                        journal.PostingDate = DateTime.Now;
                        journal.HeaderDebitCreditFlag = modEnumsDebitCreditType.Credit;
                        journal.Description = "Membership Import Journal";
                        journal.PostLive = false;

                        request.Ticket = FetchTicket();
                        request.Transaction = journal;
                        
                        try
                        {
                            Console.WriteLine("trying to make a request");
                            response = serviceClient.NominalTaxJournalUpdate(request);
                            if (response.ErrorID > 0)
                            {
                                Console.WriteLine("The request was sent however the following error came back form the web service:");
                                Console.WriteLine(response.ErrorMessage);
                                Console.WriteLine("The request failed on line {0}", rowIndex + 1);
                                failureLines++;
                            }
                            else
                            {
                                Console.WriteLine(response.Transaction.HeaderAuditNo.ToString());
                                successLines++;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("The following error has occured no request was sent:\n" + e);
                        }
                        rowIndex++;
                    }
                    break;
                case 'd':
                    Console.WriteLine("Currency selected: US Dollars");
                    foreach (var row in nominal.csvList)
                    {
                        taxJournalDetails.Add(new NominalTaxJournalDetail()
                        {
                            NominalCode = row[0],
                            CurrencyGrossValue = Convert.ToDouble(row[1]),
                            LineDetail = row[2],
                            TaxCode = row[3],
                            CurrencyTaxValue = Convert.ToDouble(row[4]),
                            TransactionUserKey1 = row[5],
                            TransactionUserKey2 = row[6],
                            TransactionUserKey3 = row[7]
                        });

                        journal.GrossContraNominalCode = ConfigurationManager.AppSettings["GCNC USD"];
                        journal.TaxContraNominalCode = ConfigurationManager.AppSettings["TCNC USD"];
                        journal.CurrencyCode = ConfigurationManager.AppSettings["CCODE USD"];

                        journal.DetailLines = taxJournalDetails.ToArray();
                        journal.Reference = "VOUCHERRE2";
                        journal.BatchReference = "FONTEVA";
                        journal.PostingDate = DateTime.Now;
                        journal.HeaderDebitCreditFlag = modEnumsDebitCreditType.Credit;
                        journal.Description = "Membership Import Journal";
                        journal.PostLive = false;

                        request.Ticket = FetchTicket();
                        request.Transaction = journal;

                        try
                        {
                            Console.WriteLine("trying to make a request");
                            response = serviceClient.NominalTaxJournalUpdate(request);
                            if (response.ErrorID > 0)
                            {
                                Console.WriteLine("The request was sent however the following error came back form the web service:");
                                Console.WriteLine(response.ErrorMessage);
                                Console.WriteLine("The request failed on line {0}", rowIndex + 1);
                                failureLines++;
                            }
                            else
                            {
                                Console.WriteLine(response.Transaction.HeaderAuditNo.ToString());
                                successLines++;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("The following error has occured no request was sent:\n" + e);
                        }
                        rowIndex++;
                    }

                    break;
                /*case 'e':
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
                    if (journal.GrossContraNominalCode == null)
                    {
                        journal.GrossContraNominalCode = ConfigurationManager.AppSettings["GCNC EUR"];
                        journal.TaxContraNominalCode = ConfigurationManager.AppSettings["TCNC EUR"];
                        journal.CurrencyCode = ConfigurationManager.AppSettings["CCODE EUR"];
                        //journal.ExchangeRate = Convert.ToDecimal(ConfigurationManager.AppSettings["ExchangeRate"]);
                    }
                    break;*/
            }

            Console.WriteLine(string.Format("\n\nA total of {0} lines were read\n{1} lines were pushed successfully\n{2} lines failed", nominal.csvList.Count, successLines, failureLines));
        }        
    }
}
