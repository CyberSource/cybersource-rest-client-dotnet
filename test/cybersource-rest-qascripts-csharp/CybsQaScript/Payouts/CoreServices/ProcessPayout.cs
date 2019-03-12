using System.IO;
using CyberSource.Api;
using CyberSource.Model;
using CybsQaScript.Csv_HelperClasses;
using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CybsQaScript.Payouts.CoreServices
{
    public class ProcessPayout
    {
        public static void ProcessPayoutExec()
        {
            // Initialize Api Name
            var apiFunctionName = "ProcessPayout";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/Payouts/CoreServices/ProcessPayout.csv"), true))
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
                        string cleintRefInfoCode = null;
                        string businessAppId = null;
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
                                case "cleintRefInfoCode":
                                    cleintRefInfoCode = csv[i];
                                    break;
                                case "businessAppId":
                                    businessAppId = csv[i];
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

                            var requestObj = new PtsV2PayoutsPostResponse();

                            var clientReferenceInformationObj = new PtsV2PaymentsPost201ResponseClientReferenceInformation
                            {
                                Code = cleintRefInfoCode
                            };

                            requestObj.ClientReferenceInformation = clientReferenceInformationObj;

                            var senderInformationObj = new Ptsv2payoutsSenderInformation
                            {
                                ReferenceNumber = "1234567890",
                                Address1 = "900 Metro Center Blvd.900",
                                CountryCode = "US",
                                Locality = "Foster City",
                                Name = "Thomas Jefferson",
                                AdministrativeArea = "CA"
                            };

                            var accountObj = new Ptsv2payoutsSenderInformationAccount
                            {
                                Number = "1234567890123456789012345678901234",
                                FundsSource = "01"
                            };

                            senderInformationObj.Account = accountObj;

                            requestObj.SenderInformation = senderInformationObj;

                            var processingInformationObj = new Ptsv2payoutsProcessingInformation
                            {
                                CommerceIndicator = "internet",
                                BusinessApplicationId = businessAppId,
                                NetworkRoutingOrder = "ECG"
                            };

                            requestObj.ProcessingInformation = processingInformationObj;
                            // var payoutsOptionsObj = new PayoutsOptions();

                            // payoutsOptionsObj.RetrievalReferenceNumber = "123456789012";
                            // payoutsOptionsObj.AcquirerBin = "567890124";
                            // requestObj.PayoutsOptions = payoutsOptionsObj;

                            // requestObj.ReconciliationId = "1087488702VIAQNSPQ";

                            var orderInformationObj = new Ptsv2payoutsOrderInformation();

                            var amountDetailsObj = new Ptsv2payoutsOrderInformationAmountDetails
                            {
                                TotalAmount = amount,
                                Currency = "USD"
                            };

                            orderInformationObj.AmountDetails = amountDetailsObj;

                            requestObj.OrderInformation = orderInformationObj;

                            var merchantInformationObj = new Ptsv2payoutsMerchantInformation();

                            var merchantDescriptorObj = new Ptsv2payoutsMerchantInformationMerchantDescriptor
                            {
                                Country = "US",
                                PostalCode = "94440",
                                Locality = "FC",
                                Name = "Thomas",
                                AdministrativeArea = "CA"
                            };

                            merchantInformationObj.MerchantDescriptor = merchantDescriptorObj;

                            requestObj.MerchantInformation = merchantInformationObj;

                            var paymentInformationObj = new Ptsv2payoutsPaymentInformation();

                            var cardObj = new Ptsv2payoutsPaymentInformationCard
                            {
                                ExpirationYear = "2025",
                                Number = "4111111111111111",
                                ExpirationMonth = "12",
                                Type = "001",
                                SourceAccountType = "CH"
                            };

                            paymentInformationObj.Card = cardObj;

                            requestObj.PaymentInformation = paymentInformationObj;

                            var recipientInformationObj = new Ptsv2payoutsRecipientInformation
                            {
                                FirstName = "John",
                                LastName = "Doe",
                                Address1 = "Paseo Padre Boulevard",
                                Locality = "Foster City",
                                AdministrativeArea = "CA",
                                PostalCode = "94400",
                                PhoneNumber = "6504320556",
                                DateOfBirth = "19801009",
                                Country = "US"
                            };

                            requestObj.RecipientInformation = recipientInformationObj;

                            var apiInstance = new ProcessAPayoutApi(clientConfig);

                            var response = apiInstance.OctCreatePaymentWithHttpInfo(requestObj);

                            if (response != null)
                            {
                                var responseBody = clientConfig.ApiClient.ApiResponse.Data;
                                var jsonResponseBody = JsonConvert.DeserializeObject(responseBody);
                                var jsonObj = JObject.Parse(jsonResponseBody.ToString());

                                var amountInResponse = (string)jsonObj["orderInformation"]["amountDetails"]["totalAmount"];
                                var statusInResponse = (string)jsonObj["status"];
                                var idInResponse = (string)jsonObj["id"];

                                if (statusInResponse != "ACCEPTED")
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = Constants.MessageForIncorrectStatus + "ACCEPTED";
                                }
                                else if (idInResponse == null)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = Constants.MessageNullId;
                                }
                                else if (amount != amountInResponse)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = "Fails due to mismatch in amount";
                                }
                                else
                                {
                                    resultStatus = $"Pass:{clientConfig.ApiClient.ApiResponse.StatusCode}- {idInResponse}";
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