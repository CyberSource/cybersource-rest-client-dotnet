using System;

namespace CybsQaScript
{
    public class SampleCode
    {
        public static void RunMethod(string methodName)
        {

            switch (methodName)
            {
                case "ProcessPayment":
                    Payments.CoreServices.ProcessPayment.ProcessPaymentExec();
                    break;
                case "CapturePayment":
                    Payments.CoreServices.CapturePayment.CapturePaymentExec();
                    break;
                case "ProcessAuthorizationReversal":
                    Payments.CoreServices.ProcessAuthorizationReversal.ProcessAuthorizationReversalExec();
                    break;
                case "RefundPayment":
                    Payments.CoreServices.RefundPayment.RefundPaymentExec();
                    break;
                case "RefundCapture":
                    Payments.CoreServices.RefundCapture.RefundCaptureExec();
                    break;
                case "ProcessCredit":
                    Payments.CoreServices.ProcessCredit.ProcessCreditExec();
                    break;
                case "VoidPayment":
                    Payments.CoreServices.VoidPayment.VoidPaymentExec();
                    break;
                case "VoidCapture":
                    Payments.CoreServices.VoidCapture.VoidCaptureExec();
                    break;
                case "VoidRefund":
                    Payments.CoreServices.VoidRefund.VoidRefundExec();
                    break;
                case "VoidCredit":
                    Payments.CoreServices.VoidCredit.VoidCreditExec();
                    break;
                case "ProcessPayout":
                    Payouts.CoreServices.ProcessPayout.ProcessPayoutExec();
                    break;
                case "CreateInstrumentIdentifier":
                    TMS.CoreServices.CreateInstrumentIdentifier.CreateTmsExec();
                    break;
                case "CreatePaymentInstrument":
                    TMS.CoreServices.CreatePaymentInstrument.CreateTmsExec();
                    break;
                case "DeleteInstrumentIdentifier":
                    TMS.CoreServices.DeleteInstrumentIdentifier.DeleteTmsExec();
                    break;
                case "DeletePaymentInstrument":
                    TMS.CoreServices.DeletePaymentInstrument.DeleteTmsExec();
                    break;
                case "RetrieveAllPaymentInstruments":
                    TMS.CoreServices.RetrieveAllPaymentInstruments.GetTmsExec();
                    break;
                case "RetrieveInstrumentIdentifier":
                    TMS.CoreServices.RetrieveInstrumentIdentifier.GetTmsExec();
                    break;
                case "RetrievePaymentInstrument":
                    TMS.CoreServices.RetrievePaymentInstrument.GetTmsExec();
                    break;
                case "UpdateInstrumentIdentifier":
                    TMS.CoreServices.UpdateInstrumentIdentifier.UpdateTmsExec();
                    break;
                case "UpdatePaymentInstrument":
                    TMS.CoreServices.UpdatePaymentInstrument.UpdateTmsExec();
                    break;
                case "GenerateKey":
                    Flex.CoreServices.GenerateKey.GenerateKeyExec();
                    break;
                case "TokenizeCard":
                    Flex.CoreServices.TokenizeCard.TokenizeCardExec();
                    break;
                case "GetListOfFiles":
                    SecureFileShare.CoreServices.GetListOfFiles.GetListOfFilesExec();
                    break;
                case "DownloadFileWithFileIdentifier":
                    SecureFileShare.CoreServices.DownloadFileWithFileIdentifier.DownloadFileWithFileIdentifierExec();
                    break;
                case "GetIndividualBatchFile":
                    TransactionBatches.CoreServices.GetIndividualBatchFile.GetTransBatchExec();
                    break;
                case "GetListOfBatchFiles":
                    TransactionBatches.CoreServices.GetListOfBatchFiles.GetListOfBatchFilesExec();
                    break;
                case "RetrieveTransaction":
                    TransactionDetails.CoreServices.RetrieveTransaction.GetTransExec();
                    break;
                case "CreateSearchRequest":
                    TransactionSearch.CoreServices.CreateSearchRequest.CreateSearchExec();
                    break;
                case "GetSearchResults":
                    TransactionSearch.CoreServices.GetSearchResults.GetSearchExec();
                    break;
                case "GetUserInformation":
                    UserManagement.CoreServices.GetUserInformation.GetUserInfoExec();
                    break;
                case "GetAllSubscriptions":
                    Reporting.CoreServices.GetAllSubscriptions.GetAllSubsExec();
                    break;
                case "GetNotificationOfChanges":
                    Reporting.CoreServices.GetNotificationOfChanges.GetNotifChangesExec();
                    break;
                case "GetPurchaseAndRefundDetails":
                    Reporting.CoreServices.GetPurchaseAndRefundDetails.GetPurchRefExec();
                    break;
                case "GetReportBasedOnReportid":
                    Reporting.CoreServices.GetReportBasedOnReportid.GetRepIdExec();
                    break;
                case "GetReportDefinition":
                    Reporting.CoreServices.GetReportDefinition.GetRepDefiExec();
                    break;
                case "GetReportingResourceInformation":
                    Reporting.CoreServices.GetReportingResourceInformation.GetRepResoInfoExec();
                    break;
                case "GetSubscriptionForReportName":
                    Reporting.CoreServices.GetSubscriptionForReportName.GetSubsRepExec();
                    break;
                case "RetrieveAvailableReports":
                    Reporting.CoreServices.RetrieveAvailableReports.RetrieveAvaiRepExec();
                    break;
                case "CreateAdhocReport":
                    Reporting.CoreServices.CreateAdhocReport.CreateAdhocRepExec();
                    break;
                case "DownloadReport":
                    Reporting.CoreServices.DownloadReport.DownloadRepExec();
                    break;
                case "CreateReportSubscriptionForReportNameByOrganization":
                    Reporting.CoreServices.CreateReportSubscriptionForReportNameByOrganization.CreateRepSubsOrgExec();
                    break;
                case "DeleteSubscriptionOfReportNameByOrganization":
                    Reporting.CoreServices.DeleteSubscriptionOfReportNameByOrganization.DeleteSubsRepOrgExec();
                    break;
                default:
                    ShowUsage();
                    break;
            }
        }

        private static void ShowUsage()
        {
            Console.WriteLine("Usage : SampleCode [CodeSampleName]");
            Console.WriteLine(string.Empty);
            Console.WriteLine("Run with no parameter to select a method.  Otherwise pass a method name.");
            Console.WriteLine(string.Empty);
            Console.WriteLine("Code Sample Names: ");
            ShowMethods();
            Console.WriteLine("Code Sample Names: ");
        }

        private static void SelectMethod()
        {
            Console.WriteLine("Code Sample Names: ");
            Console.WriteLine(string.Empty);
            ShowMethods();
            Console.WriteLine(string.Empty);
            Console.Write("Type a sample name & then press <Return> : ");
            RunMethod(Console.ReadLine());
        }

        private static void ShowMethods()
        {
            Console.WriteLine("    AuthorizationOnly");
        }
    }
}