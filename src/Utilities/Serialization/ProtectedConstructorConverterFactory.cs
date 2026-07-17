using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CyberSource.Utilities.Serialization
{
    public class ProtectedConstructorConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            // Skip primitives, strings, arrays, enums, abstract/interface types.
            if (typeToConvert.IsPrimitive ||
                typeToConvert == typeof(string) ||
                typeToConvert.IsArray ||
                typeToConvert.IsEnum ||
                typeToConvert.IsAbstract ||
                typeToConvert.IsInterface)
            {
                return false;
            }

            // Skip common collection and dictionary types.
            if (IsCollectionLike(typeToConvert))
            {
                return false;
            }

            // Check for a protected/private parameterless constructor
            // or non-public constructor marked with [JsonConstructor].
            var protectedCtor = GetProtectedJsonConstructor(typeToConvert);

            return protectedCtor != null;
        }

        public override JsonConverter CreateConverter(
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            var converterType = typeof(ProtectedConstructorConverter<>)
                .MakeGenericType(typeToConvert);

            return (JsonConverter)Activator.CreateInstance(converterType);
        }

        internal static ConstructorInfo GetProtectedJsonConstructor(Type type)
        {
            var constructors = type.GetConstructors(BindingFlags.Public |
                BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var ctor in constructors)
            {
                var hasAttribute =
                    ctor.GetCustomAttribute<JsonConstructorAttribute>() != null;

                if (hasAttribute)
                {
                    return ctor;
                }
            }

            return type.GetConstructor(
                BindingFlags.NonPublic | BindingFlags.Instance,
                binder: null,
                types: Type.EmptyTypes,
                modifiers: null);
        }

        private static bool IsCollectionLike(Type type)
        {
            // string implements IEnumerable<char>, so string is already skipped above.
            if (type == typeof(string))
            {
                return false;
            }

            // Non-generic IEnumerable, e.g. ArrayList.
            if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                return true;
            }

            return false;
        }
    }
}