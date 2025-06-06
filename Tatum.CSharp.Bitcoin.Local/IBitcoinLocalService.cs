﻿using NBitcoin;
using Tatum.CSharp.Bitcoin.Local.Models;

namespace Tatum.CSharp.Bitcoin.Local
{
    public interface IBitcoinLocalService
    {
        /// <summary>
        /// Generates a BIP44 compatible EVM wallet with the derivation path m/44'/60'/0'/0.
        /// </summary>
        WalletLocal GenerateWallet();

        /// <summary>
        /// Generates a BIP44 compatible EVM wallet with the derivation path m/44'/60'/0'/0.
        /// </summary>
        /// <param name="mnemonic">Mnemonic to use for generating extended public and private keys.</param>
        WalletLocal GenerateWallet(string mnemonic);

        /// <summary>
        /// Generates an EVM account deposit address from an Extended public key.
        /// </summary>
        /// <param name="walletXpub">Extended public key of wallet.</param>
        /// <param name="index">Derivation index of the address to be generated.</param>
        /// <returns></returns>
        GeneratedAddressBtcLocal GenerateAddress(string walletXpub, int index);

        /// <summary>
        /// Generates the private key of an address from a mnemonic for a given derivation path index.
        /// </summary>
        PrivKeyLocal GenerateAddressPrivateKey(PrivKeyRequestLocal privKeyRequest);

        /// <summary>
        /// Creates <see cref="BitcoinSecret"/> from private key.
        /// </summary>
        /// <param name="privateKey">Private key string.</param>
        /// <param name="network">Target network type.</param>
        BitcoinSecret CreateBitcoinSecret(string privateKey, Network network);
    }
}