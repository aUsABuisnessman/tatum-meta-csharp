﻿using System;
using System.Net.Http;
using Tatum.CSharp.Ethereum.Configuration;
using Tatum.CSharp.Ethereum.Core.Api;
using Tatum.CSharp.Ethereum.Core.Model;
using Tatum.CSharp.Ethereum.Utils;
using Tatum.CSharp.Evm.Local;
using Tatum.CSharp.Utils;

namespace Tatum.CSharp.Ethereum.Clients
{
    public class EthereumClient : IEthereumClient
    {
        /// <inheritdoc />
        public IEthereumApiAsync EthereumBlockchain { get; }
        
        /// <inheritdoc />
        public IEthereumApiWithHttpInfoAsync EthereumBlockchainWithHttpInfo { get; }

        /// <inheritdoc />
        public INFTApiAsync EthereumNft { get; }
        
        /// <inheritdoc />
        public INFTApiWithHttpInfoAsync EthereumNftWithHttpInfo { get; }
        
        /// <inheritdoc />
        public IFungibleTokensApiAsync EthereumFungibleTokens { get; }
        
        /// <inheritdoc />
        public IFungibleTokensApiWithHttpInfoAsync EthereumFungibleTokensWithHttpInfo { get; }
        
        /// <inheritdoc />
        public IBlockchainFeesApiAsync BlockchainFees { get; }
        
        /// <inheritdoc />
        public IBlockchainFeesApiWithHttpInfoAsync BlockchainFeesWithHttpInfo { get; }

        /// <inheritdoc />
        public IEvmLocalService Local { get; }
        
        /// <inheritdoc />
        public ITatumUtils Utils { get; }
        
        /// <summary>
        /// Creates an instance of <see cref="EthereumClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="optionsFunc">Configuration options func.</param>
        public EthereumClient(HttpClient httpClient, Func<EthereumClientOptions, EthereumClientOptions> optionsFunc) 
            : this(httpClient, optionsFunc(new EthereumClientOptions()))
        {
        }
        
        /// <summary>
        /// Creates an instance of <see cref="EthereumClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="options">Configuration options.</param>
        public EthereumClient(HttpClient httpClient, EthereumClientOptions options) 
            : this(httpClient, options.ApiKey, options.IsTestnet)
        {
        }

        /// <summary>
        /// Creates an instance of <see cref="EthereumClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="apiKey">Api key that will be used when calling Tatum API.</param>
        public EthereumClient(HttpClient httpClient, string apiKey) 
            : this(httpClient, apiKey, false)
        {
        }

        /// <summary>
        /// Creates an instance of <see cref="EthereumClient"/>.
        /// </summary>
        /// <param name="httpClient"><see cref="HttpClient"/> Instance that should preferably be managed by HttpClient Factory.</param>
        /// <param name="apiKey">Api key that will be used when calling Tatum API.</param>
        /// <param name="isTestNet">Value indicating weather Local services should generate values for Testnet.</param>
        public EthereumClient(HttpClient httpClient, string apiKey, bool isTestNet)
        {
            var ethereumApi = new EthereumApi(httpClient);

            ethereumApi.Configuration.ApiKey.Add("x-api-key", apiKey);

            EthereumBlockchain = ethereumApi;
            EthereumBlockchainWithHttpInfo = ethereumApi;
            
            var ethereumNftApi = new NFTApi(httpClient);
            
            ethereumNftApi.Configuration.ApiKey.Add("x-api-key", apiKey);
            
            EthereumNft = ethereumNftApi;
            EthereumNftWithHttpInfo = ethereumNftApi;
            
            var ethereumFungibleTokensApi = new FungibleTokensApi(httpClient);
            
            ethereumFungibleTokensApi.Configuration.ApiKey.Add("x-api-key", apiKey);
            
            EthereumFungibleTokens = ethereumFungibleTokensApi;
            EthereumFungibleTokensWithHttpInfo = ethereumFungibleTokensApi;

            var feeApi = new BlockchainFeesApi(httpClient);
            
            feeApi.Configuration.ApiKey.Add("x-api-key", apiKey);
            
            BlockchainFees = feeApi;
            BlockchainFeesWithHttpInfo = feeApi;
            
            Local = new EvmLocalService(isTestNet);
            
            Utils = new TatumUtils<EthTx>(new EthereumTransactionWaiter(this));
        }
    }
}