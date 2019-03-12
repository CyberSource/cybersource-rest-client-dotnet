using System.IO;
using CyberSource.Api;
using CyberSource.Model;
using NUnit.Framework;
using CybsQaScript.Csv_HelperClasses;
using LumenWorks.Framework.IO.Csv;
using System;
using Newtonsoft.Json.Linq;

namespace CybsQaScript.TMS.CoreServices
{
    public class UpdatePaymentInstrument
    {
        public static void UpdateTmsExec()
        {
            // Initialize Api Name
            var apiFunctionName = "UpdatePaymentInstrument";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/TMS/CoreServices/UpdatePaymentInstrument.csv"), true))
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
                        string profileId = null;
                        string tokenId = null;
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
                                case "profileId":
                                    profileId = csv[i];
                                    break;
                                case "tokenId":
                                    tokenId = csv[i];
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

                            var requestObj = new Body3();

                            var cardObj = new Tmsv1paymentinstrumentsCard
                            {
                                ExpirationMonth = "09",
                                ExpirationYear = "2022",
                                Type = Tmsv1paymentinstrumentsCard.TypeEnum.Visa
                            };

                            requestObj.Card = cardObj;

                            var billToObj = new Tmsv1paymentinstrumentsBillTo
                            {
                                FirstName = "John",
                                LastName = "Smith",
                                Company = "CyberSource",
                                Address1 = "12 Main Street",
                                Address2 = "20 My Street",
                                Locality = "San Francisco",
                                AdministrativeArea = "CA",
                                PostalCode = "90200",
                                Country = "US",
                                Email = "john.smith@example.com",
                                PhoneNumber = "555123456"
                            };

                            requestObj.BillTo = billToObj;

                            var instrumentIdentifierObj = new Tmsv1paymentinstrumentsInstrumentIdentifier();

                            var cardObj2 = new Tmsv1instrumentidentifiersCard
                            {
                                Number = "4111111111111111"
                            };

                            instrumentIdentifierObj.Card = cardObj2;

                            requestObj.InstrumentIdentifier = instrumentIdentifierObj;

                            var apiInstance = new PaymentInstrumentsApi(clientConfig);

                            var response = apiInstance.TmsV1PaymentinstrumentsTokenIdPatch(profileId, tokenId, requestObj);

                            if (response != null)
                            {
                                if (response.State != TmsV1PaymentinstrumentsPost201Response.StateEnum.ACTIVE)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = "State is not ACTIVE";
                                }
                                else if (response.Id != tokenId)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = "Token ID does not match";
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
