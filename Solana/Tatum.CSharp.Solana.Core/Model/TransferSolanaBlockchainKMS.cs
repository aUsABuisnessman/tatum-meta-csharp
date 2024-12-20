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
using FileParameter = Tatum.CSharp.Solana.Core.Client.FileParameter;
using OpenAPIDateConverter = Tatum.CSharp.Solana.Core.Client.OpenAPIDateConverter;

namespace Tatum.CSharp.Solana.Core.Model
{
    /// <summary>
    /// TransferSolanaBlockchainKMS
    /// </summary>
    [DataContract(Name = "TransferSolanaBlockchainKMS")]
    public partial class TransferSolanaBlockchainKMS : IEquatable<TransferSolanaBlockchainKMS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferSolanaBlockchainKMS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferSolanaBlockchainKMS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferSolanaBlockchainKMS" /> class.
        /// </summary>
        /// <param name="from">Blockchain address to send assets from (required).</param>
        /// <param name="to">Blockchain address to send assets to (required).</param>
        /// <param name="amount">Amount to be sent in SOL. (required).</param>
        /// <param name="signatureId">Identifier of the private key associated in signing application. Private key, or signature Id must be present. (required).</param>
        /// <param name="feePayer">Blockchain address to pay the fee for the transaction from.</param>
        /// <param name="feePayerSignatureId">Identifier of the private key used for paying the gas costs in signing application. Defaults to the signatureId..</param>
        public TransferSolanaBlockchainKMS(string from = default(string), string to = default(string), string amount = default(string), Guid signatureId = default(Guid), string feePayer = default(string), Guid feePayerSignatureId = default(Guid))
        {
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new ArgumentNullException("from is a required property for TransferSolanaBlockchainKMS and cannot be null");
            }
            this.From = from;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for TransferSolanaBlockchainKMS and cannot be null");
            }
            this.To = to;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for TransferSolanaBlockchainKMS and cannot be null");
            }
            this.Amount = amount;
            this.SignatureId = signatureId;
            this.FeePayer = feePayer;
            this.FeePayerSignatureId = feePayerSignatureId;
        }


        /// <summary>
        /// Blockchain address to send assets from
        /// </summary>
        /// <value>Blockchain address to send assets from</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Blockchain address to send assets to
        /// </summary>
        /// <value>Blockchain address to send assets to</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// Amount to be sent in SOL.
        /// </summary>
        /// <value>Amount to be sent in SOL.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Identifier of the private key associated in signing application. Private key, or signature Id must be present.
        /// </summary>
        /// <value>Identifier of the private key associated in signing application. Private key, or signature Id must be present.</value>
        [DataMember(Name = "signatureId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SignatureId { get; set; }

        /// <summary>
        /// Blockchain address to pay the fee for the transaction from
        /// </summary>
        /// <value>Blockchain address to pay the fee for the transaction from</value>
        [DataMember(Name = "feePayer", EmitDefaultValue = false)]
        public string FeePayer { get; set; }

        /// <summary>
        /// Identifier of the private key used for paying the gas costs in signing application. Defaults to the signatureId.
        /// </summary>
        /// <value>Identifier of the private key used for paying the gas costs in signing application. Defaults to the signatureId.</value>
        [DataMember(Name = "feePayerSignatureId", EmitDefaultValue = false)]
        public Guid FeePayerSignatureId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferSolanaBlockchainKMS {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as TransferSolanaBlockchainKMS);
        }

        /// <summary>
        /// Returns true if TransferSolanaBlockchainKMS instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferSolanaBlockchainKMS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferSolanaBlockchainKMS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
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
            if (this.To != null && this.To.Length > 44)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be less than 44.", new [] { "To" });
            }

            // To (string) minLength
            if (this.To != null && this.To.Length < 43)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be greater than 43.", new [] { "To" });
            }

            // Amount (string) pattern
            Regex regexAmount = new Regex(@"^[+]?((\\d+(\\.\\d*)?)|(\\.\\d+))$", RegexOptions.CultureInvariant);
            if (false == regexAmount.Match(this.Amount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must match a pattern of " + regexAmount, new [] { "Amount" });
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
