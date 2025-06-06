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
    /// SolanaWallet
    /// </summary>
    [DataContract(Name = "SolanaWallet")]
    public partial class SolanaWallet : IEquatable<SolanaWallet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolanaWallet" /> class.
        /// </summary>
        /// <param name="mnemonic">Generated mnemonic for wallet..</param>
        /// <param name="address">Generated account address..</param>
        /// <param name="privateKey">Generated private key for account..</param>
        public SolanaWallet(string mnemonic = default(string), string address = default(string), string privateKey = default(string))
        {
            this.Mnemonic = mnemonic;
            this.Address = address;
            this.PrivateKey = privateKey;
        }


        /// <summary>
        /// Generated mnemonic for wallet.
        /// </summary>
        /// <value>Generated mnemonic for wallet.</value>
        [DataMember(Name = "mnemonic", EmitDefaultValue = false)]
        public string Mnemonic { get; set; }

        /// <summary>
        /// Generated account address.
        /// </summary>
        /// <value>Generated account address.</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Generated private key for account.
        /// </summary>
        /// <value>Generated private key for account.</value>
        [DataMember(Name = "privateKey", EmitDefaultValue = false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SolanaWallet {\n");
            sb.Append("  Mnemonic: ").Append(Mnemonic).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as SolanaWallet);
        }

        /// <summary>
        /// Returns true if SolanaWallet instances are equal
        /// </summary>
        /// <param name="input">Instance of SolanaWallet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SolanaWallet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Mnemonic == input.Mnemonic ||
                    (this.Mnemonic != null &&
                    this.Mnemonic.Equals(input.Mnemonic))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.Mnemonic != null)
                {
                    hashCode = (hashCode * 59) + this.Mnemonic.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
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
            yield break;
        }
    }

}
