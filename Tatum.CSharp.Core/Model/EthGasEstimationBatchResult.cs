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
    /// EthGasEstimationBatchResult
    /// </summary>
    [DataContract(Name = "EthGasEstimationBatchResult")]
    public partial class EthGasEstimationBatchResult : IEquatable<EthGasEstimationBatchResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EthGasEstimationBatchResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EthGasEstimationBatchResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EthGasEstimationBatchResult" /> class.
        /// </summary>
        /// <param name="error">If estimation succeeded. (required).</param>
        /// <param name="contractAddress">Contract address of ERC20 token, if transaction is ERC20 token.</param>
        /// <param name="data">data.</param>
        /// <param name="msg">Error message. Present only if error - true..</param>
        public EthGasEstimationBatchResult(bool error = default(bool), string contractAddress = default(string), EthGasEstimationBatchResultData data = default(EthGasEstimationBatchResultData), string msg = default(string))
        {
            this.Error = error;
            this.ContractAddress = contractAddress;
            this.Data = data;
            this.Msg = msg;
        }

        /// <summary>
        /// If estimation succeeded.
        /// </summary>
        /// <value>If estimation succeeded.</value>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = true)]
        public bool Error { get; set; }

        /// <summary>
        /// Contract address of ERC20 token, if transaction is ERC20 token
        /// </summary>
        /// <value>Contract address of ERC20 token, if transaction is ERC20 token</value>
        [DataMember(Name = "contractAddress", EmitDefaultValue = false)]
        public string ContractAddress { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public EthGasEstimationBatchResultData Data { get; set; }

        /// <summary>
        /// Error message. Present only if error - true.
        /// </summary>
        /// <value>Error message. Present only if error - true.</value>
        [DataMember(Name = "msg", EmitDefaultValue = false)]
        public string Msg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EthGasEstimationBatchResult {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ContractAddress: ").Append(ContractAddress).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
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
            return this.Equals(input as EthGasEstimationBatchResult);
        }

        /// <summary>
        /// Returns true if EthGasEstimationBatchResult instances are equal
        /// </summary>
        /// <param name="input">Instance of EthGasEstimationBatchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EthGasEstimationBatchResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Error == input.Error ||
                    this.Error.Equals(input.Error)
                ) && 
                (
                    this.ContractAddress == input.ContractAddress ||
                    (this.ContractAddress != null &&
                    this.ContractAddress.Equals(input.ContractAddress))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
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
                hashCode = (hashCode * 59) + this.Error.GetHashCode();
                if (this.ContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ContractAddress.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Msg != null)
                {
                    hashCode = (hashCode * 59) + this.Msg.GetHashCode();
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
            if (this.ContractAddress != null && this.ContractAddress.Length > 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractAddress, length must be less than 42.", new [] { "ContractAddress" });
            }

            // ContractAddress (string) minLength
            if (this.ContractAddress != null && this.ContractAddress.Length < 42)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractAddress, length must be greater than 42.", new [] { "ContractAddress" });
            }

            yield break;
        }
    }

}
