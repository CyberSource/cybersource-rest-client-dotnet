using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;

namespace CyberSource.Utilities.Tracking
{
    public interface ISdkTracker
    {
        object InsertDeveloperIdTracker(object requestObj, string requestClass, string runEnvironment, string defaultMerchantConfigDeveloperId);
    }

    public partial class SdkTracker : ISdkTracker
    {
        public object InsertDeveloperIdTracker(object requestObj, string requestClass, string runEnvironment, string defaultMerchantConfigDeveloperId)
        {
            string developerIdValue;
            if (runEnvironment.Contains("apitest.cybersource.com"))
            {
                developerIdValue = "CEOVXJBB";
            }
            else
            {
                developerIdValue = "JZKVPX48";
            }

            if (!string.IsNullOrEmpty(defaultMerchantConfigDeveloperId))
            {
                defaultMerchantConfigDeveloperId = defaultMerchantConfigDeveloperId.Trim();
                developerIdValue = !string.IsNullOrEmpty(defaultMerchantConfigDeveloperId) ? defaultMerchantConfigDeveloperId : developerIdValue;
            }

            InjectDeveloperId(requestObj, developerIdValue);
            return requestObj;
        }

        // The developer-id is injected into the request's
        // ClientReferenceInformation -> Partner -> DeveloperId chain whenever the runtime
        // type exposes that shape. Decided by cached reflection (one inspection per type),
        // so it is correct for subclasses and any request carrying the shape, and it
        // never overwrites a developer-id the caller already set.
        private static readonly ConcurrentDictionary<Type, DeveloperIdPath> _developerIdPathCache =
            new ConcurrentDictionary<Type, DeveloperIdPath>();

        private void InjectDeveloperId(object requestObj, string developerIdValue)
        {
            if (requestObj == null)
            {
                return;
            }

            DeveloperIdPath path = _developerIdPathCache.GetOrAdd(requestObj.GetType(), ResolveDeveloperIdPath);
            if (path == null)
            {
                // Request type does not expose the CRI -> Partner -> DeveloperId shape.
                return;
            }

            object clientReferenceInformation = path.ClientReferenceInformation.GetValue(requestObj);
            if (clientReferenceInformation == null)
            {
                clientReferenceInformation = CreateInstance(path.ClientReferenceInformation.PropertyType);
                if (clientReferenceInformation == null)
                {
                    return;
                }

                path.ClientReferenceInformation.SetValue(requestObj, clientReferenceInformation);
            }

            object partner = path.Partner.GetValue(clientReferenceInformation);
            if (partner == null)
            {
                partner = CreateInstance(path.Partner.PropertyType);
                if (partner == null)
                {
                    return;
                }

                path.Partner.SetValue(clientReferenceInformation, partner);
            }

            // Never overwrite a developer-id the caller already supplied.
            if (path.DeveloperId.GetValue(partner) == null)
            {
                path.DeveloperId.SetValue(partner, developerIdValue);
            }
        }

        /// <summary>
        /// Inspects a request type for the ClientReferenceInformation -> Partner ->
        /// DeveloperId (string) property chain. Returns null when the shape is absent; the
        /// result is cached so the reflection cost is paid once per type.
        /// </summary>
        private static DeveloperIdPath ResolveDeveloperIdPath(Type requestType)
        {
            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;

            PropertyInfo clientReferenceInformation = requestType.GetProperty("ClientReferenceInformation", flags);
            if (clientReferenceInformation == null || !clientReferenceInformation.CanRead || !clientReferenceInformation.CanWrite)
            {
                return null;
            }

            PropertyInfo partner = clientReferenceInformation.PropertyType.GetProperty("Partner", flags);
            if (partner == null || !partner.CanRead || !partner.CanWrite)
            {
                return null;
            }

            PropertyInfo developerId = partner.PropertyType.GetProperty("DeveloperId", flags);
            if (developerId == null || !developerId.CanWrite || developerId.PropertyType != typeof(string))
            {
                return null;
            }

            return new DeveloperIdPath
            {
                ClientReferenceInformation = clientReferenceInformation,
                Partner = partner,
                DeveloperId = developerId
            };
        }

        /// <summary>
        /// Creates an instance of a generated model type. Generated models expose either a
        /// real parameterless constructor or a single constructor whose parameters are all
        /// optional; this invokes the fewest-parameter constructor with default arguments.
        /// </summary>
        private static object CreateInstance(Type type)
        {
            ConstructorInfo ctor = type
                .GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                .OrderBy(c => c.GetParameters().Length)
                .FirstOrDefault();

            if (ctor == null)
            {
                return null;
            }

            ParameterInfo[] parameters = ctor.GetParameters();
            object[] args = new object[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                ParameterInfo p = parameters[i];
                if (p.HasDefaultValue)
                {
                    args[i] = p.DefaultValue;
                }
                else if (p.ParameterType.IsValueType)
                {
                    args[i] = Activator.CreateInstance(p.ParameterType);
                }
                else
                {
                    args[i] = null;
                }
            }

            return ctor.Invoke(args);
        }

        /// <summary>
        /// Cached PropertyInfo chain for the developer-id injection shape.
        /// </summary>
        private sealed class DeveloperIdPath
        {
            public PropertyInfo ClientReferenceInformation { get; set; }
            public PropertyInfo Partner { get; set; }
            public PropertyInfo DeveloperId { get; set; }
        }
    }
}
