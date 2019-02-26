using System.IO;
using CyberSource.Api;
using CyberSource.Model;
using CybsQaScript.Csv_HelperClasses;
using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using System;
using Newtonsoft.Json.Linq;

namespace CybsQaScript.Payments.CoreServices
{
    public class RefundCapture
    {
        public static void RefundCaptureExec()
        {
            // Initialize Api Name
            var apiFunctionName = "RefundCapture";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/Payment/CoreServices/RefundCapture.csv"), true))
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
                        string captureId = null;
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
                                case "captureId":
                                    captureId = csv[i];
                                    break;
                                case "amount":
                                    amount = csv[i];
                                    break;
                                case "message":
                                    message = csv[i];
                                    break;
                            }
                        }

                        string capId = captureId;

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

                            var requestObj = new RefundCaptureRequest();

                            var clientReferenceInformationObj = new Ptsv2paymentsClientReferenceInformation
                            {
                                Code = "test_refund_capture"
                            };

                            requestObj.ClientReferenceInformation = clientReferenceInformationObj;

                            var buyerInformationObj = new Ptsv2paymentsidcapturesBuyerInformation
                            {
                                MerchantCustomerId = "123456abcd"
                            };

                            requestObj.BuyerInformation = buyerInformationObj;

                            var subMerchantObj = new Ptsv2paymentsidcapturesAggregatorInformationSubMerchant
                            {
                                Country = "US",
                                PhoneNumber = "650-432-0000",
                                Address1 = "900 Metro Center",
                                PostalCode = "94404-2775",
                                Locality = "Foster City",
                                Name = "Visa Inc",
                                AdministrativeArea = "CA",
                                Email = "test@cybs.com"

                                // subMerchantObj.CardAcceptorID = "1234567890";
                                // subMerchantObj.Region = "PEN";
                            };

                            var aggregatorInformationObj = new Ptsv2paymentsidcapturesAggregatorInformation
                            {
                                SubMerchant = subMerchantObj,
                                Name = "V-Internatio",
                                AggregatorId = "123456789"
                            };

                            requestObj.AggregatorInformation = aggregatorInformationObj;

                            var orderInformationObj = new Ptsv2paymentsidrefundsOrderInformation();

                            var shippingDetailsObj = new Ptsv2paymentsidcapturesOrderInformationShippingDetails
                            {
                                ShipFromPostalCode = "47404"
                            };

                            orderInformationObj.ShippingDetails = shippingDetailsObj;

                            var billToObj = new Ptsv2paymentsidcapturesOrderInformationBillTo
                            {
                                Country = "US",
                                FirstName = "John",
                                LastName = "Deo",
                                PhoneNumber = "9999999",
                                Address2 = "test2credit",
                                Address1 = "testcredit",
                                PostalCode = "48104-2201",
                                Locality = "Ann Arbor",
                                Company = "Visa",
                                AdministrativeArea = "MI",
                                Email = "test2@cybs.com"
                            };

                            orderInformationObj.BillTo = billToObj;

                            var invoiceDetailsObj = new Ptsv2paymentsidcapturesOrderInformationInvoiceDetails
                            {
                                PurchaseOrderDate = "20111231",
                                PurchaseOrderNumber = "CREDIT US"
                            };

                            orderInformationObj.InvoiceDetails = invoiceDetailsObj;

                            var amountDetailsObj = new Ptsv2paymentsidcapturesOrderInformationAmountDetails
                            {
                                TotalAmount = amount,
                                ExchangeRate = "0.5",
                                ExchangeRateTimeStamp = "2.01304E+13",
                                Currency = "usd"
                            };

                            orderInformationObj.AmountDetails = amountDetailsObj;

                            requestObj.OrderInformation = orderInformationObj;

                            var merchantInformationObj = new Ptsv2paymentsidrefundsMerchantInformation
                            {
                                CategoryCode = 1234
                            };

                            requestObj.MerchantInformation = merchantInformationObj;

                            var apiInstance = new RefundApi(clientConfig);

                            var response = apiInstance.RefundCapture(requestObj, capId);

                            if (response != null)
                            {
                                if (response.Status != PtsV2PaymentsRefundPost201Response.StatusEnum.PENDING)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = Constants.MessageForIncorrectStatus + response.Status.ToString();
                                }
                                else if (response.Id == null)
                                {
                                    resultStatus = $"Assertion Failed: {clientConfig.ApiClient.ApiResponse.StatusCode}";
                                    resultMessage = Constants.MessageNullId;
                                }
                                else if (amount != response.RefundAmountDetails.RefundAmount)
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
