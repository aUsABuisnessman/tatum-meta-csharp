﻿using System;
using System.Net.Http;
using Tatum.CSharp.Evm.Local;
using Tatum.CSharp.FungibleTokens.Configuration;
using Tatum.CSharp.FungibleTokens.Core.Api;

namespace Tatum.CSharp.FungibleTokens.Clients
{
    public class FungibleTokensClient : IFungibleTokensClient
    {
        /// <inheritdoc />
        public IFungibleTokensEthApiAsync EthereumFungibleTokens { get; }
        
        /// <inheritdoc />
        public IFungibleTokensEthApiWithHttpInfoAsync EthereumFungibleTokensWithHttpInfo { get; }
        
        /// <inheritdoc />
        public IFungibleTokensMaticApiAsync PolygonFungibleTokens { get; }
        
        /// <inheritdoc />
        public IFungibleTokensMaticApiWithHttpInfoAsync PolygonFungibleTokensWithHttpInfo { get; }
        
        /// <inheritdoc />
        public IFungibleTokensBscApiAsync BscFungibleTokens { get; }
        
        /// <inheritdoc />
        public IFungibleTokensBscApiWithHttpInfoAsync BscFungibleTokensWithHttpInfo { get; }
        
        /// <inheritdoc />
        public IFungibleTokensOneApiAsync HarmonyFungibleTokens { get; }
        
        /// <inheritdoc />
        public IFungibleTokensOneApiWithHttpInfoAsync HarmonyFungibleTokensWithHttpInfo { get; }

        /// <inheritdoc />
        public IEvmLocalService Local { get; }
        
        /// <summary>
        /// Creates an instance of <see cref="FungibleTokensClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="optionsFunc">Configuration options func.</param>
        public FungibleTokensClient(HttpClient httpClient, Func<FungibleTokensClientOptions, FungibleTokensClientOptions> optionsFunc) 
            : this(httpClient, optionsFunc(new FungibleTokensClientOptions()))
        {
        }
        
        /// <summary>
        /// Creates an instance of <see cref="FungibleTokensClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="options">Configuration options.</param>
        public FungibleTokensClient(HttpClient httpClient, FungibleTokensClientOptions options) 
            : this(httpClient, options.ApiKey, options.IsTestnet)
        {
        }

        /// <summary>
        /// Creates an instance of <see cref="FungibleTokensClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="apiKey">Api key that will be used when calling Tatum API.</param>
        public FungibleTokensClient(HttpClient httpClient, string apiKey) 
            : this(httpClient, apiKey, false)
        {
        }

        /// <summary>
        /// Creates an instance of <see cref="FungibleTokensClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="apiKey">Api key that will be used when calling Tatum API.</param>
        /// <param name="isTestNet">Value indicating weather Local services should generate values for Testnet.</param>
        public FungibleTokensClient(HttpClient httpClient, string apiKey, bool isTestNet)
        {
            var configuration = new Core.Client.Configuration();
            configuration.ApiKey.Add("x-api-key", apiKey);
            
            var ethereumFungibleTokensApi = new FungibleTokensEthApi(httpClient, configuration);
            

            
            EthereumFungibleTokens = ethereumFungibleTokensApi;
            EthereumFungibleTokensWithHttpInfo = ethereumFungibleTokensApi;
            
            var polygonFungibleTokensApi = new FungibleTokensMaticApi(httpClient, configuration);
            

            
            PolygonFungibleTokens = polygonFungibleTokensApi;
            PolygonFungibleTokensWithHttpInfo = polygonFungibleTokensApi;
            
            var bscFungibleTokensApi = new FungibleTokensBscApi(httpClient, configuration);
            

            
            BscFungibleTokens = bscFungibleTokensApi;
            BscFungibleTokensWithHttpInfo = bscFungibleTokensApi;
            
            var oneFungibleTokensApi = new FungibleTokensOneApi(httpClient, configuration);
            

            
            HarmonyFungibleTokens = oneFungibleTokensApi;
            HarmonyFungibleTokensWithHttpInfo = oneFungibleTokensApi;

            Local = new EvmLocalService(isTestNet);
        }
    }
}