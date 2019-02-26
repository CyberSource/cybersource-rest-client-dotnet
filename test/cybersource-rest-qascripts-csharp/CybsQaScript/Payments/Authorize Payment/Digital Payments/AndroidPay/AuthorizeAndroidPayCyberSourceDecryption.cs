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
    public class AuthorizeAndroidPayCyberSourceDecryption
    {
        public static void CreatePaymentExec()
        {
            // Initialize Api Name
            var apiFunctionName = "AuthAndroidPayCybsDecryption";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/Payment/AuthorizePayment/DigitalPayments/AndroidPay/CreateAuthorizeAndroidPayCybersourceDecryption.csv"), true))
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
                                Code = "TC_MPOS_Paymentech_1"
                            };

                            requestObj.ClientReferenceInformation = v2PaymentsClientReferenceInformationObj;

                            var v2PaymentsProcessingInformationObj = new Ptsv2paymentsProcessingInformation
                            {
                                PaymentSolution = "006"
                            };

                            requestObj.ProcessingInformation = v2PaymentsProcessingInformationObj;

                            var v2PaymentsOrderInformationObj = new Ptsv2paymentsOrderInformation();

                            var v2PaymentsOrderInformationBillToObj = new Ptsv2paymentsOrderInformationBillTo
                            {
                                Country = "US",
                                LastName = "Deo",
                                Address1 = "201 S. Division St.",
                                PostalCode = "48104-2201",
                                FirstName = "John"
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

                            var v2PaymentsPaymentInformationFluidDataObj = new Ptsv2paymentsPaymentInformationFluidData
                            {
                                Value =
                                    "ewoJInB1YmxpY0tleUhhc2giICAgIDogIlNKU1NSN0Q4VHZxbHBPWmcwMFhWY1pYclI1czJBUTJxYU8rK0VTVnl4clU9IiwKCSJ2ZXJzaW9uIjogIjEuMCIsCgkiZGF0YSIgOiAiZXdvSkltVnVZM0o1Y0hSbFpFMWxjM05oWjJVaU9pQWlSbFZrUjNWQlFWVlpRVWd2VXpreU1rczNXVE5QTm5VclpsWXJlbU5wUjBwamN6SkRPVVJ1Ykd0TlYyZzJZa2hVS3pCd2FsTTJjbkZJTDFoTWVYcGlSVTg1WWtsdkwyUmtUbTEzYVRGblRqbEVZV1Y2Y3pOdlpFNXVValZ0Ykd4MlIzWktNRVpYU0ZKeVRTOVRabVF6TlRZeVlqaFNObFpST1ZwS1ZUTmFNMXBDT0ZSWmFtdGpiWGhVTHpkSWQwaHdVWGgxUmpaT2JXZHNWMmwwVnk5VU0ya3dSVE5QV1dwUkswZGtWbTFZTVVOaVoxbHNlWHBRTVVOSWFrNXdUV3RxVUhvMGVrTlVibUpHTmxGc1pIWkxaVFJvYkhselpuZ3pPVzlwVEU5YVIxcG9SSGhVVDNwU2VXUXhWekl6VVQwOUlpd0tDU0psY0dobGJXVnlZV3hRZFdKc2FXTkxaWGtpT2lBaVRVWnJkMFYzV1VoTGIxcEplbW93UTBGUldVbExiMXBKZW1vd1JFRlJZMFJSWjBGRmJ6RnlUMnBGU2t4SUsxWk1VRGQwUkV4YVdHSnBia2xaWWtjeVYwOXZjMDlDZWs5TVMyVkRiMU5ZVm1KSk9XNTBjWFpHT1dKelRtRlhOWEJYUkRsbFdsUXZXSHBHZURoTGIwdEROVmhOYVRSblZXWkdRMUU5UFNJc0Nna2lkR0ZuSWpvZ0lrVkRkRFZwVW1kM1VscGxMM2hJWlRCSU1rMXJhRUpGTXpSM1dYVXllVFJKZG13ME5uUjRXSFlyVjFFOUlncDkiCn0="
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
