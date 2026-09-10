using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace CyberSource.Client
{
    /// <summary>
    /// Transport-level configuration used by the SDK to construct or key an
    /// <see cref="System.Net.Http.HttpClient"/>.
    /// </summary>
    internal sealed class HttpTransportOptions
    {
        public Uri BaseUrl { get; set; }
        public TimeSpan? Timeout { get; set; }
        public string UserAgent { get; set; }
        public IWebProxy Proxy { get; set; }
        public X509CertificateCollection ClientCertificates { get; set; }
    }
}
