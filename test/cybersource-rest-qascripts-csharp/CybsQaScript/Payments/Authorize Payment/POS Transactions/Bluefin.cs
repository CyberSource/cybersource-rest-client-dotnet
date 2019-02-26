using System.IO;
using AuthenticationSdk.core;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;
using CybsQaScript.Csv_HelperClasses;
using LumenWorks.Framework.IO.Csv;
using Newtonsoft.Json;
using NUnit.Framework;
using System;

namespace CybsQaScript.Payments.Authorize_Payment.POS_Transactions
{
    public class Bluefin
    {
        public static void CreatePaymentExec()
        {
            // Initialize Api Name
            var apiFunctionName = "Bluefin";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/Payment/AuthorizePayment/POSTransactions/CreateBluefin.csv"), true))
            {
                var fieldCount = csv.FieldCount;

                // Writing  to output CSV file
                using (var writer = new CsvFileWriter(@"../../CSV_Files/TestReport/TestResults.csv"))
                {
                    var flag = 0;
                    var headers = csv.GetFieldHeaders();

                    while (csv.ReadNextRecord())
                    {
                        // Read Input Csv File
                        string amount = null;
                        string testCaseId = null;
                        string message = null;

                        for (int i = 0; i < fieldCount; i++)
                        {
                            switch (headers[i])
                            {
                                case "testCaseId":
                                    testCaseId = csv[i];
                                    break;
                                case "amount":
                                    amount = csv[i];
                                    break;
                                case "message":
                                    message = csv[i];
                                    break;
                            }
                        }

                        // Write to output file
                        var row = new CsvRow();

                        // Intialize Api Configuration and client configuration
                        var configDictionary = new Configuration().GetConfiguration();
                        var clientConfig = new CyberSource.Client.Configuration(merchConfigDictObj: configDictionary);

                        try
                        {
                            // To write existing data of output csv file
                            if (flag == 0)
                            {
                                row.Add("TestCaseId");
                                row.Add("APIName");
                                row.Add("Status");
                                row.Add("TimeStamp");
                                writer.WriteRow(row);

                                // Write previous records
                                foreach (var item in recordsPrev)
                                {
                                    var rowPrev = new CsvRow
                                    {
                                        item.TestCaseId,
                                        item.APIName,
                                        item.Status,
                                        item.TimeStamp
                                    };
                                    writer.WriteRow(rowPrev);
                                }

                                flag = flag + 1;
                            }

                            var requestObj = new CreatePaymentRequest();

                            var v2PaymentsClientReferenceInformationObj = new Ptsv2paymentsClientReferenceInformation
                            {
                                Code = "demomerchant"
                            };

                            requestObj.ClientReferenceInformation = v2PaymentsClientReferenceInformationObj;

                            var v2PaymentsPointOfSaleInformationObj = new Ptsv2paymentsPointOfSaleInformation
                            {
                                CardPresent = true,
                                CatLevel = 1,
                                EntryMode = "keyed",
                                TerminalCapability = 2
                            };

                            requestObj.PointOfSaleInformation = v2PaymentsPointOfSaleInformationObj;

                            var v2PaymentsProcessingInformationObj = new Ptsv2paymentsProcessingInformation
                            {
                                CommerceIndicator = "retail"
                            };

                            requestObj.ProcessingInformation = v2PaymentsProcessingInformationObj;

                            var v2PaymentsOrderInformationObj = new Ptsv2paymentsOrderInformation();

                            var v2PaymentsOrderInformationBillToObj = new Ptsv2paymentsOrderInformationBillTo
                            {
                                Country = "US",
                                LastName = "Deo",
                                Address1 = "201 S. Division St.",
                                PostalCode = "48104-2201",
                                Locality = "Ann Arbor",
                                AdministrativeArea = "MI",
                                FirstName = "John",
                                PhoneNumber = "999999999",
                                District = "MI",
                                Email = "test@cybs.com"
                            };

                            v2PaymentsOrderInformationObj.BillTo = v2PaymentsOrderInformationBillToObj;

                            var amountDetailsObj = new Ptsv2paymentsOrderInformationAmountDetails
                            {
                                TotalAmount = amount,
                                Currency = "USD"
                            };

                            v2PaymentsOrderInformationObj.AmountDetails = amountDetailsObj;

                            requestObj.OrderInformation = v2PaymentsOrderInformationObj;

                            var v2PaymentsPaymentInformationObj = new Ptsv2paymentsPaymentInformation();

                            var v2PaymentsPaymentInformationCardObj = new Ptsv2paymentsPaymentInformationCard
                            {
                                ExpirationYear = "2050",
                                ExpirationMonth = "12"
                            };

                            v2PaymentsPaymentInformationObj.Card = v2PaymentsPaymentInformationCardObj;

                            var v2PaymentsPaymentInformationFluidDataObj = new Ptsv2paymentsPaymentInformationFluidData
                            {
                                Descriptor = "Ymx1ZWZpbg==",
                                Value =
                                    "02d700801f3c20008383252a363031312a2a2a2a2a2a2a2a303030395e46444d53202020202020202020202020202020202020202020205e323231322a2a2a2a2a2a2a2a3f2a3b363031312a2a2a2a2a2a2a2a303030393d323231322a2a2a2a2a2a2a2a3f2a7a75ad15d25217290c54b3d9d1c3868602136c68d339d52d98423391f3e631511d548fff08b414feac9ff6c6dede8fb09bae870e4e32f6f462d6a75fa0a178c3bd18d0d3ade21bc7a0ea687a2eef64551751e502d97cb98dc53ea55162cdfa395431323439323830303762994901000001a000731a8003"
                            };

                            v2PaymentsPaymentInformationObj.FluidData = v2PaymentsPaymentInformationFluidDataObj;

                            requestObj.PaymentInformation = v2PaymentsPaymentInformationObj;

                            var apiInstance = new PaymentsApi(clientConfig);

                            var response = apiInstance.CreatePayment(requestObj);
                            Console.WriteLine(response);

                            if (response != null)
                            {
                                try
                                {
                                    Assert.AreEqual(amount, response.OrderInformation.AmountDetails.AuthorizedAmount);

                                    Console.WriteLine("Assertion Succeeded. Valid Amount.");

                                    var row1 = new CsvRow
                                    {
                                      testCaseId,
                                      apiFunctionName,
                                      $"Pass:{clientConfig.ApiClient.ApiResponse.StatusCode}- {response.Id}",
                                       DateTime.Now.ToString("yyyy/MM/dd" + "::" + "HH:mm:ss:fff")
                                    };

                                    writer.WriteRow(row1);

                                    Console.WriteLine(testCaseId + "Success " + message);

                                    flag = flag + 1;
                                }
                                catch
                                {
                                    var row1 = new CsvRow
                                    {
                                     testCaseId,
                                     apiFunctionName,
                                     $"Assertion Failed!: {clientConfig.ApiClient.ApiResponse.StatusCode}- {response.Id}",
                                     DateTime.Now.ToString("yyyy/MM/dd" + "::" + "HH:mm:ss:fff")
                                    };

                                    writer.WriteRow(row1);
                                    Console.WriteLine("Assertion Failed! Invalid details fetched.");
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            var row2 = new CsvRow
                            {
                                testCaseId,
                                apiFunctionName,
                                $"Fail:{clientConfig.ApiClient.ApiResponse.StatusCode} - {e.Message}",
                                DateTime.Now.ToString("yyyy/MM/dd" + "::" + "HH:mm:ss:fff")
                            };
                            writer.WriteRow(row2);
                            flag = flag + 1;
                            Console.WriteLine(testCaseId + "Error Message: " + e.Message);
                        }
                    }
                }
            }
        }
    }
}
