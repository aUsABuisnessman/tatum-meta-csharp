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
    /// ChainTransferSolanaSplKMS
    /// </summary>
    [DataContract(Name = "ChainTransferSolanaSplKMS")]
    public partial class ChainTransferSolanaSplKMS : IEquatable<ChainTransferSolanaSplKMS>, IValidatableObject
    {
        /// <summary>
        /// The blockchain to work with
        /// </summary>
        /// <value>The blockchain to work with</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChainEnum
        {
            /// <summary>
            /// Enum SOL for value: SOL
            /// </summary>
            [EnumMember(Value = "SOL")]
            SOL = 1

        }


        /// <summary>
        /// The blockchain to work with
        /// </summary>
        /// <value>The blockchain to work with</value>
        [DataMember(Name = "chain", IsRequired = true, EmitDefaultValue = true)]
        public ChainEnum Chain { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChainTransferSolanaSplKMS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChainTransferSolanaSplKMS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChainTransferSolanaSplKMS" /> class.
        /// </summary>
        /// <param name="chain">The blockchain to work with (required).</param>
        /// <param name="from">The blockchain address to send the fungible tokens from (required).</param>
        /// <param name="to">The blockchain address to send the fungible tokens to (required).</param>
        /// <param name="contractAddress">The blockchain address of the fungible tokens (required).</param>
        /// <param name="amount">The amount of the fungible tokens to be sent (required).</param>
        /// <param name="digits">The number of decimal places that the fungible tokens have (required).</param>
        /// <param name="signatureId">The KMS identifier of the private key of the blockchain address that you are sending the fungible tokens from (the address that you specified in the &lt;code&gt;from&lt;/code&gt; parameter); the transaction fee will be deducted from this address (required).</param>
        /// <param name="feePayer">The blockchain address from which the fee will be deducted; if not set, defaults to the address that you specified in the &lt;code&gt;from&lt;/code&gt; parameter.</param>
        /// <param name="feePayerSignatureId">The KMS identifier of the private key of the blockchain address that you specified in the &lt;code&gt;feePayer&lt;/code&gt; parameter; if not set, defaults to the signature ID that you specified in the &lt;code&gt;signatureId&lt;/code&gt; parameter.</param>
        public ChainTransferSolanaSplKMS(ChainEnum chain = default(ChainEnum), string from = default(string), string to = default(string), string contractAddress = default(string), string amount = default(string), decimal digits = default(decimal), Guid signatureId = default(Guid), string feePayer = default(string), Guid feePayerSignatureId = default(Guid))
        {
            this.Chain = chain;
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new ArgumentNullException("from is a required property for ChainTransferSolanaSplKMS and cannot be null");
            }
            this.From = from;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for ChainTransferSolanaSplKMS and cannot be null");
            }
            this.To = to;
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for ChainTransferSolanaSplKMS and cannot be null");
            }
            this.ContractAddress = contractAddress;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for ChainTransferSolanaSplKMS and cannot be null");
            }
            this.Amount = amount;
            this.Digits = digits;
            this.SignatureId = signatureId;
            this.FeePayer = feePayer;
            this.FeePayerSignatureId = feePayerSignatureId;
        }

        /// <summary>
        /// The blockchain address to send the fungible tokens from
        /// </summary>
        /// <value>The blockchain address to send the fungible tokens from</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// The blockchain address to send the fungible tokens to
        /// </summary>
        /// <value>The blockchain address to send the fungible tokens to</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// The blockchain address of the fungible tokens
        /// </summary>
        /// <value>The blockchain address of the fungible tokens</value>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = true)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// The amount of the fungible tokens to be sent
        /// </summary>
        /// <value>The amount of the fungible tokens to be sent</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// The number of decimal places that the fungible tokens have
        /// </summary>
        /// <value>The number of decimal places that the fungible tokens have</value>
        [DataMember(Name = "digits", IsRequired = true, EmitDefaultValue = true)]
        public decimal Digits { get; set; }

        /// <summary>
        /// The KMS identifier of the private key of the blockchain address that you are sending the fungible tokens from (the address that you specified in the &lt;code&gt;from&lt;/code&gt; parameter); the transaction fee will be deducted from this address
        /// </summary>
        /// <value>The KMS identifier of the private key of the blockchain address that you are sending the fungible tokens from (the address that you specified in the &lt;code&gt;from&lt;/code&gt; parameter); the transaction fee will be deducted from this address</value>
        [DataMember(Name = "signatureId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SignatureId { get; set; }

        /// <summary>
        /// The blockchain address from which the fee will be deducted; if not set, defaults to the address that you specified in the &lt;code&gt;from&lt;/code&gt; parameter
        /// </summary>
        /// <value>The blockchain address from which the fee will be deducted; if not set, defaults to the address that you specified in the &lt;code&gt;from&lt;/code&gt; parameter</value>
        [DataMember(Name = "feePayer", EmitDefaultValue = false)]
        public string FeePayer { get; set; }

        /// <summary>
        /// The KMS identifier of the private key of the blockchain address that you specified in the &lt;code&gt;feePayer&lt;/code&gt; parameter; if not set, defaults to the signature ID that you specified in the &lt;code&gt;signatureId&lt;/code&gt; parameter
        /// </summary>
        /// <value>The KMS identifier of the private key of the blockchain address that you specified in the &lt;code&gt;feePayer&lt;/code&gt; parameter; if not set, defaults to the signature ID that you specified in the &lt;code&gt;signatureId&lt;/code&gt; parameter</value>
        [DataMember(Name = "feePayerSignatureId", EmitDefaultValue = false)]
        public Guid FeePayerSignatureId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChainTransferSolanaSplKMS {\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Digits: ").Append(Digits).Append("\n");
            sb.Append("  SignatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  FeePayer: ").Append(FeePayer).Append("\n");
            sb.Append("  FeePayerSignatureId: ").Append(FeePayerSignatureId).Append("\n");
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
            return this.Equals(input as ChainTransferSolanaSplKMS);
        }

        /// <summary>
        /// Returns true if ChainTransferSolanaSplKMS instances are equal
        /// </summary>
        /// <param name="input">Instance of ChainTransferSolanaSplKMS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChainTransferSolanaSplKMS input)
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
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
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
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Digits == input.Digits ||
                    this.Digits.Equals(input.Digits)
                ) && 
                (
                    this.SignatureId == input.SignatureId ||
                    (this.SignatureId != null &&
                    this.SignatureId.Equals(input.SignatureId))
                ) && 
                (
                    this.FeePayer == input.FeePayer ||
                    (this.FeePayer != null &&
                    this.FeePayer.Equals(input.FeePayer))
                ) && 
                (
                    this.FeePayerSignatureId == input.FeePayerSignatureId ||
                    (this.FeePayerSignatureId != null &&
                    this.FeePayerSignatureId.Equals(input.FeePayerSignatureId))
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
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Digits.GetHashCode();
                if (this.SignatureId != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureId.GetHashCode();
                }
                if (this.FeePayer != null)
                {
                    hashCode = (hashCode * 59) + this.FeePayer.GetHashCode();
                }
                if (this.FeePayerSignatureId != null)
                {
                    hashCode = (hashCode * 59) + this.FeePayerSignatureId.GetHashCode();
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
            // From (string) maxLength
            if (this.From != null && this.From.Length > 44)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for From, length must be less than 44.", new [] { "From" });
            }

            // From (string) minLength
            if (this.From != null && this.From.Length < 43)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for From, length must be greater than 43.", new [] { "From" });
            }

            // To (string) maxLength
            if (this.To != null && this.To.Length > 43)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be less than 43.", new [] { "To" });
            }

            // To (string) minLength
            if (this.To != null && this.To.Length < 44)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be greater than 44.", new [] { "To" });
            }

            // ContractAddress (string) maxLength
            if (this.ContractAddress != null && this.ContractAddress.Length > 43)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractAddress, length must be less than 43.", new [] { "ContractAddress" });
            }

            // ContractAddress (string) minLength
            if (this.ContractAddress != null && this.ContractAddress.Length < 44)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractAddress, length must be greater than 44.", new [] { "ContractAddress" });
            }

            // Amount (string) pattern
            Regex regexAmount = new Regex(@"^[+]?((\\d+(\\.\\d*)?)|(\\.\\d+))$", RegexOptions.CultureInvariant);
            if (false == regexAmount.Match(this.Amount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must match a pattern of " + regexAmount, new [] { "Amount" });
            }

            // Digits (decimal) maximum
            if (this.Digits > (decimal)30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Digits, must be a value less than or equal to 30.", new [] { "Digits" });
            }

            // Digits (decimal) minimum
            if (this.Digits < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Digits, must be a value greater than or equal to 0.", new [] { "Digits" });
            }

            // FeePayer (string) maxLength
            if (this.FeePayer != null && this.FeePayer.Length > 44)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FeePayer, length must be less than 44.", new [] { "FeePayer" });
            }

            // FeePayer (string) minLength
            if (this.FeePayer != null && this.FeePayer.Length < 43)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FeePayer, length must be greater than 43.", new [] { "FeePayer" });
            }

            yield break;
        }
    }

}
