/*
 * Tatum API Reference
 *
 * # Welcome to the Tatum API Reference!  ## What is Tatum?  Tatum offers a flexible framework to build, run, and scale blockchain apps fast. To learn more about the Tatum blockchain development framework, visit [our website](https://tatum.io/framework).  The Tatum API features powerful endpoints that simplify a complex blockchain into single API requests. Code for all supported blockchains using unified API calls.  ## Need help?  To chat with other developers, get help from the Support team, and engage with the thriving Tatum community, join  our [Discord server](https://discord.com/invite/tatum). For more information about how to work with Tatum, review the [online documentation](https://docs.tatum.io/).  ## About this API Reference  The Tatum API Reference is based on OpenAPI Specification v3.1.0 with a few [vendor extensions](https://github.com/Redocly/redoc/blob/master/docs/redoc-vendor-extensions.md) applied.  # Authentication  When using the Tatum API, you authenticate yourself with an **API key**. <SecurityDefinitions /> 
 *
 * The version of the OpenAPI document: 3.17.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;

namespace Tatum.CSharp.NodeRpc.Core.Client
{
    /// <summary>
    /// A URI builder
    /// </summary>
    class WebRequestPathBuilder
    {
            private string _baseUrl;
            private string _path;
            private string _query = "?";
            public WebRequestPathBuilder(string baseUrl, string path)
            {
                _baseUrl = baseUrl;
                _path = path;
            }

            public void AddPathParameters(Dictionary<string, string> parameters)
            {
                foreach (var parameter in parameters)
                {
                    _path = _path.Replace("{" + parameter.Key + "}", Uri.EscapeDataString(parameter.Value));
                }
            }

            public void AddQueryParameters(Multimap<string, string> parameters)
            {
                foreach (var parameter in parameters)
                {
                    foreach (var value in parameter.Value)
                    {
                        _query = _query + parameter.Key + "=" + Uri.EscapeDataString(value) + "&";
                    }
                }
            }

            public string GetFullUri()
            {
                return _baseUrl + _path + _query.Substring(0, _query.Length - 1);
            }
    }
}
