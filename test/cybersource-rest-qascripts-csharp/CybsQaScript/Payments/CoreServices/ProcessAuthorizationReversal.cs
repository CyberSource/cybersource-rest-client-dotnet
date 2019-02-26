using System.IO;
using CyberSource.Api;
using CyberSource.Model;
using CybsQaScript.Csv_HelperClasses;
using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using System.Collections.Generic;
using System;
using Newtonsoft.Json.Linq;

namespace CybsQaScript.Payments.CoreServices
{
    public class ProcessAuthorizationReversal
    {
        public static void ProcessAuthorizationReversalExec()
        {
            // Initialize Api Name
            var apiFunctionName = "ProcessAuthorizationReversal";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/Payment/CoreServices/ProcessAuthorizationReversal.csv"), true))
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

                        // TestResults csv file fields
                        var resultStatus = string.Empty;
                        var resultMessage = string.Empty;

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
                                row.Add("Message");
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
                                        item.Message,
                                        item.TimeStamp
                                    };
                                    writer.WriteRow(rowPrev);
                                }

                                flag = flag + 1;
                            }

                            var clientReferenceInformationObj = new Ptsv2paymentsidreversalsClientReferenceInformation { Code = "test_reversal" };

                            var amountInModel = new Ptsv2paymentsidreversalsOrderInformationLineItems { UnitPrice = amount };

                            var amountDetailsObj = new List<Ptsv2paymentsidreversalsOrderInformationLineItems> { amountInModel };

                            var orderInformationObj = new Ptsv2paymentsidreversalsOrderInformation(amountDetailsObj);

                            var requestBody = new AuthReversalRequest { ClientReferenceInformation = clientReferenceInformationObj, OrderInformation = orderInformationObj };
                            var apiInstance = new ReversalApi(clientConfig);

                            var response = apiInstance.AuthReversal(payId, requestBody);

                            if (response != null)
                            {
                                if (response.Status != PtsV2PaymentsReversalsPost201Response.StatusEnum.REVERSED)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = Constants.MessageForIncorrectStatus + response.Status.ToString();
                                }
                                else if (response.Id == null)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = Constants.MessageNullId;
                                }
                                else if (amount != response.ReversalAmountDetails.ReversedAmount)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = "Fails due to mismatch in amount";
                                }
                                else
                                {
                                    resultStatus = $"Pass:{clientConfig.ApiClient.ApiResponse.StatusCode}- {response.Id}";
                                    resultMessage = "Success";
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            resultStatus = $"Fail:{clientConfig.ApiClient.ApiResponse.StatusCode}";

                            var jsonResponseBody = e.GetType().GetProperty("ErrorContent").GetValue(e);
                            var jsonObj = JObject.Parse(jsonResponseBody.ToString());
                            var reasonInResponseBody = (string)jsonObj["message"];
                            resultMessage = reasonInResponseBody;
                        }
                        finally
                        {
                            if (resultStatus == null)
                            {
                                resultStatus = string.Empty;
                            }

                            if (resultMessage == null)
                            {
                                resultMessage = string.Empty;
                            }

                            var row1 = new CsvRow
                                        {
                                          testCaseId,
                                          apiFunctionName,
                                          resultStatus,
                                          resultMessage,
                                          Constants.DateTimeNow
                                        };

                            writer.WriteRow(row1);
                            flag = flag + 1;
                        }
                    }
                }
            }
        }
    }
}