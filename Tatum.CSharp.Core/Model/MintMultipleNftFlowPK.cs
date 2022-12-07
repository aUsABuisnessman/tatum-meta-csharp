/*
 * Tatum API Reference
 *
 * # Welcome to the Tatum API Reference!  ## What is Tatum?  Tatum offers a flexible framework to build, run, and scale blockchain apps fast. To learn more about the Tatum blockchain development framework, visit [our website](https://tatum.io/framework).  The Tatum API features powerful endpoints that simplify a complex blockchain into single API requests. Code for all supported blockchains using unified API calls.  ## Need help?  To chat with other developers, get help from the Support team, and engage with the thriving Tatum community, join  our [Discord server](https://discord.com/invite/tatum). For more information about how to work with Tatum, review the [online documentation](https://docs.tatum.io/).  ## About this API Reference  The Tatum API Reference is based on OpenAPI Specification v3.1.0 with a few [vendor extensions](https://github.com/Redocly/redoc/blob/master/docs/redoc-vendor-extensions.md) applied.  # Authentication  When using the Tatum API, you authenticate yourself with an **API key**. <SecurityDefinitions /> 
 *
 * The version of the OpenAPI document: 3.17.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Tatum.CSharp.Core.Model
{
    /// <summary>
    /// MintMultipleNftFlowPK
    /// </summary>
    [DataContract(Name = "MintMultipleNftFlowPK")]
    public partial class MintMultipleNftFlowPK : IEquatable<MintMultipleNftFlowPK>, IValidatableObject
    {
        /// <summary>
        /// The blockchain to work with
        /// </summary>
        /// <value>The blockchain to work with</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChainEnum
        {
            /// <summary>
            /// Enum FLOW for value: FLOW
            /// </summary>
            [EnumMember(Value = "FLOW")]
            FLOW = 1

        }


        /// <summary>
        /// The blockchain to work with
        /// </summary>
        /// <value>The blockchain to work with</value>
        [DataMember(Name = "chain", IsRequired = true, EmitDefaultValue = true)]
        public ChainEnum Chain { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MintMultipleNftFlowPK" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MintMultipleNftFlowPK() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MintMultipleNftFlowPK" /> class.
        /// </summary>
        /// <param name="chain">The blockchain to work with (required).</param>
        /// <param name="to">Blockchain address to send NFT token to. (required).</param>
        /// <param name="url">The URL pointing to the NFT metadata; for more information, see &lt;a href&#x3D;\&quot;https://eips.ethereum.org/EIPS/eip-721#specification\&quot; target&#x3D;\&quot;_blank\&quot;&gt;EIP-721&lt;/a&gt; (required).</param>
        /// <param name="contractAddress">Address of NFT token (required).</param>
        /// <param name="account">Blockchain address of the sender account. (required).</param>
        /// <param name="privateKey">Private key of sender address. Private key, mnemonic and index or signature Id must be present. (required).</param>
        public MintMultipleNftFlowPK(ChainEnum chain = default(ChainEnum), List<string> to = default(List<string>), List<string> url = default(List<string>), string contractAddress = default(string), string account = default(string), string privateKey = default(string))
        {
            this.Chain = chain;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for MintMultipleNftFlowPK and cannot be null");
            }
            this.To = to;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for MintMultipleNftFlowPK and cannot be null");
            }
            this.Url = url;
            // to ensure "contractAddress" is required (not null)
            if (contractAddress == null)
            {
                throw new ArgumentNullException("contractAddress is a required property for MintMultipleNftFlowPK and cannot be null");
            }
            this.ContractAddress = contractAddress;
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new ArgumentNullException("account is a required property for MintMultipleNftFlowPK and cannot be null");
            }
            this.Account = account;
            // to ensure "privateKey" is required (not null)
            if (privateKey == null)
            {
                throw new ArgumentNullException("privateKey is a required property for MintMultipleNftFlowPK and cannot be null");
            }
            this.PrivateKey = privateKey;
        }

        /// <summary>
        /// Blockchain address to send NFT token to.
        /// </summary>
        /// <value>Blockchain address to send NFT token to.</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public List<string> To { get; set; }

        /// <summary>
        /// The URL pointing to the NFT metadata; for more information, see &lt;a href&#x3D;\&quot;https://eips.ethereum.org/EIPS/eip-721#specification\&quot; target&#x3D;\&quot;_blank\&quot;&gt;EIP-721&lt;/a&gt;
        /// </summary>
        /// <value>The URL pointing to the NFT metadata; for more information, see &lt;a href&#x3D;\&quot;https://eips.ethereum.org/EIPS/eip-721#specification\&quot; target&#x3D;\&quot;_blank\&quot;&gt;EIP-721&lt;/a&gt;</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Url { get; set; }

        /// <summary>
        /// Address of NFT token
        /// </summary>
        /// <value>Address of NFT token</value>
        [DataMember(Name = "contractAddress", IsRequired = true, EmitDefaultValue = true)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// Blockchain address of the sender account.
        /// </summary>
        /// <value>Blockchain address of the sender account.</value>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = true)]
        public string Account { get; set; }

        /// <summary>
        /// Private key of sender address. Private key, mnemonic and index or signature Id must be present.
        /// </summary>
        /// <value>Private key of sender address. Private key, mnemonic and index or signature Id must be present.</value>
        [DataMember(Name = "privateKey", IsRequired = true, EmitDefaultValue = true)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MintMultipleNftFlowPK {\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
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
            return this.Equals(input as MintMultipleNftFlowPK);
        }

        /// <summary>
        /// Returns true if MintMultipleNftFlowPK instances are equal
        /// </summary>
        /// <param name="input">Instance of MintMultipleNftFlowPK to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MintMultipleNftFlowPK input)
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
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.Url == input.Url ||
                    this.Url != null &&
                    input.Url != null &&
                    this.Url.SequenceEqual(input.Url)
                ) && 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
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
                hashCode = (hashCode * 59) + this.Chain.GetHashCode();
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
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
            // ContractAddress (string) maxLength
            if (this.ContractAddress != null && this.ContractAddress.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractAddress, length must be less than 36.", new [] { "ContractAddress" });
            }

            // ContractAddress (string) minLength
            if (this.ContractAddress != null && this.ContractAddress.Length < 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractAddress, length must be greater than 36.", new [] { "ContractAddress" });
            }

            // Account (string) maxLength
            if (this.Account != null && this.Account.Length > 18)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Account, length must be less than 18.", new [] { "Account" });
            }

            // Account (string) minLength
            if (this.Account != null && this.Account.Length < 18)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Account, length must be greater than 18.", new [] { "Account" });
            }

            // PrivateKey (string) maxLength
            if (this.PrivateKey != null && this.PrivateKey.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrivateKey, length must be less than 64.", new [] { "PrivateKey" });
            }

            // PrivateKey (string) minLength
            if (this.PrivateKey != null && this.PrivateKey.Length < 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrivateKey, length must be greater than 64.", new [] { "PrivateKey" });
            }

            yield break;
        }
    }

}
