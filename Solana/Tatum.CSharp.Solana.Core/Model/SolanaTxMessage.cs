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
    /// SolanaTxMessage
    /// </summary>
    [DataContract(Name = "SolanaTxMessage")]
    public partial class SolanaTxMessage : IEquatable<SolanaTxMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolanaTxMessage" /> class.
        /// </summary>
        /// <param name="header">header.</param>
        /// <param name="accountKeys">accountKeys.</param>
        /// <param name="recentBlockhash">recentBlockhash.</param>
        /// <param name="instructions">instructions.</param>
        /// <param name="indexToProgramIds">indexToProgramIds.</param>
        public SolanaTxMessage(SolanaTxMessageHeader header = default(SolanaTxMessageHeader), List<string> accountKeys = default(List<string>), string recentBlockhash = default(string), List<SolanaTxMessageInstruction> instructions = default(List<SolanaTxMessageInstruction>), Object indexToProgramIds = default(Object))
        {
            this.Header = header;
            this.AccountKeys = accountKeys;
            this.RecentBlockhash = recentBlockhash;
            this.Instructions = instructions;
            this.IndexToProgramIds = indexToProgramIds;
        }


        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name = "header", EmitDefaultValue = false)]
        public SolanaTxMessageHeader Header { get; set; }

        /// <summary>
        /// Gets or Sets AccountKeys
        /// </summary>
        [DataMember(Name = "accountKeys", EmitDefaultValue = false)]
        public List<string> AccountKeys { get; set; }

        /// <summary>
        /// Gets or Sets RecentBlockhash
        /// </summary>
        [DataMember(Name = "recentBlockhash", EmitDefaultValue = false)]
        public string RecentBlockhash { get; set; }

        /// <summary>
        /// Gets or Sets Instructions
        /// </summary>
        [DataMember(Name = "instructions", EmitDefaultValue = false)]
        public List<SolanaTxMessageInstruction> Instructions { get; set; }

        /// <summary>
        /// Gets or Sets IndexToProgramIds
        /// </summary>
        [DataMember(Name = "indexToProgramIds", EmitDefaultValue = false)]
        public Object IndexToProgramIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SolanaTxMessage {\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  AccountKeys: ").Append(AccountKeys).Append("\n");
            sb.Append("  RecentBlockhash: ").Append(RecentBlockhash).Append("\n");
            sb.Append("  Instructions: ").Append(Instructions).Append("\n");
            sb.Append("  IndexToProgramIds: ").Append(IndexToProgramIds).Append("\n");
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
            return this.Equals(input as SolanaTxMessage);
        }

        /// <summary>
        /// Returns true if SolanaTxMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of SolanaTxMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SolanaTxMessage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
                ) && 
                (
                    this.AccountKeys == input.AccountKeys ||
                    this.AccountKeys != null &&
                    input.AccountKeys != null &&
                    this.AccountKeys.SequenceEqual(input.AccountKeys)
                ) && 
                (
                    this.RecentBlockhash == input.RecentBlockhash ||
                    (this.RecentBlockhash != null &&
                    this.RecentBlockhash.Equals(input.RecentBlockhash))
                ) && 
                (
                    this.Instructions == input.Instructions ||
                    this.Instructions != null &&
                    input.Instructions != null &&
                    this.Instructions.SequenceEqual(input.Instructions)
                ) && 
                (
                    this.IndexToProgramIds == input.IndexToProgramIds ||
                    (this.IndexToProgramIds != null &&
                    this.IndexToProgramIds.Equals(input.IndexToProgramIds))
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
                if (this.Header != null)
                {
                    hashCode = (hashCode * 59) + this.Header.GetHashCode();
                }
                if (this.AccountKeys != null)
                {
                    hashCode = (hashCode * 59) + this.AccountKeys.GetHashCode();
                }
                if (this.RecentBlockhash != null)
                {
                    hashCode = (hashCode * 59) + this.RecentBlockhash.GetHashCode();
                }
                if (this.Instructions != null)
                {
                    hashCode = (hashCode * 59) + this.Instructions.GetHashCode();
                }
                if (this.IndexToProgramIds != null)
                {
                    hashCode = (hashCode * 59) + this.IndexToProgramIds.GetHashCode();
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
