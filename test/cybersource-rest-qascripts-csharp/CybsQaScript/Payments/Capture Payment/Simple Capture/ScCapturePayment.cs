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

namespace CybsQaScript.Payments.Capture_Payment.Simple_Capture
{
    public class ScCapturePayment
    {
        public static void CapturePaymentExec()
        {
            // Initialize Api Name
            var apiFunctionName = "ScCapturePayment";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/Payment/CapturePayment/SimpleCapture/CreateCapturePayment.csv"), true))
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
                        string paymentId = null;
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
                                case "paymentId":
                                    paymentId = csv[i];
                                    break;
                                case "amount":
                                    amount = csv[i];
                                    break;
                                case "message":
                                    message = csv[i];
                                    break;
                            }
                        }
                        string payId = paymentId;

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

                            var requestObj = new CapturePaymentRequest();

                            var v2PaymentsClientReferenceInformationObj = new Ptsv2paymentsClientReferenceInformation
                            {
                                Code = "1234567890"
                            };

                            requestObj.ClientReferenceInformation = v2PaymentsClientReferenceInformationObj;

                            /*
                            var v2paymentsPointOfSaleInformationObj = new V2paymentsidcapturesPointOfSaleInformation();

                            v2paymentsPointOfSaleInformationObj.CardPresent = "false";
                            v2paymentsPointOfSaleInformationObj.CatLevel = "6";
                            v2paymentsPointOfSaleInformationObj.TerminalCapability = "4";
                            requestObj.PointOfSaleInformation = v2paymentsPointOfSaleInformationObj;
                            */

                            var v2PaymentsOrderInformationObj = new Ptsv2paymentsidcapturesOrderInformation();

                            var v2PaymentsOrderInformationBillToObj = new Ptsv2paymentsidcapturesOrderInformationBillTo
                            {
                                Country = "US",
                                FirstName = "John",
                                LastName = "Deo",
                                Address1 = "901 Metro Center Blvd",
                                PostalCode = "40500",
                                Locality = "Foster City",
                                AdministrativeArea = "CA",
                                Email = "test@cybs.com"
                            };

                            v2PaymentsOrderInformationObj.BillTo = v2PaymentsOrderInformationBillToObj;

                            var v2PaymentsOrderInformationAmountDetailsObj = new Ptsv2paymentsidcapturesOrderInformationAmountDetails
                            {
                                TotalAmount = amount,
                                Currency = "USD"
                            };

                            v2PaymentsOrderInformationObj.AmountDetails = v2PaymentsOrderInformationAmountDetailsObj;

                            requestObj.OrderInformation = v2PaymentsOrderInformationObj;
                            var apiInstance = new CaptureApi(clientConfig);

                            var response = apiInstance.CapturePayment(requestObj, payId);
                            Console.WriteLine(response);

                            if (response != null)
                            {
                                try
                                {
                                    Assert.AreEqual(amount, response.OrderInformation.AmountDetails.TotalAmount);

                                    Console.WriteLine("Assertion Succeeded. Valid amount.");

                                    var row1 = new CsvRow
                                    {
                                        testCaseId,
                                        apiFunctionName,
                                        $"Pass:{clientConfig.ApiClient.ApiResponse.StatusCode}- {response.Id}",
                                        DateTime.Now.ToString("yyyy/MM/dd" + "::" + "HH:mm:ss:fff")
                                    };

                                    writer.WriteRow(row1);

                                    Console.WriteLine(testCaseId + "Success for capture a payment: " + response.Id);

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