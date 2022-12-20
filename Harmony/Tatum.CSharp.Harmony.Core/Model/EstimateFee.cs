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
using FileParameter = Tatum.CSharp.Harmony.Core.Client.FileParameter;
using OpenAPIDateConverter = Tatum.CSharp.Harmony.Core.Client.OpenAPIDateConverter;

namespace Tatum.CSharp.Harmony.Core.Model
{
    /// <summary>
    /// EstimateFee
    /// </summary>
    [DataContract(Name = "EstimateFee")]
    public partial class EstimateFee : IEquatable<EstimateFee>, IValidatableObject
    {
        /// <summary>
        /// Type of transaction
        /// </summary>
        /// <value>Type of transaction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum DEPLOYERC20 for value: DEPLOY_ERC20
            /// </summary>
            [EnumMember(Value = "DEPLOY_ERC20")]
            DEPLOYERC20 = 1,

            /// <summary>
            /// Enum DEPLOYNFT for value: DEPLOY_NFT
            /// </summary>
            [EnumMember(Value = "DEPLOY_NFT")]
            DEPLOYNFT = 2,

            /// <summary>
            /// Enum MINTNFT for value: MINT_NFT
            /// </summary>
            [EnumMember(Value = "MINT_NFT")]
            MINTNFT = 3,

            /// <summary>
            /// Enum BURNNFT for value: BURN_NFT
            /// </summary>
            [EnumMember(Value = "BURN_NFT")]
            BURNNFT = 4,

            /// <summary>
            /// Enum TRANSFERNFT for value: TRANSFER_NFT
            /// </summary>
            [EnumMember(Value = "TRANSFER_NFT")]
            TRANSFERNFT = 5,

            /// <summary>
            /// Enum TRANSFERERC20 for value: TRANSFER_ERC20
            /// </summary>
            [EnumMember(Value = "TRANSFER_ERC20")]
            TRANSFERERC20 = 6,

            /// <summary>
            /// Enum DEPLOYAUCTION for value: DEPLOY_AUCTION
            /// </summary>
            [EnumMember(Value = "DEPLOY_AUCTION")]
            DEPLOYAUCTION = 7,

            /// <summary>
            /// Enum DEPLOYMARKETPLACE for value: DEPLOY_MARKETPLACE
            /// </summary>
            [EnumMember(Value = "DEPLOY_MARKETPLACE")]
            DEPLOYMARKETPLACE = 8

        }


        /// <summary>
        /// Type of transaction
        /// </summary>
        /// <value>Type of transaction</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateFee" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EstimateFee() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateFee" /> class.
        /// </summary>
        /// <param name="type">Type of transaction (required).</param>
        /// <param name="sender">Sender address, if type is TRANSFER_ERC20.</param>
        /// <param name="recipient">Blockchain address to send assets, if type is TRANSFER_ERC20.</param>
        /// <param name="contractAddress">Contract address of ERC20 token, if type is TRANSFER_ERC20.</param>
        /// <param name="amount">Amount to be sent in ERC20, if type is TRANSFER_ERC20.</param>
        public EstimateFee(TypeEnum type = default(TypeEnum), string sender = default(string), string recipient = default(string), string contractAddress = default(string), string amount = default(string))
        {
            this.Type = type;
            this.Sender = sender;
            this.Recipient = recipient;
            this.ContractAddress = contractAddress;
            this.Amount = amount;
        }

        /// <summary>
        /// Blockchain to estimate fee for.
        /// </summary>
        /// <value>Blockchain to estimate fee for.</value>
        [DataMember(Name = "chain", IsRequired = true, EmitDefaultValue = true)]
        public string Chain { get; } = "ONE";


        /// <summary>
        /// Sender address, if type is TRANSFER_ERC20
        /// </summary>
        /// <value>Sender address, if type is TRANSFER_ERC20</value>
        [DataMember(Name = "sender", EmitDefaultValue = false)]
        public string Sender { get; set; }

        /// <summary>
        /// Blockchain address to send assets, if type is TRANSFER_ERC20
        /// </summary>
        /// <value>Blockchain address to send assets, if type is TRANSFER_ERC20</value>
        [DataMember(Name = "recipient", EmitDefaultValue = false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Contract address of ERC20 token, if type is TRANSFER_ERC20
        /// </summary>
        /// <value>Contract address of ERC20 token, if type is TRANSFER_ERC20</value>
        [DataMember(Name = "contractAddress", EmitDefaultValue = false)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// Amount to be sent in ERC20, if type is TRANSFER_ERC20
        /// </summary>
        /// <value>Amount to be sent in ERC20, if type is TRANSFER_ERC20</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EstimateFee {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as EstimateFee);
        }

        /// <summary>
        /// Returns true if EstimateFee instances are equal
        /// </summary>
        /// <param name="input">Instance of EstimateFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstimateFee input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Sender != null)
                {
                    hashCode = (hashCode * 59) + this.Sender.GetHashCode();
                }
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
                }
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
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
            // Sender (string) maxLength
            if (this.Sender != null && this.Sender.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sender, length must be less than 42.", new [] { "Sender" });
            }

            // Sender (string) minLength
            if (this.Sender != null && this.Sender.Length < 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Sender, length must be greater than 42.", new [] { "Sender" });
            }

            // Recipient (string) maxLength
            if (this.Recipient != null && this.Recipient.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Recipient, length must be less than 42.", new [] { "Recipient" });
            }

            // Recipient (string) minLength
            if (this.Recipient != null && this.Recipient.Length < 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Recipient, length must be greater than 42.", new [] { "Recipient" });
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

            // Amount (string) pattern
            Regex regexAmount = new Regex(@"^[+]?((\\d+(\\.\\d*)?)|(\\.\\d+))$", RegexOptions.CultureInvariant);
            if (false == regexAmount.Match(this.Amount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must match a pattern of " + regexAmount, new [] { "Amount" });
            }

            yield break;
        }
    }

}