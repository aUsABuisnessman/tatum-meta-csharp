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
using FileParameter = Tatum.CSharp.Ethereum.Core.Client.FileParameter;
using OpenAPIDateConverter = Tatum.CSharp.Ethereum.Core.Client.OpenAPIDateConverter;

namespace Tatum.CSharp.Ethereum.Core.Model
{
    /// <summary>
    /// ChainTransferEthErc20
    /// </summary>
    [DataContract(Name = "ChainTransferEthErc20")]
    public partial class ChainTransferEthErc20 : IEquatable<ChainTransferEthErc20>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChainTransferEthErc20" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChainTransferEthErc20() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChainTransferEthErc20" /> class.
        /// </summary>
        /// <param name="to">The blockchain address to send the fungible tokens to (required).</param>
        /// <param name="contractAddress">The blockchain address of the fungible token smart contract (required).</param>
        /// <param name="amount">The amount of the fungible tokens to be sent (required).</param>
        /// <param name="digits">The number of decimal places that the fungible tokens have; to find out how many decimal places are used in the fungible tokens, check out the &lt;a href&#x3D;\&quot;https://apidoc.tatum.io/tag/Blockchain-utils#operation/SCGetContractAddress\&quot; target&#x3D;\&quot;_blank\&quot;&gt;smart contract&lt;/a&gt; (required).</param>
        /// <param name="fromPrivateKey">The private key of the blockchain address from which the fee will be deducted (required).</param>
        /// <param name="nonce">The nonce to be set to the transaction; if not present, the last known nonce will be used.</param>
        /// <param name="fee">fee.</param>
        public ChainTransferEthErc20(string to = default(string), string contractAddress = default(string), string amount = default(string), decimal digits = default(decimal), string fromPrivateKey = default(string), decimal nonce = default(decimal), CustomFee fee = default(CustomFee))
        {
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for ChainTransferEthErc20 and cannot be null");
            }
            this.To = to;
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for ChainTransferEthErc20 and cannot be null");
            }
            this.ContractAddress = contractAddress;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for ChainTransferEthErc20 and cannot be null");
            }
            this.Amount = amount;
            this.Digits = digits;
            // to ensure "fromPrivateKey" is required (not null)
            if (fromPrivateKey == null)
            {
                throw new ArgumentNullException("fromPrivateKey is a required property for ChainTransferEthErc20 and cannot be null");
            }
            this.FromPrivateKey = fromPrivateKey;
            this.Nonce = nonce;
            this.Fee = fee;
        }

        /// <summary>
        /// The blockchain to work with
        /// </summary>
        /// <value>The blockchain to work with</value>
        [DataMember(Name = "chain", IsRequired = true, EmitDefaultValue = true)]
        public string Chain { get; } = "ETH";


        /// <summary>
        /// The blockchain address to send the fungible tokens to
        /// </summary>
        /// <value>The blockchain address to send the fungible tokens to</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// The blockchain address of the fungible token smart contract
        /// </summary>
        /// <value>The blockchain address of the fungible token smart contract</value>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = true)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// The amount of the fungible tokens to be sent
        /// </summary>
        /// <value>The amount of the fungible tokens to be sent</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// The number of decimal places that the fungible tokens have; to find out how many decimal places are used in the fungible tokens, check out the &lt;a href&#x3D;\&quot;https://apidoc.tatum.io/tag/Blockchain-utils#operation/SCGetContractAddress\&quot; target&#x3D;\&quot;_blank\&quot;&gt;smart contract&lt;/a&gt;
        /// </summary>
        /// <value>The number of decimal places that the fungible tokens have; to find out how many decimal places are used in the fungible tokens, check out the &lt;a href&#x3D;\&quot;https://apidoc.tatum.io/tag/Blockchain-utils#operation/SCGetContractAddress\&quot; target&#x3D;\&quot;_blank\&quot;&gt;smart contract&lt;/a&gt;</value>
        [DataMember(Name = "digits", IsRequired = true, EmitDefaultValue = true)]
        public decimal Digits { get; set; }

        /// <summary>
        /// The private key of the blockchain address from which the fee will be deducted
        /// </summary>
        /// <value>The private key of the blockchain address from which the fee will be deducted</value>
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
            sb.Append("class ChainTransferEthErc20 {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Digits: ").Append(Digits).Append("\n");
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
            return this.Equals(input as ChainTransferEthErc20);
        }

        /// <summary>
        /// Returns true if ChainTransferEthErc20 instances are equal
        /// </summary>
        /// <param name="input">Instance of ChainTransferEthErc20 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChainTransferEthErc20 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
            if (this.To != null && this.To.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be less than 50.", new [] { "To" });
            }

            // To (string) minLength
            if (this.To != null && this.To.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be greater than 1.", new [] { "To" });
            }

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
            if (this.Digits < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Digits, must be a value greater than or equal to 1.", new [] { "Digits" });
            }

            // FromPrivateKey (string) maxLength
            if (this.FromPrivateKey != null && this.FromPrivateKey.Length > 66)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FromPrivateKey, length must be less than 66.", new [] { "FromPrivateKey" });
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
