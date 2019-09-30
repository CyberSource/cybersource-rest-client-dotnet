@echo off

rd /s /q ..\Api
rd /s /q ..\Client
rd /s /q ..\Model
rd /s /q ..\docs
rd /s /q ..\test

java -jar swagger-codegen-cli-2.2.3.jar generate -t cybersource-csharp-template -i cybersource-rest-spec.json -l csharp -o ../ -c cybersource-csharp-config.json

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\SecureFileShareApi.cs) ; $fileContents[300] = $fileContents[300] -replace 'null', 'localVarResponse.Content' ;  $fileContents[372] = $fileContents[372] -replace 'null', 'localVarResponse.Content' ;$fileContents|Set-Content ..\src\CyberSource\Api\SecureFileShareApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportDownloadsApi.cs) ; $fileContents[259] = $fileContents[259] -replace 'null', 'localVarResponse.Content' ;  $fileContents[336] = $fileContents[336] -replace 'null', 'localVarResponse.Content' ;$fileContents|Set-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\TransactionBatchesApi.cs) ; $fileContents[344] = $fileContents[344] -replace 'null', 'localVarResponse.Content' ;  $fileContents[418] = $fileContents[418] -replace 'null', 'localVarResponse.Content' ;$fileContents|Set-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs"

rem Accept Type and Content Type Changes

REM Should be fixed by change in spec files. Need review 
powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\SearchTransactionsApi.cs) ; $fileContents[409] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\SearchTransactionsApi.cs"

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
