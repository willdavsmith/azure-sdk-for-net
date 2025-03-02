﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;
using Azure.Core.TestFramework.Models;

namespace Azure.DigitalTwins.Core.Tests
{
    internal class TestUrlSanitizer : RecordedTestSanitizer
    {
        internal const string FAKE_URL = "https://fakeHost.api.wus2.digitaltwins.azure.net";
        internal const string FAKE_HOST = "fakeHost.api.wus2.digitaltwins.azure.net";

        public TestUrlSanitizer()
        {
            ReplaceHostInUri(FAKE_HOST);
        }

        public override string SanitizeUri(string uri)
        {
            return uri.Replace(new Uri(uri).Host, FAKE_HOST);
        }
    }
}
