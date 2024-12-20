﻿using System;
using System.Net.Http;
using Tatum.CSharp.Evm.Local;
using Tatum.CSharp.Nft.Configuration;
using Tatum.CSharp.Nft.Core.Api;

namespace Tatum.CSharp.Nft.Clients
{
    public class NftClient : INftClient
    {
        /// <inheritdoc />
        public INFTEthApiAsync EthereumNft { get; }
        
        /// <inheritdoc />
        public INFTEthApiWithHttpInfoAsync EthereumNftWithHttpInfo { get; }
        
        /// <inheritdoc />
        public INFTMaticApiAsync PolygonNft { get; }
        
        /// <inheritdoc />
        public INFTMaticApiWithHttpInfoAsync PolygonNftWithHttpInfo { get; }
        
        /// <inheritdoc />
        public INFTBscApiAsync BscNft { get; }
        
        /// <inheritdoc />
        public INFTBscApiWithHttpInfoAsync BscNftWithHttpInfo { get; }
        
        /// <inheritdoc />
        public INFTOneApiAsync HarmonyNft { get; }
        
        /// <inheritdoc />
        public INFTOneApiWithHttpInfoAsync HarmonyNftWithHttpInfo { get; }

        /// <inheritdoc />
        public IEvmLocalService Local { get; }
        
        /// <summary>
        /// Creates an instance of <see cref="NftClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="optionsFunc">Configuration options func.</param>
        public NftClient(HttpClient httpClient, Func<NftClientOptions, NftClientOptions> optionsFunc) 
            : this(httpClient, optionsFunc(new NftClientOptions()))
        {
        }
        
        /// <summary>
        /// Creates an instance of <see cref="NftClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="options">Configuration options.</param>
        public NftClient(HttpClient httpClient, NftClientOptions options) 
            : this(httpClient, options.ApiKey, options.IsTestnet)
        {
        }

        /// <summary>
        /// Creates an instance of <see cref="NftClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="apiKey">Api key that will be used when calling Tatum API.</param>
        public NftClient(HttpClient httpClient, string apiKey) 
            : this(httpClient, apiKey, false)
        {
        }

        /// <summary>
        /// Creates an instance of <see cref="NftClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="apiKey">Api key that will be used when calling Tatum API.</param>
        /// <param name="isTestNet">Value indicating weather Local services should generate values for Testnet.</param>
        public NftClient(HttpClient httpClient, string apiKey, bool isTestNet)
        {
            var configuration = new Core.Client.Configuration();
            configuration.ApiKey.Add("x-api-key", apiKey);
            
            var ethereumNftApi = new NFTEthApi(httpClient, configuration);
            

            
            EthereumNft = ethereumNftApi;
            EthereumNftWithHttpInfo = ethereumNftApi;
            
            var polygonNftApi = new NFTMaticApi(httpClient, configuration);
            

            
            PolygonNft = polygonNftApi;
            PolygonNftWithHttpInfo = polygonNftApi;
            
            var bscNftApi = new NFTBscApi(httpClient, configuration);
            

            
            BscNft = bscNftApi;
            BscNftWithHttpInfo = bscNftApi;
            
            var oneNftApi = new NFTOneApi(httpClient, configuration);
            

            
            HarmonyNft = oneNftApi;
            HarmonyNftWithHttpInfo = oneNftApi;

            Local = new EvmLocalService(isTestNet);
        }
    }
}