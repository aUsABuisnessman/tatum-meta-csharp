/*
 * Tatum API Reference
 *
 * # Welcome to the Tatum API Reference!  ## What is Tatum?  Tatum offers a flexible framework to build, run, and scale blockchain apps fast. To learn more about the Tatum blockchain development framework, visit [our website](https://tatum.io/framework).  The Tatum API features powerful endpoints that simplify a complex blockchain into single API requests. Code for all supported blockchains using unified API calls.  ## Need help?  To chat with other developers, get help from the Support team, and engage with the thriving Tatum community, join  our [Discord server](https://discord.com/invite/tatum). For more information about how to work with Tatum, review the [online documentation](https://docs.tatum.io/).  ## About this API Reference  The Tatum API Reference is based on OpenAPI Specification v3.1.0 with a few [vendor extensions](https://github.com/Redocly/redoc/blob/master/docs/redoc-vendor-extensions.md) applied.  # Authentication  When using the Tatum API, you authenticate yourself with an **API key**. <SecurityDefinitions /> 
 *
 * The version of the OpenAPI document: 3.17.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Tatum.CSharp.Core.Client.FileParameter;
using OpenAPIDateConverter = Tatum.CSharp.Core.Client.OpenAPIDateConverter;

namespace Tatum.CSharp.Core.Model
{
    /// <summary>
    /// &lt;p&gt;The &lt;code&gt;MintNftKMSTron&lt;/code&gt; schema lets you mint NFTs natively on TRON and sign the transaction with your signature ID.&lt;br/&gt;For more information, see \&quot;Minting NFTs natively on a blockchain\&quot; in &lt;a href&#x3D;\&quot;#operation/NftMintErc721\&quot;&gt;Mint an NFT&lt;/a&gt;.&lt;/p&gt;&lt;br/&gt;
    /// </summary>
    [DataContract(Name = "MintNftKMSTron")]
    public partial class MintNftKMSTron : IEquatable<MintNftKMSTron>, IValidatableObject
    {
        /// <summary>
        /// The blockchain to work with
        /// </summary>
        /// <value>The blockchain to work with</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChainEnum
        {
            /// <summary>
            /// Enum TRON for value: TRON
            /// </summary>
            [EnumMember(Value = "TRON")]
            TRON = 1

        }


        /// <summary>
        /// The blockchain to work with
        /// </summary>
        /// <value>The blockchain to work with</value>
        [DataMember(Name = "chain", IsRequired = true, EmitDefaultValue = true)]
        public ChainEnum Chain { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MintNftKMSTron" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MintNftKMSTron() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MintNftKMSTron" /> class.
        /// </summary>
        /// <param name="chain">The blockchain to work with (required).</param>
        /// <param name="to">The blockchain address to send the NFT to (required).</param>
        /// <param name="contractAddress">The blockchain address of the smart contract to build the NFT on (required).</param>
        /// <param name="tokenId">The ID of the NFT. (uint256 number) (required).</param>
        /// <param name="url">The URL pointing to the NFT metadata; for more information, see &lt;a href&#x3D;\&quot;https://eips.ethereum.org/EIPS/eip-721#specification\&quot; target&#x3D;\&quot;_blank\&quot;&gt;EIP-721&lt;/a&gt; (required).</param>
        /// <param name="feeLimit">The maximum amount to be paid as the transaction fee (in TRX) (required).</param>
        /// <param name="account">The blockchain address that will pay the fee for the transaction (required).</param>
        /// <param name="signatureId">The KMS identifier of the private key of the blockchain address that will pay the fee for the transaction (required).</param>
        /// <param name="index">(Only if the signature ID is mnemonic-based) The index of the address to pay the transaction fee that was generated from the mnemonic.</param>
        /// <param name="authorAddresses">The blockchain addresses where the royalties will be sent every time the minted NFT is transferred; the royalties are paid in the native blockchain currency, TRX.</param>
        /// <param name="cashbackValues">The amounts of the royalties that will be paid to the authors of the minted NFT every time the NFT is transferred; the amount is defined as a fixed amount of the native blockchain currency.</param>
        public MintNftKMSTron(ChainEnum chain = default(ChainEnum), string to = default(string), string contractAddress = default(string), string tokenId = default(string), string url = default(string), decimal feeLimit = default(decimal), string account = default(string), Guid signatureId = default(Guid), decimal index = default(decimal), List<string> authorAddresses = default(List<string>), List<string> cashbackValues = default(List<string>))
        {
            this.Chain = chain;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for MintNftKMSTron and cannot be null");
            }
            this.To = to;
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for MintNftKMSTron and cannot be null");
            }
            this.ContractAddress = contractAddress;
            // to ensure "tokenId" is required (not null)
            if (tokenId == null)
            {
                throw new ArgumentNullException("tokenId is a required property for MintNftKMSTron and cannot be null");
            }
            this.TokenId = tokenId;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for MintNftKMSTron and cannot be null");
            }
            this.Url = url;
            this.FeeLimit = feeLimit;
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new ArgumentNullException("account is a required property for MintNftKMSTron and cannot be null");
            }
            this.Account = account;
            this.SignatureId = signatureId;
            this.Index = index;
            this.AuthorAddresses = authorAddresses;
            this.CashbackValues = cashbackValues;
        }

        /// <summary>
        /// The blockchain address to send the NFT to
        /// </summary>
        /// <value>The blockchain address to send the NFT to</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// The blockchain address of the smart contract to build the NFT on
        /// </summary>
        /// <value>The blockchain address of the smart contract to build the NFT on</value>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = true)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// The ID of the NFT. (uint256 number)
        /// </summary>
        /// <value>The ID of the NFT. (uint256 number)</value>
        [DataMember(Name = "tokenId", IsRequired = true, EmitDefaultValue = true)]
        public string TokenId { get; set; }

        /// <summary>
        /// The URL pointing to the NFT metadata; for more information, see &lt;a href&#x3D;\&quot;https://eips.ethereum.org/EIPS/eip-721#specification\&quot; target&#x3D;\&quot;_blank\&quot;&gt;EIP-721&lt;/a&gt;
        /// </summary>
        /// <value>The URL pointing to the NFT metadata; for more information, see &lt;a href&#x3D;\&quot;https://eips.ethereum.org/EIPS/eip-721#specification\&quot; target&#x3D;\&quot;_blank\&quot;&gt;EIP-721&lt;/a&gt;</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The maximum amount to be paid as the transaction fee (in TRX)
        /// </summary>
        /// <value>The maximum amount to be paid as the transaction fee (in TRX)</value>
        [DataMember(Name = "feeLimit", IsRequired = true, EmitDefaultValue = true)]
        public decimal FeeLimit { get; set; }

        /// <summary>
        /// The blockchain address that will pay the fee for the transaction
        /// </summary>
        /// <value>The blockchain address that will pay the fee for the transaction</value>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = true)]
        public string Account { get; set; }

        /// <summary>
        /// The KMS identifier of the private key of the blockchain address that will pay the fee for the transaction
        /// </summary>
        /// <value>The KMS identifier of the private key of the blockchain address that will pay the fee for the transaction</value>
        [DataMember(Name = "signatureId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SignatureId { get; set; }

        /// <summary>
        /// (Only if the signature ID is mnemonic-based) The index of the address to pay the transaction fee that was generated from the mnemonic
        /// </summary>
        /// <value>(Only if the signature ID is mnemonic-based) The index of the address to pay the transaction fee that was generated from the mnemonic</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public decimal Index { get; set; }

        /// <summary>
        /// The blockchain addresses where the royalties will be sent every time the minted NFT is transferred; the royalties are paid in the native blockchain currency, TRX
        /// </summary>
        /// <value>The blockchain addresses where the royalties will be sent every time the minted NFT is transferred; the royalties are paid in the native blockchain currency, TRX</value>
        [DataMember(Name = "authorAddresses", EmitDefaultValue = false)]
        public List<string> AuthorAddresses { get; set; }

        /// <summary>
        /// The amounts of the royalties that will be paid to the authors of the minted NFT every time the NFT is transferred; the amount is defined as a fixed amount of the native blockchain currency
        /// </summary>
        /// <value>The amounts of the royalties that will be paid to the authors of the minted NFT every time the NFT is transferred; the amount is defined as a fixed amount of the native blockchain currency</value>
        [DataMember(Name = "cashbackValues", EmitDefaultValue = false)]
        public List<string> CashbackValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MintNftKMSTron {\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  FeeLimit: ").Append(FeeLimit).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  SignatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  AuthorAddresses: ").Append(AuthorAddresses).Append("\n");
            sb.Append("  CashbackValues: ").Append(CashbackValues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MintNftKMSTron);
        }

        /// <summary>
        /// Returns true if MintNftKMSTron instances are equal
        /// </summary>
        /// <param name="input">Instance of MintNftKMSTron to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MintNftKMSTron input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Chain == input.Chain ||
                    this.Chain.Equals(input.Chain)
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                ) && 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.FeeLimit == input.FeeLimit ||
                    this.FeeLimit.Equals(input.FeeLimit)
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.SignatureId == input.SignatureId ||
                    (this.SignatureId != null &&
                    this.SignatureId.Equals(input.SignatureId))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.AuthorAddresses == input.AuthorAddresses ||
                    this.AuthorAddresses != null &&
                    input.AuthorAddresses != null &&
                    this.AuthorAddresses.SequenceEqual(input.AuthorAddresses)
                ) && 
                (
                    this.CashbackValues == input.CashbackValues ||
                    this.CashbackValues != null &&
                    input.CashbackValues != null &&
                    this.CashbackValues.SequenceEqual(input.CashbackValues)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Chain.GetHashCode();
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FeeLimit.GetHashCode();
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.SignatureId != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                if (this.AuthorAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorAddresses.GetHashCode();
                }
                if (this.CashbackValues != null)
                {
                    hashCode = (hashCode * 59) + this.CashbackValues.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // To (string) maxLength
            if (this.To != null && this.To.Length > 34)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be less than 34.", new [] { "To" });
            }

            // To (string) minLength
            if (this.To != null && this.To.Length < 34)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be greater than 34.", new [] { "To" });
            }

            // ContractAddress (string) maxLength
            if (this.ContractAddress != null && this.ContractAddress.Length > 34)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractAddress, length must be less than 34.", new [] { "ContractAddress" });
            }

            // ContractAddress (string) minLength
            if (this.ContractAddress != null && this.ContractAddress.Length < 34)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractAddress, length must be greater than 34.", new [] { "ContractAddress" });
            }

            // TokenId (string) maxLength
            if (this.TokenId != null && this.TokenId.Length > 78)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenId, length must be less than 78.", new [] { "TokenId" });
            }

            // Url (string) maxLength
            if (this.Url != null && this.Url.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be less than 256.", new [] { "Url" });
            }

            // Account (string) maxLength
            if (this.Account != null && this.Account.Length > 34)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Account, length must be less than 34.", new [] { "Account" });
            }

            // Account (string) minLength
            if (this.Account != null && this.Account.Length < 34)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Account, length must be greater than 34.", new [] { "Account" });
            }

            // Index (decimal) minimum
            if (this.Index < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Index, must be a value greater than or equal to 0.", new [] { "Index" });
            }

            yield break;
        }
    }

}
