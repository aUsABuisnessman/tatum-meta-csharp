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
    /// TransferPolygonBlockchain
    /// </summary>
    [DataContract(Name = "TransferPolygonBlockchain")]
    public partial class TransferPolygonBlockchain : IEquatable<TransferPolygonBlockchain>, IValidatableObject
    {
        /// <summary>
        /// Currency to transfer from Polygon Blockchain Account. ERC20 tokens USDC and USDT are available only for mainnet use.
        /// </summary>
        /// <value>Currency to transfer from Polygon Blockchain Account. ERC20 tokens USDC and USDT are available only for mainnet use.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrencyEnum
        {
            /// <summary>
            /// Enum MATIC for value: MATIC
            /// </summary>
            [EnumMember(Value = "MATIC")]
            MATIC = 1,

            /// <summary>
            /// Enum USDCMATIC for value: USDC_MATIC
            /// </summary>
            [EnumMember(Value = "USDC_MATIC")]
            USDCMATIC = 2,

            /// <summary>
            /// Enum USDTMATIC for value: USDT_MATIC
            /// </summary>
            [EnumMember(Value = "USDT_MATIC")]
            USDTMATIC = 3

        }


        /// <summary>
        /// Currency to transfer from Polygon Blockchain Account. ERC20 tokens USDC and USDT are available only for mainnet use.
        /// </summary>
        /// <value>Currency to transfer from Polygon Blockchain Account. ERC20 tokens USDC and USDT are available only for mainnet use.</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public CurrencyEnum Currency { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferPolygonBlockchain" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferPolygonBlockchain() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferPolygonBlockchain" /> class.
        /// </summary>
        /// <param name="data">Additional data that can be passed to a blockchain transaction as a data property; must be in the hexadecimal format.</param>
        /// <param name="nonce">Nonce to be set to Polygon transaction. If not present, last known nonce will be used..</param>
        /// <param name="to">Blockchain address to send assets (required).</param>
        /// <param name="currency">Currency to transfer from Polygon Blockchain Account. ERC20 tokens USDC and USDT are available only for mainnet use. (required).</param>
        /// <param name="fee">fee.</param>
        /// <param name="amount">Amount to be sent. (required).</param>
        /// <param name="fromPrivateKey">Private key of sender address. Private key, or signature Id must be present. (required).</param>
        public TransferPolygonBlockchain(string data = default(string), decimal nonce = default(decimal), string to = default(string), CurrencyEnum currency = default(CurrencyEnum), CustomFee fee = default(CustomFee), string amount = default(string), string fromPrivateKey = default(string))
        {
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for TransferPolygonBlockchain and cannot be null");
            }
            this.To = to;
            this.Currency = currency;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for TransferPolygonBlockchain and cannot be null");
            }
            this.Amount = amount;
            // to ensure "fromPrivateKey" is required (not null)
            if (fromPrivateKey == null)
            {
                throw new ArgumentNullException("fromPrivateKey is a required property for TransferPolygonBlockchain and cannot be null");
            }
            this.FromPrivateKey = fromPrivateKey;
            this.Data = data;
            this.Nonce = nonce;
            this.Fee = fee;
        }


        /// <summary>
        /// Additional data that can be passed to a blockchain transaction as a data property; must be in the hexadecimal format
        /// </summary>
        /// <value>Additional data that can be passed to a blockchain transaction as a data property; must be in the hexadecimal format</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// Nonce to be set to Polygon transaction. If not present, last known nonce will be used.
        /// </summary>
        /// <value>Nonce to be set to Polygon transaction. If not present, last known nonce will be used.</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        public decimal Nonce { get; set; }

        /// <summary>
        /// Blockchain address to send assets
        /// </summary>
        /// <value>Blockchain address to send assets</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public CustomFee Fee { get; set; }

        /// <summary>
        /// Amount to be sent.
        /// </summary>
        /// <value>Amount to be sent.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public string Amount { get; set; }

        /// <summary>
        /// Private key of sender address. Private key, or signature Id must be present.
        /// </summary>
        /// <value>Private key of sender address. Private key, or signature Id must be present.</value>
        [DataMember(Name = "fromPrivateKey", IsRequired = true, EmitDefaultValue = true)]
        public string FromPrivateKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferPolygonBlockchain {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  FromPrivateKey: ").Append(FromPrivateKey).Append("\n");
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
            return this.Equals(input as TransferPolygonBlockchain);
        }

        /// <summary>
        /// Returns true if TransferPolygonBlockchain instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferPolygonBlockchain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferPolygonBlockchain input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    this.Nonce.Equals(input.Nonce)
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.FromPrivateKey == input.FromPrivateKey ||
                    (this.FromPrivateKey != null &&
                    this.FromPrivateKey.Equals(input.FromPrivateKey))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.FromPrivateKey != null)
                {
                    hashCode = (hashCode * 59) + this.FromPrivateKey.GetHashCode();
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
            // Data (string) maxLength
            if (this.Data != null && this.Data.Length > 50000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Data, length must be less than 50000.", new [] { "Data" });
            }

            // Nonce (decimal) minimum
            if (this.Nonce < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Nonce, must be a value greater than or equal to 0.", new [] { "Nonce" });
            }

            // To (string) maxLength
            if (this.To != null && this.To.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be less than 42.", new [] { "To" });
            }

            // To (string) minLength
            if (this.To != null && this.To.Length < 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, length must be greater than 42.", new [] { "To" });
            }

            // Amount (string) pattern
            Regex regexAmount = new Regex(@"^[+]?((\\d+(\\.\\d*)?)|(\\.\\d+))$", RegexOptions.CultureInvariant);
            if (false == regexAmount.Match(this.Amount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must match a pattern of " + regexAmount, new [] { "Amount" });
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

            yield break;
        }
    }

}
