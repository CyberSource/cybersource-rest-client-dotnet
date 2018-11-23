mkdir %~dp0Csharp
cd %~dp0

java -jar swagger-codegen-cli-2.2.3.jar generate -t cybersource-csharp-template -i cybersource-rest-spec.json -l csharp -o Csharp -c %~dp0cybersource-csharp-config.json


pause



