@echo off

rd /s /q ..\Api
rd /s /q ..\Client
rd /s /q ..\Model
rd /s /q ..\docs
rd /s /q ..\test

setlocal enabledelayedexpansion
python replaceFieldNamesForPaths.py -i cybersource-rest-spec.json -o cybersource-rest-spec-dotnet.json > replaceFieldLogs.log
del replaceFieldLogs.log
endlocal

java -jar swagger-codegen-cli-2.4.38.jar generate -t cybersource-csharp-template -i cybersource-rest-spec-dotnet.json -l csharp -o ../ -c cybersource-csharp-config.json

powershell -Command "Get-ChildItem '..\src\Cybersource\Api\*.cs' -Recurse | ForEach-Object { (Get-Content $_).Replace('Method.POST','Method.Post').Replace('Method.GET','Method.Get').Replace('Method.PATCH','Method.Patch').Replace('Method.DELETE','Method.Delete').Replace('Method.PUT','Method.Put') | Set-Content $_ }"

powershell -Command "(Get-Content ..\src\CyberSource\Api\SecureFileShareApi.cs) | ForEach-Object { $_ -replace 'null\); \/\/ Return statement', 'localVarResponse.Content); // Return statement' } | Set-Content ..\src\CyberSource\Api\SecureFileShareApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs) | ForEach-Object { $_ -replace 'null\); \/\/ Return statement', 'localVarResponse.Content); // Return statement' } | Set-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs) | ForEach-Object { $_ -replace 'null\); \/\/ Return statement', 'localVarResponse.Content); // Return statement' } | Set-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs"

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

@REM replace sdkLinks fieldName to links for supporting links field name in request/response body
echo "starting of replacing the links keyword in PblPaymentLinksAllGet200Response.cs model"
powershell -Command "Set-Content ..\Model\PblPaymentLinksAllGet200Response.cs ((Get-Content ..\Model\PblPaymentLinksAllGet200Response.cs -Raw) -replace '\[DataMember\(Name=\"sdkLinks\", EmitDefaultValue=false\)\]', '[DataMember(Name=\"links\", EmitDefaultValue=false)]')"
echo "completed the task of replacing the links keyword in PblPaymentLinksAllGet200Response.cs model"

git checkout ..\README.md
git checkout ..\Api\OAuthApi.cs
git checkout ..\Model\AccessTokenResponse.cs
git checkout ..\Model\CreateAccessTokenRequest.cs
md ..\test
xcopy ..\src\cybersource.test ..\test /s /e /y
git checkout ..\test\packages.config

rd /s /q ..\src

del ..\Client\IReadableConfiguration.cs

pause
