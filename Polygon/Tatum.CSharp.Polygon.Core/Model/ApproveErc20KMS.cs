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
using FileParameter = Tatum.CSharp.Polygon.Core.Client.FileParameter;
using OpenAPIDateConverter = Tatum.CSharp.Polygon.Core.Client.OpenAPIDateConverter;

namespace Tatum.CSharp.Polygon.Core.Model
{
    /// <summary>
    /// ApproveErc20KMS
    /// </summary>
    [DataContract(Name = "ApproveErc20KMS")]
    public partial class ApproveErc20KMS : IEquatable<ApproveErc20KMS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveErc20KMS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApproveErc20KMS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApproveErc20KMS" /> class.
        /// </summary>
        /// <param name="contractAddress">The address of the smart contract (required).</param>
        /// <param name="spender">The blockchain address to be allowed to transfer or burn the fungible tokens (required).</param>
        /// <param name="amount">The amount of the tokens allowed to be transferred or burnt (required).</param>
        /// <param name="signatureId">The KMS identifier of the private key of the smart contract&#39;s owner; the fee will be deducted from the owner&#39;s address (required).</param>
        /// <param name="fee">fee.</param>
        /// <param name="nonce">The nonce to be set to the transaction; if not present, the last known nonce will be used.</param>
        public ApproveErc20KMS(string contractAddress = default(string), string spender = default(string), string amount = default(string), Guid signatureId = default(Guid), CustomFee fee = default(CustomFee), decimal nonce = default(decimal))
        {
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for ApproveErc20KMS and cannot be null");
            }
            this.ContractAddress = contractAddress;
            // to ensure "spender" is required (not null)
            if (spender == null)
            {
                throw new ArgumentNullException("spender is a required property for ApproveErc20KMS and cannot be null");
            }
            this.Spender = spender;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for ApproveErc20KMS and cannot be null");
            }
            this.Amount = amount;
            this.SignatureId = signatureId;
            this.Fee = fee;
            this.Nonce = nonce;
        }

        /// <summary>
        /// The blockchain to work with
        /// </summary>
        /// <value>The blockchain to work with</value>
        [DataMember(Name = "chain", IsRequired = true, EmitDefaultValue = true)]
        public string Chain { get; } = "MATIC";


        /// <summary>
        /// The address of the smart contract
        /// </summary>
        /// <value>The address of the smart contract</value>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = true)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// The blockchain address to be allowed to transfer or burn the fungible tokens
        /// </summary>
        /// <value>The blockchain address to be allowed to transfer or burn the fungible tokens</value>
        [DataMember(Name = "spender", IsRequired = true, EmitDefaultValue = true)]
        public string Spender { get; set; }

        /// <summary>
        /// The amount of the tokens allowed to be transferred or burnt
        /// </summary>
        /// <value>The amount of the tokens allowed to be transferred or burnt</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// The KMS identifier of the private key of the smart contract&#39;s owner; the fee will be deducted from the owner&#39;s address
        /// </summary>
        /// <value>The KMS identifier of the private key of the smart contract&#39;s owner; the fee will be deducted from the owner&#39;s address</value>
        [DataMember(Name = "signatureId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SignatureId { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public CustomFee Fee { get; set; }

        /// <summary>
        /// The nonce to be set to the transaction; if not present, the last known nonce will be used
        /// </summary>
        /// <value>The nonce to be set to the transaction; if not present, the last known nonce will be used</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        public decimal Nonce { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApproveErc20KMS {\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  Spender: ").Append(Spender).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  SignatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
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
            return this.Equals(input as ApproveErc20KMS);
        }

        /// <summary>
        /// Returns true if ApproveErc20KMS instances are equal
        /// </summary>
        /// <param name="input">Instance of ApproveErc20KMS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApproveErc20KMS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                ) && 
                (
                    this.Spender == input.Spender ||
                    (this.Spender != null &&
                    this.Spender.Equals(input.Spender))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.SignatureId == input.SignatureId ||
                    (this.SignatureId != null &&
                    this.SignatureId.Equals(input.SignatureId))
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
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
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                if (this.Spender != null)
                {
                    hashCode = (hashCode * 59) + this.Spender.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.SignatureId != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureId.GetHashCode();
                }
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
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
            if (this.ContractAddress != null && this.ContractAddress.Length > 43)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractAddress, length must be less than 43.", new [] { "ContractAddress" });
            }

            // ContractAddress (string) minLength
            if (this.ContractAddress != null && this.ContractAddress.Length < 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractAddress, length must be greater than 42.", new [] { "ContractAddress" });
            }

            // Spender (string) maxLength
            if (this.Spender != null && this.Spender.Length > 43)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Spender, length must be less than 43.", new [] { "Spender" });
            }

            // Spender (string) minLength
            if (this.Spender != null && this.Spender.Length < 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Spender, length must be greater than 42.", new [] { "Spender" });
            }

            // Amount (string) pattern
            Regex regexAmount = new Regex(@"^[+]?((\\d+(\\.\\d*)?)|(\\.\\d+))$", RegexOptions.CultureInvariant);
            if (false == regexAmount.Match(this.Amount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must match a pattern of " + regexAmount, new [] { "Amount" });
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
