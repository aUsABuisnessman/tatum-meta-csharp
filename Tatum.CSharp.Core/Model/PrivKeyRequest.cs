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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Tatum.CSharp.Core.Model
{
    /// <summary>
    /// PrivKeyRequest
    /// </summary>
    [DataContract(Name = "PrivKeyRequest")]
    public partial class PrivKeyRequest : IEquatable<PrivKeyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivKeyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PrivKeyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivKeyRequest" /> class.
        /// </summary>
        /// <param name="index">Derivation index of private key to generate. (required).</param>
        /// <param name="mnemonic">Mnemonic to generate private key from. (required).</param>
        public PrivKeyRequest(int index = default(int), string mnemonic = default(string))
        {
            this.Index = index;
            // to ensure "mnemonic" is required (not null)
            if (mnemonic == null)
            {
                throw new ArgumentNullException("mnemonic is a required property for PrivKeyRequest and cannot be null");
            }
            this.Mnemonic = mnemonic;
        }

        /// <summary>
        /// Derivation index of private key to generate.
        /// </summary>
        /// <value>Derivation index of private key to generate.</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public int Index { get; set; }

        /// <summary>
        /// Mnemonic to generate private key from.
        /// </summary>
        /// <value>Mnemonic to generate private key from.</value>
        [DataMember(Name = "mnemonic", IsRequired = true, EmitDefaultValue = true)]
        public string Mnemonic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PrivKeyRequest {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Mnemonic: ").Append(Mnemonic).Append("\n");
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
            return this.Equals(input as PrivKeyRequest);
        }

        /// <summary>
        /// Returns true if PrivKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PrivKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrivKeyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Mnemonic == input.Mnemonic ||
                    (this.Mnemonic != null &&
                    this.Mnemonic.Equals(input.Mnemonic))
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
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                if (this.Mnemonic != null)
                {
                    hashCode = (hashCode * 59) + this.Mnemonic.GetHashCode();
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
            // Index (int) maximum
            if (this.Index > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Index, must be a value less than or equal to 2147483647.", new [] { "Index" });
            }

            // Mnemonic (string) maxLength
            if (this.Mnemonic != null && this.Mnemonic.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Mnemonic, length must be less than 500.", new [] { "Mnemonic" });
            }

            // Mnemonic (string) minLength
            if (this.Mnemonic != null && this.Mnemonic.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Mnemonic, length must be greater than 1.", new [] { "Mnemonic" });
            }

            yield break;
        }
    }

}
