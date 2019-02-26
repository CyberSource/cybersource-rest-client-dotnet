using System.IO;
using CyberSource.Api;
using CyberSource.Model;
using CybsQaScript.Csv_HelperClasses;
using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CybsQaScript.Payments.CoreServices
{
    public class ProcessPayment
    {
        public static void ProcessPaymentExec()
        {
            // Initialize Api Name
            var apiFunctionName = "ProcessPayment";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/Payment/CoreServices/ProcessPayment.csv"), true))
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
                        PtsV2PaymentsPost201Response response = null;

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

                            var clientReferenceInformationObj = new Ptsv2paymentsClientReferenceInformation
                            {
                                Code = "test_payment"
                            };

                            var pointOfSaleInformationObj = new Ptsv2paymentsPointOfSaleInformation
                            {
                                CardPresent = false,
                                CatLevel = 6,
                                TerminalCapability = 4
                            };

                            var orderInformationObj = new Ptsv2paymentsOrderInformation();

                            var billToObj = new Ptsv2paymentsOrderInformationBillTo
                            {
                                Country = "US",
                                FirstName = "Joh",
                                LastName = "Deo",
                                Address1 = "901 Metro Center Blvd",
                                PostalCode = "40500",
                                Locality = "Foster City",
                                AdministrativeArea = "CA",
                                Email = "test@cybs.com"
                            };

                            orderInformationObj.BillTo = billToObj;

                            var amountDetailsObj = new Ptsv2paymentsOrderInformationAmountDetails
                            {
                                TotalAmount = amount,
                                Currency = "USD"
                            };

                            orderInformationObj.AmountDetails = amountDetailsObj;

                            var paymentInformationObj = new Ptsv2paymentsPaymentInformation();

                            var cardObj = new Ptsv2paymentsPaymentInformationCard
                            {
                                ExpirationYear = "2031",
                                Number = "4111111111111111",
                                SecurityCode = "123",
                                ExpirationMonth = "12"
                            };

                            paymentInformationObj.Card = cardObj;

                            var processingInfoObj = new Ptsv2paymentsProcessingInformation();

                            var requestObj = new CreatePaymentRequest
                            {
                                PaymentInformation = paymentInformationObj,
                                ClientReferenceInformation = clientReferenceInformationObj,
                                PointOfSaleInformation = pointOfSaleInformationObj,
                                OrderInformation = orderInformationObj,
                                ProcessingInformation = processingInfoObj
                            };

                            var apiInstance = new PaymentsApi(clientConfig);

                             requestObj.ProcessingInformation.Capture = true;
                            response = apiInstance.CreatePayment(requestObj);

                            if (response != null)
                            {
                                if (response.Status != PtsV2PaymentsPost201Response.StatusEnum.AUTHORIZED)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = Constants.MessageForIncorrectStatus + response.Status.ToString();
                                }
                                else if (response.Id == null)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = Constants.MessageNullId;
                                }
                                else if (amount != response.OrderInformation.AmountDetails.AuthorizedAmount)
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