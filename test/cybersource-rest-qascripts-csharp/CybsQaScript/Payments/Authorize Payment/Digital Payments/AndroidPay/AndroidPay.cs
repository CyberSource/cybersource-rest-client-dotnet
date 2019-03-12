using System.IO;
using AuthenticationSdk.core;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;
using CybsQaScript.Csv_HelperClasses;
using LumenWorks.Framework.IO.Csv;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace CybsQaScript.Payments.Authorize_Payment.Digital_Payments.AndroidPay
{
    public class AndroidPay
    {
        public static void CreatePaymentExec()
        {
            // Initialize Api Name
            var apiFunctionName = "AndroidPay";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/Payment/AuthorizePayment/DigitalPayments/AndroidPay/CreateAndroidPay.csv"), true))
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
                                Code = "33557799"
                            };

                            requestObj.ClientReferenceInformation = v2PaymentsClientReferenceInformationObj;

                            var v2PaymentsPointOfSaleInformationObj = new Ptsv2paymentsPointOfSaleInformation
                            {
                                TerminalId = "terminal",
                                CardPresent = true
                            };

                            var emvObj = new Ptsv2paymentsPointOfSaleInformationEmv
                            {
                                CardSequenceNumber = "123",
                                Tags =
                                    "9C01019A031207109F33036040209F1A0207849F370482766E409F3602001F82025C009F2608EF7753429A5D16B19F100706010A03A00000950580000400009F02060000000700009F6E0482766E409F5B04123456789F2701809F3403AB12349F0902AB129F4104AB1234AB9F0702AB129F0610123456789012345678901234567890AB9F030200005F2A0207849F7C031234569F350123"
                            };

                            v2PaymentsPointOfSaleInformationObj.Emv = emvObj;

                            v2PaymentsPointOfSaleInformationObj.EntryMode = "QRCode";
                            v2PaymentsPointOfSaleInformationObj.TerminalCapability = 4;
                            requestObj.PointOfSaleInformation = v2PaymentsPointOfSaleInformationObj;

                            var v2PaymentsProcessingInformationObj = new Ptsv2paymentsProcessingInformation
                            {
                                CommerceIndicator = "retail",
                                PaymentSolution = "006"
                            };

                            requestObj.ProcessingInformation = v2PaymentsProcessingInformationObj;

                            var v2PaymentsOrderInformationObj = new Ptsv2paymentsOrderInformation();

                            var v2PaymentsOrderInformationBillToObj = new Ptsv2paymentsOrderInformationBillTo
                            {
                                Country = "US",
                                LastName = "Deo",
                                Address2 = "test",
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

                            var amountDetailsObj = new Ptsv2paymentsOrderInformationAmountDetails
                            {
                                TotalAmount = amount,
                                Currency = "USD"
                            };

                            v2PaymentsOrderInformationObj.AmountDetails = amountDetailsObj;

                            requestObj.OrderInformation = v2PaymentsOrderInformationObj;

                            var v2PaymentsPaymentInformationObj = new Ptsv2paymentsPaymentInformation();

                            var tokenizedCardObj = new Ptsv2paymentsPaymentInformationTokenizedCard
                            {
                                TransactionType = "1",
                                RequestorId = "12345678901"
                            };

                            v2PaymentsPaymentInformationObj.TokenizedCard = tokenizedCardObj;

                            var v2PaymentsPaymentInformationCardObj = new Ptsv2paymentsPaymentInformationCard
                            {
                                Type = "001"
                            };

                            // v2paymentsPaymentInformationCardObj.TrackData = ";4111111111111111=21121019761186800000?";
                            v2PaymentsPaymentInformationObj.Card = v2PaymentsPaymentInformationCardObj;

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
