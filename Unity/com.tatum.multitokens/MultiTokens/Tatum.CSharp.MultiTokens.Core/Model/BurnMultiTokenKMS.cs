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
using FileParameter = Tatum.CSharp.MultiTokens.Core.Client.FileParameter;
using OpenAPIDateConverter = Tatum.CSharp.MultiTokens.Core.Client.OpenAPIDateConverter;

namespace Tatum.CSharp.MultiTokens.Core.Model
{
    /// <summary>
    /// BurnMultiTokenKMS
    /// </summary>
    [DataContract(Name = "BurnMultiTokenKMS")]
    public partial class BurnMultiTokenKMS : IEquatable<BurnMultiTokenKMS>, IValidatableObject
    {
        /// <summary>
        /// Chain to work with.
        /// </summary>
        /// <value>Chain to work with.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChainEnum
        {
            /// <summary>
            /// Enum ETH for value: ETH
            /// </summary>
            [EnumMember(Value = "ETH")]
            ETH = 1,

            /// <summary>
            /// Enum ONE for value: ONE
            /// </summary>
            [EnumMember(Value = "ONE")]
            ONE = 2,

            /// <summary>
            /// Enum MATIC for value: MATIC
            /// </summary>
            [EnumMember(Value = "MATIC")]
            MATIC = 3,

            /// <summary>
            /// Enum BSC for value: BSC
            /// </summary>
            [EnumMember(Value = "BSC")]
            BSC = 4

        }


        /// <summary>
        /// Chain to work with.
        /// </summary>
        /// <value>Chain to work with.</value>
        [DataMember(Name = "chain", IsRequired = true, EmitDefaultValue = true)]
        public ChainEnum Chain { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BurnMultiTokenKMS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BurnMultiTokenKMS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BurnMultiTokenKMS" /> class.
        /// </summary>
        /// <param name="chain">Chain to work with. (required).</param>
        /// <param name="account">Address of holder (required).</param>
        /// <param name="tokenId">ID of token to be destroyed. (required).</param>
        /// <param name="amount">amount of token to be destroyed. (required).</param>
        /// <param name="data">Data in bytes.</param>
        /// <param name="contractAddress">Address of Multi Token token (required).</param>
        /// <param name="index">If signatureId is mnemonic-based, this is the index to the specific address from that mnemonic..</param>
        /// <param name="signatureId">Identifier of the private key associated in signing application. Private key, or signature Id must be present. (required).</param>
        /// <param name="nonce">Nonce to be set to transaction. If not present, last known nonce will be used..</param>
        /// <param name="fee">fee.</param>
        public BurnMultiTokenKMS(ChainEnum chain = default(ChainEnum), string account = default(string), string tokenId = default(string), string amount = default(string), string data = default(string), string contractAddress = default(string), decimal index = default(decimal), Guid signatureId = default(Guid), decimal nonce = default(decimal), CustomFee fee = default(CustomFee))
        {
            this.Chain = chain;
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new ArgumentNullException("account is a required property for BurnMultiTokenKMS and cannot be null");
            }
            this.Account = account;
            // to ensure "tokenId" is required (not null)
            if (tokenId == null)
            {
                throw new ArgumentNullException("tokenId is a required property for BurnMultiTokenKMS and cannot be null");
            }
            this.TokenId = tokenId;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for BurnMultiTokenKMS and cannot be null");
            }
            this.Amount = amount;
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for BurnMultiTokenKMS and cannot be null");
            }
            this.ContractAddress = contractAddress;
            this.SignatureId = signatureId;
            this.Data = data;
            this.Index = index;
            this.Nonce = nonce;
            this.Fee = fee;
        }


        /// <summary>
        /// Address of holder
        /// </summary>
        /// <value>Address of holder</value>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = true)]
        public string Account { get; set; }

        /// <summary>
        /// ID of token to be destroyed.
        /// </summary>
        /// <value>ID of token to be destroyed.</value>
        [DataMember(Name = "tokenId", IsRequired = true, EmitDefaultValue = true)]
        public string TokenId { get; set; }

        /// <summary>
        /// amount of token to be destroyed.
        /// </summary>
        /// <value>amount of token to be destroyed.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Data in bytes
        /// </summary>
        /// <value>Data in bytes</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// Address of Multi Token token
        /// </summary>
        /// <value>Address of Multi Token token</value>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = true)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// If signatureId is mnemonic-based, this is the index to the specific address from that mnemonic.
        /// </summary>
        /// <value>If signatureId is mnemonic-based, this is the index to the specific address from that mnemonic.</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public decimal Index { get; set; }

        /// <summary>
        /// Identifier of the private key associated in signing application. Private key, or signature Id must be present.
        /// </summary>
        /// <value>Identifier of the private key associated in signing application. Private key, or signature Id must be present.</value>
        [DataMember(Name = "signatureId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SignatureId { get; set; }

        /// <summary>
        /// Nonce to be set to transaction. If not present, last known nonce will be used.
        /// </summary>
        /// <value>Nonce to be set to transaction. If not present, last known nonce will be used.</value>
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
            sb.Append("class BurnMultiTokenKMS {\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  SignatureId: ").Append(SignatureId).Append("\n");
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
            return this.Equals(input as BurnMultiTokenKMS);
        }

        /// <summary>
        /// Returns true if BurnMultiTokenKMS instances are equal
        /// </summary>
        /// <param name="input">Instance of BurnMultiTokenKMS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BurnMultiTokenKMS input)
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
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.SignatureId == input.SignatureId ||
                    (this.SignatureId != null &&
                    this.SignatureId.Equals(input.SignatureId))
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
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                if (this.SignatureId != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureId.GetHashCode();
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
            // Account (string) maxLength
            if (this.Account != null && this.Account.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Account, length must be less than 42.", new [] { "Account" });
            }

            // Account (string) minLength
            if (this.Account != null && this.Account.Length < 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Account, length must be greater than 42.", new [] { "Account" });
            }

            // TokenId (string) maxLength
            if (this.TokenId != null && this.TokenId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TokenId, length must be less than 32.", new [] { "TokenId" });
            }

            // Amount (string) maxLength
            if (this.Amount != null && this.Amount.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, length must be less than 32.", new [] { "Amount" });
            }

            // ContractAddress (string) maxLength
            if (this.ContractAddress != null && this.ContractAddress.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractAddress, length must be less than 42.", new [] { "ContractAddress" });
            }

            // ContractAddress (string) minLength
            if (this.ContractAddress != null && this.ContractAddress.Length < 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractAddress, length must be greater than 42.", new [] { "ContractAddress" });
            }

            // Index (decimal) minimum
            if (this.Index < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Index, must be a value greater than or equal to 0.", new [] { "Index" });
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
