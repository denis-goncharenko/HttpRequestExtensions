using System;
using Microsoft.AspNetCore.Http;

namespace HttpRequestExtensions
{
    public static class HttpRequestExtensions
    {
        /// <summary>
        /// Create a Absolute Uri from Request
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Absolute path as Uri object</returns>
        public static Uri GetAbsoluteUri(this HttpRequest request)
        {
            var url = $"{request.Scheme}://{request.Host.Host}:{request.Host.Port}{request.Path}";
            Uri.TryCreate(url, UriKind.Absolute, out var uri);
            return uri;
        }

        /// <summary>
        /// Create a Absolute Uri with QueryString from Request
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Absolute path as Uri object</returns>
        public static Uri GetAbsoluteUriWithQueryString(this HttpRequest request)
        {
            var url = $"{request.Scheme}://{request.Host.Host}:{request.Host.Port}{request.Path}{request.QueryString}";
            Uri.TryCreate(url, UriKind.Absolute, out var uri);

            return uri;
        }

        /// <summary>
        /// Create a relative path with query string.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Relative path with query string</returns>
        public static string GetRelativePathWithQueryString(this HttpRequest request)
        {
            return $"{request.Path}{request.QueryString}";
        }
    }
}
