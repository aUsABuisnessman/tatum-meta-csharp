﻿using System;
using System.Net.Http;
using Tatum.CSharp.Harmony.Configuration;
using Tatum.CSharp.Evm.Local;
using Tatum.CSharp.Harmony.Core.Api;
using Tatum.CSharp.Harmony.Core.Model;
using Tatum.CSharp.Harmony.Utils;
using Tatum.CSharp.Utils;

namespace Tatum.CSharp.Harmony.Clients
{
    public class HarmonyClient : IHarmonyClient
    {
        /// <inheritdoc />
        public IHarmonyApiAsync HarmonyBlockchain { get; }
        
        /// <inheritdoc />
        public IHarmonyApiWithHttpInfoAsync HarmonyBlockchainWithHttpInfo { get; }

        /// <inheritdoc />
        public INFTApiAsync HarmonyNft { get; }
        
        /// <inheritdoc />
        public INFTApiWithHttpInfoAsync HarmonyNftWithHttpInfo { get; }
        
        /// <inheritdoc />
        public IFungibleTokensApiAsync HarmonyFungibleTokens { get; }
        
        /// <inheritdoc />
        public IFungibleTokensApiWithHttpInfoAsync HarmonyFungibleTokensWithHttpInfo { get; }
        
        /// <inheritdoc />
        public IBlockchainFeesApiAsync BlockchainFees { get; }
        
        /// <inheritdoc />
        public IBlockchainFeesApiWithHttpInfoAsync BlockchainFeesWithHttpInfo { get; }

        /// <inheritdoc />
        public IEvmLocalService Local { get; }

        /// <inheritdoc />
        public ITatumUtils Utils { get; }

        /// <summary>
        /// Creates an instance of <see cref="HarmonyClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="optionsFunc">Configuration options func.</param>
        public HarmonyClient(HttpClient httpClient, Func<HarmonyClientOptions, HarmonyClientOptions> optionsFunc) 
            : this(httpClient, optionsFunc(new HarmonyClientOptions()))
        {
        }
        
        /// <summary>
        /// Creates an instance of <see cref="HarmonyClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="options">Configuration options.</param>
        public HarmonyClient(HttpClient httpClient, HarmonyClientOptions options) 
            : this(httpClient, options.ApiKey, options.IsTestnet)
        {
        }

        /// <summary>
        /// Creates an instance of <see cref="HarmonyClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="apiKey">Api key that will be used when calling Tatum API.</param>
        public HarmonyClient(HttpClient httpClient, string apiKey) 
            : this(httpClient, apiKey, false)
        {
        }

        /// <summary>
        /// Creates an instance of <see cref="HarmonyClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="apiKey">Api key that will be used when calling Tatum API.</param>
        /// <param name="isTestNet">Value indicating weather Local services should generate values for Testnet.</param>
        public HarmonyClient(HttpClient httpClient, string apiKey, bool isTestNet)
        {
            var harmonyApi = new HarmonyApi(httpClient);

            harmonyApi.Configuration.ApiKey.Add("x-api-key", apiKey);

            HarmonyBlockchain = harmonyApi;
            HarmonyBlockchainWithHttpInfo = harmonyApi;
            
            var harmonyNftApi = new NFTApi(httpClient);
            
            harmonyNftApi.Configuration.ApiKey.Add("x-api-key", apiKey);
            
            HarmonyNft = harmonyNftApi;
            HarmonyNftWithHttpInfo = harmonyNftApi;
            
            var harmonyFungibleTokensApi = new FungibleTokensApi(httpClient);
            
            harmonyFungibleTokensApi.Configuration.ApiKey.Add("x-api-key", apiKey);
            
            HarmonyFungibleTokens = harmonyFungibleTokensApi;
            HarmonyFungibleTokensWithHttpInfo = harmonyFungibleTokensApi;

            var feeApi = new BlockchainFeesApi(httpClient);
            
            feeApi.Configuration.ApiKey.Add("x-api-key", apiKey);
            
            BlockchainFees = feeApi;
            BlockchainFeesWithHttpInfo = feeApi;
            
            Local = new EvmLocalService(isTestNet);
            
            Utils = new TatumUtils<OneTx>(new HarmonyTransactionWaiter(this));
        }
    }
}