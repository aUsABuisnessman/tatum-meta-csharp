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
using FileParameter = Tatum.CSharp.Bitcoin.Core.Client.FileParameter;
using OpenAPIDateConverter = Tatum.CSharp.Bitcoin.Core.Client.OpenAPIDateConverter;

namespace Tatum.CSharp.Bitcoin.Core.Model
{
    /// <summary>
    /// BtcTransactionFromUTXOSource
    /// </summary>
    [DataContract(Name = "BtcTransactionFromUTXOSource")]
    public partial class BtcTransactionFromUTXOSource : IEquatable<BtcTransactionFromUTXOSource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BtcTransactionFromUTXOSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BtcTransactionFromUTXOSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BtcTransactionFromUTXOSource" /> class.
        /// </summary>
        /// <param name="txHash">The transaction hash of the UTXO to be spent (required).</param>
        /// <param name="index">The index of the UTXO to be spent (required).</param>
        /// <param name="privateKey">The private key of the blockchain address that holds the UTXO to be spent (required).</param>
        public BtcTransactionFromUTXOSource(string txHash = default(string), decimal index = default(decimal), string privateKey = default(string))
        {
            // to ensure "txHash" is required (not null)
            if (txHash == null)
            {
                throw new ArgumentNullException("txHash is a required property for BtcTransactionFromUTXOSource and cannot be null");
            }
            this.TxHash = txHash;
            this.Index = index;
            // to ensure "privateKey" is required (not null)
            if (privateKey == null)
            {
                throw new ArgumentNullException("privateKey is a required property for BtcTransactionFromUTXOSource and cannot be null");
            }
            this.PrivateKey = privateKey;
        }


        /// <summary>
        /// The transaction hash of the UTXO to be spent
        /// </summary>
        /// <value>The transaction hash of the UTXO to be spent</value>
        [DataMember(Name = "txHash", IsRequired = true, EmitDefaultValue = true)]
        public string TxHash { get; set; }

        /// <summary>
        /// The index of the UTXO to be spent
        /// </summary>
        /// <value>The index of the UTXO to be spent</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public decimal Index { get; set; }

        /// <summary>
        /// The private key of the blockchain address that holds the UTXO to be spent
        /// </summary>
        /// <value>The private key of the blockchain address that holds the UTXO to be spent</value>
        [DataMember(Name = "privateKey", IsRequired = true, EmitDefaultValue = true)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BtcTransactionFromUTXOSource {\n");
            sb.Append("  TxHash: ").Append(TxHash).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
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
            return this.Equals(input as BtcTransactionFromUTXOSource);
        }

        /// <summary>
        /// Returns true if BtcTransactionFromUTXOSource instances are equal
        /// </summary>
        /// <param name="input">Instance of BtcTransactionFromUTXOSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BtcTransactionFromUTXOSource input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TxHash == input.TxHash ||
                    (this.TxHash != null &&
                    this.TxHash.Equals(input.TxHash))
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
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
                if (this.TxHash != null)
                {
                    hashCode = (hashCode * 59) + this.TxHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                if (this.PrivateKey != null)
                {
                    hashCode = (hashCode * 59) + this.PrivateKey.GetHashCode();
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
            // TxHash (string) maxLength
            if (this.TxHash != null && this.TxHash.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TxHash, length must be less than 64.", new [] { "TxHash" });
            }

            // TxHash (string) minLength
            if (this.TxHash != null && this.TxHash.Length < 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TxHash, length must be greater than 64.", new [] { "TxHash" });
            }

            // Index (decimal) maximum
            if (this.Index > (decimal)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Index, must be a value less than or equal to 2147483647.", new [] { "Index" });
            }

            // Index (decimal) minimum
            if (this.Index < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Index, must be a value greater than or equal to 0.", new [] { "Index" });
            }

            // PrivateKey (string) maxLength
            if (this.PrivateKey != null && this.PrivateKey.Length > 52)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrivateKey, length must be less than 52.", new [] { "PrivateKey" });
            }

            // PrivateKey (string) minLength
            if (this.PrivateKey != null && this.PrivateKey.Length < 52)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrivateKey, length must be greater than 52.", new [] { "PrivateKey" });
            }

            yield break;
        }
    }

}