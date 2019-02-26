using System;
using System.IO;
using CyberSource.Api;
using CyberSource.Model;
using CybsQaScript.Csv_HelperClasses;
using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using Newtonsoft.Json.Linq;

namespace CybsQaScript.Payments.CoreServices
{
    public class VoidRefund
    {
        public static void VoidRefundExec()
        {
            // Initialize Api Name
            var apiFunctionName = "VoidRefund";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/Payment/CoreServices/VoidRefund.csv"), true))
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
                        string refundId = null;
                        string status = null;
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
                                case "refundId":
                                    refundId = csv[i];
                                    break;
                                case "status":
                                    status = csv[i];
                                    break;
                                case "message":
                                    message = csv[i];
                                    break;
                            }
                        }

                        string refId = refundId;
                        string statusInp = status;

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

                            // Create Instance of Payment Api
                            var clientReferenceInformationObj = new Ptsv2paymentsidreversalsClientReferenceInformation("test_refund_void");
                            var requestBody = new VoidRefundRequest(clientReferenceInformationObj);

                            var apiInstance = new VoidApi(clientConfig);

                            var response = apiInstance.VoidRefund(requestBody, refId);

                            if (response != null)
                            {
                                if (response.Status != PtsV2PaymentsVoidsPost201Response.StatusEnum.VOIDED)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = Constants.MessageForIncorrectStatus + response.Status.ToString();
                                }
                                else if (response.Id == null)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = Constants.MessageNullId;
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
