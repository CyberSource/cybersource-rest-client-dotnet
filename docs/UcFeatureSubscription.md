# CyberSource.Model.UcFeatureSubscription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PazeForUnifiedCheckout** | [**UcFeatureSubscriptionPazeForUnifiedCheckout**](UcFeatureSubscriptionPazeForUnifiedCheckout.md) |  | [optional] 
**TokenManagement** | [**UcFeatureSubscriptionTokenManagement**](UcFeatureSubscriptionTokenManagement.md) |  | [optional] 
**PayPal** | [**UcFeatureSubscriptionPayPal**](UcFeatureSubscriptionPayPal.md) |  | [optional] 
**Venmo** | [**UcFeatureSubscriptionVenmo**](UcFeatureSubscriptionVenmo.md) |  | [optional] 
**ApplePay** | [**UcFeatureSubscriptionApplePay**](UcFeatureSubscriptionApplePay.md) |  | [optional] 
**GooglePay** | [**UcFeatureSubscriptionGooglePay**](UcFeatureSubscriptionGooglePay.md) |  | [optional] 
**TinkPayByBank** | [**UcFeatureSubscriptionTinkPayByBank**](UcFeatureSubscriptionTinkPayByBank.md) |  | [optional] 
**ECheck** | [**UcFeatureSubscriptionECheck**](UcFeatureSubscriptionECheck.md) |  | [optional] 
**P24** | [**UcFeatureSubscriptionP24**](UcFeatureSubscriptionP24.md) |  | [optional] 
**MyBank** | [**UcFeatureSubscriptionMyBank**](UcFeatureSubscriptionMyBank.md) |  | [optional] 
**Konbini** | [**UcFeatureSubscriptionKonbini**](UcFeatureSubscriptionKonbini.md) |  | [optional] 
**DragonPay** | [**UcFeatureSubscriptionDragonPay**](UcFeatureSubscriptionDragonPay.md) |  | [optional] 
**DecisionManager** | [**UcFeatureSubscriptionDecisionManager**](UcFeatureSubscriptionDecisionManager.md) |  | [optional] 
**PayerAuthentication** | [**UcFeatureSubscriptionPayerAuthentication**](UcFeatureSubscriptionPayerAuthentication.md) |  | [optional] 
**AfterPay** | [**UcFeatureSubscriptionAfterPay**](UcFeatureSubscriptionAfterPay.md) |  | [optional] 
**Ideal** | [**UcFeatureSubscriptionIdeal**](UcFeatureSubscriptionIdeal.md) |  | [optional] 
**Multibanco** | [**UcFeatureSubscriptionMultibanco**](UcFeatureSubscriptionMultibanco.md) |  | [optional] 
**Bancontact** | [**UcFeatureSubscriptionBancontact**](UcFeatureSubscriptionBancontact.md) |  | [optional] 
**ClickToPay** | [**UcFeatureSubscriptionClickToPay**](UcFeatureSubscriptionClickToPay.md) |  | [optional] 
**UnifiedClickToPaySDK** | [**UcFeatureSubscriptionUnifiedClickToPaySDK**](UcFeatureSubscriptionUnifiedClickToPaySDK.md) |  | [optional] 
**PortfolioAccessofSensitiveData** | [**UcFeatureSubscriptionPortfolioAccessofSensitiveData**](UcFeatureSubscriptionPortfolioAccessofSensitiveData.md) |  | [optional] 

## Extensibility

This model derives from `ExtensibleModel`, so it can round-trip JSON fields that are not (yet) defined as typed properties above:

- `SetExtraField(string jsonName, object value)` &mdash; set a field that is not mapped to a property.
- `GetExtraField<T>(string jsonName)` / `TryGetExtraField<T>(string jsonName, out T value)` &mdash; read an unmapped field.

Unknown fields received in a response are preserved and re-serialized on the next request. Setting the same field both as a typed property and via `SetExtraField` throws at serialization time (serialize-time conflict guard).

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

