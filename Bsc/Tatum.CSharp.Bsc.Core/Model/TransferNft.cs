/*
 * Tatum API Reference
 *
 * # Welcome to the Tatum API Reference!  ## What is Tatum?  Tatum offers a flexible framework to build, run, and scale blockchain apps fast. To learn more about the Tatum blockchain development framework, visit [our website](https://tatum.io/framework).  The Tatum API features powerful endpoints that simplify a complex blockchain into single API requests. Code for all supported blockchains using unified API calls.  ## Need help?  To chat with other developers, get help from the Support team, and engage with the thriving Tatum community, join  our [Discord server](https://discord.com/invite/tatum). For more information about how to work with Tatum, review the [online documentation](https://docs.tatum.io/).  ## About this API Reference  The Tatum API Reference is based on OpenAPI Specification v3.1.0 with a few [vendor extensions](https://github.com/Redocly/redoc/blob/master/docs/redoc-vendor-extensions.md) applied.  # Authentication  When using the Tatum API, you authenticate yourself with an **API key**. <SecurityDefinitions /> 
 *
 * The version of the OpenAPI document: 3.17.1
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
using FileParameter = Tatum.CSharp.Bsc.Core.Client.FileParameter;
using OpenAPIDateConverter = Tatum.CSharp.Bsc.Core.Client.OpenAPIDateConverter;

namespace Tatum.CSharp.Bsc.Core.Model
{
    /// <summary>
    /// TransferNft
    /// </summary>
    [DataContract(Name = "TransferNft")]
    public partial class TransferNft : IEquatable<TransferNft>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferNft" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferNft() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferNft" /> class.
        /// </summary>
        /// <param name="value">If token to be transferred is Royalty NFT token, this is a value to be paid as a cashback to the authors of the token..</param>
        /// <param name="to">Blockchain address to send NFT token to (required).</param>
        /// <param name="tokenId">ID of the token. (required).</param>
        /// <param name="contractAddress">Address of NFT token (required).</param>
        /// <param name="provenance">True if the contract is provenance type.</param>
        /// <param name="provenanceData">data you want to store with transaction, optional and valid only if provenance contract.</param>
        /// <param name="tokenPrice">current price of the token, valid only for provenance.</param>
        /// <param name="fromPrivateKey">Private key of sender address. Private key, or signature Id must be present. (required).</param>
        /// <param name="nonce">The nonce to be set to the transaction; if not present, the last known nonce will be used.</param>
        /// <param name="fee">fee.</param>
        public TransferNft(string value = default(string), string to = default(string), string tokenId = default(string), string contractAddress = default(string), bool provenance = default(bool), string provenanceData = default(string), string tokenPrice = default(string), string fromPrivateKey = default(string), decimal nonce = default(decimal), CustomFee fee = default(CustomFee))
        {
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for TransferNft and cannot be null");
            }
            this.To = to;
            // to ensure "tokenId" is required (not null)
            if (tokenId == null)
            {
                throw new ArgumentNullException("tokenId is a required property for TransferNft and cannot be null");
            }
            this.TokenId = tokenId;
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for TransferNft and cannot be null");
            }
            this.ContractAddress = contractAddress;
            // to ensure "fromPrivateKey" is required (not null)
            if (fromPrivateKey == null)
            {
                throw new ArgumentNullException("fromPrivateKey is a required property for TransferNft and cannot be null");
            }
            this.FromPrivateKey = fromPrivateKey;
            this.Value = value;
            this.Provenance = provenance;
            this.ProvenanceData = provenanceData;
            this.TokenPrice = tokenPrice;
            this.Nonce = nonce;
            this.Fee = fee;
        }

        /// <summary>
        /// The blockchain to work with
        /// </summary>
        /// <value>The blockchain to work with</value>
        [DataMember(Name = "chain", IsRequired = true, EmitDefaultValue = true)]
        public string Chain { get; } = "BSC";


        /// <summary>
        /// If token to be transferred is Royalty NFT token, this is a value to be paid as a cashback to the authors of the token.
        /// </summary>
        /// <value>If token to be transferred is Royalty NFT token, this is a value to be paid as a cashback to the authors of the token.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Blockchain address to send NFT token to
        /// </summary>
        /// <value>Blockchain address to send NFT token to</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// ID of the token.
        /// </summary>
        /// <value>ID of the token.</value>
        [DataMember(Name = "tokenId", IsRequired = true, EmitDefaultValue = true)]
        public string TokenId { get; set; }

        /// <summary>
        /// Address of NFT token
        /// </summary>
        /// <value>Address of NFT token</value>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = true)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// True if the contract is provenance type
        /// </summary>
        /// <value>True if the contract is provenance type</value>
        [DataMember(Name = "provenance", EmitDefaultValue = true)]
        public bool Provenance { get; set; }

        /// <summary>
        /// data you want to store with transaction, optional and valid only if provenance contract
        /// </summary>
        /// <value>data you want to store with transaction, optional and valid only if provenance contract</value>
        [DataMember(Name = "provenanceData", EmitDefaultValue = false)]
        public string ProvenanceData { get; set; }

        /// <summary>
        /// current price of the token, valid only for provenance
        /// </summary>
        /// <value>current price of the token, valid only for provenance</value>
        [DataMember(Name = "tokenPrice", EmitDefaultValue = false)]
        public string TokenPrice { get; set; }

        /// <summary>
        /// Private key of sender address. Private key, or signature Id must be present.
        /// </summary>
        /// <value>Private key of sender address. Private key, or signature Id must be present.</value>
        [DataMember(Name = "fromPrivateKey", IsRequired = true, EmitDefaultValue = true)]
        public string FromPrivateKey { get; set; }

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
            sb.Append("class TransferNft {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  Provenance: ").Append(Provenance).Append("\n");
            sb.Append("  ProvenanceData: ").Append(ProvenanceData).Append("\n");
            sb.Append("  TokenPrice: ").Append(TokenPrice).Append("\n");
            sb.Append("  FromPrivateKey: ").Append(FromPrivateKey).Append("\n");
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
            return this.Equals(input as TransferNft);
        }

        /// <summary>
        /// Returns true if TransferNft instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferNft to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferNft input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                ) && 
                (
                    this.Provenance == input.Provenance ||
                    this.Provenance.Equals(input.Provenance)
                ) && 
                (
                    this.ProvenanceData == input.ProvenanceData ||
                    (this.ProvenanceData != null &&
                    this.ProvenanceData.Equals(input.ProvenanceData))
                ) && 
                (
                    this.TokenPrice == input.TokenPrice ||
                    (this.TokenPrice != null &&
                    this.TokenPrice.Equals(input.TokenPrice))
                ) && 
                (
                    this.FromPrivateKey == input.FromPrivateKey ||
                    (this.FromPrivateKey != null &&
                    this.FromPrivateKey.Equals(input.FromPrivateKey))
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
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Provenance.GetHashCode();
                if (this.ProvenanceData != null)
                {
                    hashCode = (hashCode * 59) + this.ProvenanceData.GetHashCode();
                }
                if (this.TokenPrice != null)
                {
                    hashCode = (hashCode * 59) + this.TokenPrice.GetHashCode();
                }
                if (this.FromPrivateKey != null)
                {
                    hashCode = (hashCode * 59) + this.FromPrivateKey.GetHashCode();
                }
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
            // To (string) maxLength
            if (this.To != null && this.To.Length > 58)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be less than 58.", new [] { "To" });
            }

            // To (string) minLength
            if (this.To != null && this.To.Length < 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be greater than 42.", new [] { "To" });
            }

            // TokenId (string) maxLength
            if (this.TokenId != null && this.TokenId.Length > 78)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenId, length must be less than 78.", new [] { "TokenId" });
            }

            // ContractAddress (string) maxLength
            if (this.ContractAddress != null && this.ContractAddress.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractAddress, length must be less than 42.", new [] { "ContractAddress" });
            }

            // ContractAddress (string) minLength
            if (this.ContractAddress != null && this.ContractAddress.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractAddress, length must be greater than 1.", new [] { "ContractAddress" });
            }

            // TokenPrice (string) maxLength
            if (this.TokenPrice != null && this.TokenPrice.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenPrice, length must be less than 256.", new [] { "TokenPrice" });
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

            yield break;
        }
    }

}