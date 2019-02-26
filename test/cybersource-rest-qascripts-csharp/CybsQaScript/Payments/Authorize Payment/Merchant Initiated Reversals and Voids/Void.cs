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
    public class Void
    {
        public static void CreateVoidExec()
        {
            // Initialize Api Name
            var apiFunctionName = "Void";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/Payment/AuthorizePayment/MerchantIntiatedReversalsAndVoids/CreateVoid.csv"), true))
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

                            var clientReferenceInformationObj = new Ptsv2paymentsidreversalsClientReferenceInformation("test_void");
                            var requestBody = new VoidPaymentRequest(clientReferenceInformationObj);

                            var apiInstance = new VoidApi(clientConfig);

                            var response = apiInstance.VoidPayment(requestBody, payId);
                            Console.WriteLine(response);

                            if (response != null)
                            {
                                var row1 = new CsvRow
                                    {
                                        testCaseId,
                                        apiFunctionName,
                                        $"Pass:{clientConfig.ApiClient.ApiResponse.StatusCode}- {response.Id}",
                                        DateTime.Now.ToString("yyyy/MM/dd" + "::" + "HH:mm:ss:fff")
                                    };

                                writer.WriteRow(row1);

                                Console.WriteLine(testCaseId + "Success for void a payment: " + response.Id);

                                flag = flag + 1;
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