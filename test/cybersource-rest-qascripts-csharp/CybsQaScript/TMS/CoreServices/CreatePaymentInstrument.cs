using System.IO;
using CyberSource.Api;
using CyberSource.Model;
using CybsQaScript.Csv_HelperClasses;
using LumenWorks.Framework.IO.Csv;
using System;
using Newtonsoft.Json.Linq;

namespace CybsQaScript.TMS.CoreServices
{
    public class CreatePaymentInstrument
    {
        public static void CreateTmsExec()
        {
            // Initialize Api Name
            var apiFunctionName = "CreatePaymentInstrument";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/TMS/CoreServices/CreatePaymentInstrument.csv"), true))
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

                            var requestObj = new Body2();

                            var cardObj = new Tmsv1paymentinstrumentsCard();

                            cardObj.ExpirationMonth = "09";
                            cardObj.ExpirationYear = "2022";
                            cardObj.Type = Tmsv1paymentinstrumentsCard.TypeEnum.Visa;
                            requestObj.Card = cardObj;

                            var billToObj = new Tmsv1paymentinstrumentsBillTo();

                            billToObj.FirstName = "John";
                            billToObj.LastName = "Deo";
                            billToObj.Company = "CyberSource";
                            billToObj.Address1 = "12 Main Street";
                            billToObj.Address2 = "20 My Street";
                            billToObj.Locality = "Foster City";
                            billToObj.AdministrativeArea = "CA";
                            billToObj.PostalCode = "90200";
                            billToObj.Country = "US";
                            billToObj.Email = "john.smith@example.com";
                            billToObj.PhoneNumber = "555123456";
                            requestObj.BillTo = billToObj;

                            var instrumentIdentifierObj = new Tmsv1paymentinstrumentsInstrumentIdentifier();

                            var cardObj2 = new Tmsv1instrumentidentifiersCard();

                            cardObj2.Number = "4111111111111111";
                            instrumentIdentifierObj.Card = cardObj2;

                            requestObj.InstrumentIdentifier = instrumentIdentifierObj;

                            var apiInstance = new PaymentInstrumentsApi(clientConfig);

                            var response = apiInstance.TmsV1PaymentinstrumentsPost(profileId, requestObj);

                            if (response != null)
                            {
                                if (response.State != TmsV1PaymentinstrumentsPost201Response.StateEnum.ACTIVE)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = "State is not ACTIVE";
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
