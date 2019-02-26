using System.IO;
using CyberSource.Api;
using CyberSource.Model;
using CybsQaScript.Csv_HelperClasses;
using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using System;
using Newtonsoft.Json.Linq;

namespace CybsQaScript.TMS.CoreServices
{
    public class CreateInstrumentIdentifier
    {
        public static void CreateTmsExec()
        {
            // Initialize Api Name
            var apiFunctionName = "CreateInstrumentIdentifier";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/TMS/CoreServices/CreateInstrumentIdentifier.csv"), true))
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
                        string prevTransactionId = null;
                        string profileId = null;
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
                                case "prevTransactionId":
                                    prevTransactionId = csv[i];
                                    break;
                                case "profileId":
                                    profileId = csv[i];
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

                            var requestObj = new Body();

                            var cardObj = new Tmsv1instrumentidentifiersCard();

                            cardObj.Number = "1234567890987656";
                            requestObj.Card = cardObj;

                            var processingInformationObj = new Tmsv1instrumentidentifiersProcessingInformation();

                            var authorizationOptionsObj = new Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptions();

                            var initiatorObj = new Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptionsInitiator();

                            var merchantInitiatedTransactionObj = new Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransaction();

                            merchantInitiatedTransactionObj.PreviousTransactionId = prevTransactionId;
                            initiatorObj.MerchantInitiatedTransaction = merchantInitiatedTransactionObj;

                            authorizationOptionsObj.Initiator = initiatorObj;

                            processingInformationObj.AuthorizationOptions = authorizationOptionsObj;

                            requestObj.ProcessingInformation = processingInformationObj;
                            var apiInstance = new InstrumentIdentifiersApi(clientConfig);

                            var response = apiInstance.TmsV1InstrumentidentifiersPost(profileId, requestObj);

                            if (response != null)
                            {
                                if (response.State != TmsV1InstrumentidentifiersPost200Response.StateEnum.ACTIVE)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = "State is not ACTIVE";
                                }
                                else if (response.ProcessingInformation.AuthorizationOptions.Initiator.MerchantInitiatedTransaction.PreviousTransactionId != prevTransactionId)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = "Previous transaction ID in response does not match with the provided ID";
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
                            var reasonInResponseBody = (string)jsonObj["errors"][0]["message"];
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