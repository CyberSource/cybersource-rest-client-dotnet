using System;
using System.Net.Http;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace cybersource_rest_client_netstandard.Test.Client
{
    /// <summary>
    /// Unit tests for the private static <c>RestClientFactory.ApplyClientCertificates</c> method.
    ///
    /// In production this method is reached when the end-user supplies the client-certificate
    /// settings (EnableClientCert, ClientCertDirectory, ClientCertFile, ClientCertPassword) in the
    /// dictionary passed to the <see cref="CyberSource.Client.Configuration"/> constructor. Those
    /// values are stored on the MerchantCredentialSettings, used by ApiClient to load the PFX into
    /// <c>RestClientOptions.ClientCertificates</c>, which is finally handed to
    /// <c>ApplyClientCertificates</c> to attach the certificates to the underlying
    /// <see cref="StandardSocketsHttpHandler"/>.
    ///
    /// The method is private and the declaring type is internal, so it is invoked via reflection.
    /// A self-signed public certificate (DER, no private key) is embedded so the tests are
    /// deterministic and run on every target framework, including net461 where runtime certificate
    /// generation (CertificateRequest) is unavailable.
    /// </summary>
    [TestFixture]
    public class RestClientFactoryTests
    {
        // Self-signed public certificate (DER), base64 encoded. Subject: CN=CyberSource Test Client Cert.
        // No private key is included, so there is no secret material in this test asset.
        private const string TestCertificateBase64 =
            "MIICzzCCAbegAwIBAgIJAN/HEeiP/iVJMA0GCSqGSIb3DQEBCwUAMCcxJTAjBgNVBAMTHEN5YmVyU291cmNlIFRlc3QgQ2xpZW50IENlcnQwHhcNMjYwNjIyMTQ1MzU4WhcNNDYwNjIzMTQ1MzU4WjAnMSUwIwYDVQQDExxDeWJlclNvdXJjZSBUZXN0IENsaWVudCBDZXJ0MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAvbeB4q2YZMYNT2IWCkcCEA9E9fB7aPCf6KrBSuavuCbN4s5Gk/UTX4ZIitrj6IHkhPT1mkIx7YeIsso2ASK88ascz4lBB2hR3WKYyLHViKt4OZ4hzj6N6Fb8bn4Z/uhci/P9j336bIWi5CS8vejjkLZeMjx+uERd55usoY7mzJPlAtPMiDVMWdEXnLxN4xc6fdfs4GYv61ed1E5Np4+V6fl4fLHOJ0uRY4wxxs7CFJzELtDP+uZpB/rxcWT0hlTreAN8oJCAdDaJbBb4p6pakgB+6brnt+UlSZ977CKPdBopP/G+RXcd8nlXc0VU5DgmTj0YcMSr2sH1Nr8EmodUHQIDAQABMA0GCSqGSIb3DQEBCwUAA4IBAQB9/LXCK8mr5bcHhGL9fc1vWs/q7r1dZc+Lu8a4Mslj/0/7ngNZc1Qw5dYFuuJFEHf5OesJpfinLrznrUYes4Dkm9m7mbic0USZrKFeGRcPVicoWHHWwgUMJTgfC/1FBkgWDYu85MKv5ei1jOFn1cbEUWNopbGkjjnsgBETB6c+YANPv13VuF0G1qhjkHdyujYGcgj34Gnz5Tih0+3O5B2m3wOzILgxlB7J1+AdaekmHOtgXmb+/Nhbb70gi4ZyYCk3is3kOYxiLy1/BKZAnce8XUP9A/cp5Gd1AeCOzStSxgRGGmNzWPjm580Q4d9KLspetnOlabANzXQf/jyjMSuJ";

        private static readonly MethodInfo ApplyClientCertificatesMethod = ResolveApplyClientCertificates();

        private static MethodInfo ResolveApplyClientCertificates()
        {
            // Anchor on any public type in the SDK assembly to locate the internal factory.
            Assembly sdkAssembly = typeof(CyberSource.Client.ApiClient).Assembly;
            Type factoryType = sdkAssembly.GetType("CyberSource.Client.RestClientFactory", throwOnError: true);

            MethodInfo method = factoryType.GetMethod(
                "ApplyClientCertificates",
                BindingFlags.NonPublic | BindingFlags.Static);

            Assert.That(method, Is.Not.Null, "RestClientFactory.ApplyClientCertificates(StandardSocketsHttpHandler, X509CertificateCollection) was not found.");
            return method;
        }

        private static void InvokeApplyClientCertificates(StandardSocketsHttpHandler handler, X509CertificateCollection certificates)
        {
            try
            {
                ApplyClientCertificatesMethod.Invoke(null, new object[] { handler, certificates });
            }
            catch (TargetInvocationException ex) when (ex.InnerException != null)
            {
                // Surface the real exception (e.g. NullReferenceException) to the assertion instead
                // of the reflection wrapper.
                ExceptionDispatchInfo.Capture(ex.InnerException).Throw();
            }
        }

        private static X509Certificate2 LoadCertificate2()
            => new X509Certificate2(Convert.FromBase64String(TestCertificateBase64));

        private static X509Certificate LoadCertificateBase()
            => new X509Certificate(Convert.FromBase64String(TestCertificateBase64));

        private static int AppliedCertificateCount(StandardSocketsHttpHandler handler)
            => handler.SslOptions.ClientCertificates?.Count ?? 0;

        private static bool HandlerContainsThumbprint(StandardSocketsHttpHandler handler, string thumbprint)
        {
            X509CertificateCollection applied = handler.SslOptions.ClientCertificates;
            if (applied == null) { return false; }

            foreach (X509Certificate certificate in applied)
            {
                if (certificate is X509Certificate2 certificate2 &&
                    string.Equals(certificate2.Thumbprint, thumbprint, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        // ─── Null / empty input: method must be a safe no-op ─────────────────────

        [Test]
        public void ApplyClientCertificates_NullCollection_DoesNotThrowAndAppliesNothing()
        {
            StandardSocketsHttpHandler handler = new StandardSocketsHttpHandler();

            Assert.DoesNotThrow(() => InvokeApplyClientCertificates(handler, null));
            Assert.AreEqual(0, AppliedCertificateCount(handler));
        }

        [Test]
        public void ApplyClientCertificates_EmptyCollection_DoesNotThrowAndAppliesNothing()
        {
            StandardSocketsHttpHandler handler = new StandardSocketsHttpHandler();

            Assert.DoesNotThrow(() => InvokeApplyClientCertificates(handler, new X509CertificateCollection()));
            Assert.AreEqual(0, AppliedCertificateCount(handler));
        }

        // ─── Happy path: certificates are attached to the handler ────────────────

        [Test]
        public void ApplyClientCertificates_SingleX509Certificate2_IsAppliedToHandler()
        {
            StandardSocketsHttpHandler handler = new StandardSocketsHttpHandler();
            X509Certificate2 certificate = LoadCertificate2();
            X509CertificateCollection input = new X509CertificateCollection { certificate };

            InvokeApplyClientCertificates(handler, input);

            Assert.AreEqual(1, AppliedCertificateCount(handler));
            Assert.IsTrue(
                HandlerContainsThumbprint(handler, certificate.Thumbprint),
                "The supplied client certificate was not applied to the handler's SSL options.");
        }

        [Test]
        public void ApplyClientCertificates_BaseX509Certificate_IsConvertedAndApplied()
        {
            StandardSocketsHttpHandler handler = new StandardSocketsHttpHandler();
            X509Certificate baseCertificate = LoadCertificateBase();
            X509CertificateCollection input = new X509CertificateCollection { baseCertificate };

            InvokeApplyClientCertificates(handler, input);

            Assert.AreEqual(1, AppliedCertificateCount(handler));
            // The conversion branch must store an X509Certificate2 instance.
            Assert.IsInstanceOf<X509Certificate2>(handler.SslOptions.ClientCertificates[0]);
        }

        [Test]
        public void ApplyClientCertificates_MultipleCertificates_AllApplied()
        {
            StandardSocketsHttpHandler handler = new StandardSocketsHttpHandler();
            X509CertificateCollection input = new X509CertificateCollection
            {
                LoadCertificate2(),   // already an X509Certificate2 -> direct-add branch
                LoadCertificateBase() // base certificate -> conversion branch
            };

            InvokeApplyClientCertificates(handler, input);

            Assert.AreEqual(2, AppliedCertificateCount(handler));
        }

        [Test]
        public void ApplyClientCertificates_ExistingClientCertificates_ArePreserved()
        {
            StandardSocketsHttpHandler handler = new StandardSocketsHttpHandler();
            X509Certificate2 existing = LoadCertificate2();
            handler.SslOptions.ClientCertificates = new X509CertificateCollection { existing };

            InvokeApplyClientCertificates(handler, new X509CertificateCollection { LoadCertificate2() });

            // The pre-existing certificate must not be discarded when new ones are applied.
            Assert.AreEqual(2, AppliedCertificateCount(handler));
        }
    }
}
