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
    /// MultiTx
    /// </summary>
    [DataContract(Name = "MultiTx")]
    public partial class MultiTx : IEquatable<MultiTx>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiTx" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MultiTx() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiTx" /> class.
        /// </summary>
        /// <param name="blockNumber">Block number (required).</param>
        /// <param name="txId">Transaction ID (required).</param>
        /// <param name="contractAddress">Contract address (required).</param>
        /// <param name="tokenId">ID of the token (required).</param>
        /// <param name="amount">Amount of tokens transferred. (required).</param>
        /// <param name="from">Sender (required).</param>
        /// <param name="_operator">Operator (required).</param>
        /// <param name="to">recipient (required).</param>
        public MultiTx(decimal blockNumber = default(decimal), string txId = default(string), string contractAddress = default(string), string tokenId = default(string), string amount = default(string), string from = default(string), string _operator = default(string), string to = default(string))
        {
            this.BlockNumber = blockNumber;
            // to ensure "txId" is required (not null)
            if (txId == null)
            {
                throw new ArgumentNullException("txId is a required property for MultiTx and cannot be null");
            }
            this.TxId = txId;
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for MultiTx and cannot be null");
            }
            this.ContractAddress = contractAddress;
            // to ensure "tokenId" is required (not null)
            if (tokenId == null)
            {
                throw new ArgumentNullException("tokenId is a required property for MultiTx and cannot be null");
            }
            this.TokenId = tokenId;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for MultiTx and cannot be null");
            }
            this.Amount = amount;
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new ArgumentNullException("from is a required property for MultiTx and cannot be null");
            }
            this.From = from;
            // to ensure "_operator" is required (not null)
            if (_operator == null)
            {
                throw new ArgumentNullException("_operator is a required property for MultiTx and cannot be null");
            }
            this.Operator = _operator;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for MultiTx and cannot be null");
            }
            this.To = to;
        }


        /// <summary>
        /// Block number
        /// </summary>
        /// <value>Block number</value>
        [DataMember(Name = "blockNumber", IsRequired = true, EmitDefaultValue = true)]
        public decimal BlockNumber { get; set; }

        /// <summary>
        /// Transaction ID
        /// </summary>
        /// <value>Transaction ID</value>
        [DataMember(Name = "txId", IsRequired = true, EmitDefaultValue = true)]
        public string TxId { get; set; }

        /// <summary>
        /// Contract address
        /// </summary>
        /// <value>Contract address</value>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = true)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// ID of the token
        /// </summary>
        /// <value>ID of the token</value>
        [DataMember(Name = "tokenId", IsRequired = true, EmitDefaultValue = true)]
        public string TokenId { get; set; }

        /// <summary>
        /// Amount of tokens transferred.
        /// </summary>
        /// <value>Amount of tokens transferred.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Sender
        /// </summary>
        /// <value>Sender</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Operator
        /// </summary>
        /// <value>Operator</value>
        [DataMember(Name = "operator", IsRequired = true, EmitDefaultValue = true)]
        public string Operator { get; set; }

        /// <summary>
        /// recipient
        /// </summary>
        /// <value>recipient</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MultiTx {\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  TxId: ").Append(TxId).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(input as MultiTx);
        }

        /// <summary>
        /// Returns true if MultiTx instances are equal
        /// </summary>
        /// <param name="input">Instance of MultiTx to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiTx input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BlockNumber == input.BlockNumber ||
                    this.BlockNumber.Equals(input.BlockNumber)
                ) && 
                (
                    this.TxId == input.TxId ||
                    (this.TxId != null &&
                    this.TxId.Equals(input.TxId))
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
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
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
                hashCode = (hashCode * 59) + this.BlockNumber.GetHashCode();
                if (this.TxId != null)
                {
                    hashCode = (hashCode * 59) + this.TxId.GetHashCode();
                }
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.Operator != null)
                {
                    hashCode = (hashCode * 59) + this.Operator.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
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
            yield break;
        }
    }

}