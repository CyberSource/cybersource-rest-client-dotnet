using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace CyberSource.Utilities
{
    /// <summary>
    /// Utility for masking sensitive credential field values in diagnostic outputs
    /// such as ToString() and ToJson() on model objects.
    /// This class must NOT be used during API request/response serialization.
    ///
    /// TWO-LIST DESIGN:
    /// Credential fields (password, secret, secretKey, apiKey, cvv, cvn) appear in BOTH:
    ///   1. SensitiveDataConfigurationType.sensitiveTags (AuthenticationSdk) — masks them
    ///      in outbound HTTP request/response logs.
    ///   2. SensitiveFieldMaskingUtility.SensitiveKeys (this class) — masks them in model
    ///      diagnostic output (ToString / ToJson).
    /// The two lists serve different concerns (logging vs. diagnostics) so they remain
    /// separate, but their credential entries must stay in sync.
    /// MAINTENANCE: if you add a new credential field to one list, add it to the other.
    /// </summary>
    public static class SensitiveFieldMaskingUtility
    {
        private const string MaskedValue = "***";

        /// <summary>
        /// Exact-normalized sensitive field names (underscores/dashes removed, lowercased).
        /// Covers both camelCase and snake_case variants of the same field.
        /// NOTE: These fields are also registered in
        /// SensitiveDataConfigurationType.sensitiveTags for HTTP logging masking.
        /// Keep both lists in sync — see class-level comment above.
        /// </summary>
        private static readonly HashSet<string> NormalizedSensitiveKeys = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            // ── Credentials ──────────────────────────────────────────────────────
            "password",
            "secret",
            "secretkey",
            "clientsecret",     // clientSecret / client_secret
            "apikey",           // apiKey / api_key
            "token",
            "accesstoken",      // accessToken / access_token
            "refreshtoken",     // refreshToken / refresh_token
            "otptoken",         // otpToken — one-time-password token
            "idtoken",          // idToken — OIDC identity token
            "transienttoken",   // transientToken — Flex transient token (also in sensitiveTags)
            "transienttokenjwt",// transientTokenJwt — Flex transient-token JWT (JWT-suffixed variant of transientToken)
            "jti",              // jti — JWT ID claim (also in sensitiveTags)
            "paymentcredentialsreference", // paymentCredentialsReference (also in sensitiveTags)
            "responseaccesstoken", // responseAccessToken — 3DS-provider JWT bearer token
            "transactiontoken",    // transactionToken — Rupay consumer-auth token
            "legacytoken",         // legacyToken — legacy payment network token (masks nested Id)
            "thirdpartytoken",     // thirdPartyToken — third-party payment token (masks nested Id)
            "cvv",
            "cvn",
            "pin",
            "passcode",         // passcode — wraps issuer-OTP / one-time-passcode payloads (Tmsv2tokenizedcardsPasscode)
            "code",             // OAuth authorization code
            "clientid",         // client_id / clientId
            "privatekey",
            "encryptionkey",
            "signature",        // auth/payment signature (also in sensitiveTags)
            // ── CHD / PAN ────────────────────────────────────────────────────────
            "number",           // card number (PAN) — generated model field name
            "cardnumber",       // cardNumber / card_number
            "accountnumber",    // accountNumber / account_number
            "routingnumber",    // routingNumber / routing_number — bank routing (BSB/ABA)
            "securitycode",     // securityCode — card verification value (CVV-equivalent)
            "expirationmonth",  // expirationMonth — card expiry (also in sensitiveTags)
            "expirationyear",   // expirationYear — card expiry (also in sensitiveTags)
            "encryptedrequest", // encryptedRequest — encrypted payload (also in sensitiveTags)
            "encryptedresponse",// encryptedResponse — encrypted payload (also in sensitiveTags)
            "cryptogram",       // cryptogram — payment network cryptogram (also in sensitiveTags)
            // ── PII ──────────────────────────────────────────────────────────────
            "ssn",                      // Social Security Number
            "email",                    // email address
            "phonenumber",              // phoneNumber / phone_number
            "mobilephone",              // mobilePhone / mobile_phone
            "firstname",                // firstName / first_name
            "lastname",                 // lastName / last_name
            "middlename",               // middleName / middle_name
            "middleinitial",            // middleInitial (also in sensitiveTags)
            "dateofbirth",              // dateOfBirth / date_of_birth
            "ipaddress",                // ipAddress / ip_address
            "address1",                 // address line 1 (also in sensitiveTags)
            "address2",                 // address line 2 (also in sensitiveTags)
            "address3",                 // address line 3 (also in sensitiveTags)
            "address4",                 // address line 4 (also in sensitiveTags)
            "postalcode",               // postalCode (also in sensitiveTags)
            "identificationnumber",     // identificationNumber — government-issued ID (also in sensitiveTags)
            "vatregistrationnumber",    // vatRegistrationNumber — VAT/tax id
            "companytaxid",             // companyTaxId
            "personalidentification",   // personalIdentification — government-issued ID
            "taxid",                    // taxId
            "taxidnumber",              // taxIdNumber
            "passportnumber",           // passportNumber
            "nationalid",               // nationalId
            "birthdate",                // birthDate (alternate to dateOfBirth)
            "countryofbirth",           // countryOfBirth
            "alternateemail",           // alternateEmail
            "alternatephonenumber",     // alternatePhoneNumber
            "workphone",                // workPhone
            "fullname",                 // fullName
            "legalname",                // legalName
            "beneficiaryname",          // beneficiaryName
            "accountid",                // accountId (also in sensitiveTags)
            // ── Bank / financial identifiers ─────────────────────────────────────
            "iban",                     // International Bank Account Number
            "swiftcode",                // SWIFT/BIC
            "bankaccount",              // bankAccount
            "accountholdername",        // accountHolderName
            "accountroutingnumber",     // accountRoutingNumber
            "correctedaccountnumber",   // correctedAccountNumber
            "correctedroutingnumber",   // correctedRoutingNumber
            // ── Sensitive Authentication Data (SAD) ──────────────────────────────
            "trackdata",                // trackData — magnetic-stripe track 1/2 data (PCI SAD)
            "jis2trackdata",            // jis2TrackData — JIS II magnetic-stripe track data (PCI SAD)
            "cavv",                     // cavv — 3DS/Verified-by-Visa cardholder auth value (PCI SAD)
                                        //   NOTE: 'cvv' fragment does NOT match 'cavv'; explicit entry required
            "ucafauthenticationdata",   // ucafAuthenticationData — MasterCard SecureCode/UCAF value (PCI SAD)
            "proxypan",                 // proxyPan — surrogate/proxy PAN value
            "emv",                      // emv — EMV tag data (track-equivalent; PCI SAD)
        };

        /// <summary>
        /// Sensitive-indicating substrings for substring matching — catches camelCase/prefixed
        /// variants not covered by NormalizedSensitiveKeys.
        /// "token" is intentionally excluded to avoid false positives on token_type and
        /// refresh_token_expires_in.
        /// </summary>
        private static readonly string[] SensitiveFragments = { "password", "secret", "cvv", "cvn", "pin", "securitycode" };

        /// <summary>
        /// Class-scoped sensitive fields — for generically-named properties (e.g. "value")
        /// that are sensitive only in specific model classes. The matcher consults this map
        /// before falling back to the global (name-only) catalog.
        /// Entries: "{normalizedClassName}.{normalizedFieldName}".
        ///
        /// Covers issuer-OTP / encrypted-payment-blob / EMV-tag carriers whose property is
        /// the generic name "value" — a name that cannot be cataloged globally without
        /// masking unrelated "value" fields throughout the SDK.
        /// </summary>
        private static readonly HashSet<string> SensitiveClassFields = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "tmsv2tokenizedcardspasscode.value",                                       // OTP at issuer (SAD)
            "ptsv2paymentspaymentinformationfluiddata.value",                          // P2PE encrypted payment BLOB
            "riskv1authenticationsetupspaymentinformationfluiddata.value",             // P2PE encrypted payment BLOB
            "riskv1authenticationresultspaymentinformationfluiddata.value",            // P2PE encrypted payment BLOB
            "tmsembeddedinstrumentidentifierpointofsaleinformationemvtags.value",      // EMV tag value (track-equivalent SAD)
        };

        /// <summary>Returns the field name normalized to lowercase with underscores and dashes removed.</summary>
        private static string NormalizeKey(string key) =>
            key.Replace("_", string.Empty).Replace("-", string.Empty).ToLowerInvariant();

        /// <summary>
        /// Returns true when <paramref name="fieldName"/> refers to a credential field that
        /// must be redacted. Matches both exact-normalized names (covering snake_case and
        /// camelCase variants) and names that contain a known sensitive fragment.
        /// </summary>
        private static bool IsSensitiveKey(string fieldName)
        {
            if (fieldName == null) return false;
            var normalized = NormalizeKey(fieldName);
            if (NormalizedSensitiveKeys.Contains(normalized)) return true;
            foreach (var fragment in SensitiveFragments)
            {
                if (normalized.Contains(fragment)) return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true when <paramref name="fieldName"/> on <paramref name="className"/>
        /// is a class-scoped sensitive field. Falls back to global name-based matching.
        /// </summary>
        private static bool IsSensitiveClassField(string className, string fieldName)
        {
            if (className != null && fieldName != null)
            {
                var key = NormalizeKey(className) + "." + NormalizeKey(fieldName);
                if (SensitiveClassFields.Contains(key)) return true;
            }
            return IsSensitiveKey(fieldName);
        }

        /// <summary>
        /// Recursively walks a JSON string and replaces values of any sensitive key with "***".
        /// On parse failure, falls back to a regex-based sweep that masks credential values in
        /// XML, form-encoded, and malformed-JSON shapes plus a Luhn-validated PAN sweep, so the
        /// utility never returns sensitive data verbatim even on non-JSON diagnostic output.
        /// </summary>
        public static string MaskSensitiveDataInJson(string json)
        {
            if (string.IsNullOrEmpty(json))
                return json;

            try
            {
                var token = JsonNode.Parse(json);
                MaskToken(token);
                return token.ToJsonString(new JsonSerializerOptions{ WriteIndented = true });
            }
            catch (JsonException)
            {
                return MaskNonJsonFallback(json);
            }
        }

        /// <summary>
        /// Class-context-aware overload. Same recursive masking as <see cref="MaskSensitiveDataInJson(string)"/>,
        /// but additionally redacts top-level properties registered in <c>SensitiveClassFields</c>
        /// for the given <paramref name="className"/>. Intended for use in ToJson() of model
        /// classes that have generically-named sensitive properties (e.g. "value").
        /// </summary>
        public static string MaskSensitiveDataInJson(string className, string json)
        {
            if (string.IsNullOrEmpty(json))
                return json;

            try
            {
                var token = JsonNode.Parse(json);
                if (!string.IsNullOrEmpty(className) && token is JsonObject root)
                {
                    foreach (KeyValuePair<string, JsonNode> property in root.ToList())
                    {
                        if (IsSensitiveClassField(className, property.Key) && property.Value != null && property.Value.GetValueKind() != JsonValueKind.Null)
                        {
                            root[property.Key] = MaskedValue;
                        }
                    }
                }
                MaskToken(token);
                return token.ToJsonString(new JsonSerializerOptions{ WriteIndented = true });
            }
            catch (JsonException)
            {
                return MaskNonJsonFallback(json);
            }
        }

        private static readonly Regex PanCandidateRegex = new Regex(
            @"(?<![\d])\d(?:[ -]?\d){12,18}(?![\d])",
            RegexOptions.Compiled);

        private static string MaskNonJsonFallback(string input)
        {
            string output = input;
            foreach (var key in NormalizedSensitiveKeys)
            {
                string escaped = Regex.Escape(key);
                // JSON-quoted (terminated and truncated)
                output = Regex.Replace(output, $"\\\"{escaped}\\\"\\s*:\\s*\\\"[^\\\"]*\\\"", $"\"{key}\":\"{MaskedValue}\"", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                output = Regex.Replace(output, $"\\\"{escaped}\\\"\\s*:\\s*\\\"[^\\\"]*\\z", $"\"{key}\":\"{MaskedValue}\"", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                // JSON unquoted numeric
                output = Regex.Replace(output, $"\\\"{escaped}\\\"\\s*:\\s*\\d+", $"\"{key}\":0", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                // XML element (terminated and truncated)
                output = Regex.Replace(output, $"<{escaped}>[^<]*</{escaped}>", $"<{key}>{MaskedValue}</{key}>", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                output = Regex.Replace(output, $"<{escaped}>[^<]*\\z", $"<{key}>", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                // Form-encoded
                output = Regex.Replace(output, $"\\b{escaped}=[^&\\s\\r\\n]*", $"{key}={MaskedValue}", RegexOptions.Singleline | RegexOptions.IgnoreCase);
            }

            // Luhn-validated PAN sweep for unlabeled card numbers in free-text bodies.
            output = PanCandidateRegex.Replace(output, m =>
            {
                string match = m.Value;
                var sb = new StringBuilder(match.Length);
                for (int i = 0; i < match.Length; i++)
                {
                    char c = match[i];
                    if (c >= '0' && c <= '9') sb.Append(c);
                }
                string digits = sb.ToString();
                if (digits.Length < 13 || digits.Length > 19) return match;
                int sum = 0;
                bool alt = false;
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    int n = digits[i] - '0';
                    if (alt) { n *= 2; if (n > 9) n -= 9; }
                    sum += n;
                    alt = !alt;
                }
                return sum % 10 == 0 ? new string('X', match.Length) : match;
            });

            return output;
        }

        /// <summary>
        /// Returns "***" when fieldName is in the sensitive keys set, otherwise returns value unchanged.
        /// Intended for use in ToString() implementations.
        /// </summary>
        public static string MaskFieldValue(string fieldName, string value)
        {
            if (value == null)
                return null;

            return IsSensitiveKey(fieldName) ? MaskedValue : value;
        }

        /// <summary>
        /// Class-context-aware overload. Returns "***" when <paramref name="fieldName"/> on
        /// <paramref name="className"/> is in the class-scoped sensitive map or the global
        /// catalog, otherwise returns <paramref name="value"/> unchanged.
        /// Intended for use in ToString() to mask generically-named sensitive properties
        /// (e.g. "value" on Tmsv2tokenizedcardsPasscode / FluidData / EMV-tag classes).
        /// </summary>
        public static string MaskFieldValue(string className, string fieldName, string value)
        {
            if (value == null)
                return null;

            return IsSensitiveClassField(className, fieldName) ? MaskedValue : value;
        }

        private static void MaskToken(JsonNode token)
        {
            if (token is JsonObject obj)
            {
                foreach (KeyValuePair<string, JsonNode> property in obj.ToList())
                {
                    if (IsSensitiveKey(property.Key) && property.Value != null && property.Value.GetValueKind() != JsonValueKind.Null)
                    {
                        obj[property.Key] = MaskedValue;
                    }
                    else
                    {
                        MaskToken(property.Value);
                    }
                }
            }
            else if (token is JsonArray array)
            {
                foreach (var item in array)
                {
                    MaskToken(item);
                }
            }
        }
    }
}
