@echo off

rd /s /q ..\Api
rd /s /q ..\Client
rd /s /q ..\Model
rd /s /q ..\docs
rd /s /q ..\test

java -jar swagger-codegen-cli-2.4.38.jar generate -t cybersource-csharp-template -i cybersource-rest-spec.json -l csharp -o ../ -c cybersource-csharp-config.json

powershell -Command "Get-ChildItem '..\src\Cybersource\Api\*.cs' -Recurse | ForEach-Object { (Get-Content $_).Replace('Method.POST','Method.Post').Replace('Method.GET','Method.Get').Replace('Method.PATCH','Method.Patch').Replace('Method.DELETE','Method.Delete').Replace('Method.PUT','Method.Put') | Set-Content $_ }"

powershell -Command "(Get-Content ..\src\CyberSource\Api\SecureFileShareApi.cs) | ForEach-Object { $_ -replace 'null\); \/\/ Return statement', 'localVarResponse.Content); // Return statement' } | Set-Content ..\src\CyberSource\Api\SecureFileShareApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs) | ForEach-Object { $_ -replace 'null\); \/\/ Return statement', 'localVarResponse.Content); // Return statement' } | Set-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs) | ForEach-Object { $_ -replace 'null\); \/\/ Return statement', 'localVarResponse.Content); // Return statement' } | Set-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs"

REM Need to shorten filenames

powershell Rename-Item ..\src\Cybersource\Model\Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransaction.cs Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedMerchantInitiatedTransaction.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransactionTests.cs Tmsv2customersEmbeddedMerchantInitiatedTransactionTests.cs

powershell Rename-Item ..\docs\Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransaction.md Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedMerchantInitiatedTransaction.md

powershell Rename-Item ..\src\Cybersource.Test\Model\Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierProcessingInformationAuthorizationOptionsInitiatorTests.cs Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedAuthorizationOptionsInitiatorTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierProcessingInformationAuthorizationOptionsTests.cs Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedAuthorizationOptionsTests.cs

powershell Rename-Item ..\src\Cybersource\Model\Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierProcessingInformationAuthorizationOptions.cs Tmsv2customersEmbeddedAuthorizationOptions.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1Tests.cs RiskV1AddressVerificationsPost201ResponseStandardAddressAddress1Tests.cs

powershell Rename-Item ..\src\Cybersource\Model\Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierProcessingInformationAuthorizationOptionsInitiator.cs Tmsv2customersEmbeddedAuthorizationOptionsInitiator.cs

powershell Rename-Item ..\docs\Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierProcessingInformationAuthorizationOptionsInitiator.md Tmsv2customersEmbeddedAuthorizationOptionsInitiator.md

powershell Rename-Item ..\src\Cybersource.Test\Model\Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierLinksPaymentInstrumentsTests.cs Tmsv2customersEmbeddedPaymentInstrumentsTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbeddedInstrumentIdentifierProcessingInformationTests.cs Tmsv2customersEmbeddedDefaultProcessingInformationTests.cs


@REM renaming
powershell Rename-Item ..\src\Cybersource.Test\Model\PaymentProductsCardProcessingConfigurationInformationConfigurationsCommonMerchantDescriptorInformationTests.cs PaymentProductsCardProcessingMerchantDescriptorInformationTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\PaymentProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentPayoutsCurrenciesTests.cs PaymentProductsCardProcessingPayoutsCurrenciesTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\PaymentProductsECheckConfigurationInformationConfigurationsFeaturesAccountValidationServiceInternalOnlyTests.cs PaymentProductsECheckServiceInternalOnlyTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\PaymentProductsECheckConfigurationInformationConfigurationsFeaturesAccountValidationServiceProcessorsTests.cs PaymentProductsECheckProcessorsTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\PaymentProductsPayerAuthenticationConfigurationInformationConfigurationsCardTypesVerifiedByVisaCurrenciesTests.cs PaymentProductsPayerAuthVerifiedByVisaCurrenciesTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\PaymentProductsSecureAcceptanceConfigurationInformationConfigurationsNotificationsCustomerNotificationsTests.cs PaymentProductsSecureAcceptanceCustomerNotificationsTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\PaymentProductsSecureAcceptanceConfigurationInformationConfigurationsNotificationsMerchantNotificationsTests.cs PaymentProductsSecureAcceptanceMerchantNotificationsTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationBasicInformationTests.cs PaymentProductsVirtualTerminalPaymentInformationBasicInformationTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationMerchantDefinedDataFieldsTests.cs PaymentProductsVirtualTerminalMerchantDefinedDataFieldsTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationPaymentInformationTests.cs PaymentProductsVirtualTerminalPaymentInformationTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationTests.cs PaymentProductsVirtualTerminalCardNotPresentGlobalPaymentInformationTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentReceiptInformationEmailReceiptTests.cs PaymentProductsVirtualTerminalReceiptInformationEmailReceiptTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentReceiptInformationHeaderTests.cs PaymentProductsVirtualTerminalReceiptInformationHeaderTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentReceiptInformationOrderInformationTests.cs PaymentProductsVirtualTerminalReceiptInformationOrderInformationTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\RiskProductsDecisionManagerConfigurationInformationConfigurationsThirdpartyProviderAccurintCredentialsTests.cs RiskProductsDecisionManagerThirdpartyAccurintCredentialsTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\RiskProductsDecisionManagerConfigurationInformationConfigurationsThirdpartyProviderCredilinkCredentialsTests.cs RiskProductsDecisionManagerThirdpartyCredilinkCredentialsTests.cs

powershell Rename-Item ..\src\Cybersource.Test\Model\RiskProductsDecisionManagerConfigurationInformationConfigurationsThirdpartyProviderSignifydCredentialsTests.cs RiskProductsDecisionManagerThirdpartySignifydCredentialsTests.cs

powershell Rename-Item ..\src\Cybersource\Model\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationBasicInformation.cs PaymentProductsVirtualTerminalPaymentInformationBasicInformation.cs

powershell Rename-Item ..\src\Cybersource\Model\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationMerchantDefinedDataFields.cs PaymentProductsVirtualTerminalMerchantDefinedDataFields.cs

powershell Rename-Item ..\src\Cybersource\Model\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationPaymentInformation.cs PaymentProductsVirtualTerminalPaymentInformation.cs

powershell Rename-Item ..\src\Cybersource\Model\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentReceiptInformationEmailReceipt.cs PaymentProductsVirtualTerminalReceiptInformationEmailReceipt.cs

powershell Rename-Item ..\src\Cybersource\Model\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentReceiptInformationOrderInformation.cs PaymentProductsVirtualTerminalReceiptInformationOrderInformation.cs

powershell Rename-Item ..\docs\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationBasicInformation.md PaymentProductsVirtualTerminalPaymentInformationBasicInformation.md

powershell Rename-Item ..\docs\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationMerchantDefinedDataFields.md PaymentProductsVirtualTerminalMerchantDefinedDataFields.md

powershell Rename-Item ..\docs\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentGlobalPaymentInformationPaymentInformation.md PaymentProductsVirtualTerminalPaymentInformation.md

powershell Rename-Item ..\docs\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentReceiptInformationEmailReceipt.md PaymentProductsVirtualTerminalReceiptInformationEmailReceipt.md

powershell Rename-Item ..\docs\PaymentProductsVirtualTerminalConfigurationInformationConfigurationsCardNotPresentReceiptInformationOrderInformation.md PaymentProductsVirtualTerminalReceiptInformationOrderInformation.md

powershell -Command " Set-Content ..\src\CyberSource\Api\SecureFileShareApi.cs ((get-content ..\src\CyberSource\Api\SecureFileShareApi.cs -raw) -replace '\*_\/_\*;charset=utf-8', '*/*;charset=utf-8') "

REM For changing nuspec filename in csproj file
powershell -Command "(Get-Content ..\src\CyberSource\CyberSource.csproj) | ForEach-Object { $_ -replace '<None Include=\"CyberSource.nuspec\" />', '<None Include=\"cybersource-rest-client-dotnet.nuspec\" />' } | Set-Content ..\src\CyberSource\CyberSource.csproj"

powershell -Command "(Get-Content ..\src\CyberSource.Test\CyberSource.Test.csproj) | ForEach-Object { $_ -replace 'CyberSource\\CyberSource.csproj', 'cybersource-rest-client-dotnet.csproj' } | ForEach-Object { $_ -replace '<Name>CyberSource</Name>', '<Name>cybersource-rest-client-dotnet</Name>' } | Set-Content ..\src\CyberSource.Test\CyberSource.Test.csproj"

REM For Renaming the .csproj file Name from Cybersource to cybersource-rest-client-dotnet
powershell Rename-Item ..\src\CyberSource\CyberSource.csproj cybersource-rest-client-dotnet.csproj
powershell Rename-Item ..\src\CyberSource.Test\CyberSource.Test.csproj cybersource-rest-client-dotnet.Test.csproj

REM For changing project filenames in sln file
powershell -Command "(Get-Content ..\CyberSource.sln) | ForEach-Object { $_ -replace 'CyberSource', 'cybersource-rest-client-dotnet' } | Set-Content ..\CyberSource.sln"

REM For Renaming the .sln filename from Cybersource to cybersource-rest-client-dotnet
del ..\cybersource-rest-client-dotnet.sln

powershell Rename-Item ..\CyberSource.sln cybersource-rest-client-dotnet.sln

xcopy ..\src\cybersource ..\ /s /e /y /exclude:excludelist.txt
git checkout ..\README.md
git checkout ..\Api\OAuthApi.cs
git checkout ..\Model\AccessTokenResponse.cs
git checkout ..\Model\CreateAccessTokenRequest.cs
md ..\test
xcopy ..\src\cybersource.test ..\test /s /e /y
git checkout ..\test\packages.config

rd /s /q ..\src


pause
