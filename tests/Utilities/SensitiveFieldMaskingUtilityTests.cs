using System;
using NUnit.Framework;
using Newtonsoft.Json.Linq;
using CyberSource.Utilities;

namespace cybersource_rest_client_netstandard.Test.Utilities
{
    [TestFixture]
    public class SensitiveFieldMaskingUtilityTests
    {
        private const string Masked = "***";

        // ─── MaskFieldValue: sensitive fields ────────────────────────────────────

        [Test]
        public void MaskFieldValue_ExactPassword_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("password", "s3cr3t!"));

        [Test]
        public void MaskFieldValue_CamelCaseClientSecret_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("clientSecret", "mySecret"));

        [Test]
        public void MaskFieldValue_SnakeCaseClientSecret_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("client_secret", "mySecret"));

        [Test]
        public void MaskFieldValue_SnakeCaseRefreshToken_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("refresh_token", "tok123"));

        [Test]
        public void MaskFieldValue_SnakeCaseAccessToken_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("access_token", "tok456"));

        [Test]
        public void MaskFieldValue_OAuthCode_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("code", "authcode789"));

        [Test]
        public void MaskFieldValue_SnakeCaseClientId_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("client_id", "app-id-001"));

        [Test]
        public void MaskFieldValue_HashedPassword_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("hashedPassword", "hash123"));

        [Test]
        public void MaskFieldValue_EncryptedPin_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("encryptedPin", "encpin"));

        [Test]
        public void MaskFieldValue_CvvVariant_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("cvv", "123"));

        // ─── MaskFieldValue: null / non-sensitive ────────────────────────────────

        [Test]
        public void MaskFieldValue_NullValue_ReturnsNull()
            => Assert.IsNull(SensitiveFieldMaskingUtility.MaskFieldValue("password", null));

        [Test]
        public void MaskFieldValue_TokenType_ReturnsUnchanged()
            => Assert.AreEqual("Bearer", SensitiveFieldMaskingUtility.MaskFieldValue("token_type", "Bearer"));

        [Test]
        public void MaskFieldValue_RefreshTokenExpiresIn_ReturnsUnchanged()
            => Assert.AreEqual("3600", SensitiveFieldMaskingUtility.MaskFieldValue("refresh_token_expires_in", "3600"));

        [Test]
        public void MaskFieldValue_Scope_ReturnsUnchanged()
            => Assert.AreEqual("openid", SensitiveFieldMaskingUtility.MaskFieldValue("scope", "openid"));

        [Test]
        public void MaskFieldValue_GrantType_ReturnsUnchanged()
            => Assert.AreEqual("authorization_code", SensitiveFieldMaskingUtility.MaskFieldValue("grant_type", "authorization_code"));

        // ─── MaskSensitiveDataInJson: snake_case credential keys ─────────────────

        [Test]
        public void MaskSensitiveDataInJson_MasksClientSecret()
        {
            var json = "{\"client_secret\": \"mySecret\", \"grant_type\": \"authorization_code\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["client_secret"]);
            Assert.AreEqual("authorization_code", (string)obj["grant_type"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksRefreshToken()
        {
            var json = "{\"refresh_token\": \"tok123\", \"expires_in\": 3600}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["refresh_token"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksAccessToken()
        {
            var json = "{\"access_token\": \"tok456\", \"token_type\": \"Bearer\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["access_token"]);
        }

        // ─── MaskSensitiveDataInJson: non-sensitive fields not masked ────────────

        [Test]
        public void MaskSensitiveDataInJson_DoesNotMaskTokenType()
        {
            var json = "{\"token_type\": \"Bearer\", \"access_token\": \"tok\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual("Bearer", (string)obj["token_type"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_DoesNotMaskRefreshTokenExpiresIn()
        {
            var json = "{\"refresh_token_expires_in\": 7200}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual("7200", (string)obj["refresh_token_expires_in"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_DoesNotMaskGrantType()
        {
            var json = "{\"grant_type\": \"client_credentials\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual("client_credentials", (string)obj["grant_type"]);
        }

        // ─── MaskSensitiveDataInJson: edge cases ─────────────────────────────────

        [Test]
        public void MaskSensitiveDataInJson_EmptyString_ReturnsEmpty()
            => Assert.AreEqual(string.Empty, SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(string.Empty));

        [Test]
        public void MaskSensitiveDataInJson_NullString_ReturnsNull()
            => Assert.IsNull(SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(null));

        [Test]
        public void MaskSensitiveDataInJson_InvalidJson_ReturnsUnchanged()
        {
            const string notJson = "not json at all";
            Assert.AreEqual(notJson, SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(notJson));
        }

        [Test]
        public void MaskSensitiveDataInJson_NullFieldValue_NotTouched()
        {
            var json = "{\"password\": null}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.IsNull((string)obj["password"]);
        }

        // ─── MaskFieldValue: CHD / PAN fields ────────────────────────────────────

        [Test]
        public void MaskFieldValue_SecurityCode_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("securityCode", "123"));

        [Test]
        public void MaskFieldValue_CardNumber_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("cardNumber", "4111111111111111"));

        [Test]
        public void MaskFieldValue_Number_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("number", "4111111111111111"));

        [Test]
        public void MaskFieldValue_AccountNumber_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("accountNumber", "123456789"));

        [Test]
        public void MaskFieldValue_Ssn_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("ssn", "123-45-6789"));

        [Test]
        public void MaskFieldValue_SnakeCaseCardNumber_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("card_number", "4111111111111111"));

        [Test]
        public void MaskFieldValue_SnakeCaseAccountNumber_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("account_number", "123456789"));

        // ─── MaskSensitiveDataInJson: CHD / PAN fields ───────────────────────────

        [Test]
        public void MaskSensitiveDataInJson_MasksSecurityCode()
        {
            var json = "{\"securityCode\": \"123\", \"amount\": \"100\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["securityCode"]);
            Assert.AreEqual("100", (string)obj["amount"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksCardNumber()
        {
            var json = "{\"cardNumber\": \"4111111111111111\", \"currency\": \"USD\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["cardNumber"]);
            Assert.AreEqual("USD", (string)obj["currency"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksNumber()
        {
            var json = "{\"number\": \"4111111111111111\", \"type\": \"Visa\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["number"]);
            Assert.AreEqual("Visa", (string)obj["type"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksAccountNumber()
        {
            var json = "{\"accountNumber\": \"123456789\", \"routingNumber\": \"021000021\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["accountNumber"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksSsn()
        {
            var json = "{\"ssn\": \"123-45-6789\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["ssn"]);
        }

        // ─── MaskFieldValue: PII fields ──────────────────────────────────────────

        [Test]
        public void MaskFieldValue_Email_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("email", "user@example.com"));

        [Test]
        public void MaskFieldValue_PhoneNumber_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("phoneNumber", "+1-555-0100"));

        [Test]
        public void MaskFieldValue_SnakeCasePhoneNumber_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("phone_number", "+1-555-0100"));

        [Test]
        public void MaskFieldValue_MobilePhone_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("mobilePhone", "+1-555-0100"));

        [Test]
        public void MaskFieldValue_FirstName_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("firstName", "Jane"));

        [Test]
        public void MaskFieldValue_LastName_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("lastName", "Doe"));

        [Test]
        public void MaskFieldValue_MiddleName_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("middleName", "Q"));

        [Test]
        public void MaskFieldValue_DateOfBirth_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("dateOfBirth", "1990-01-01"));

        [Test]
        public void MaskFieldValue_IpAddress_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("ipAddress", "10.0.0.1"));

        [Test]
        public void MaskFieldValue_RoutingNumber_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("routingNumber", "021000021"));

        [Test]
        public void MaskFieldValue_VatRegistrationNumber_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("vatRegistrationNumber", "GB123456789"));

        [Test]
        public void MaskFieldValue_CompanyTaxId_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("companyTaxId", "12-3456789"));

        [Test]
        public void MaskFieldValue_PersonalIdentification_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("personalIdentification", "A1234567"));

        // PII negative cases — non-sensitive look-alikes pass through unchanged.

        [Test]
        public void MaskFieldValue_Gender_ReturnsUnchanged()
            => Assert.AreEqual("F", SensitiveFieldMaskingUtility.MaskFieldValue("gender", "F"));

        [Test]
        public void MaskFieldValue_Language_ReturnsUnchanged()
            => Assert.AreEqual("en-US", SensitiveFieldMaskingUtility.MaskFieldValue("language", "en-US"));

        // ─── MaskSensitiveDataInJson: PII fields ─────────────────────────────────

        [Test]
        public void MaskSensitiveDataInJson_MasksEmail()
        {
            var json = "{\"email\": \"user@example.com\", \"language\": \"en-US\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["email"]);
            Assert.AreEqual("en-US", (string)obj["language"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksPhoneNumber()
        {
            var json = "{\"phoneNumber\": \"+1-555-0100\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["phoneNumber"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksMobilePhone()
        {
            var json = "{\"mobilePhone\": \"+1-555-0100\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["mobilePhone"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksNameFields()
        {
            var json = "{\"firstName\": \"Jane\", \"middleName\": \"Q\", \"lastName\": \"Doe\", \"gender\": \"F\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["firstName"]);
            Assert.AreEqual(Masked, (string)obj["middleName"]);
            Assert.AreEqual(Masked, (string)obj["lastName"]);
            Assert.AreEqual("F", (string)obj["gender"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksDateOfBirth()
        {
            var json = "{\"dateOfBirth\": \"1990-01-01\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["dateOfBirth"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksIpAddress()
        {
            var json = "{\"ipAddress\": \"10.0.0.1\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["ipAddress"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksRoutingNumber()
        {
            var json = "{\"accountNumber\": \"123456789\", \"routingNumber\": \"021000021\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["accountNumber"]);
            Assert.AreEqual(Masked, (string)obj["routingNumber"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksVatAndTaxId()
        {
            var json = "{\"vatRegistrationNumber\": \"GB123456789\", \"companyTaxId\": \"12-3456789\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["vatRegistrationNumber"]);
            Assert.AreEqual(Masked, (string)obj["companyTaxId"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksPersonalIdentification()
        {
            var json = "{\"personalIdentification\": \"A1234567\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["personalIdentification"]);
        }

        // ─── MaskFieldValue: extended PII / bank identifiers ─────────────────────

        [Test]
        public void MaskFieldValue_TaxId_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("taxId", "12-3456789"));

        [Test]
        public void MaskFieldValue_TaxIdNumber_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("taxIdNumber", "12-3456789"));

        [Test]
        public void MaskFieldValue_PassportNumber_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("passportNumber", "X12345678"));

        [Test]
        public void MaskFieldValue_NationalId_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("nationalId", "AB1234567"));

        [Test]
        public void MaskFieldValue_BirthDate_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("birthDate", "1990-01-01"));

        [Test]
        public void MaskFieldValue_CountryOfBirth_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("countryOfBirth", "US"));

        [Test]
        public void MaskFieldValue_AlternateEmail_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("alternateEmail", "user@example.com"));

        [Test]
        public void MaskFieldValue_AlternatePhoneNumber_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("alternatePhoneNumber", "+1-555-0100"));

        [Test]
        public void MaskFieldValue_WorkPhone_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("workPhone", "+1-555-0100"));

        [Test]
        public void MaskFieldValue_FullName_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("fullName", "Jane Doe"));

        [Test]
        public void MaskFieldValue_LegalName_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("legalName", "Acme Inc"));

        [Test]
        public void MaskFieldValue_BeneficiaryName_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("beneficiaryName", "Jane Doe"));

        [Test]
        public void MaskFieldValue_Iban_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("iban", "DE89370400440532013000"));

        [Test]
        public void MaskFieldValue_SwiftCode_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("swiftCode", "DEUTDEFF"));

        [Test]
        public void MaskFieldValue_BankAccount_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("bankAccount", "123456789"));

        [Test]
        public void MaskFieldValue_AccountHolderName_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("accountHolderName", "Jane Doe"));

        [Test]
        public void MaskFieldValue_AccountRoutingNumber_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("accountRoutingNumber", "021000021"));

        [Test]
        public void MaskFieldValue_CorrectedAccountNumber_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("correctedAccountNumber", "987654321"));

        [Test]
        public void MaskFieldValue_CorrectedRoutingNumber_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("correctedRoutingNumber", "021000021"));

        // Negative cases — non-sensitive look-alikes pass through unchanged.

        [Test]
        public void MaskFieldValue_Country_ReturnsUnchanged()
            => Assert.AreEqual("US", SensitiveFieldMaskingUtility.MaskFieldValue("country", "US"));

        [Test]
        public void MaskFieldValue_BankName_ReturnsUnchanged()
            => Assert.AreEqual("Acme Bank", SensitiveFieldMaskingUtility.MaskFieldValue("bankName", "Acme Bank"));

        // ─── MaskSensitiveDataInJson: extended PII / bank identifiers ────────────

        [Test]
        public void MaskSensitiveDataInJson_MasksPassportAndNationalId()
        {
            var json = "{\"passportNumber\": \"X12345678\", \"nationalId\": \"AB1234567\", \"country\": \"US\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["passportNumber"]);
            Assert.AreEqual(Masked, (string)obj["nationalId"]);
            Assert.AreEqual("US", (string)obj["country"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksBirthDate()
        {
            var json = "{\"birthDate\": \"1990-01-01\", \"countryOfBirth\": \"US\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["birthDate"]);
            Assert.AreEqual(Masked, (string)obj["countryOfBirth"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksTaxIdVariants()
        {
            var json = "{\"taxId\": \"12-3456789\", \"taxIdNumber\": \"98-7654321\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["taxId"]);
            Assert.AreEqual(Masked, (string)obj["taxIdNumber"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksNameVariants()
        {
            var json = "{\"fullName\": \"Jane Doe\", \"legalName\": \"Acme Inc\", \"beneficiaryName\": \"Jane Doe\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["fullName"]);
            Assert.AreEqual(Masked, (string)obj["legalName"]);
            Assert.AreEqual(Masked, (string)obj["beneficiaryName"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksAlternateContactFields()
        {
            var json = "{\"alternateEmail\": \"user@example.com\", \"alternatePhoneNumber\": \"+1-555-0100\", \"workPhone\": \"+1-555-0200\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["alternateEmail"]);
            Assert.AreEqual(Masked, (string)obj["alternatePhoneNumber"]);
            Assert.AreEqual(Masked, (string)obj["workPhone"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksBankIdentifiers()
        {
            var json = "{\"iban\": \"DE89370400440532013000\", \"swiftCode\": \"DEUTDEFF\", \"bankName\": \"Acme Bank\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["iban"]);
            Assert.AreEqual(Masked, (string)obj["swiftCode"]);
            Assert.AreEqual("Acme Bank", (string)obj["bankName"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksBankAccountFields()
        {
            var json = "{\"bankAccount\": \"123456789\", \"accountHolderName\": \"Jane Doe\", \"accountRoutingNumber\": \"021000021\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["bankAccount"]);
            Assert.AreEqual(Masked, (string)obj["accountHolderName"]);
            Assert.AreEqual(Masked, (string)obj["accountRoutingNumber"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksCorrectedAccountFields()
        {
            var json = "{\"correctedAccountNumber\": \"987654321\", \"correctedRoutingNumber\": \"021000021\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["correctedAccountNumber"]);
            Assert.AreEqual(Masked, (string)obj["correctedRoutingNumber"]);
        }

        // ─── MaskFieldValue: Sensitive Authentication Data (SAD) / PAN ───────────

        [Test]
        public void MaskFieldValue_TrackData_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("trackData", "B4111111111111111^DOE/JANE^2512101000000000000000000000000000000000"));

        [Test]
        public void MaskFieldValue_SnakeCaseTrackData_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("track_data", "B4111111111111111^DOE/JANE^2512"));

        [Test]
        public void MaskFieldValue_Jis2TrackData_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("jis2TrackData", "4111111111111111=251210100000000"));

        [Test]
        public void MaskFieldValue_Cavv_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("cavv", "AAABCSIIAAAAAAACcwgQkAAAAAAA="));

        [Test]
        public void MaskFieldValue_UcafAuthenticationData_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("ucafAuthenticationData", "AAABCSIIAAAAAAACcwgQkAAAAAAA="));

        [Test]
        public void MaskFieldValue_SnakeCaseUcafAuthenticationData_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("ucaf_authentication_data", "AAABCSIIAAAAAAACcwgQkAAAAAAA="));

        [Test]
        public void MaskFieldValue_ProxyPan_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("proxyPan", "4111111111111111"));

        [Test]
        public void MaskFieldValue_Emv_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("emv", "9F2608C2C4F5A4F3E1B79F0702FF00"));

        // Negative: cavv is NOT matched by the 'cvv' substring fragment
        // (IsSensitiveKey must match it via the explicit NormalizedSensitiveKeys entry,
        //  not via fragment, because 'cvv' is not a substring of 'cavv')
        [Test]
        public void MaskFieldValue_Cavv_IsMaskedViaExplicitKeyNotFragment()
        {
            // 'cavv' normalized = 'cavv'; 'cvv' is NOT a substring of 'cavv',
            // so the masking must come from the NormalizedSensitiveKeys entry.
            Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("cavv", "someAuthValue"));
        }

        // ─── MaskSensitiveDataInJson: SAD / PAN fields ────────────────────────────

        [Test]
        public void MaskSensitiveDataInJson_MasksTrackData()
        {
            var json = "{\"trackData\": \"B4111111111111111^DOE/JANE^2512\", \"cardType\": \"Visa\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["trackData"]);
            Assert.AreEqual("Visa", (string)obj["cardType"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksJis2TrackData()
        {
            var json = "{\"jis2TrackData\": \"4111111111111111=251210100000000\", \"cardType\": \"Visa\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["jis2TrackData"]);
            Assert.AreEqual("Visa", (string)obj["cardType"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksCavv()
        {
            var json = "{\"cavv\": \"AAABCSIIAAAAAAACcwgQkAAAAAAA=\", \"eci\": \"05\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["cavv"]);
            Assert.AreEqual("05", (string)obj["eci"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksUcafAuthenticationData()
        {
            var json = "{\"ucafAuthenticationData\": \"AAABCSIIAAAAAAACcwgQkAAAAAAA=\", \"eci\": \"07\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["ucafAuthenticationData"]);
            Assert.AreEqual("07", (string)obj["eci"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksProxyPan()
        {
            var json = "{\"proxyPan\": \"4111111111111111\", \"currency\": \"USD\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["proxyPan"]);
            Assert.AreEqual("USD", (string)obj["currency"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksEmv()
        {
            var json = "{\"emv\": \"9F2608C2C4F5A4F3E1B7\", \"currency\": \"USD\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["emv"]);
            Assert.AreEqual("USD", (string)obj["currency"]);
        }

        // ─── MaskFieldValue: compound credential token fields (round-7 gaps) ──────

        [Test]
        public void MaskFieldValue_ResponseAccessToken_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("responseAccessToken", "eyJhbGc.payload.sig"));

        [Test]
        public void MaskFieldValue_TransientTokenJwt_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("transientTokenJwt", "eyJhbGc.payload.sig"));

        [Test]
        public void MaskFieldValue_TransactionToken_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("transactionToken", "rupay-token-xyz"));

        [Test]
        public void MaskFieldValue_LegacyToken_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("legacyToken", "legacy-id-abc"));

        [Test]
        public void MaskFieldValue_ThirdPartyToken_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("thirdPartyToken", "3p-token-def"));

        // ─── MaskSensitiveDataInJson: compound credential token fields ────────────

        [Test]
        public void MaskSensitiveDataInJson_MasksResponseAccessToken()
        {
            var json = "{\"responseAccessToken\": \"eyJhbGc.payload.sig\", \"eci\": \"05\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["responseAccessToken"]);
            Assert.AreEqual("05", (string)obj["eci"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksTransientTokenJwt()
        {
            var json = "{\"transientTokenJwt\": \"eyJhbGc.payload.sig\", \"networkTokenOption\": \"STANDARD\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["transientTokenJwt"]);
            Assert.AreEqual("STANDARD", (string)obj["networkTokenOption"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksTransactionToken()
        {
            var json = "{\"transactionToken\": \"rupay-token-xyz\", \"xid\": \"abc123\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["transactionToken"]);
            Assert.AreEqual("abc123", (string)obj["xid"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_MasksLegacyAndThirdPartyToken()
        {
            var json = "{\"legacyToken\": \"legacy-id-abc\", \"thirdPartyToken\": \"3p-token-def\", \"currency\": \"USD\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["legacyToken"]);
            Assert.AreEqual(Masked, (string)obj["thirdPartyToken"]);
            Assert.AreEqual("USD", (string)obj["currency"]);
        }

        // ─── MaskFieldValue: passcode (PostTokenizedCardRequest carrier) ──────────

        [Test]
        public void MaskFieldValue_Passcode_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("passcode", "otp-123456"));

        [Test]
        public void MaskSensitiveDataInJson_MasksPasscode()
        {
            var json = "{\"passcode\": \"otp-123456\", \"consumerId\": \"C-1\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["passcode"]);
            Assert.AreEqual("C-1", (string)obj["consumerId"]);
        }

        // ─── MaskFieldValue: class-context overload ───────────────────────────────
        // Generic field names ("value") that are sensitive only in specific model
        // classes — must mask in those classes and pass through elsewhere.

        [Test]
        public void MaskFieldValue_ClassContext_PasscodeValue_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("Tmsv2tokenizedcardsPasscode", "value", "otp-issuer-987"));

        [Test]
        public void MaskFieldValue_ClassContext_PaymentsFluidDataValue_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("Ptsv2paymentsPaymentInformationFluidData", "value", "encrypted-p2pe-blob"));

        [Test]
        public void MaskFieldValue_ClassContext_RiskSetupsFluidDataValue_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("Riskv1authenticationsetupsPaymentInformationFluidData", "value", "encrypted-p2pe-blob"));

        [Test]
        public void MaskFieldValue_ClassContext_RiskResultsFluidDataValue_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("Riskv1authenticationresultsPaymentInformationFluidData", "value", "encrypted-p2pe-blob"));

        [Test]
        public void MaskFieldValue_ClassContext_EmvTagValue_ReturnsMasked()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("TmsEmbeddedInstrumentIdentifierPointOfSaleInformationEmvTags", "value", "9F2608C2C4F5A4F3E1B7"));

        // Negative — generic "value" on a non-sensitive class passes through.
        [Test]
        public void MaskFieldValue_ClassContext_ValueOnUnregisteredClass_ReturnsUnchanged()
            => Assert.AreEqual("not-sensitive", SensitiveFieldMaskingUtility.MaskFieldValue("SomeUnrelatedModel", "value", "not-sensitive"));

        // Class-context overload still falls back to the global catalog.
        [Test]
        public void MaskFieldValue_ClassContext_GlobalKey_StillMasks()
            => Assert.AreEqual(Masked, SensitiveFieldMaskingUtility.MaskFieldValue("AnyClass", "password", "p@ss"));

        [Test]
        public void MaskFieldValue_ClassContext_NullValue_ReturnsNull()
            => Assert.IsNull(SensitiveFieldMaskingUtility.MaskFieldValue("Tmsv2tokenizedcardsPasscode", "value", null));

        // ─── MaskSensitiveDataInJson: class-context overload ──────────────────────

        [Test]
        public void MaskSensitiveDataInJson_ClassContext_PasscodeValue_Masks()
        {
            var json = "{\"value\": \"otp-issuer-987\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson("Tmsv2tokenizedcardsPasscode", json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["value"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_ClassContext_FluidDataValue_Masks()
        {
            var json = "{\"keySerialNumber\": \"FFFF11111111110001\", \"descriptor\": \"Ymx1ZWZpbg==\", \"value\": \"encrypted-p2pe-blob\", \"encoding\": \"Base64\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson("Ptsv2paymentsPaymentInformationFluidData", json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["value"]);
            Assert.AreEqual("FFFF11111111110001", (string)obj["keySerialNumber"]);
            Assert.AreEqual("Base64", (string)obj["encoding"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_ClassContext_RiskSetupsFluidDataValue_Masks()
        {
            var json = "{\"value\": \"encrypted-p2pe-blob\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson("Riskv1authenticationsetupsPaymentInformationFluidData", json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["value"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_ClassContext_RiskResultsFluidDataValue_Masks()
        {
            var json = "{\"value\": \"encrypted-p2pe-blob\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson("Riskv1authenticationresultsPaymentInformationFluidData", json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["value"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_ClassContext_EmvTagValue_Masks()
        {
            var json = "{\"tag\": \"9F26\", \"value\": \"C2C4F5A4F3E1B7\", \"source\": \"CARD\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson("TmsEmbeddedInstrumentIdentifierPointOfSaleInformationEmvTags", json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["value"]);
            Assert.AreEqual("9F26", (string)obj["tag"]);
            Assert.AreEqual("CARD", (string)obj["source"]);
        }

        // Negative — generic "value" on a non-sensitive class is not masked.
        [Test]
        public void MaskSensitiveDataInJson_ClassContext_ValueOnUnregisteredClass_NotMasked()
        {
            var json = "{\"value\": \"safe-payload\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson("SomeUnrelatedModel", json);
            var obj = JObject.Parse(result);
            Assert.AreEqual("safe-payload", (string)obj["value"]);
        }

        // Backward compatibility — class-context overload still recurses into nested
        // sensitive fields known by the global catalog.
        [Test]
        public void MaskSensitiveDataInJson_ClassContext_StillMasksNestedGlobalKeys()
        {
            var json = "{\"value\": \"payload\", \"nested\": {\"password\": \"p@ss\"}}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson("SomeUnrelatedModel", json);
            var obj = JObject.Parse(result);
            Assert.AreEqual("payload", (string)obj["value"]);
            Assert.AreEqual(Masked, (string)obj["nested"]["password"]);
        }

        // Null/empty class name behaves as the non-class-context overload.
        [Test]
        public void MaskSensitiveDataInJson_ClassContext_NullClassName_FallsBack()
        {
            var json = "{\"password\": \"p@ss\", \"value\": \"v\"}";
            var result = SensitiveFieldMaskingUtility.MaskSensitiveDataInJson(null, json);
            var obj = JObject.Parse(result);
            Assert.AreEqual(Masked, (string)obj["password"]);
            Assert.AreEqual("v", (string)obj["value"]);
        }

        [Test]
        public void MaskSensitiveDataInJson_ClassContext_EmptyJson_ReturnsInput()
        {
            Assert.AreEqual(string.Empty, SensitiveFieldMaskingUtility.MaskSensitiveDataInJson("Tmsv2tokenizedcardsPasscode", string.Empty));
            Assert.IsNull(SensitiveFieldMaskingUtility.MaskSensitiveDataInJson("Tmsv2tokenizedcardsPasscode", null));
        }
    }
}
