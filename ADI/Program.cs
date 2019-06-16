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
            NominalLedgerServiceClient serviceClient;
            NominalTaxJournalUpdateRequest request;
            List<NominalTaxJournalDetail> taxJournalDetails;
            NominalTaxJournal journal;
            NominalTransactionUpdateResponse response;
            
            NominalData nominal = new NominalData();

            int successLines = 0;
            int failureLines = 0;
            int rowIndex = 0;
            int skippedLines = 0;

            foreach (var row in nominal.csvList)
            {
                //test if the line needs to be skipped
                if(row[9] != "x")
                {
                    //check the currency of the line
                    switch (row[8])
                    {
                        case "GBP":
                            Console.WriteLine("Currency selected: Sterling GBP");
                            BuildNominalHeader(out serviceClient, out request, out taxJournalDetails, out journal, out response);

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
                            //currency specific configuration
                            journal.GrossContraNominalCode = ConfigurationManager.AppSettings["GCNC GBP"];
                            journal.TaxContraNominalCode = ConfigurationManager.AppSettings["TCNC GBP"];

                            BuildNominalLines(serviceClient, request, taxJournalDetails, journal, ref response, ref successLines, ref failureLines, rowIndex);
                            break;
                        case "EURR":
                            Console.WriteLine("Currency selected: Euros");
                                BuildNominalHeader(out serviceClient, out request, out taxJournalDetails, out journal, out response);

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
                                //currency specific configuration
                                journal.GrossContraNominalCode = ConfigurationManager.AppSettings["GCNC EUR"];
                                journal.TaxContraNominalCode = ConfigurationManager.AppSettings["TCNC EUR"];
                                journal.CurrencyCode = ConfigurationManager.AppSettings["CCODE EUR"];

                                BuildNominalLines(serviceClient, request, taxJournalDetails, journal, ref response, ref successLines, ref failureLines, rowIndex);
                                break;
                        case "USD":
                            Console.WriteLine("Currency selected: US Dollars");
                            BuildNominalHeader(out serviceClient, out request, out taxJournalDetails, out journal, out response);

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
                            //currency specific configuration
                            journal.GrossContraNominalCode = ConfigurationManager.AppSettings["GCNC USD"];
                            journal.TaxContraNominalCode = ConfigurationManager.AppSettings["TCNC USD"];
                            journal.CurrencyCode = ConfigurationManager.AppSettings["CCODE USD"];

                            BuildNominalLines(serviceClient, request, taxJournalDetails, journal, ref response, ref successLines, ref failureLines, rowIndex);
                            break;
                            //if no currency or wrong value entered 
                        default:
                            failureLines++;
                            Console.WriteLine("No currency or wrong currency entered: " + row[8]);
                            break;
                    }
                }
                else
                {
                    skippedLines++;
                }
                rowIndex++;
            }
            //original switch no longer needed
            switch (nominal.typeChar)
            {
                case 's':
                    Console.WriteLine("Currency selected: Sterling GBP");
                    foreach (var row in nominal.csvList)
                    {
                        if(row[9] != "x")
                        {
                            BuildNominalHeader(out serviceClient, out request, out taxJournalDetails, out journal, out response);

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
                            //currency specific configuration
                            journal.GrossContraNominalCode = ConfigurationManager.AppSettings["GCNC GBP"];
                            journal.TaxContraNominalCode = ConfigurationManager.AppSettings["TCNC GBP"];

                            BuildNominalLines(serviceClient, request, taxJournalDetails, journal, ref response, ref successLines, ref failureLines, rowIndex);
                        }
                        else
                        {
                            skippedLines++;
                        }
                        rowIndex++;
                    }
                    break;
                case 'd':
                    Console.WriteLine("Currency selected: US Dollars");
                    foreach (var row in nominal.csvList)
                    {
                        BuildNominalHeader(out serviceClient, out request, out taxJournalDetails, out journal, out response);

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
                        //currency specific configuration
                        journal.GrossContraNominalCode = ConfigurationManager.AppSettings["GCNC USD"];
                        journal.TaxContraNominalCode = ConfigurationManager.AppSettings["TCNC USD"];
                        journal.CurrencyCode = ConfigurationManager.AppSettings["CCODE USD"];

                        BuildNominalLines(serviceClient, request, taxJournalDetails, journal, ref response, ref successLines, ref failureLines, rowIndex);

                        rowIndex++;
                    }

                    break;
                case 'e':
                    Console.WriteLine("Currency selected: Euros");
                    foreach (var row in nominal.csvList)
                    {
                        BuildNominalHeader(out serviceClient, out request, out taxJournalDetails, out journal, out response);

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
                        //currency specific configuration
                        journal.GrossContraNominalCode = ConfigurationManager.AppSettings["GCNC EUR"];
                        journal.TaxContraNominalCode = ConfigurationManager.AppSettings["TCNC EUR"];
                        journal.CurrencyCode = ConfigurationManager.AppSettings["CCODE EUR"];

                        BuildNominalLines(serviceClient, request, taxJournalDetails, journal, ref response, ref successLines, ref failureLines, rowIndex);

                        rowIndex++;
                    }
                    break;
                default:
                    Console.WriteLine("Nothing Entered ending application");
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine(string.Format("\n\nA total of {0} lines were read\n{1} lines were pushed successfully\n{2} lines failed\n{3} lines were skipped", nominal.csvList.Count, successLines, failureLines, skippedLines));
        }

        private static void BuildNominalLines(NominalLedgerServiceClient serviceClient, NominalTaxJournalUpdateRequest request, List<NominalTaxJournalDetail> taxJournalDetails, NominalTaxJournal journal, ref NominalTransactionUpdateResponse response, ref int successLines, ref int failureLines, int rowIndex)
        {
            journal.DetailLines = taxJournalDetails.ToArray();
            journal.Reference = ConfigurationManager.AppSettings["JOURREF"];
            journal.BatchReference = ConfigurationManager.AppSettings["BATREF"];
            journal.PostingDate = DateTime.Now;
            journal.HeaderDebitCreditFlag = modEnumsDebitCreditType.Credit;
            journal.Description = ConfigurationManager.AppSettings["JOURDESC"];
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
        }

        private static void BuildNominalHeader(out NominalLedgerServiceClient serviceClient, out NominalTaxJournalUpdateRequest request, out List<NominalTaxJournalDetail> taxJournalDetails, out NominalTaxJournal journal, out NominalTransactionUpdateResponse response)
        {
            serviceClient = new NominalLedgerServiceClient();
            request = new NominalTaxJournalUpdateRequest();
            taxJournalDetails = new List<NominalTaxJournalDetail>();
            journal = new NominalTaxJournal
            {
                Ledger = modEnumsNominalLedgerType.Cashbook,
                IsPayment = true
            };
            //NominalTaxJournalDetail journalDetail = new NominalTaxJournalDetail();
            response = new NominalTransactionUpdateResponse();
        }
    }
}
