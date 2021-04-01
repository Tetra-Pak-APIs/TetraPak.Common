﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace TetraPak.Api
{
    public static class FormUrlEncodedContentExtensions
    {
        
        public static async Task<IDictionary<string, string>> ReadAsDictionaryAsync(
            this FormUrlEncodedContent self)
        {
            var sFormData = await self.ReadAsStringAsync();
            sFormData = WebUtility.UrlDecode(sFormData);
            var pairs = sFormData.Split('&', StringSplitOptions.RemoveEmptyEntries);
            var dictionary = new Dictionary<string, string>(); 
            foreach (var p in pairs)
            {
                var pair = p.Split('=', StringSplitOptions.RemoveEmptyEntries);
                dictionary[pair[0]] = pair.Length == 2 ? pair[1] : null;
            }

            return dictionary;
        }

        
#if NET5_0_OR_GREATER
        public static async Task<IDictionary<string, string>> ReadAsDictionaryAsync(
            this FormUrlEncodedContent self, 
            CancellationToken cancellationToken)
        {
            var sFormData = await self.ReadAsStringAsync(cancellationToken);
            sFormData = WebUtility.UrlDecode(sFormData);
            var pairs = sFormData.Split('&', StringSplitOptions.RemoveEmptyEntries);
            var dictionary = new Dictionary<string, string>(); 
            foreach (var p in pairs)
            {
                var pair = p.Split('=', StringSplitOptions.RemoveEmptyEntries);
                dictionary[pair[0]] = pair.Length == 2 ? pair[1] : null;
            }

            return dictionary;
        }
#endif
    }
}