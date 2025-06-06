/*
 * Tatum API Reference
 *
 * # Welcome to the Tatum API Reference!  ## What is Tatum?  Tatum offers a flexible framework to build, run, and scale blockchain apps fast. To learn more about the Tatum blockchain development framework, visit [our website](https://tatum.io/framework).  The Tatum API features powerful endpoints that simplify a complex blockchain into single API requests. Code for all supported blockchains using unified API calls.  ## Supported blockchains  Tatum supports multiple blockchains and various blockchain features.  Because not all blockchains function identically, Tatum supports a different set of features on each blockchain.  To see all the blockchains that Tatum supports, please refer to [this article](https://docs.tatum.io/introduction/supported-blockchains).  ## Need help?  To chat with other developers, get help from the Support team, and engage with the thriving Tatum community, join  our [Discord server](https://discord.com/invite/tatum). For more information about how to work with Tatum, review the [online documentation](https://docs.tatum.io/).  # Authentication  When using the Tatum API, you authenticate yourself with an **API key**. <SecurityDefinitions /> 
 *
 * The version of the OpenAPI document: 3.17.2
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
using FileParameter = Tatum.CSharp.Nft.Core.Client.FileParameter;
using OpenAPIDateConverter = Tatum.CSharp.Nft.Core.Client.OpenAPIDateConverter;

namespace Tatum.CSharp.Nft.Core.Model
{
    /// <summary>
    /// DeployNft
    /// </summary>
    [DataContract(Name = "DeployNft")]
    public partial class DeployNft : IEquatable<DeployNft>, IValidatableObject
    {
        /// <summary>
        /// The blockchain to work with
        /// </summary>
        /// <value>The blockchain to work with</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChainEnum
        {
            /// <summary>
            /// Enum ETH for value: ETH
            /// </summary>
            [EnumMember(Value = "ETH")]
            ETH = 1,

            /// <summary>
            /// Enum MATIC for value: MATIC
            /// </summary>
            [EnumMember(Value = "MATIC")]
            MATIC = 2,

            /// <summary>
            /// Enum ONE for value: ONE
            /// </summary>
            [EnumMember(Value = "ONE")]
            ONE = 3,

            /// <summary>
            /// Enum BSC for value: BSC
            /// </summary>
            [EnumMember(Value = "BSC")]
            BSC = 4

        }


        /// <summary>
        /// The blockchain to work with
        /// </summary>
        /// <value>The blockchain to work with</value>
        [DataMember(Name = "chain", IsRequired = true, EmitDefaultValue = true)]
        public ChainEnum Chain { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeployNft" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeployNft() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeployNft" /> class.
        /// </summary>
        /// <param name="chain">The blockchain to work with (required).</param>
        /// <param name="name">Name of the NFT token (required).</param>
        /// <param name="symbol">Symbol of the NFT token (required).</param>
        /// <param name="fromPrivateKey">Private key of account address, from which gas for deployment of ERC721 will be paid. Private key, or signature Id must be present. (required).</param>
        /// <param name="provenance">True if the contract is provenance percentage royalty type. False by default. &lt;a href&#x3D;\&quot;https://github.com/tatumio/smart-contracts\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Details and sources available here.&lt;/a&gt;.</param>
        /// <param name="cashback">True if the contract is fixed price royalty type. False by default. &lt;a href&#x3D;\&quot;https://github.com/tatumio/smart-contracts\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Details and sources available here.&lt;/a&gt;.</param>
        /// <param name="publicMint">True if the contract is publicMint type. False by default..</param>
        /// <param name="nonce">The nonce to be set to the transaction; if not present, the last known nonce will be used.</param>
        /// <param name="fee">fee.</param>
        public DeployNft(ChainEnum chain = default(ChainEnum), string name = default(string), string symbol = default(string), string fromPrivateKey = default(string), bool provenance = default(bool), bool cashback = default(bool), bool publicMint = default(bool), decimal nonce = default(decimal), CustomFee fee = default(CustomFee))
        {
            this.Chain = chain;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DeployNft and cannot be null");
            }
            this.Name = name;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for DeployNft and cannot be null");
            }
            this.Symbol = symbol;
            // to ensure "fromPrivateKey" is required (not null)
            if (fromPrivateKey == null)
            {
                throw new ArgumentNullException("fromPrivateKey is a required property for DeployNft and cannot be null");
            }
            this.FromPrivateKey = fromPrivateKey;
            this.Provenance = provenance;
            this.Cashback = cashback;
            this.PublicMint = publicMint;
            this.Nonce = nonce;
            this.Fee = fee;
        }


        /// <summary>
        /// Name of the NFT token
        /// </summary>
        /// <value>Name of the NFT token</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Symbol of the NFT token
        /// </summary>
        /// <value>Symbol of the NFT token</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Private key of account address, from which gas for deployment of ERC721 will be paid. Private key, or signature Id must be present.
        /// </summary>
        /// <value>Private key of account address, from which gas for deployment of ERC721 will be paid. Private key, or signature Id must be present.</value>
        [DataMember(Name = "fromPrivateKey", IsRequired = true, EmitDefaultValue = true)]
        public string FromPrivateKey { get; set; }

        /// <summary>
        /// True if the contract is provenance percentage royalty type. False by default. &lt;a href&#x3D;\&quot;https://github.com/tatumio/smart-contracts\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Details and sources available here.&lt;/a&gt;
        /// </summary>
        /// <value>True if the contract is provenance percentage royalty type. False by default. &lt;a href&#x3D;\&quot;https://github.com/tatumio/smart-contracts\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Details and sources available here.&lt;/a&gt;</value>
        [DataMember(Name = "provenance", EmitDefaultValue = true)]
        public bool Provenance { get; set; }

        /// <summary>
        /// True if the contract is fixed price royalty type. False by default. &lt;a href&#x3D;\&quot;https://github.com/tatumio/smart-contracts\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Details and sources available here.&lt;/a&gt;
        /// </summary>
        /// <value>True if the contract is fixed price royalty type. False by default. &lt;a href&#x3D;\&quot;https://github.com/tatumio/smart-contracts\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Details and sources available here.&lt;/a&gt;</value>
        [DataMember(Name = "cashback", EmitDefaultValue = true)]
        public bool Cashback { get; set; }

        /// <summary>
        /// True if the contract is publicMint type. False by default.
        /// </summary>
        /// <value>True if the contract is publicMint type. False by default.</value>
        [DataMember(Name = "publicMint", EmitDefaultValue = true)]
        public bool PublicMint { get; set; }

        /// <summary>
        /// The nonce to be set to the transaction; if not present, the last known nonce will be used
        /// </summary>
        /// <value>The nonce to be set to the transaction; if not present, the last known nonce will be used</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        public decimal Nonce { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public CustomFee Fee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeployNft {\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  FromPrivateKey: ").Append(FromPrivateKey).Append("\n");
            sb.Append("  Provenance: ").Append(Provenance).Append("\n");
            sb.Append("  Cashback: ").Append(Cashback).Append("\n");
            sb.Append("  PublicMint: ").Append(PublicMint).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
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
            return this.Equals(input as DeployNft);
        }

        /// <summary>
        /// Returns true if DeployNft instances are equal
        /// </summary>
        /// <param name="input">Instance of DeployNft to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeployNft input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.FromPrivateKey == input.FromPrivateKey ||
                    (this.FromPrivateKey != null &&
                    this.FromPrivateKey.Equals(input.FromPrivateKey))
                ) && 
                (
                    this.Provenance == input.Provenance ||
                    this.Provenance.Equals(input.Provenance)
                ) && 
                (
                    this.Cashback == input.Cashback ||
                    this.Cashback.Equals(input.Cashback)
                ) && 
                (
                    this.PublicMint == input.PublicMint ||
                    this.PublicMint.Equals(input.PublicMint)
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.FromPrivateKey != null)
                {
                    hashCode = (hashCode * 59) + this.FromPrivateKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Provenance.GetHashCode();
                hashCode = (hashCode * 59) + this.Cashback.GetHashCode();
                hashCode = (hashCode * 59) + this.PublicMint.GetHashCode();
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Symbol (string) maxLength
            if (this.Symbol != null && this.Symbol.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Symbol, length must be less than 30.", new [] { "Symbol" });
            }

            // Symbol (string) minLength
            if (this.Symbol != null && this.Symbol.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Symbol, length must be greater than 1.", new [] { "Symbol" });
            }

            // FromPrivateKey (string) maxLength
            if (this.FromPrivateKey != null && this.FromPrivateKey.Length > 103)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FromPrivateKey, length must be less than 103.", new [] { "FromPrivateKey" });
            }

            // FromPrivateKey (string) minLength
            if (this.FromPrivateKey != null && this.FromPrivateKey.Length < 66)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FromPrivateKey, length must be greater than 66.", new [] { "FromPrivateKey" });
            }

            // Nonce (decimal) minimum
            if (this.Nonce < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Nonce, must be a value greater than or equal to 0.", new [] { "Nonce" });
            }

            yield break;
        }
    }

}
