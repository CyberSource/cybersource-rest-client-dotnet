java -jar swagger-codegen-cli-2.2.3.jar generate -t cybersource-csharp-template -i cybersource-rest-spec.json -l csharp -o ../ -c cybersource-csharp-config.json

powershell -Command "(Get-Content ..\src\CyberSource\Api\CreditApi.cs) | ForEach-Object { $_ -replace '/pts/v2/credits/', '/pts/v2/credits' } | Set-Content ..\src\CyberSource\Api\CreditApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\PaymentsApi.cs) | ForEach-Object { $_ -replace '/pts/v2/payments/', '/pts/v2/payments' } | Set-Content ..\src\CyberSource\Api\PaymentsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\ProcessAPayoutApi.cs) | ForEach-Object { $_ -replace '/pts/v2/payouts/', '/pts/v2/payouts' } | Set-Content ..\src\CyberSource\Api\ProcessAPayoutApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs) | ForEach-Object { $_ -replace '/reporting/v3/report-downloads', '/reporting/v3/report-downloads/?reportDate={reportDate}&reportName={reportName}' } | Set-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs) | ForEach-Object { $_ -replace 'if \(organizationId != null\)', '//if (organizationId != null)' } | Set-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs) | ForEach-Object { $_ -replace 'if \(reportDate != null\)', '//if (reportDate != null)' } | Set-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs) | ForEach-Object { $_ -replace 'if \(reportName != null\)', '//if (reportName != null)' } | Set-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs) | ForEach-Object { $_ -replace '/pts/v1/transaction-batches', '/pts/v1/transaction-batches?startTime={startTime}&endTime={endTime}' } | Set-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs) | ForEach-Object { $_ -replace 'if \(startTime != null\)', '//if (startTime != null)' } | Set-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs) | ForEach-Object { $_ -replace 'if \(endTime != null\)', '//if (endTime != null)' } | Set-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs"

pause
