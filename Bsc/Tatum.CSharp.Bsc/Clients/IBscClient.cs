﻿using Tatum.CSharp.Bsc.Core.Api;
using Tatum.CSharp.Bsc.Core.Client;
using Tatum.CSharp.Evm.Local;
using Tatum.CSharp.Utils;

namespace Tatum.CSharp.Bsc.Clients
{
    public interface IBscClient
    {
        /// <summary>
        /// Client wrapping all operations related directly to the Bsc blockchain.
        /// </summary>
        IBNBSmartChainApiAsync BscBlockchain { get; }
        
        /// <summary>
        /// Client wrapping all operations related directly to the Bsc blockchain with full <see cref="ApiResponse{T}"/> return types.
        /// </summary>
        IBNBSmartChainApiWithHttpInfoAsync BscBlockchainWithHttpInfo { get; }
        
        /// <summary>
        /// Client wrapping all operations related to the Bsc NFTs.
        /// </summary>
        INFTApiAsync BscNft { get; }
        
        /// <summary>
        /// Client wrapping all operations related to the Bsc NFTs with full <see cref="ApiResponse{T}"/> return types.
        /// </summary>
        INFTApiWithHttpInfoAsync BscNftWithHttpInfo { get; }
        
        /// <summary>
        /// Client wrapping all operations related to the Bsc FungibleTokens.
        /// </summary>
        IFungibleTokensApiAsync BscFungibleTokens { get; }
        
        /// <summary>
        /// Client wrapping all operations related to the Bsc FungibleTokens with full <see cref="ApiResponse{T}"/> return types.
        /// </summary>
        IFungibleTokensApiWithHttpInfoAsync BscFungibleTokensWithHttpInfo { get; }
        
        // Client wrapping all blockchain fee estimation operations.
        IBlockchainFeesApiAsync BlockchainFees { get; }
        
        // Client wrapping all blockchain fee estimation operations with full <see cref="ApiResponse{T}"/> return types.
        IBlockchainFeesApiWithHttpInfoAsync BlockchainFeesWithHttpInfo { get; }
        
        // Service for local operations that can be used to keep all sensitive information local.
        IEvmLocalService Local { get; }
        
        // Utility tools for the client.
        ITatumUtils Utils { get; }
    }
}