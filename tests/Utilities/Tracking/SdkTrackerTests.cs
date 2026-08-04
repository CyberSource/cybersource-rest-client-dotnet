using NUnit.Framework;
using CyberSource.Utilities.Tracking;

namespace cybersource_rest_client_netstandard.Test.Utilities.Tracking
{
    /// <summary>
    /// NFR-6: the developer-id tracker now decides injection by JSON SHAPE
    /// (ClientReferenceInformation -> Partner -> DeveloperId) via cached reflection,
    /// instead of a hard-coded request-class switch. These tests exercise that shape logic
    /// using lightweight stand-ins that mirror the generated model property chain.
    /// </summary>
    [TestFixture]
    public class SdkTrackerTests
    {
        private const string ProdEnv = "api.cybersource.com";
        private const string TestEnv = "apitest.cybersource.com";

        // ── Shape stand-ins (mirror generated ClientReferenceInformation/Partner) ────

        public class FakePartner
        {
            public string DeveloperId { get; set; }
        }

        public class FakeCri
        {
            public FakePartner Partner { get; set; }
        }

        // Has the full CRI -> Partner -> DeveloperId shape.
        public class FakeRequestWithShape
        {
            public FakeCri ClientReferenceInformation { get; set; }
        }

        // Subclass of a shape-carrying request (FR-3: must still be injected).
        public class FakeRequestSubclass : FakeRequestWithShape
        {
        }

        // CRI exists but exposes no Partner (mirrors the subscription/plan models that the
        // legacy switch deliberately skipped) -> no injection.
        public class FakeCriNoPartner
        {
            public string Code { get; set; }
        }

        public class FakeRequestNoPartner
        {
            public FakeCriNoPartner ClientReferenceInformation { get; set; }
        }

        // No ClientReferenceInformation at all (mirrors CreatePlanRequest) -> no injection.
        public class FakeRequestNoCri
        {
            public string Something { get; set; }
        }

        private static SdkTracker NewTracker() => new SdkTracker();

        // ── Injection happy path ─────────────────────────────────────────────────────

        [Test]
        public void Inject_CreatesChain_AndSetsProductionDeveloperId()
        {
            var request = new FakeRequestWithShape();

            var result = (FakeRequestWithShape)NewTracker()
                .InsertDeveloperIdTracker(request, nameof(FakeRequestWithShape), ProdEnv, null);

            Assert.IsNotNull(result.ClientReferenceInformation);
            Assert.IsNotNull(result.ClientReferenceInformation.Partner);
            Assert.AreEqual("JZKVPX48", result.ClientReferenceInformation.Partner.DeveloperId);
        }

        [Test]
        public void Inject_TestEnvironment_UsesTestDeveloperId()
        {
            var request = new FakeRequestWithShape();

            NewTracker().InsertDeveloperIdTracker(request, nameof(FakeRequestWithShape), TestEnv, null);

            Assert.AreEqual("CEOVXJBB", request.ClientReferenceInformation.Partner.DeveloperId);
        }

        [Test]
        public void Inject_MerchantConfigDeveloperId_OverridesDefault()
        {
            var request = new FakeRequestWithShape();

            NewTracker().InsertDeveloperIdTracker(request, nameof(FakeRequestWithShape), ProdEnv, "  MID123  ");

            Assert.AreEqual("MID123", request.ClientReferenceInformation.Partner.DeveloperId);
        }

        [Test]
        public void Inject_Subclass_OfShapeRequest_IsInjected()
        {
            var request = new FakeRequestSubclass();

            NewTracker().InsertDeveloperIdTracker(request, nameof(FakeRequestSubclass), ProdEnv, null);

            Assert.IsNotNull(request.ClientReferenceInformation);
            Assert.AreEqual("JZKVPX48", request.ClientReferenceInformation.Partner.DeveloperId);
        }

        [Test]
        public void Inject_ReusesExistingClientReferenceInformationAndPartner()
        {
            var existingCri = new FakeCri();
            var existingPartner = new FakePartner();
            existingCri.Partner = existingPartner;
            var request = new FakeRequestWithShape { ClientReferenceInformation = existingCri };

            NewTracker().InsertDeveloperIdTracker(request, nameof(FakeRequestWithShape), ProdEnv, null);

            Assert.AreSame(existingCri, request.ClientReferenceInformation);
            Assert.AreSame(existingPartner, request.ClientReferenceInformation.Partner);
            Assert.AreEqual("JZKVPX48", existingPartner.DeveloperId);
        }

        // ── Caller-set value preserved ───────────────────────────────────────────────

        [Test]
        public void Inject_DoesNotOverwriteCallerSuppliedDeveloperId()
        {
            var request = new FakeRequestWithShape
            {
                ClientReferenceInformation = new FakeCri
                {
                    Partner = new FakePartner { DeveloperId = "CALLER_OWN" }
                }
            };

            NewTracker().InsertDeveloperIdTracker(request, nameof(FakeRequestWithShape), ProdEnv, null);

            Assert.AreEqual("CALLER_OWN", request.ClientReferenceInformation.Partner.DeveloperId);
        }

        // ── Shape absent -> no injection, no exception ───────────────────────────────

        [Test]
        public void NoPartner_Shape_IsNotInjected()
        {
            var request = new FakeRequestNoPartner();

            var result = NewTracker()
                .InsertDeveloperIdTracker(request, nameof(FakeRequestNoPartner), ProdEnv, null);

            Assert.AreSame(request, result);
            Assert.IsNull(request.ClientReferenceInformation); // left untouched
        }

        [Test]
        public void NoClientReferenceInformation_Shape_IsNotInjected()
        {
            var request = new FakeRequestNoCri();

            var result = NewTracker()
                .InsertDeveloperIdTracker(request, nameof(FakeRequestNoCri), ProdEnv, null);

            Assert.AreSame(request, result);
        }

        [Test]
        public void NullRequest_ReturnsNull_WithoutThrowing()
        {
            object result = null;
            Assert.DoesNotThrow(() =>
                result = NewTracker().InsertDeveloperIdTracker(null, "Anything", ProdEnv, null));
            Assert.IsNull(result);
        }
    }
}
