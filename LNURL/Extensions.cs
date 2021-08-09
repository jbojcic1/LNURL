﻿using System;

namespace BTCPayServer.LNUrl
{
    public static class Extensions
    {
        public static bool IsOnion(this Uri uri)
        {
            if (uri == null || !uri.IsAbsoluteUri)
                return false;
            return uri.DnsSafeHost.EndsWith(".onion", StringComparison.OrdinalIgnoreCase);
        }
    }
}