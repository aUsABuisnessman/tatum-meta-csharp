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
    /// BtcInfo
    /// </summary>
    [DataContract(Name = "BtcInfo")]
    public partial class BtcInfo : IEquatable<BtcInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BtcInfo" /> class.
        /// </summary>
        /// <param name="chain">Chain of the blockchain, main or test..</param>
        /// <param name="blocks">Last block..</param>
        /// <param name="headers">Last headers..</param>
        /// <param name="bestblockhash">Hash of the last block..</param>
        /// <param name="difficulty">Difficulty of the algorithm..</param>
        public BtcInfo(string chain = default(string), decimal blocks = default(decimal), decimal headers = default(decimal), string bestblockhash = default(string), decimal difficulty = default(decimal))
        {
            this.Chain = chain;
            this.Blocks = blocks;
            this.Headers = headers;
            this.Bestblockhash = bestblockhash;
            this.Difficulty = difficulty;
        }

        /// <summary>
        /// Chain of the blockchain, main or test.
        /// </summary>
        /// <value>Chain of the blockchain, main or test.</value>
        [DataMember(Name = "chain", EmitDefaultValue = false)]
        public string Chain { get; set; }

        /// <summary>
        /// Last block.
        /// </summary>
        /// <value>Last block.</value>
        [DataMember(Name = "blocks", EmitDefaultValue = false)]
        public decimal Blocks { get; set; }

        /// <summary>
        /// Last headers.
        /// </summary>
        /// <value>Last headers.</value>
        [DataMember(Name = "headers", EmitDefaultValue = false)]
        public decimal Headers { get; set; }

        /// <summary>
        /// Hash of the last block.
        /// </summary>
        /// <value>Hash of the last block.</value>
        [DataMember(Name = "bestblockhash", EmitDefaultValue = false)]
        public string Bestblockhash { get; set; }

        /// <summary>
        /// Difficulty of the algorithm.
        /// </summary>
        /// <value>Difficulty of the algorithm.</value>
        [DataMember(Name = "difficulty", EmitDefaultValue = false)]
        public decimal Difficulty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BtcInfo {\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  Blocks: ").Append(Blocks).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Bestblockhash: ").Append(Bestblockhash).Append("\n");
            sb.Append("  Difficulty: ").Append(Difficulty).Append("\n");
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
            return this.Equals(input as BtcInfo);
        }

        /// <summary>
        /// Returns true if BtcInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BtcInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BtcInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Chain == input.Chain ||
                    (this.Chain != null &&
                    this.Chain.Equals(input.Chain))
                ) && 
                (
                    this.Blocks == input.Blocks ||
                    this.Blocks.Equals(input.Blocks)
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers.Equals(input.Headers)
                ) && 
                (
                    this.Bestblockhash == input.Bestblockhash ||
                    (this.Bestblockhash != null &&
                    this.Bestblockhash.Equals(input.Bestblockhash))
                ) && 
                (
                    this.Difficulty == input.Difficulty ||
                    this.Difficulty.Equals(input.Difficulty)
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
                if (this.Chain != null)
                {
                    hashCode = (hashCode * 59) + this.Chain.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Blocks.GetHashCode();
                hashCode = (hashCode * 59) + this.Headers.GetHashCode();
                if (this.Bestblockhash != null)
                {
                    hashCode = (hashCode * 59) + this.Bestblockhash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Difficulty.GetHashCode();
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
