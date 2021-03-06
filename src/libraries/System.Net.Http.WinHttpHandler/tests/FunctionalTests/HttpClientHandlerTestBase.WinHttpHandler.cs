// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Net.Test.Common;
using System.IO;

namespace System.Net.Http.Functional.Tests
{
    public abstract partial class HttpClientHandlerTestBase : FileCleanupTestBase
    {
        protected static bool IsWinHttpHandler => true;

        protected static bool AllowAllCertificates { get; set; } = true;

        protected static WinHttpClientHandler CreateHttpClientHandler(Version useVersion = null)
        {
            useVersion ??= HttpVersion.Version11;

            WinHttpClientHandler handler = new WinHttpClientHandler(useVersion);

            if (useVersion >= HttpVersion20.Value && AllowAllCertificates)
            {
                handler.ServerCertificateCustomValidationCallback = TestHelper.AllowAllCertificates;
            }

            return handler;
        }
    }
}
