using CyberSource.Client;
using CyberSource.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSource.Utilities.Tracking
{
    public interface ISdkTracker
    {
        object InsertDeveloperIdTracker(object requestObj, string requestClass, string runEnvironment);
    }

    public partial class SdkTracker : ISdkTracker
    {
        public object InsertDeveloperIdTracker(object requestObj, string requestClass, string runEnvironment)
        {
            string developerIdValue;
            if (runEnvironment.Contains("apitest.cybersource.com"))
            {
                developerIdValue = "CEOVXJBB";
            }
            else
            {
                developerIdValue = "JZKVPX48";
            }

            switch (requestClass)
            {
                case "CapturePaymentRequest":
                    CapturePaymentRequest capturePaymentRequest = (CapturePaymentRequest)requestObj;

                    if (capturePaymentRequest.ClientReferenceInformation == null)
                    {
                        capturePaymentRequest.ClientReferenceInformation = new Ptsv2paymentsClientReferenceInformation();
                    }

                    if (capturePaymentRequest.ClientReferenceInformation.Partner == null)
                    {
                        capturePaymentRequest.ClientReferenceInformation.Partner = new Ptsv2paymentsClientReferenceInformationPartner();
                    }

                    if (capturePaymentRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        capturePaymentRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return capturePaymentRequest;
                case "CreateCreditRequest":
                    CreateCreditRequest createCreditRequest = (CreateCreditRequest)requestObj;

                    if (createCreditRequest.ClientReferenceInformation == null)
                    {
                        createCreditRequest.ClientReferenceInformation = new Ptsv2paymentsClientReferenceInformation();
                    }

                    if (createCreditRequest.ClientReferenceInformation.Partner == null)
                    {
                        createCreditRequest.ClientReferenceInformation.Partner = new Ptsv2paymentsClientReferenceInformationPartner();
                    }

                    if (createCreditRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        createCreditRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return createCreditRequest;
                case "AddNegativeListRequest":
                    AddNegativeListRequest addNegativeListRequest = (AddNegativeListRequest)requestObj;

                    if (addNegativeListRequest.ClientReferenceInformation == null)
                    {
                        addNegativeListRequest.ClientReferenceInformation = new Riskv1liststypeentriesClientReferenceInformation();
                    }

                    if (addNegativeListRequest.ClientReferenceInformation.Partner == null)
                    {
                        addNegativeListRequest.ClientReferenceInformation.Partner = new Riskv1decisionsClientReferenceInformationPartner();
                    }

                    if (addNegativeListRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        addNegativeListRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return addNegativeListRequest;
                case "CreateBundledDecisionManagerCaseRequest":
                    CreateBundledDecisionManagerCaseRequest createBundledDecisionManagerCaseRequest = (CreateBundledDecisionManagerCaseRequest)requestObj;

                    if (createBundledDecisionManagerCaseRequest.ClientReferenceInformation == null)
                    {
                        createBundledDecisionManagerCaseRequest.ClientReferenceInformation = new Riskv1decisionsClientReferenceInformation();
                    }

                    if (createBundledDecisionManagerCaseRequest.ClientReferenceInformation.Partner == null)
                    {
                        createBundledDecisionManagerCaseRequest.ClientReferenceInformation.Partner = new Riskv1decisionsClientReferenceInformationPartner();
                    }

                    if (createBundledDecisionManagerCaseRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        createBundledDecisionManagerCaseRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return createBundledDecisionManagerCaseRequest;
                case "FraudMarkingActionRequest":
                    FraudMarkingActionRequest fraudMarkingActionRequest = (FraudMarkingActionRequest)requestObj;

                    if (fraudMarkingActionRequest.ClientReferenceInformation == null)
                    {
                        fraudMarkingActionRequest.ClientReferenceInformation = new Riskv1liststypeentriesClientReferenceInformation();
                    }

                    if (fraudMarkingActionRequest.ClientReferenceInformation.Partner == null)
                    {
                        fraudMarkingActionRequest.ClientReferenceInformation.Partner = new Riskv1decisionsClientReferenceInformationPartner();
                    }

                    if (fraudMarkingActionRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        fraudMarkingActionRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return fraudMarkingActionRequest;
                case "CheckPayerAuthEnrollmentRequest":
                    CheckPayerAuthEnrollmentRequest checkPayerAuthEnrollmentRequest = (CheckPayerAuthEnrollmentRequest)requestObj;

                    if (checkPayerAuthEnrollmentRequest.ClientReferenceInformation == null)
                    {
                        checkPayerAuthEnrollmentRequest.ClientReferenceInformation = new Riskv1authenticationsetupsClientReferenceInformation();
                    }

                    if (checkPayerAuthEnrollmentRequest.ClientReferenceInformation.Partner == null)
                    {
                        checkPayerAuthEnrollmentRequest.ClientReferenceInformation.Partner = new Riskv1decisionsClientReferenceInformationPartner();
                    }

                    if (checkPayerAuthEnrollmentRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        checkPayerAuthEnrollmentRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return checkPayerAuthEnrollmentRequest;
                case "PayerAuthSetupRequest":
                    PayerAuthSetupRequest payerAuthSetupRequest = (PayerAuthSetupRequest)requestObj;

                    if (payerAuthSetupRequest.ClientReferenceInformation == null)
                    {
                        payerAuthSetupRequest.ClientReferenceInformation = new Riskv1authenticationsetupsClientReferenceInformation();
                    }

                    if (payerAuthSetupRequest.ClientReferenceInformation.Partner == null)
                    {
                        payerAuthSetupRequest.ClientReferenceInformation.Partner = new Riskv1decisionsClientReferenceInformationPartner();
                    }

                    if (payerAuthSetupRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        payerAuthSetupRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return payerAuthSetupRequest;
                case "ValidateRequest":
                    ValidateRequest validateRequest = (ValidateRequest)requestObj;

                    if (validateRequest.ClientReferenceInformation == null)
                    {
                        validateRequest.ClientReferenceInformation = new Riskv1authenticationsetupsClientReferenceInformation();
                    }

                    if (validateRequest.ClientReferenceInformation.Partner == null)
                    {
                        validateRequest.ClientReferenceInformation.Partner = new Riskv1decisionsClientReferenceInformationPartner();
                    }

                    if (validateRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        validateRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return validateRequest;
                case "CreatePaymentRequest":
                    CreatePaymentRequest createPaymentRequest = (CreatePaymentRequest)requestObj;

                    if (createPaymentRequest.ClientReferenceInformation == null)
                    {
                        createPaymentRequest.ClientReferenceInformation = new Ptsv2paymentsClientReferenceInformation();
                    }

                    if (createPaymentRequest.ClientReferenceInformation.Partner == null)
                    {
                        createPaymentRequest.ClientReferenceInformation.Partner = new Ptsv2paymentsClientReferenceInformationPartner();
                    }

                    if (createPaymentRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        createPaymentRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return createPaymentRequest;
                case "IncrementAuthRequest":
                    IncrementAuthRequest incrementAuthRequest = (IncrementAuthRequest)requestObj;

                    if (incrementAuthRequest.ClientReferenceInformation == null)
                    {
                        incrementAuthRequest.ClientReferenceInformation = new Ptsv2paymentsidClientReferenceInformation();
                    }

                    if (incrementAuthRequest.ClientReferenceInformation.Partner == null)
                    {
                        incrementAuthRequest.ClientReferenceInformation.Partner = new Ptsv2paymentsidClientReferenceInformationPartner();
                    }

                    if (incrementAuthRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        incrementAuthRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return incrementAuthRequest;
                case "CreatePlanRequest":
                    CreatePlanRequest createPlanRequest = (CreatePlanRequest)requestObj;

                    if (createPlanRequest.ClientReferenceInformation == null)
                    {
                        createPlanRequest.ClientReferenceInformation = new Rbsv1plansClientReferenceInformation();
                    }

                    if (createPlanRequest.ClientReferenceInformation.Partner == null)
                    {
                        createPlanRequest.ClientReferenceInformation.Partner = new Riskv1decisionsClientReferenceInformationPartner();
                    }

                    if (createPlanRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        createPlanRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return createPlanRequest;
                case "RefundCaptureRequest":
                    RefundCaptureRequest refundCaptureRequest = (RefundCaptureRequest)requestObj;

                    if (refundCaptureRequest.ClientReferenceInformation == null)
                    {
                        refundCaptureRequest.ClientReferenceInformation = new Ptsv2paymentsidrefundsClientReferenceInformation();
                    }

                    if (refundCaptureRequest.ClientReferenceInformation.Partner == null)
                    {
                        refundCaptureRequest.ClientReferenceInformation.Partner = new Ptsv2paymentsClientReferenceInformationPartner();
                    }

                    if (refundCaptureRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        refundCaptureRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return refundCaptureRequest;
                case "RefundPaymentRequest":
                    RefundPaymentRequest refundPaymentRequest = (RefundPaymentRequest)requestObj;

                    if (refundPaymentRequest.ClientReferenceInformation == null)
                    {
                        refundPaymentRequest.ClientReferenceInformation = new Ptsv2paymentsidrefundsClientReferenceInformation();
                    }

                    if (refundPaymentRequest.ClientReferenceInformation.Partner == null)
                    {
                        refundPaymentRequest.ClientReferenceInformation.Partner = new Ptsv2paymentsClientReferenceInformationPartner();
                    }

                    if (refundPaymentRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        refundPaymentRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return refundPaymentRequest;
                case "AuthReversalRequest":
                    AuthReversalRequest authReversalRequest = (AuthReversalRequest)requestObj;

                    if (authReversalRequest.ClientReferenceInformation == null)
                    {
                        authReversalRequest.ClientReferenceInformation = new Ptsv2paymentsidreversalsClientReferenceInformation();
                    }

                    if (authReversalRequest.ClientReferenceInformation.Partner == null)
                    {
                        authReversalRequest.ClientReferenceInformation.Partner = new Ptsv2paymentsidreversalsClientReferenceInformationPartner();
                    }

                    if (authReversalRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        authReversalRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return authReversalRequest;
                case "MitReversalRequest":
                    MitReversalRequest mitReversalRequest = (MitReversalRequest)requestObj;

                    if (mitReversalRequest.ClientReferenceInformation == null)
                    {
                        mitReversalRequest.ClientReferenceInformation = new Ptsv2paymentsClientReferenceInformation();
                    }

                    if (mitReversalRequest.ClientReferenceInformation.Partner == null)
                    {
                        mitReversalRequest.ClientReferenceInformation.Partner = new Ptsv2paymentsClientReferenceInformationPartner();
                    }

                    if (mitReversalRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        mitReversalRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return mitReversalRequest;
                case "CreateSubscriptionRequest":
                    CreateSubscriptionRequest createSubscriptionRequest = (CreateSubscriptionRequest)requestObj;

                    if (createSubscriptionRequest.ClientReferenceInformation == null)
                    {
                        createSubscriptionRequest.ClientReferenceInformation = new Rbsv1subscriptionsClientReferenceInformation();
                    }

                    if (createSubscriptionRequest.ClientReferenceInformation.Partner == null)
                    {
                        createSubscriptionRequest.ClientReferenceInformation.Partner = new Riskv1decisionsClientReferenceInformationPartner();
                    }

                    if (createSubscriptionRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        createSubscriptionRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return createSubscriptionRequest;
                case "UpdateSubscription":
                    UpdateSubscription updateSubscription = (UpdateSubscription)requestObj;

                    if (updateSubscription.ClientReferenceInformation == null)
                    {
                        updateSubscription.ClientReferenceInformation = new Rbsv1subscriptionsClientReferenceInformation();
                    }

                    if (updateSubscription.ClientReferenceInformation.Partner == null)
                    {
                        updateSubscription.ClientReferenceInformation.Partner = new Riskv1decisionsClientReferenceInformationPartner();
                    }

                    if (updateSubscription.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        updateSubscription.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return updateSubscription;
                case "TaxRequest":
                    TaxRequest taxRequest = (TaxRequest)requestObj;

                    if (taxRequest.ClientReferenceInformation == null)
                    {
                        taxRequest.ClientReferenceInformation = new Vasv2taxClientReferenceInformation();
                    }

                    if (taxRequest.ClientReferenceInformation.Partner == null)
                    {
                        taxRequest.ClientReferenceInformation.Partner = new Riskv1decisionsClientReferenceInformationPartner();
                    }

                    if (taxRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        taxRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return taxRequest;
                case "VoidTaxRequest":
                    VoidTaxRequest voidTaxRequest = (VoidTaxRequest)requestObj;

                    if (voidTaxRequest.ClientReferenceInformation == null)
                    {
                        voidTaxRequest.ClientReferenceInformation = new Vasv2taxidClientReferenceInformation();
                    }

                    if (voidTaxRequest.ClientReferenceInformation.Partner == null)
                    {
                        voidTaxRequest.ClientReferenceInformation.Partner = new Vasv2taxidClientReferenceInformationPartner();
                    }

                    if (voidTaxRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        voidTaxRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return voidTaxRequest;
                case "ValidateExportComplianceRequest":
                    ValidateExportComplianceRequest validateExportComplianceRequest = (ValidateExportComplianceRequest)requestObj;

                    if (validateExportComplianceRequest.ClientReferenceInformation == null)
                    {
                        validateExportComplianceRequest.ClientReferenceInformation = new Riskv1liststypeentriesClientReferenceInformation();
                    }

                    if (validateExportComplianceRequest.ClientReferenceInformation.Partner == null)
                    {
                        validateExportComplianceRequest.ClientReferenceInformation.Partner = new Riskv1decisionsClientReferenceInformationPartner();
                    }

                    if (validateExportComplianceRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        validateExportComplianceRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return validateExportComplianceRequest;
                case "VerifyCustomerAddressRequest":
                    VerifyCustomerAddressRequest verifyCustomerAddressRequest = (VerifyCustomerAddressRequest)requestObj;

                    if (verifyCustomerAddressRequest.ClientReferenceInformation == null)
                    {
                        verifyCustomerAddressRequest.ClientReferenceInformation = new Riskv1liststypeentriesClientReferenceInformation();
                    }

                    if (verifyCustomerAddressRequest.ClientReferenceInformation.Partner == null)
                    {
                        verifyCustomerAddressRequest.ClientReferenceInformation.Partner = new Riskv1decisionsClientReferenceInformationPartner();
                    }

                    if (verifyCustomerAddressRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        verifyCustomerAddressRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return verifyCustomerAddressRequest;
                case "MitVoidRequest":
                    MitVoidRequest mitVoidRequest = (MitVoidRequest)requestObj;

                    if (mitVoidRequest.ClientReferenceInformation == null)
                    {
                        mitVoidRequest.ClientReferenceInformation = new Ptsv2paymentsClientReferenceInformation();
                    }

                    if (mitVoidRequest.ClientReferenceInformation.Partner == null)
                    {
                        mitVoidRequest.ClientReferenceInformation.Partner = new Ptsv2paymentsClientReferenceInformationPartner();
                    }

                    if (mitVoidRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        mitVoidRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return mitVoidRequest;
                case "VoidCaptureRequest":
                    VoidCaptureRequest voidCaptureRequest = (VoidCaptureRequest)requestObj;

                    if (voidCaptureRequest.ClientReferenceInformation == null)
                    {
                        voidCaptureRequest.ClientReferenceInformation = new Ptsv2paymentsidreversalsClientReferenceInformation();
                    }

                    if (voidCaptureRequest.ClientReferenceInformation.Partner == null)
                    {
                        voidCaptureRequest.ClientReferenceInformation.Partner = new Ptsv2paymentsidreversalsClientReferenceInformationPartner();
                    }

                    if (voidCaptureRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        voidCaptureRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return voidCaptureRequest;
                case "VoidCreditRequest":
                    VoidCreditRequest voidCreditRequest = (VoidCreditRequest)requestObj;

                    if (voidCreditRequest.ClientReferenceInformation == null)
                    {
                        voidCreditRequest.ClientReferenceInformation = new Ptsv2paymentsidreversalsClientReferenceInformation();
                    }

                    if (voidCreditRequest.ClientReferenceInformation.Partner == null)
                    {
                        voidCreditRequest.ClientReferenceInformation.Partner = new Ptsv2paymentsidreversalsClientReferenceInformationPartner();
                    }

                    if (voidCreditRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        voidCreditRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return voidCreditRequest;
                case "VoidPaymentRequest":
                    VoidPaymentRequest voidPaymentRequest = (VoidPaymentRequest)requestObj;

                    if (voidPaymentRequest.ClientReferenceInformation == null)
                    {
                        voidPaymentRequest.ClientReferenceInformation = new Ptsv2paymentsidreversalsClientReferenceInformation();
                    }

                    if (voidPaymentRequest.ClientReferenceInformation.Partner == null)
                    {
                        voidPaymentRequest.ClientReferenceInformation.Partner = new Ptsv2paymentsidreversalsClientReferenceInformationPartner();
                    }

                    if (voidPaymentRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        voidPaymentRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return voidPaymentRequest;
                case "VoidRefundRequest":
                    VoidRefundRequest voidRefundRequest = (VoidRefundRequest)requestObj;

                    if (voidRefundRequest.ClientReferenceInformation == null)
                    {
                        voidRefundRequest.ClientReferenceInformation = new Ptsv2paymentsidreversalsClientReferenceInformation();
                    }

                    if (voidRefundRequest.ClientReferenceInformation.Partner == null)
                    {
                        voidRefundRequest.ClientReferenceInformation.Partner = new Ptsv2paymentsidreversalsClientReferenceInformationPartner();
                    }

                    if (voidRefundRequest.ClientReferenceInformation.Partner.DeveloperId == null)
                    {
                        voidRefundRequest.ClientReferenceInformation.Partner.DeveloperId = developerIdValue;
                    }

                    return voidRefundRequest;
                default:
                    return requestObj;
            }
        }
    }
}
