@echo off

rd /s /q ..\Api
rd /s /q ..\Client
rd /s /q ..\Model
rd /s /q ..\docs
rd /s /q ..\test

java -jar swagger-codegen-cli-2.2.3.jar generate -t cybersource-csharp-template -i cybersource-rest-spec.json -l csharp -o ../ -c cybersource-csharp-config.json

rem For removing trailing forward slash from endpoints
powershell -Command "(Get-Content ..\src\CyberSource\Api\CreditApi.cs) | ForEach-Object { $_ -replace '/pts/v2/credits/', '/pts/v2/credits' } | Set-Content ..\src\CyberSource\Api\CreditApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\PaymentsApi.cs) | ForEach-Object { $_ -replace '/pts/v2/payments/', '/pts/v2/payments' } | Set-Content ..\src\CyberSource\Api\PaymentsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\PayoutsApi.cs) | ForEach-Object { $_ -replace '/pts/v2/payouts/', '/pts/v2/payouts' } | Set-Content ..\src\CyberSource\Api\PayoutsApi.cs"


rem For Converting the datetime values to string while passing them to the query params object
powershell -Command "(Get-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs) | ForEach-Object { $_ -replace 'ParameterToString\(reportDate\)', 'ParameterToString(reportDate.Value.ToString("""yyyy-MM-dd"""))' } | Set-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\SecureFileShareApi.cs) | ForEach-Object { $_ -replace 'ParameterToString\(startDate\)', 'ParameterToString(startDate.Value.ToString("""yyyy-MM-dd"""))' } | Set-Content ..\src\CyberSource\Api\SecureFileShareApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\SecureFileShareApi.cs) | ForEach-Object { $_ -replace 'ParameterToString\(endDate\)', 'ParameterToString(endDate.Value.ToString("""yyyy-MM-dd"""))' } | Set-Content ..\src\CyberSource\Api\SecureFileShareApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\SecureFileShareApi.cs) ; $fileContents[300] = $fileContents[300] -replace 'null', 'localVarResponse.Content' ; $fileContents|Set-Content ..\src\CyberSource\Api\SecureFileShareApi.cs"
powershell -Command "(Get-Content ..\src\CyberSource\Model\ReportingV3ReportSubscriptionsGet200ResponseSubscriptions.cs) | ForEach-Object { $_ -replace 'DateTime\?', 'string' } | Set-Content ..\src\CyberSource\Model\ReportingV3ReportSubscriptionsGet200ResponseSubscriptions.cs"


rem For Converting the datetime values to string while appending them to the localVarPath and commenting out the values being set in query params obj
powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\TransactionBatchesApi.cs) ; $fileContents[388] = $fileContents[388] -replace '/pts/v1/transaction-batches', '/pts/v1/transaction-batches?startTime={startTime.Value.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")}&endTime={endTime.Value.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")}' ; $fileContents[462] = $fileContents[462] -replace '/pts/v1/transaction-batches', '/pts/v1/transaction-batches?startTime={startTime.Value.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")}&endTime={endTime.Value.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")}'; $fileContents|Set-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs) | ForEach-Object { $_ -replace 'if \(startTime != null\)', '//if (startTime != null)' } | Set-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs) | ForEach-Object { $_ -replace 'if \(endTime != null\)', '//if (endTime != null)' } | Set-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportDownloadsApi.cs) ; $fileContents[259] = $fileContents[259] -replace 'null', 'localVarResponse.Content' ; $fileContents|Set-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs"

powershell -Command "$fileContents = (Get-Content ..\src\CyberSource\Api\NetFundingsApi.cs) | ForEach-Object { $_ -replace '/reporting/v3/net-fundings', '/reporting/v3/net-fundings?startTime={startTime.Value.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")}&endTime={endTime.Value.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")}&organizationId={organizationId}&groupName={groupName}' } | Set-Content ..\src\CyberSource\Api\NetFundingsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\NetFundingsApi.cs) | ForEach-Object { $_ -replace 'if \(startTime != null\)', '//if (startTime != null)' } | Set-Content ..\src\CyberSource\Api\NetFundingsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\NetFundingsApi.cs) | ForEach-Object { $_ -replace 'if \(endTime != null\)', '//if (endTime != null)' } | Set-Content ..\src\CyberSource\Api\NetFundingsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\NetFundingsApi.cs) | ForEach-Object { $_ -replace 'if \(organizationId != null\)', '//if (organizationId != null)' } | Set-Content ..\src\CyberSource\Api\NetFundingsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\NetFundingsApi.cs) | ForEach-Object { $_ -replace 'if \(groupName != null\)', '//if (groupName != null)' } | Set-Content ..\src\CyberSource\Api\NetFundingsApi.cs"


powershell -Command "$fileContents = (Get-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs) | ForEach-Object { $_ -replace '/reporting/v3/purchase-refund-details', '/reporting/v3/purchase-refund-details?startTime={startTime.Value.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")}&endTime={endTime.Value.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")}&organizationId={organizationId}&paymentSubtype={paymentSubtype}&viewBy={viewBy}&groupName={groupName}&offset={offset}&limit={limit}' } | Set-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs) | ForEach-Object { $_ -replace 'if \(startTime != null\)', '//if (startTime != null)' } | Set-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs) | ForEach-Object { $_ -replace 'if \(endTime != null\)', '//if (endTime != null)' } | Set-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs) | ForEach-Object { $_ -replace 'if \(organizationId != null\)', '//if (organizationId != null)' } | Set-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs) | ForEach-Object { $_ -replace 'if \(paymentSubtype != null\)', '//if (paymentSubtype != null)' } | Set-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs) | ForEach-Object { $_ -replace 'if \(viewBy != null\)', '//if (viewBy != null)' } | Set-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs) | ForEach-Object { $_ -replace 'if \(groupName != null\)', '//if (groupName != null)' } | Set-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs) | ForEach-Object { $_ -replace 'if \(offset != null\)', '//if (offset != null)' } | Set-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs) | ForEach-Object { $_ -replace 'if \(limit != null\)', '//if (limit != null)' } | Set-Content ..\src\CyberSource\Api\PurchaseAndRefundDetailsApi.cs"


powershell -Command "(Get-Content ..\src\CyberSource\Api\NotificationOfChangesApi.cs) | ForEach-Object { $_ -replace '/reporting/v3/notification-of-changes', '/reporting/v3/notification-of-changes?startTime={startTime.Value.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")}&endTime={endTime.Value.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")}' } | Set-Content ..\src\CyberSource\Api\NotificationOfChangesApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\NotificationOfChangesApi.cs) | ForEach-Object { $_ -replace 'if \(startTime != null\)', '//if (startTime != null)' } | Set-Content ..\src\CyberSource\Api\NotificationOfChangesApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\NotificationOfChangesApi.cs) | ForEach-Object { $_ -replace 'if \(endTime != null\)', '//if (endTime != null)' } | Set-Content ..\src\CyberSource\Api\NotificationOfChangesApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\ConversionDetailsApi.cs) | ForEach-Object { $_ -replace '/reporting/v3/conversion-details', '/reporting/v3/conversion-details?startTime={startTime.Value.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")}&endTime={endTime.Value.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")}&organizationId={organizationId}' } | Set-Content ..\src\CyberSource\Api\ConversionDetailsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\ConversionDetailsApi.cs) | ForEach-Object { $_ -replace 'if \(startTime != null\)', '//if (startTime != null)' } | Set-Content ..\src\CyberSource\Api\ConversionDetailsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\ConversionDetailsApi.cs) | ForEach-Object { $_ -replace 'if \(endTime != null\)', '//if (endTime != null)' } | Set-Content ..\src\CyberSource\Api\ConversionDetailsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\ConversionDetailsApi.cs) | ForEach-Object { $_ -replace 'if \(organizationId != null\)', '//if (organizationId != null)' } | Set-Content ..\src\CyberSource\Api\ConversionDetailsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[656] = $fileContents[656] -replace 'Configuration.ApiClient.SelectHeaderContentType\(localVarHttpContentTypes\)', '\"\"'; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[666] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[667] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[668] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[669] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[670] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[671] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[672] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[673] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[674] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[644] = (get-content ReportsApiLocalVarPath.txt); $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"


rem For Removing the length check for a property which is currently giving compile time error
powershell -Command "$fileContents = (get-content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs) ; $fileContents[448] = ''; $fileContents|Set-Content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs) ; $fileContents[449] = ''; $fileContents|Set-Content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs) ; $fileContents[450] = ''; $fileContents|Set-Content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs) ; $fileContents[451] = ''; $fileContents|Set-Content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs) ; $fileContents[452] = ''; $fileContents|Set-Content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs"


rem For Adding missing properties in the model file
powershell -Command "(Get-Content ..\src\CyberSource\Model\Ptsv2paymentsidcapturesPointOfSaleInformation.cs) | ForEach-Object { $_ -replace 'AmexCapnData = default\(string\)', 'AmexCapnData = default(string), bool CardPresent = default(bool), string CatLevel = default(string), string TerminalCapability = default(string)' } | Set-Content ..\src\CyberSource\Model\Ptsv2paymentsidcapturesPointOfSaleInformation.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Model\Ptsv2paymentsidcapturesPointOfSaleInformation.cs) | ForEach-Object { $_ -replace \"this.AmexCapnData = AmexCapnData;\", \"this.AmexCapnData = AmexCapnData;`r`n`t`t`tthis.CardPresent = CardPresent;`r`n`t`t`tthis.CatLevel = CatLevel;`r`n`t`t`tthis.TerminalCapability = TerminalCapability;\" } | Set-Content ..\src\CyberSource\Model\Ptsv2paymentsidcapturesPointOfSaleInformation.cs"


powershell -Command "(Get-Content ..\src\CyberSource\Model\Ptsv2paymentsidcapturesPointOfSaleInformation.cs) | ForEach-Object { $_ -replace 'public string AmexCapnData { get; set; }', 'public string AmexCapnData { get; set; }[DataMember(Name = \"CardPresent\", EmitDefaultValue = false)]public bool CardPresent { get; set; }[DataMember(Name = \"CatLevel\", EmitDefaultValue = false)]public string CatLevel { get; set; }[DataMember(Name = \"TerminalCapability\", EmitDefaultValue = false)]public string TerminalCapability { get; set; }' } | Set-Content ..\src\CyberSource\Model\Ptsv2paymentsidcapturesPointOfSaleInformation.cs"


rem Accept Type and Content Type Changes
powershell -Command " Set-Content ..\src\CyberSource\Api\CaptureApi.cs ((get-content ..\src\CyberSource\Api\CaptureApi.cs -raw) -replace '(?m)(.*)^*String\[\] localVarHttpHeaderAccepts = new String\[\] {[\r\n\s]+\"application\/json;charset=utf-8\"', 'String[] localVarHttpHeaderAccepts = new String[] {\"application/hal+json;charset=utf-8\"')"

powershell -Command " Set-Content ..\src\CyberSource\Api\CreditApi.cs ((get-content ..\src\CyberSource\Api\CreditApi.cs -raw) -replace '(?m)(.*)^*String\[\] localVarHttpHeaderAccepts = new String\[\] {[\r\n\s]+\"application\/json;charset=utf-8\"', 'String[] localVarHttpHeaderAccepts = new String[] {\"application/hal+json;charset=utf-8\"')"

powershell -Command " Set-Content ..\src\CyberSource\Api\PaymentsApi.cs ((get-content ..\src\CyberSource\Api\PaymentsApi.cs -raw) -replace '(?m)(.*)^*String\[\] localVarHttpHeaderAccepts = new String\[\] {[\r\n\s]+\"application\/json;charset=utf-8\"', 'String[] localVarHttpHeaderAccepts = new String[] {\"application/hal+json;charset=utf-8\"')"

powershell -Command " Set-Content ..\src\CyberSource\Api\PayoutsApi.cs ((get-content ..\src\CyberSource\Api\PayoutsApi.cs -raw) -replace '(?m)(.*)^*String\[\] localVarHttpHeaderAccepts = new String\[\] {[\r\n\s]+\"application\/json;charset=utf-8\"', 'String[] localVarHttpHeaderAccepts = new String[] {\"application/hal+json;charset=utf-8\"')"

powershell -Command " Set-Content ..\src\CyberSource\Api\RefundApi.cs ((get-content ..\src\CyberSource\Api\RefundApi.cs -raw) -replace '(?m)(.*)^*String\[\] localVarHttpHeaderAccepts = new String\[\] {[\r\n\s]+\"application\/json;charset=utf-8\"', 'String[] localVarHttpHeaderAccepts = new String[] {\"application/hal+json;charset=utf-8\"')"

powershell -Command " Set-Content ..\src\CyberSource\Api\ReversalApi.cs ((get-content ..\src\CyberSource\Api\ReversalApi.cs -raw) -replace '(?m)(.*)^*String\[\] localVarHttpHeaderAccepts = new String\[\] {[\r\n\s]+\"application\/json;charset=utf-8\"', 'String[] localVarHttpHeaderAccepts = new String[] {\"application/hal+json;charset=utf-8\"')"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\SearchTransactionsApi.cs) ; $fileContents[409] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\SearchTransactionsApi.cs"

powershell -Command " Set-Content ..\src\CyberSource\Api\TransactionDetailsApi.cs ((get-content ..\src\CyberSource\Api\TransactionDetailsApi.cs -raw) -replace '(?m)(.*)^*String\[\] localVarHttpHeaderAccepts = new String\[\] {[\r\n\s]+\"application\/json;charset=utf-8\"', 'String[] localVarHttpHeaderAccepts = new String[] {\"application/hal+json;charset=utf-8\"')"

powershell -Command " Set-Content ..\src\CyberSource\Api\UserManagementApi.cs ((get-content ..\src\CyberSource\Api\UserManagementApi.cs -raw) -replace '(?m)(.*)^*String\[\] localVarHttpHeaderAccepts = new String\[\] {[\r\n\s]+\"application\/json;charset=utf-8\"', 'String[] localVarHttpHeaderAccepts = new String[] {\"application/hal+json;charset=utf-8\"')"

powershell -Command " Set-Content ..\src\CyberSource\Api\VoidApi.cs ((get-content ..\src\CyberSource\Api\VoidApi.cs -raw) -replace '(?m)(.*)^*String\[\] localVarHttpHeaderAccepts = new String\[\] {[\r\n\s]+\"application\/json;charset=utf-8\"', 'String[] localVarHttpHeaderAccepts = new String[] {\"application/hal+json;charset=utf-8\"')"

powershell -Command " Set-Content ..\src\CyberSource\Api\PayerAuthenticationApi.cs ((get-content ..\src\CyberSource\Api\PayerAuthenticationApi.cs -raw) -replace '(?m)(.*)^*String\[\] localVarHttpHeaderAccepts = new String\[\] {[\r\n\s]+\"application\/json;charset=utf-8\"', 'String[] localVarHttpHeaderAccepts = new String[] {\"application/hal+json;charset=utf-8\"')"


rem For Adding Missing Enum Value
powershell -Command "$fileContents = (get-content ..\src\CyberSource\Model\ReportingV3ReportDefinitionsGet200ResponseReportDefinitions.cs) ; $fileContents[50] = (get-content ReportingV3ReportDefinitionsGet200ResponseReportDefinitions.txt); $fileContents|Set-Content ..\src\CyberSource\Model\ReportingV3ReportDefinitionsGet200ResponseReportDefinitions.cs"

REM powershell -Command "$fileContents = (get-content ..\src\CyberSource\Model\ReportingV3ReportsIdGet200Response.cs) ; $fileContents[77] = (get-content ReportingV3ReportsIdGet200Response.txt); $fileContents|Set-Content ..\src\CyberSource\Model\ReportingV3ReportsIdGet200Response.cs"

rem For changing nuspec filename in csproj file

powershell -Command "(Get-Content ..\src\CyberSource\CyberSource.csproj) | ForEach-Object { $_ -replace '<None Include=\"CyberSource.nuspec\" />', '<None Include=\"cybersource-rest-client-dotnet.nuspec\" />' } | Set-Content ..\src\CyberSource\CyberSource.csproj"

powershell -Command "(Get-Content ..\src\CyberSource.Test\CyberSource.Test.csproj) | ForEach-Object { $_ -replace 'CyberSource\\CyberSource.csproj', 'cybersource-rest-client-dotnet.csproj' } | ForEach-Object { $_ -replace '<Name>CyberSource</Name>', '<Name>cybersource-rest-client-dotnet</Name>' } | Set-Content ..\src\CyberSource.Test\CyberSource.Test.csproj"

rem For Renaming the .csproj file Name from Cybersource to cybersource-rest-client-dotnet
powershell Rename-Item ..\src\CyberSource\CyberSource.csproj cybersource-rest-client-dotnet.csproj
powershell Rename-Item ..\src\CyberSource.Test\CyberSource.Test.csproj cybersource-rest-client-dotnet.Test.csproj

rem For changing project filenames in sln file
powershell -Command "(Get-Content ..\CyberSource.sln) | ForEach-Object { $_ -replace 'CyberSource', 'cybersource-rest-client-dotnet' } | Set-Content ..\CyberSource.sln"

rem For Renaming the .sln filename from Cybersource to cybersource-rest-client-dotnet
del ..\cybersource-rest-client-dotnet.sln

powershell Rename-Item ..\CyberSource.sln cybersource-rest-client-dotnet.sln

xcopy ..\src\cybersource ..\ /s /e /y /exclude:excludelist.txt
git checkout ..\README.md
md ..\test
xcopy ..\src\cybersource.test ..\test /s /e /y

rd /s /q ..\src


pause
