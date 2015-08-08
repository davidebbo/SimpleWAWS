﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace SimpleWAWS.Authentication
{
    public static class AuthSettings
    {
        private static string config([CallerMemberName] string key = null)
        {
            return System.Environment.GetEnvironmentVariable(key) ??
                ConfigurationManager.AppSettings[key];
        }

        public static string EnableAuth { get { return config(); } }
        public static string BaseLoginUrl { get { return config(); } }
        public static string AADAppId { get { return config(); } }
        public static string LoginErrorPage { get { return config(); } }
        public static string FacebookAppId { get { return config(); } }
        public static string GoogleAppId { get { return config(); } }
        public static string AADIssuerKeys { get { return config(); } }
        public static string GoogleIssuerCerts { get { return config(); } }
        public static string AdminUserId { get { return config(); } }
        public static string VkClientSecret { get { return config(); } }
        public static string VkClientId { get { return config(); } }
    }
}