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

namespace CybsQaScript.Payments.Authorize_Payment.Merchant_Initiated_Reversals_and_Voids
{
    public class MirvAuthReversal
    {
        public static void CreateAuthReversalExec()
        {
            // Initialize Api Name
            var apiFunctionName = "MirvAuthReversal";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/Payment/AuthorizePayment/MerchantIntiatedReversalsAndVoids/CreateAuthReversal.csv"), true))
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

                            var requestObj = new AuthReversalRequest();

                            var v2PaymentsClientReferenceInformationObj = new Ptsv2paymentsidreversalsClientReferenceInformation
                            {
                                Code = "TC50171_1"
                            };

                            requestObj.ClientReferenceInformation = v2PaymentsClientReferenceInformationObj;

                            // var v2paymentsOrderInformationObj = new V2paymentsidreversalsOrderInformation();

                            // var amountDetailsObj = new V2paymentsidreversalsOrderInformationAmountDetails();

                            // amountDetailsObj.Currency = "USD";
                            // v2paymentsOrderInformationObj.AmountDetails = amountDetailsObj;

                            // requestObj.OrderInformation = v2paymentsOrderInformationObj;

                            var reversalInformationObj = new Ptsv2paymentsidreversalsReversalInformation();

                            var amountDetailsObj = new Ptsv2paymentsidreversalsReversalInformationAmountDetails
                            {
                                TotalAmount = amount
                            };

                            reversalInformationObj.AmountDetails = amountDetailsObj;

                            requestObj.ReversalInformation = reversalInformationObj;

                            var apiInstance = new ReversalApi(clientConfig);

                            var response = apiInstance.AuthReversal(payId, requestObj);
                            Console.WriteLine(response);

                            if (response != null)
                            {
                                try
                                {

                                    Assert.AreEqual(amount, response.ReversalAmountDetails.ReversedAmount);

                                    Console.WriteLine("Assertion Succeeded. Valid amount.");

                                    var row1 = new CsvRow
                                    {
                                        testCaseId,
                                        apiFunctionName,
                                        $"Pass:{clientConfig.ApiClient.ApiResponse.StatusCode}- {response.Id}",
                                        DateTime.Now.ToString("yyyy/MM/dd" + "::" + "HH:mm:ss:fff")
                                    };

                                    writer.WriteRow(row1);

                                    Console.WriteLine(testCaseId + "Success for auth reversal: " + response.Id);

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