@echo off

REM ============================================================================
REM  Path layout (relative to this script at <repo-root>\generator\):
REM    ..              -> repo root
REM    ..\src          -> main project (Api, Client, Model, Utilities, .csproj)
REM    ..\tests        -> test project
REM    ..\docs         -> generated docs
REM    ..\..           -> parent of repo (swagger-codegen output staging area)
REM ============================================================================

rd /s /q ..\src\Api
rd /s /q ..\src\Client
rd /s /q ..\src\Model
rd /s /q ..\docs
rd /s /q ..\tests\Api
rd /s /q ..\tests\Model

setlocal enabledelayedexpansion
python replaceFieldNamesForPaths.py -i cybersource-rest-spec.json -o cybersource-rest-spec-netstandard.json > replaceFieldLogs.log
del replaceFieldLogs.log
endlocal

java -jar swagger-codegen-cli-2.4.38.jar generate -t cybersource-csharp-template -i cybersource-rest-spec-netstandard.json -l csharp -o ..\ -c cybersource-csharp-config.json

powershell -Command "Get-ChildItem '..\src\CyberSource\Api\*.cs' -Recurse | ForEach-Object { (Get-Content $_).Replace('Method.POST','Method.Post').Replace('Method.GET','Method.Get').Replace('Method.PATCH','Method.Patch').Replace('Method.DELETE','Method.Delete').Replace('Method.PUT','Method.Put') | Set-Content $_ }"

powershell -Command "(Get-Content ..\src\CyberSource\Api\SecureFileShareApi.cs) | ForEach-Object { $_ -replace 'null\); \/\/ Return statement', 'localVarResponse.Content); // Return statement' } | Set-Content ..\src\CyberSource\Api\SecureFileShareApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs) | ForEach-Object { $_ -replace 'null\); \/\/ Return statement', 'localVarResponse.Content); // Return statement' } | Set-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs) | ForEach-Object { $_ -replace 'null\); \/\/ Return statement', 'localVarResponse.Content); // Return statement' } | Set-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs"

powershell -Command " Set-Content ..\src\CyberSource\Api\SecureFileShareApi.cs ((Get-Content ..\src\CyberSource\Api\SecureFileShareApi.cs -raw) -replace '\*_\/_\*;charset=utf-8', '*/*;charset=utf-8') "

REM Loading content of excludeList.txt into a space-separated list in a variable
SETLOCAL EnableDelayedExpansion
SET excludeList=
FOR /f "tokens=* delims=\n" %%a in ('type "excludelist.txt"') do (
    SET excludeList=!excludeList! %%a
)

powershell Rename-Item ..\src\CyberSource.Test\Model\RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1Tests.cs RiskV1AddressVerificationsPost201ResponseStandardAddressAddress1Tests.cs

powershell Rename-Item ..\src\CyberSource\Model\RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1.cs RiskV1AddressVerificationsPost201ResponseAddress1.cs

powershell Rename-Item ..\docs\RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1.md RiskV1AddressVerificationsPost201ResponseAddress1.md

powershell Rename-Item ..\src\CyberSource.Test\Model\Ptsv2paymentsProcessingInformationAuthorizationOptionsInitiatorMerchantInitiatedTransactionTests.cs Ptsv2paymentsMerchantInitiatedTransactionTests.cs

robocopy ..\src\CyberSource ..\src /S /XF %excludeList%

robocopy ..\src\CyberSource.Test ..\tests /S /XF %excludeList%

@REM replace sdkLinks fieldName to links for supporting links field name in request/response body
echo "starting of replacing the links keyword in PblPaymentLinksAllGet200Response.cs model"
powershell -Command "Set-Content ..\src\Model\PblPaymentLinksAllGet200Response.cs ((Get-Content ..\src\Model\PblPaymentLinksAllGet200Response.cs -Raw) -replace '\[JsonPropertyName\(\"sdkLinks\"\)\]', '[JsonPropertyName(\"links\")]')"
echo "completed the task of replacing the links keyword in PblPaymentLinksAllGet200Response.cs model"

rd /s /q ..\src\CyberSource
rd /s /q ..\src\CyberSource.Test
del ..\*ignore
del ..\.travis.yml
del ..\build.*
del ..\git_push.sh
del ..\mono_nunit_test.sh
del ..\README.md
del ..\license.txt
del ..\CyberSource.sln

git checkout ..\.gitignore
git checkout ..\README.md
git checkout ..\license.txt

del ..\src\Client\IReadableConfiguration.cs

git checkout ..\src\Api\OAuthApi.cs
git checkout ..\src\Model\AccessTokenResponse.cs
git checkout ..\src\Model\CreateAccessTokenRequest.cs
git checkout ..\src\Client\GlobalConfiguration.cs
git checkout ..\src\Api\ApiBase.cs
git checkout ..\src\Client\IConfiguration.cs
git checkout ..\src\Client\IMerchantLegacySettings.cs
git checkout ..\src\Client\IMerchantNetworkSettings.cs
git checkout ..\src\Client\IMutableConfiguration.cs
git checkout ..\src\Client\ConfigurationAuthenticationExtensions.cs
git checkout ..\src\Client\ConfigurationMLEExtensions.cs
git checkout ..\src\Client\MerchantCredentialSettingsFactory.cs
git checkout ..\src\Client\MerchantCredentialSettingsProcessor.cs
git checkout ..\src\Client\MerchantCredentialSettingsValidator.cs
git checkout ..\src\Client\MerchantLegacySettings.cs
git checkout ..\src\Client\MerchantMLESettingsFactory.cs
git checkout ..\src\Client\MerchantMLESettingsProcessor.cs
git checkout ..\src\Client\MerchantMLESettingsValidator.cs
git checkout ..\src\Client\MerchantRequestSettingsFactory.cs
git checkout ..\src\Client\MerchantNetworkSettings.cs
git checkout ..\src\Client\RestClientFactory.cs

pause
