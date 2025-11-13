[![Generic badge](https://img.shields.io/badge/MLE-NEW-GREEN.svg)](https://shields.io/)

# Message Level Encryption (MLE) Feature

This feature provides an implementation of Message Level Encryption (MLE) for APIs provided by CyberSource, integrated within our SDK. This feature ensures secure communication by encrypting messages at the application level before they are sent over the network.

MLE supports both **Request Encryption** (encrypting outgoing request payloads) and **Response Decryption** (decrypting incoming response payloads).

## Authentication Requirements

- **Request MLE**: Only supported with `JWT (JSON Web Token)` authentication type
- **Response MLE**: Only supported with `JWT (JSON Web Token)` authentication type

<br/>

## Configuration

## 1. Request MLE Configuration 

#### 1.1 Global Request MLE Configuration

Configure global settings for request MLE using these properties in your `merchantConfig`:

##### (i) Primary Configuration

- **Variable**: `enableRequestMLEForOptionalApisGlobally`
- **Type**: `bool`
- **Default**: `false`
- **Description**: Enables request MLE globally for all APIs that have optional MLE support when set to `true`.

---

##### (ii) Deprecated Configuration (Backward Compatibility)

- **Variable**: `useMLEGlobally` ⚠️ **DEPRECATED**
- **Type**: `bool`
- **Default**: `false`
- **Description**: **DEPRECATED** - Use `enableRequestMLEForOptionalApisGlobally` instead. This field is maintained for backward compatibility and will be used as an alias for `enableRequestMLEForOptionalApisGlobally`.

---

##### (iii) Advanced Configuration

- **Variable**: `disableRequestMLEForMandatoryApisGlobally`
- **Type**: `bool`
- **Default**: `false`
- **Description**: Disables request MLE for APIs that have mandatory MLE requirement when set to `true`.

---

#### 1.2 Request MLE Certificate Configuration [Optional Params]

##### (i) Certificate File Path (Optional)

- **Variable**: `mleForRequestPublicCertPath`
- **Type**: `string`
- **Optional**: `true`
- **Description**: Path to the public certificate file used for request encryption. Supported formats: `.pem`, `.crt`. 
  - **Note**: This parameter is optional when using JWT authentication. If not provided, the request MLE certificate will be automatically fetched from the JWT authentication P12 file using the `requestMleKeyAlias`.

---

##### (ii) Key Alias Configuration (Optional)

- **Variable**: `requestMleKeyAlias`
- **Type**: `string`
- **Optional**: `true`
- **Default**: `CyberSource_SJC_US`
- **Description**: Key alias used to retrieve the MLE certificate from the certificate file. When `mleForRequestPublicCertPath` is not provided, this alias is used to fetch the certificate from the JWT authentication P12 file. If not specified, the SDK will automatically use the default value `CyberSource_SJC_US`.

---

##### (iii) Deprecated Key Alias (Backward Compatibility) (Optional)

- **Variable**: `mleKeyAlias` ⚠️ **DEPRECATED**
- **Type**: `string`
- **Optional**: `true`
- **Default**: `CyberSource_SJC_US`
- **Description**: **DEPRECATED** - Use `requestMleKeyAlias` instead. This field is maintained for backward compatibility and will be used as an alias for `requestMleKeyAlias`.

<br />

## 2. Response MLE Configuration

#### 2.1 Global Response MLE Configuration

- **Variable**: `enableResponseMleGlobally`
- **Type**: `bool`
- **Default**: `false`
- **Description**: Enables response MLE globally for all APIs that support MLE responses when set to `true`.

----

#### 2.2 Response MLE Private Key Configuration

##### (i) Option 1: Provide Private Key Object

- **Variable**: `responseMlePrivateKey`
- **Type**: `AsymmetricAlgorithm`
- **Description**: Direct private key object for response decryption.

---

##### (ii) Option 2: Provide Private Key File Path

- **Variable**: `responseMlePrivateKeyFilePath`
- **Type**: `string`
- **Description**: Path to the private key file. Supported formats: `.p12`, `.pfx`, `.pem`, `.key`, `.p8`. Recommendation use encrypted private Key (password protection) for MLE response.

---

##### (iii) Private Key File Password

- **Variable**: `responseMlePrivateKeyFilePassword`
- **Type**: `String`
- **Description**: Password for the private key file (required for `.p12/.pfx` files or encrypted private keys).

---

#### 2.3 Response MLE Additional Configuration

- **Variable**: `responseMleKID`
- **Type**: `string`
- **Required**: `true` (when response MLE is enabled)
- **Description**: Key ID value for the MLE response certificate (provided in merchant portal).

<br/>

## 3. API-level MLE Control for Request and Response MLE

### Dictionary Configuration

- **Variable**: `mapToControlMLEonAPI`
- **Type**: `Dictionary<string, string>`
- **Description**: Overrides global MLE settings for specific APIs. The key is the API function name, and the value controls both request and response MLE.
- **Example**: `Dictionary<string, string> { {"apiFunctionName", "true::true"} }`

#### Structure of Values in Dictionary:

(i) **"requestMLE::responseMLE"** - Control both request and response MLE
   - `"true::true"` - Enable both request and response MLE
   - `"false::false"` - Disable both request and response MLE
   - `"true::false"` - Enable request MLE, disable response MLE
   - `"false::true"` - Disable request MLE, enable response MLE
   - `"::true"` - Use global setting for request, enable response MLE
   - `"true::"` - Enable request MLE, use global setting for response
   - `"::false"` - Use global setting for request, disable response MLE
   - `"false::"` - Disable request MLE, use global setting for response

(ii) **"requestMLE"** - Control request MLE only (response uses global setting)
   - `"true"` - Enable request MLE
   - `"false"` - Disable request MLE

<br/>

## 4. Example Configurations

### (i) Minimal Request MLE Configuration

```csharp
// Dictionary-based configuration - Uses defaults (most common scenario)
private readonly Dictionary<string, string> _configurationDictionary = new Dictionary<string, string>();

public Dictionary<string, string> GetConfiguration()
{
    _configurationDictionary.Add("authenticationType", "JWT");
    _configurationDictionary.Add("enableRequestMLEForOptionalApisGlobally", "true");
    // Both mleForRequestPublicCertPath and requestMleKeyAlias are optional
    // SDK will use JWT P12 file with default alias "CyberSource_SJC_US"
    
    return _configurationDictionary;
}
```

### (ii) Request MLE with Deprecated Parameters (Backward Compatibility)

```csharp
// Using deprecated parameters - still supported but not recommended
private readonly Dictionary<string, string> _configurationDictionary = new Dictionary<string, string>();

public Dictionary<string, string> GetConfiguration()
{
    _configurationDictionary.Add("authenticationType", "JWT");
    _configurationDictionary.Add("useMLEGlobally", "true");  // Deprecated - use enableRequestMLEForOptionalApisGlobally
    _configurationDictionary.Add("mleKeyAlias", "Custom_Key_Alias");  // Deprecated - use requestMleKeyAlias
    
    return _configurationDictionary;
}
```

### (iii) Request MLE with Custom Key Alias

```csharp
// Dictionary-based configuration - With custom key alias only
private readonly Dictionary<string, string> _configurationDictionary = new Dictionary<string, string>();

public Dictionary<string, string> GetConfiguration()
{
    _configurationDictionary.Add("authenticationType", "JWT");
    _configurationDictionary.Add("enableRequestMLEForOptionalApisGlobally", "true");
    _configurationDictionary.Add("requestMleKeyAlias", "Custom_Key_Alias");
    // Will fetch from JWT P12 file using custom alias
    
    return _configurationDictionary;
}
```

### (iv) Request MLE with Separate Certificate File

```csharp
// Dictionary-based configuration - With separate MLE certificate file
private readonly Dictionary<string, string> _configurationDictionary = new Dictionary<string, string>();
private readonly Dictionary<string, string> _mleControlDictionary = new Dictionary<string, string>();

public Dictionary<string, string> GetConfiguration()
{
    _configurationDictionary.Add("authenticationType", "JWT");
    _configurationDictionary.Add("enableRequestMLEForOptionalApisGlobally", "true");
    _configurationDictionary.Add("mleForRequestPublicCertPath", "C:\path\to\public\cert.pem");
    _configurationDictionary.Add("requestMleKeyAlias", "Custom_Key_Alias");
    
    return _configurationDictionary;
}

public Dictionary<string, string> GetMLEControlMap()
{
    _mleControlDictionary.Add("CreatePayment", "true");     // Enable request MLE for this API
    _mleControlDictionary.Add("CapturePayment", "false");   // Disable request MLE for this API
    
    return _mleControlDictionary;
}
```

### (v) Response MLE Configuration with Private Key File

```csharp
// Dictionary-based configuration
private readonly Dictionary<string, string> _configurationDictionary = new Dictionary<string, string>();
private readonly Dictionary<string, string> _mleControlDictionary = new Dictionary<string, string>();

public Dictionary<string, string> GetConfiguration()
{
    _configurationDictionary.Add("authenticationType", "JWT");
    _configurationDictionary.Add("enableResponseMleGlobally", "true");
    _configurationDictionary.Add("responseMlePrivateKeyFilePath", "C:\path\to\private\key.p12");
    _configurationDictionary.Add("responseMlePrivateKeyFilePassword", "password");
    _configurationDictionary.Add("responseMleKID", "your-key-id");
    
    return _configurationDictionary;
}

public Dictionary<string, string> GetMLEControlMap()
{
    _mleControlDictionary.Add("CreatePayment", "::true");  // Enable response MLE only for this API
    
    return _mleControlDictionary;
}
```

### (vi) Response MLE Configuration with Private Key Object

```csharp
// Load private key programmatically
AsymmetricAlgorithm privateKey = LoadPrivateKeyFromSomewhere();

// Dictionary-based configuration
private readonly Dictionary<string, string> _configurationDictionary = new Dictionary<string, string>();

public Dictionary<string, string> GetConfiguration()
{
    _configurationDictionary.Add("authenticationType", "JWT");
    _configurationDictionary.Add("enableResponseMleGlobally", "true");
    _configurationDictionary.Add("responseMleKID", "your-key-id");
    
    return _configurationDictionary;
}

// Use constructor that accepts private key object
MerchantConfig merchantConfig = new MerchantConfig(GetConfiguration(), null, privateKey);
```

### (vii) Both Request and Response MLE Configuration

```csharp
// Dictionary-based configuration
private readonly Dictionary<string, string> _configurationDictionary = new Dictionary<string, string>();
private readonly Dictionary<string, string> _mleControlDictionary = new Dictionary<string, string>();

public Dictionary<string, string> GetConfiguration()
{
    _configurationDictionary.Add("authenticationType", "JWT");
    
    // Request MLE settings (minimal - uses defaults)
    _configurationDictionary.Add("enableRequestMLEForOptionalApisGlobally", "true");
    
    // Response MLE settings
    _configurationDictionary.Add("enableResponseMleGlobally", "true");
    _configurationDictionary.Add("responseMlePrivateKeyFilePath", @"C:\path\to\private\key.p12");
    _configurationDictionary.Add("responseMlePrivateKeyFilePassword", "password");
    _configurationDictionary.Add("responseMleKID", "your-key-id");
    
    return _configurationDictionary;
}

public Dictionary<string, string> GetMLEControlMap()
{
    _mleControlDictionary.Add("CreatePayment", "true::true");     // Enable both request and response MLE for this API
    _mleControlDictionary.Add("CapturePayment", "false::true");   // Disable request, enable response MLE for this API
    _mleControlDictionary.Add("RefundPayment", "true::false");    // Enable request, disable response MLE for this API
    _mleControlDictionary.Add("CreateCredit", "::true");          // Use global request setting, enable response MLE for this API
    
    return _mleControlDictionary;
}
```

### (viii) Mixed Configuration (New and Deprecated Parameters)

```csharp
// Example showing both new and deprecated parameters (deprecated will be used as aliases)
private readonly Dictionary<string, string> _configurationDictionary = new Dictionary<string, string>();

public Dictionary<string, string> GetConfiguration()
{
    _configurationDictionary.Add("authenticationType", "JWT");
    
    // If both are set with same value, it works fine
    _configurationDictionary.Add("enableRequestMLEForOptionalApisGlobally", "true");
    _configurationDictionary.Add("useMLEGlobally", "true");  // Deprecated but same value
    
    // If both are set with different values, it will cause ConfigException
    
    // Key alias - new parameter takes precedence if both are provided
    _configurationDictionary.Add("requestMleKeyAlias", "New_Alias");
    _configurationDictionary.Add("mleKeyAlias", "Old_Alias");  // This will be ignored
    
    return _configurationDictionary;
}
```

<br/>

## 5. App.Config Configuration Examples

### (i) Minimal Request MLE

```xml
<configuration>
  <configSections>
    <section name="MerchantConfig" type="System.Configuration.NameValueSectionHandler" />
  </configSections>
  <MerchantConfig>
    <add key="authenticationType" value="JWT" />
    <add key="enableRequestMLEForOptionalApisGlobally" value="true" />
  </MerchantConfig>
</configuration>
```

### (ii) Request MLE with Deprecated Parameters

```xml
<configuration>
  <configSections>
    <section name="MerchantConfig" type="System.Configuration.NameValueSectionHandler" />
  </configSections>
  <MerchantConfig>
    <add key="authenticationType" value="JWT" />
    <add key="useMLEGlobally" value="true" />
    <add key="mleKeyAlias" value="Custom_Key_Alias" />
  </MerchantConfig>
</configuration>
```

### (iii) Request MLE with Custom Configuration

```xml
<configuration>
  <configSections>
    <section name="MerchantConfig" type="System.Configuration.NameValueSectionHandler" />
  </configSections>
  <MerchantConfig>
    <add key="authenticationType" value="JWT" />
    <add key="enableRequestMLEForOptionalApisGlobally" value="true" />
    <add key="mleForRequestPublicCertPath" value="C:\path\to\public\cert.pem" />
    <add key="requestMleKeyAlias" value="Custom_Key_Alias" />
  </MerchantConfig>
</configuration>
```

### (iv) Response MLE Only

```xml
<configuration>
  <configSections>
    <section name="MerchantConfig" type="System.Configuration.NameValueSectionHandler" />
  </configSections>
  <MerchantConfig>
    <add key="authenticationType" value="JWT" />
    <add key="enableResponseMleGlobally" value="true" />
    <add key="responseMlePrivateKeyFilePath" value="C:\path\to\private\key.p12" />
    <add key="responseMlePrivateKeyFilePassword" value="password" />
    <add key="responseMleKID" value="your-key-id" />
  </MerchantConfig>
</configuration>
```

### (v) Both Request and Response MLE

```xml
<configuration>
  <configSections>
    <section name="MerchantConfig" type="System.Configuration.NameValueSectionHandler" />
  </configSections>
  <MerchantConfig>
    <add key="authenticationType" value="JWT" />
    <add key="enableRequestMLEForOptionalApisGlobally" value="true" />
    <add key="enableResponseMleGlobally" value="true" />
    <add key="responseMlePrivateKeyFilePath" value="C:\path\to\private\key.p12" />
    <add key="responseMlePrivateKeyFilePassword" value="password" />
    <add key="responseMleKID" value="your-key-id" />
  </MerchantConfig>
</configuration>
```

<br/>

## 6. Supported Private Key File Formats

For Response MLE private key files, the following formats are supported:

- **PKCS#12**: `.p12`, `.pfx` (requires password)
- **PEM**: `.pem`, `.key`, `.p8` (supports both encrypted and unencrypted)

<br/>

## 7. Important Notes

### (i) Request MLE
- Both `mleForRequestPublicCertPath` and `requestMleKeyAlias` are **optional** parameters
- If `mleForRequestPublicCertPath` is not provided, the SDK will automatically fetch the MLE certificate from the JWT authentication P12 file
- If `requestMleKeyAlias` is not provided, the SDK will use the default value `CyberSource_SJC_US`
- The SDK provides flexible configuration options: you can use defaults, customize the key alias only, or provide a separate certificate file
- If `enableRequestMLEForOptionalApisGlobally` is set to `true`, it enables request MLE for all APIs that have optional MLE support
- APIs with mandatory MLE requirements are enabled by default unless `disableRequestMLEForMandatoryApisGlobally` is set to `true`
- If `mapToControlMLEonAPI` doesn't contain a specific API, the global setting applies
- For HTTP Signature authentication, request MLE will fall back to non-encrypted requests with a warning

### (ii) Response MLE
- Response MLE requires either `responseMlePrivateKey` object OR `responseMlePrivateKeyFilePath` (not both)
- The `responseMleKID` parameter is mandatory when response MLE is enabled
- If an API expects a mandatory MLE response but the map specifies non-MLE response, the API might return an error
- Both the private key object and file path approaches are mutually exclusive
- `responseMlePrivateKeyFilePassword` uses `SecureString` type for enhanced security

### (iii) Backward Compatibility
- `useMLEGlobally` is **deprecated** but still supported as an alias for `enableRequestMLEForOptionalApisGlobally`

- If `useMLEGlobally` and `enableRequestMLEForOptionalApisGlobally` are provided with **different values**, it will cause a `ConfigException`
- `mleKeyAlias` is **deprecated** but still supported as an alias for `requestMleKeyAlias`
- When both `mleKeyAlias` and `requestMleKeyAlias`  are provided, the **`requestMleKeyAlias`** takes precedence

### (iv) API-level Control Validation
- The `mapToControlMLEonAPI` values are validated for proper format
- Invalid formats (empty values, multiple separators, non-boolean values) will cause configuration errors
- Empty string after or before `::` separator will use global defaults


### (v) Configuration Validation
- The SDK performs comprehensive validation of MLE configuration parameters
- Conflicting values between new and deprecated parameters will result in `ConfigException`
- File path validation is performed for certificate and private key files
- Invalid boolean values in `mapToControlMLEonAPI` will cause parsing errors

<br/>

## 8. Error Handling

The SDK provides specific error messages for common MLE issues:
- Invalid private key for response decryption
- Missing certificates for request encryption
- Invalid file formats or paths
- Authentication type mismatches
- Configuration validation errors
- Conflicting parameter values between new and deprecated fields
- Invalid format in `mapToControlMLEonAPI` values

<br/>

## 9. Sample Code Repository

For comprehensive examples and sample implementations, please refer to:
[Cybersource .NET Sample Code Repository (on GitHub)](https://github.com/CyberSource/cybersource-rest-samples-csharp)

<br/>

## 10. Additional Information

### (i) API Support
- MLE is designed to support specific APIs that have been enabled for encryption
- Support can be extended to additional APIs based on requirements and updates

### (ii) Using the SDK
To use the MLE feature in the SDK, configure the `merchantConfig` object as shown above and pass it to the SDK initialization. The SDK will automatically handle encryption and decryption based on your configuration.



### (iii) Migration from Deprecated Parameters

If you're currently using deprecated parameters, here's how to migrate:

```csharp
// OLD (Deprecated)
_configurationDictionary.Add("useMLEGlobally", "true");
_configurationDictionary.Add("mleKeyAlias", "Custom_Alias");

// NEW (Recommended)
_configurationDictionary.Add("enableRequestMLEForOptionalApisGlobally", "true");
_configurationDictionary.Add("requestMleKeyAlias", "Custom_Alias");
```

The deprecated parameters will continue to work but are not recommended for new implementations.

<br/>

## 11. Contact
For any issues or further assistance, please open an issue on the GitHub repository or contact our support team.
