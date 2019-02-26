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

namespace CybsQaScript.Payments.Authorize_Payment.Simple_Auth
{
    public class RetailEmvContactless
    {
        public static void CreatePaymentExec()
        {
            // Initialize Api Name
            var apiFunctionName = "RetailEmvContactless";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/Payment/AuthorizePayment/SimpleAuth/RetailEMVcontactless.csv"), true))
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
                                Code = "TC50171_16"
                            };

                            requestObj.ClientReferenceInformation = v2PaymentsClientReferenceInformationObj;

                            var v2PaymentsPointOfSaleInformationObj = new Ptsv2paymentsPointOfSaleInformation
                            {
                                CardPresent = true,
                                CatLevel = 1,
                                EntryMode = "contact",
                                TerminalCapability = 1

                                // v2PaymentsPointOfSaleInformationObj.EndlessAisleTransactionIndicator = "true";
                            };

                            requestObj.PointOfSaleInformation = v2PaymentsPointOfSaleInformationObj;

                            var v2PaymentsProcessingInformationObj = new Ptsv2paymentsProcessingInformation
                            {
                                CommerceIndicator = "retail",
                                PaymentSolution = "011"
                            };

                            requestObj.ProcessingInformation = v2PaymentsProcessingInformationObj;

                            var v2PaymentsAggregatorInformationSubMerchantObj = new Ptsv2paymentsAggregatorInformationSubMerchant
                            {
                                CardAcceptorId = "1234567890",
                                Country = "US",
                                PhoneNumber = "650-432-0000",
                                Address1 = "900 Metro Center",
                                PostalCode = "94404-2775",
                                Locality = "Foster City",
                                Name = "Visa Inc",
                                AdministrativeArea = "CA",
                                Region = "PEN",
                                Email = "test@cybs.com"
                            };

                            var v2PaymentsAggregatorInformationObj = new Ptsv2paymentsAggregatorInformation
                            {
                                SubMerchant = v2PaymentsAggregatorInformationSubMerchantObj,
                                Name = "V-Internatio",
                                AggregatorId = "123456789"
                            };

                            requestObj.AggregatorInformation = v2PaymentsAggregatorInformationObj;

                            var v2PaymentsOrderInformationObj = new Ptsv2paymentsOrderInformation();

                            var v2PaymentsOrderInformationBillToObj = new Ptsv2paymentsOrderInformationBillTo
                            {
                                Country = "US",
                                LastName = "Deo",
                                Address2 = "Address 2",
                                Address1 = "201 S. Division St.",
                                PostalCode = "48104-2201",
                                Locality = "Ann Arbor",
                                AdministrativeArea = "MI",
                                FirstName = "John",
                                PhoneNumber = "999999999",
                                District = "MI",
                                BuildingNumber = "123",
                                Company = "Visa",
                                Email = "test@cybs.com"
                            };

                            v2PaymentsOrderInformationObj.BillTo = v2PaymentsOrderInformationBillToObj;

                            var v2PaymentsOrderInformationAmountDetailsObj = new Ptsv2paymentsOrderInformationAmountDetails
                            {
                                TotalAmount = amount,
                                Currency = "USD"
                            };

                            v2PaymentsOrderInformationObj.AmountDetails = v2PaymentsOrderInformationAmountDetailsObj;

                            requestObj.OrderInformation = v2PaymentsOrderInformationObj;

                            var v2PaymentsPaymentInformationObj = new Ptsv2paymentsPaymentInformation();

                            var v2PaymentsPaymentInformationFluidDataObj = new Ptsv2paymentsPaymentInformationFluidData
                            {
                                Descriptor = "EMV.PAYMENT.AnywhereCommerce.Walker",
                                Value =
                                    "ewogICJkYXRhIiA6ICJOZmNwRURiK1dLdzBnQkpsaTRcL1hlWm1ITzdUSng0bnRoMnc2Mk9ITVJQK3hCRlFPdFE0WWpRcnY0RmFkOHh6VExqT2VFQm5iNHFzeGZMYTNyNXcxVEdXblFGQnNzMWtPYnA0XC95alNtVE1JSGVjbGc5OFROaEhNb0VRcjJkRkFqYVpBTFAxSlBsdVhKSVwvbTZKSmVwNGh3VHRWZE16Z2laSUhnaWFCYzNXZVd1ZnYzc1l0cGRaZDZYZENEUFdLeXFkYjBJdUtkdkpBPT0iLAogICJzaWduYXR1cmUiIDogIkFxck1pKzc0cm1GeVBKVE9HN3NuN2p5K1YxTlpBZUNJVE56TW01N1B5cmc9IiwKICAic2lnbmF0dXJlQWxnSW5mbyIgOiAiSE1BQ3dpdGhTSEEyNTYiLAogICJoZWFkZXIiIDogewogICAgInRyYW5zYWN0aW9uSWQiIDogIjE1MTU2MjI2NjIuMTcyMjIwIiwKICAgICJwdWJsaWNLZXlIYXNoIiA6ICJcLzdmdldqRVhMazJPRWpcL3Z5bk1jeEZvMmRWSTlpRXVoT2Nab0tHQnpGTmM9IiwKICAgICJhcHBsaWNhdGlvbkRhdGEiIDogIkN5YmVyU291cmNlLlZNcG9zS2l0IiwKICAgICJlcGhlbWVyYWxQdWJsaWNLZXkiIDogIk1Ga3dFd1lIS29aSXpqMENBUVlJS29aSXpqMERBUWNEUWdBRW1JN0tScnRNN2NNelk5Zmw2UWt2NEQzdE9jU0NYR1hoOFwvK2R4K2s5c1Zrbk05UFQrOXRqMzk2YWF6QjRcL0hYaWlLRW9DXC9jUzdoSzF6UFk3MVwvN0pUUT09IgogIH0sCiAgInZlcnNpb24iIDogIjEuMCIKfQ=="
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
