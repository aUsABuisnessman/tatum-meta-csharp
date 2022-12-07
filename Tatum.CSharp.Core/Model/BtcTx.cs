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
using System.ComponentModel.DataAnnotations;

namespace Tatum.CSharp.Core.Model
{
    /// <summary>
    /// BtcTx
    /// </summary>
    [DataContract(Name = "BtcTx")]
    public partial class BtcTx : IEquatable<BtcTx>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BtcTx" /> class.
        /// </summary>
        /// <param name="hash">Transaction hash..</param>
        /// <param name="hex">Transaction hex..</param>
        /// <param name="witnessHash">Witness hash in case of a SegWit transaction..</param>
        /// <param name="fee">Fee paid for this transaction, in satoshis..</param>
        /// <param name="rate">rate.</param>
        /// <param name="mtime">mtime.</param>
        /// <param name="blockNumber">Height of the block this transaction belongs to..</param>
        /// <param name="block">Hash of the block this transaction belongs to..</param>
        /// <param name="time">Time of the transaction..</param>
        /// <param name="index">Index of the transaction in the block..</param>
        /// <param name="version">Index of the transaction..</param>
        /// <param name="inputs">List of transactions, from which assets are being sent..</param>
        /// <param name="outputs">List of recipient addresses and amounts to send to each of them..</param>
        /// <param name="locktime">Block this transaction was included in..</param>
        public BtcTx(string hash = default(string), string hex = default(string), string witnessHash = default(string), decimal fee = default(decimal), decimal rate = default(decimal), decimal mtime = default(decimal), decimal blockNumber = default(decimal), string block = default(string), decimal time = default(decimal), decimal index = default(decimal), decimal version = default(decimal), List<BtcTxInput> inputs = default(List<BtcTxInput>), List<BtcTxOutput> outputs = default(List<BtcTxOutput>), decimal locktime = default(decimal))
        {
            this.Hash = hash;
            this.Hex = hex;
            this.WitnessHash = witnessHash;
            this.Fee = fee;
            this.Rate = rate;
            this.Mtime = mtime;
            this.BlockNumber = blockNumber;
            this.Block = block;
            this.Time = time;
            this.Index = index;
            this._Version = version;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.Locktime = locktime;
        }

        /// <summary>
        /// Transaction hash.
        /// </summary>
        /// <value>Transaction hash.</value>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public string Hash { get; set; }

        /// <summary>
        /// Transaction hex.
        /// </summary>
        /// <value>Transaction hex.</value>
        [DataMember(Name = "hex", EmitDefaultValue = false)]
        public string Hex { get; set; }

        /// <summary>
        /// Witness hash in case of a SegWit transaction.
        /// </summary>
        /// <value>Witness hash in case of a SegWit transaction.</value>
        [DataMember(Name = "witnessHash", EmitDefaultValue = false)]
        public string WitnessHash { get; set; }

        /// <summary>
        /// Fee paid for this transaction, in satoshis.
        /// </summary>
        /// <value>Fee paid for this transaction, in satoshis.</value>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public decimal Fee { get; set; }

        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        public decimal Rate { get; set; }

        /// <summary>
        /// Gets or Sets Mtime
        /// </summary>
        [DataMember(Name = "mtime", EmitDefaultValue = false)]
        public decimal Mtime { get; set; }

        /// <summary>
        /// Height of the block this transaction belongs to.
        /// </summary>
        /// <value>Height of the block this transaction belongs to.</value>
        [DataMember(Name = "blockNumber", EmitDefaultValue = false)]
        public decimal BlockNumber { get; set; }

        /// <summary>
        /// Hash of the block this transaction belongs to.
        /// </summary>
        /// <value>Hash of the block this transaction belongs to.</value>
        [DataMember(Name = "block", EmitDefaultValue = false)]
        public string Block { get; set; }

        /// <summary>
        /// Time of the transaction.
        /// </summary>
        /// <value>Time of the transaction.</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public decimal Time { get; set; }

        /// <summary>
        /// Index of the transaction in the block.
        /// </summary>
        /// <value>Index of the transaction in the block.</value>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public decimal Index { get; set; }

        /// <summary>
        /// Index of the transaction.
        /// </summary>
        /// <value>Index of the transaction.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public decimal _Version { get; set; }

        /// <summary>
        /// List of transactions, from which assets are being sent.
        /// </summary>
        /// <value>List of transactions, from which assets are being sent.</value>
        [DataMember(Name = "inputs", EmitDefaultValue = false)]
        public List<BtcTxInput> Inputs { get; set; }

        /// <summary>
        /// List of recipient addresses and amounts to send to each of them.
        /// </summary>
        /// <value>List of recipient addresses and amounts to send to each of them.</value>
        [DataMember(Name = "outputs", EmitDefaultValue = false)]
        public List<BtcTxOutput> Outputs { get; set; }

        /// <summary>
        /// Block this transaction was included in.
        /// </summary>
        /// <value>Block this transaction was included in.</value>
        [DataMember(Name = "locktime", EmitDefaultValue = false)]
        public decimal Locktime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BtcTx {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Hex: ").Append(Hex).Append("\n");
            sb.Append("  WitnessHash: ").Append(WitnessHash).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Mtime: ").Append(Mtime).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  Locktime: ").Append(Locktime).Append("\n");
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
            return this.Equals(input as BtcTx);
        }

        /// <summary>
        /// Returns true if BtcTx instances are equal
        /// </summary>
        /// <param name="input">Instance of BtcTx to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BtcTx input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Hex == input.Hex ||
                    (this.Hex != null &&
                    this.Hex.Equals(input.Hex))
                ) && 
                (
                    this.WitnessHash == input.WitnessHash ||
                    (this.WitnessHash != null &&
                    this.WitnessHash.Equals(input.WitnessHash))
                ) && 
                (
                    this.Fee == input.Fee ||
                    this.Fee.Equals(input.Fee)
                ) && 
                (
                    this.Rate == input.Rate ||
                    this.Rate.Equals(input.Rate)
                ) && 
                (
                    this.Mtime == input.Mtime ||
                    this.Mtime.Equals(input.Mtime)
                ) && 
                (
                    this.BlockNumber == input.BlockNumber ||
                    this.BlockNumber.Equals(input.BlockNumber)
                ) && 
                (
                    this.Block == input.Block ||
                    (this.Block != null &&
                    this.Block.Equals(input.Block))
                ) && 
                (
                    this.Time == input.Time ||
                    this.Time.Equals(input.Time)
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    input.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
                ) && 
                (
                    this.Locktime == input.Locktime ||
                    this.Locktime.Equals(input.Locktime)
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
                if (this.Hash != null)
                {
                    hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                }
                if (this.Hex != null)
                {
                    hashCode = (hashCode * 59) + this.Hex.GetHashCode();
                }
                if (this.WitnessHash != null)
                {
                    hashCode = (hashCode * 59) + this.WitnessHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                hashCode = (hashCode * 59) + this.Mtime.GetHashCode();
                hashCode = (hashCode * 59) + this.BlockNumber.GetHashCode();
                if (this.Block != null)
                {
                    hashCode = (hashCode * 59) + this.Block.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Time.GetHashCode();
                hashCode = (hashCode * 59) + this.Index.GetHashCode();
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                if (this.Inputs != null)
                {
                    hashCode = (hashCode * 59) + this.Inputs.GetHashCode();
                }
                if (this.Outputs != null)
                {
                    hashCode = (hashCode * 59) + this.Outputs.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Locktime.GetHashCode();
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
