// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVmware.Models
{
    internal partial class ErrorDefinition
    {
        internal static ErrorDefinition DeserializeErrorDefinition(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<IReadOnlyList<ErrorDefinition>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ErrorDefinition> array = new List<ErrorDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeErrorDefinition(item));
                    }
                    details = array;
                    continue;
                }
            }
            return new ErrorDefinition(code.Value, message.Value, Optional.ToList(details));
        }
    }
}
