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
    /// AddNftMinterKMS
    /// </summary>
    [DataContract(Name = "AddNftMinterKMS")]
    public partial class AddNftMinterKMS : IEquatable<AddNftMinterKMS>, IValidatableObject
    {
        /// <summary>
        /// The blockchain to work with
        /// </summary>
        /// <value>The blockchain to work with</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChainEnum
        {
            /// <summary>
            /// Enum BSC for value: BSC
            /// </summary>
            [EnumMember(Value = "BSC")]
            BSC = 1,

            /// <summary>
            /// Enum CELO for value: CELO
            /// </summary>
            [EnumMember(Value = "CELO")]
            CELO = 2,

            /// <summary>
            /// Enum ETH for value: ETH
            /// </summary>
            [EnumMember(Value = "ETH")]
            ETH = 3,

            /// <summary>
            /// Enum KLAY for value: KLAY
            /// </summary>
            [EnumMember(Value = "KLAY")]
            KLAY = 4,

            /// <summary>
            /// Enum KCS for value: KCS
            /// </summary>
            [EnumMember(Value = "KCS")]
            KCS = 5,

            /// <summary>
            /// Enum MATIC for value: MATIC
            /// </summary>
            [EnumMember(Value = "MATIC")]
            MATIC = 6,

            /// <summary>
            /// Enum ONE for value: ONE
            /// </summary>
            [EnumMember(Value = "ONE")]
            ONE = 7

        }


        /// <summary>
        /// The blockchain to work with
        /// </summary>
        /// <value>The blockchain to work with</value>
        [DataMember(Name = "chain", IsRequired = true, EmitDefaultValue = true)]
        public ChainEnum Chain { get; set; }
        /// <summary>
        /// (Celo only) The currency in which the transaction fee will be paid
        /// </summary>
        /// <value>(Celo only) The currency in which the transaction fee will be paid</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FeeCurrencyEnum
        {
            /// <summary>
            /// Enum CELO for value: CELO
            /// </summary>
            [EnumMember(Value = "CELO")]
            CELO = 1,

            /// <summary>
            /// Enum CUSD for value: CUSD
            /// </summary>
            [EnumMember(Value = "CUSD")]
            CUSD = 2,

            /// <summary>
            /// Enum CEUR for value: CEUR
            /// </summary>
            [EnumMember(Value = "CEUR")]
            CEUR = 3

        }


        /// <summary>
        /// (Celo only) The currency in which the transaction fee will be paid
        /// </summary>
        /// <value>(Celo only) The currency in which the transaction fee will be paid</value>
        [DataMember(Name = "feeCurrency", EmitDefaultValue = false)]
        public FeeCurrencyEnum? FeeCurrency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddNftMinterKMS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddNftMinterKMS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddNftMinterKMS" /> class.
        /// </summary>
        /// <param name="chain">The blockchain to work with (required).</param>
        /// <param name="contractAddress">The blockchain address of the NFT smart contract (required).</param>
        /// <param name="minter">The blockchain address to add to the smart contract as an NFT minter (required).</param>
        /// <param name="signatureId">The KMS identifier of the private key of the blockchain address from which the fee will be deducted (required).</param>
        /// <param name="index">(Only if the signature ID is mnemonic-based) The index of the address to pay the transaction fee that was generated from the mnemonic.</param>
        /// <param name="nonce">The nonce to be set to the transaction; if not present, the last known nonce will be used.</param>
        /// <param name="fee">fee.</param>
        /// <param name="feeCurrency">(Celo only) The currency in which the transaction fee will be paid.</param>
        public AddNftMinterKMS(ChainEnum chain = default(ChainEnum), string contractAddress = default(string), string minter = default(string), Guid signatureId = default(Guid), decimal index = default(decimal), decimal nonce = default(decimal), CustomFee fee = default(CustomFee), FeeCurrencyEnum? feeCurrency = default(FeeCurrencyEnum?))
        {
            this.Chain = chain;
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for AddNftMinterKMS and cannot be null");
            }
            this.ContractAddress = contractAddress;
            // to ensure "minter" is required (not null)
            if (minter == null)
            {
                throw new ArgumentNullException("minter is a required property for AddNftMinterKMS and cannot be null");
            }
            this.Minter = minter;
            this.SignatureId = signatureId;
            this.Index = index;
            this.Nonce = nonce;
            this.Fee = fee;
            this.FeeCurrency = feeCurrency;
        }

        /// <summary>
        /// The blockchain address of the NFT smart contract
        /// </summary>
        /// <value>The blockchain address of the NFT smart contract</value>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = true)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// The blockchain address to add to the smart contract as an NFT minter
        /// </summary>
        /// <value>The blockchain address to add to the smart contract as an NFT minter</value>
        [DataMember(Name = "minter", IsRequired = true, EmitDefaultValue = true)]
        public string Minter { get; set; }

        /// <summary>
        /// The KMS identifier of the private key of the blockchain address from which the fee will be deducted
        /// </summary>
        /// <value>The KMS identifier of the private key of the blockchain address from which the fee will be deducted</value>
        [DataMember(Name = "signatureId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SignatureId { get; set; }

        /// <summary>
        /// (Only if the signature ID is mnemonic-based) The index of the address to pay the transaction fee that was generated from the mnemonic
        /// </summary>
        /// <value>(Only if the signature ID is mnemonic-based) The index of the address to pay the transaction fee that was generated from the mnemonic</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public decimal Index { get; set; }

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
            sb.Append("class AddNftMinterKMS {\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  Minter: ").Append(Minter).Append("\n");
            sb.Append("  SignatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  FeeCurrency: ").Append(FeeCurrency).Append("\n");
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
            return this.Equals(input as AddNftMinterKMS);
        }

        /// <summary>
        /// Returns true if AddNftMinterKMS instances are equal
        /// </summary>
        /// <param name="input">Instance of AddNftMinterKMS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddNftMinterKMS input)
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
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                ) && 
                (
                    this.Minter == input.Minter ||
                    (this.Minter != null &&
                    this.Minter.Equals(input.Minter))
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
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.FeeCurrency == input.FeeCurrency ||
                    this.FeeCurrency.Equals(input.FeeCurrency)
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
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                if (this.Minter != null)
                {
                    hashCode = (hashCode * 59) + this.Minter.GetHashCode();
                }
                if (this.SignatureId != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FeeCurrency.GetHashCode();
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

            // Minter (string) maxLength
            if (this.Minter != null && this.Minter.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Minter, length must be less than 42.", new [] { "Minter" });
            }

            // Minter (string) minLength
            if (this.Minter != null && this.Minter.Length < 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Minter, length must be greater than 42.", new [] { "Minter" });
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
