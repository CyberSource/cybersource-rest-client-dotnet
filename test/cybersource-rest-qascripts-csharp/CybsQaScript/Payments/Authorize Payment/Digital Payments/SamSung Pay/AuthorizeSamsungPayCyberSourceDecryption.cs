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

namespace CybsQaScript.Payments.Authorize_Payment.Digital_Payments.SamSung_Pay
{
    public class AuthorizeSamsungPayCyberSourceDecryption
    {
        public static void CreatePaymentExec()
        {
            // Initialize Api Name
            var apiFunctionName = "AuthorizeSamsungPayCyberSourceDecryption";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/Payment/AuthorizePayment/DigitalPayments/SamsungPay/CreateAuthorizeSamsungPayCybersourceDecryption.csv"), true))
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

                            var requestObj = new CreatePaymentRequest();

                            var v2PaymentsClientReferenceInformationObj = new Ptsv2paymentsClientReferenceInformation
                            {
                                Code = "TC_MPOS_Paymentech_3"
                            };

                            requestObj.ClientReferenceInformation = v2PaymentsClientReferenceInformationObj;

                            var v2PaymentsProcessingInformationObj = new Ptsv2paymentsProcessingInformation
                            {
                                CommerceIndicator = "vbv",
                                PaymentSolution = "008"
                            };

                            requestObj.ProcessingInformation = v2PaymentsProcessingInformationObj;

                            var v2PaymentsOrderInformationObj = new Ptsv2paymentsOrderInformation();

                            var v2PaymentsOrderInformationBillToObj = new Ptsv2paymentsOrderInformationBillTo
                            {
                                Country = "US",
                                LastName = "Deo",
                                Address1 = "201 S. Division St.",
                                PostalCode = "48104-2201",
                                FirstName = "John"
                            };

                            v2PaymentsOrderInformationObj.BillTo = v2PaymentsOrderInformationBillToObj;

                            var amountDetailsObj = new Ptsv2paymentsOrderInformationAmountDetails
                            {
                                TotalAmount = amount,
                                Currency = "USD"
                            };

                            v2PaymentsOrderInformationObj.AmountDetails = amountDetailsObj;

                            requestObj.OrderInformation = v2PaymentsOrderInformationObj;

                            var v2PaymentsPaymentInformationObj = new Ptsv2paymentsPaymentInformation();

                            var v2PaymentsPaymentInformationFluidDataObj = new Ptsv2paymentsPaymentInformationFluidData
                            {
                                Value =
                                    "ewoJInB1YmxpY0tleUhhc2giOiAiaTRYell5MFRnNnkvaEUwV2RrK0dwOHV4aml4U3I0US91MUxNOVd0VTl2az0iLAoJInZlcnNpb24iOiAiMTAwIiwKCSJkYXRhIjogIlpYZHZTa2x0Um5OYWVVazJTVU5LVTFVd1JYaFllbFZwVEVGdlNrbHRWblZaZVVrMlNVTktRazFxVlRKU01FNU9TV2wzUzBOVFNuSmhWMUZwVDJsQmFXRlVVbGxsYkd3MVRVWlNiazV1YTNaaFJWVjNWakpTY2tzd1pIZFBTRlkwWVcxc05GVXpTVEJWVXpreFRWVjRUazlXWkRCV1ZHd3lZWG93YVV4QmIwcEpibEkxWTBOSk5rbERTa3RVTVU1R1NXbDNTME5UU21waFIwWjFZbTFXYzFVeVZtcGtXRXB3WkVoc1JHSXlOVEJhV0dnd1NXcHZaMGxzU2xSUlZqbFJVekJyYVVOdU1DNUdURGxEYTJScFFtOHlTSEExWDJ0Qk5WOUJNM2hJUjFCaFQwZDBSMmRWVVRoWk5UY3dNVjlzUmxSU1IxbFlNRWRpYlV4d05GVnBhM1JSV1Voa09FaHZUR3RrVVUxRFUwVjJNRGhXU0daZlJVUmtSaloyTW5rMmJURkJSRmhCWjAxeE9FaHlNVjlOT1daalpXWXhTMGgzVmpCVlNYSlRlRWN4TUZneVUwMTJVa2xmTURKcU9FVjJVV2gyZWt4dVMzRXhiRWgxTUUxMmVEZHdhV1IzYkU4NVJVdG5iRmRTY2tGTlh5MVlRMmczVW1WaE4wWmxaVU16VW00d1dqQnRUMFpZVEhaUVdESkxlWEJ5ZDFCemFHOWpZemxhTW5rNFJYVmlSVzVaT1Zka1pqazJNRUZtVTJwTGIyOHRXRlphVGxoNk5WVlZiSFZoWW5WdVlrRkNlSEJ1VWpsTlMzZzRaMnhoWjBwT1RHcFdOMjB4YzFCT1RrMVBaa1YzT1hoU1V6RjBkWE5sV2sxNFdURnRiRFJDVVVSb1IwWTROa1ZXU0hkUmFXbGpWRGhDYmxkVVVFRlBZVk5uWVVwWk1tVndjMTluVDI5aVptY3VZazFaZVdKSE5EVlFRblJNVG14TVUxOUxiRzVOUVM1Mk1tUmZkVmN5T0c5T1JqUnVUV2xPWTBOeVdWSktlSEJ6YlhJd09XZHRiM0ZSUkZkVk5FRldTMFJ6Wm5VNVltdENTRVJuTnpGclNHaGtNMDV6UTJselpXSmlia2swWVUxWE1sTkxNV054UzNCWVgwaFBNRGswU0hoeVZHeEtUV3gwY21kS2VIWjJMWGd4VVU5eVlXNUNTMnRxY0hsNlpVcDNabWRXWXkxblJ6SktPV2d4U25jMFdIRm1Nbk5ZZFZwbWQzSnJSM0pZTjAxcWFXTnRhVWxuZERGU1lURjZkRGRUYUVvemRucFlSRm81V2paTFUyaDFZWEF6TkZFd05VcERaRUpVTUhseFdqZHVaM2hwWjJ4c2EzbDFWazFRWXpkbWRpMUJkMWhzYkRoc2FtUm9la3BsYmxKdFR6ZEhVRnBtY0dsRlVUWkNTVjl2WWpWTmJERllTRlZHWXpSUFRXZG5TR3hOUW0xWFRqWkxhVVJFUldsUlIyaERaVlZpWW01MmJXTXVMVlZhVUVoME4zUkVPVGRmWVdONFgyRk5SakptUVE9PSIKfQ=="
                            };

                            v2PaymentsPaymentInformationObj.FluidData = v2PaymentsPaymentInformationFluidDataObj;

                            requestObj.PaymentInformation = v2PaymentsPaymentInformationObj;

                            var apiInstance = new PaymentsApi(clientConfig);

                            var response = apiInstance.CreatePayment(requestObj);
                            Console.WriteLine(response);

                            if (response != null)
                            {
                                try
                                {
                                    Assert.AreEqual(amount, response.OrderInformation.AmountDetails.AuthorizedAmount);

                                    Console.WriteLine("Assertion Succeeded. Valid Amount.");

                                    var row1 = new CsvRow
                                    {
                                      testCaseId,
                                      apiFunctionName,
                                      $"Pass:{clientConfig.ApiClient.ApiResponse.StatusCode}- {response.Id}",
                                       DateTime.Now.ToString("yyyy/MM/dd" + "::" + "HH:mm:ss:fff")
                                    };

                                    writer.WriteRow(row1);

                                    Console.WriteLine(testCaseId + "Success " + message);

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
