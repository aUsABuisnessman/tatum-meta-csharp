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
using FileParameter = Tatum.CSharp.Bsc.Core.Client.FileParameter;
using OpenAPIDateConverter = Tatum.CSharp.Bsc.Core.Client.OpenAPIDateConverter;

namespace Tatum.CSharp.Bsc.Core.Model
{
    /// <summary>
    /// EthBlock
    /// </summary>
    [DataContract(Name = "EthBlock")]
    public partial class EthBlock : IEquatable<EthBlock>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EthBlock" /> class.
        /// </summary>
        /// <param name="difficulty">Difficulty for this block..</param>
        /// <param name="extraData">The &#39;extra data&#39; field of this block..</param>
        /// <param name="gasLimit">The maximum gas allowed in this block..</param>
        /// <param name="gasUsed">The total used gas by all transactions in this block..</param>
        /// <param name="hash">Hash of the block. &#39;null&#39; when its pending block..</param>
        /// <param name="logsBloom">The bloom filter for the logs of the block. &#39;null&#39; when its pending block..</param>
        /// <param name="miner">The address of the beneficiary to whom the mining rewards were given..</param>
        /// <param name="mixHash">mixHash.</param>
        /// <param name="nonce">Hash of the generated proof-of-work. &#39;null&#39; when its pending block..</param>
        /// <param name="number">The block number. &#39;null&#39; when its pending block..</param>
        /// <param name="parentHash">Hash of the parent block..</param>
        /// <param name="receiptsRoot">receiptsRoot.</param>
        /// <param name="sha3Uncles">SHA3 of the uncles data in the block..</param>
        /// <param name="size">The size of this block in bytes..</param>
        /// <param name="stateRoot">The root of the final state trie of the block..</param>
        /// <param name="timestamp">The unix timestamp for when the block was collated..</param>
        /// <param name="totalDifficulty">Total difficulty of the chain until this block..</param>
        /// <param name="transactions">Array of transactions..</param>
        /// <param name="transactionsRoot">The root of the transaction trie of the block..</param>
        public EthBlock(string difficulty = default(string), string extraData = default(string), decimal gasLimit = default(decimal), decimal gasUsed = default(decimal), string hash = default(string), string logsBloom = default(string), string miner = default(string), string mixHash = default(string), string nonce = default(string), decimal number = default(decimal), string parentHash = default(string), string receiptsRoot = default(string), string sha3Uncles = default(string), decimal size = default(decimal), string stateRoot = default(string), decimal timestamp = default(decimal), string totalDifficulty = default(string), List<EthTx> transactions = default(List<EthTx>), string transactionsRoot = default(string))
        {
            this.Difficulty = difficulty;
            this.ExtraData = extraData;
            this.GasLimit = gasLimit;
            this.GasUsed = gasUsed;
            this.Hash = hash;
            this.LogsBloom = logsBloom;
            this.Miner = miner;
            this.MixHash = mixHash;
            this.Nonce = nonce;
            this.Number = number;
            this.ParentHash = parentHash;
            this.ReceiptsRoot = receiptsRoot;
            this.Sha3Uncles = sha3Uncles;
            this.Size = size;
            this.StateRoot = stateRoot;
            this.Timestamp = timestamp;
            this.TotalDifficulty = totalDifficulty;
            this.Transactions = transactions;
            this.TransactionsRoot = transactionsRoot;
        }


        /// <summary>
        /// Difficulty for this block.
        /// </summary>
        /// <value>Difficulty for this block.</value>
        [DataMember(Name = "difficulty", EmitDefaultValue = false)]
        public string Difficulty { get; set; }

        /// <summary>
        /// The &#39;extra data&#39; field of this block.
        /// </summary>
        /// <value>The &#39;extra data&#39; field of this block.</value>
        [DataMember(Name = "extraData", EmitDefaultValue = false)]
        public string ExtraData { get; set; }

        /// <summary>
        /// The maximum gas allowed in this block.
        /// </summary>
        /// <value>The maximum gas allowed in this block.</value>
        [DataMember(Name = "gasLimit", EmitDefaultValue = false)]
        public decimal GasLimit { get; set; }

        /// <summary>
        /// The total used gas by all transactions in this block.
        /// </summary>
        /// <value>The total used gas by all transactions in this block.</value>
        [DataMember(Name = "gasUsed", EmitDefaultValue = false)]
        public decimal GasUsed { get; set; }

        /// <summary>
        /// Hash of the block. &#39;null&#39; when its pending block.
        /// </summary>
        /// <value>Hash of the block. &#39;null&#39; when its pending block.</value>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public string Hash { get; set; }

        /// <summary>
        /// The bloom filter for the logs of the block. &#39;null&#39; when its pending block.
        /// </summary>
        /// <value>The bloom filter for the logs of the block. &#39;null&#39; when its pending block.</value>
        [DataMember(Name = "logsBloom", EmitDefaultValue = false)]
        public string LogsBloom { get; set; }

        /// <summary>
        /// The address of the beneficiary to whom the mining rewards were given.
        /// </summary>
        /// <value>The address of the beneficiary to whom the mining rewards were given.</value>
        [DataMember(Name = "miner", EmitDefaultValue = false)]
        public string Miner { get; set; }

        /// <summary>
        /// Gets or Sets MixHash
        /// </summary>
        [DataMember(Name = "mixHash", EmitDefaultValue = false)]
        public string MixHash { get; set; }

        /// <summary>
        /// Hash of the generated proof-of-work. &#39;null&#39; when its pending block.
        /// </summary>
        /// <value>Hash of the generated proof-of-work. &#39;null&#39; when its pending block.</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        public string Nonce { get; set; }

        /// <summary>
        /// The block number. &#39;null&#39; when its pending block.
        /// </summary>
        /// <value>The block number. &#39;null&#39; when its pending block.</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public decimal Number { get; set; }

        /// <summary>
        /// Hash of the parent block.
        /// </summary>
        /// <value>Hash of the parent block.</value>
        [DataMember(Name = "parentHash", EmitDefaultValue = false)]
        public string ParentHash { get; set; }

        /// <summary>
        /// Gets or Sets ReceiptsRoot
        /// </summary>
        [DataMember(Name = "receiptsRoot", EmitDefaultValue = false)]
        public string ReceiptsRoot { get; set; }

        /// <summary>
        /// SHA3 of the uncles data in the block.
        /// </summary>
        /// <value>SHA3 of the uncles data in the block.</value>
        [DataMember(Name = "sha3Uncles", EmitDefaultValue = false)]
        public string Sha3Uncles { get; set; }

        /// <summary>
        /// The size of this block in bytes.
        /// </summary>
        /// <value>The size of this block in bytes.</value>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public decimal Size { get; set; }

        /// <summary>
        /// The root of the final state trie of the block.
        /// </summary>
        /// <value>The root of the final state trie of the block.</value>
        [DataMember(Name = "stateRoot", EmitDefaultValue = false)]
        public string StateRoot { get; set; }

        /// <summary>
        /// The unix timestamp for when the block was collated.
        /// </summary>
        /// <value>The unix timestamp for when the block was collated.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public decimal Timestamp { get; set; }

        /// <summary>
        /// Total difficulty of the chain until this block.
        /// </summary>
        /// <value>Total difficulty of the chain until this block.</value>
        [DataMember(Name = "totalDifficulty", EmitDefaultValue = false)]
        public string TotalDifficulty { get; set; }

        /// <summary>
        /// Array of transactions.
        /// </summary>
        /// <value>Array of transactions.</value>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public List<EthTx> Transactions { get; set; }

        /// <summary>
        /// The root of the transaction trie of the block.
        /// </summary>
        /// <value>The root of the transaction trie of the block.</value>
        [DataMember(Name = "transactionsRoot", EmitDefaultValue = false)]
        public string TransactionsRoot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EthBlock {\n");
            sb.Append("  Difficulty: ").Append(Difficulty).Append("\n");
            sb.Append("  ExtraData: ").Append(ExtraData).Append("\n");
            sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
            sb.Append("  GasUsed: ").Append(GasUsed).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  LogsBloom: ").Append(LogsBloom).Append("\n");
            sb.Append("  Miner: ").Append(Miner).Append("\n");
            sb.Append("  MixHash: ").Append(MixHash).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ParentHash: ").Append(ParentHash).Append("\n");
            sb.Append("  ReceiptsRoot: ").Append(ReceiptsRoot).Append("\n");
            sb.Append("  Sha3Uncles: ").Append(Sha3Uncles).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  StateRoot: ").Append(StateRoot).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  TotalDifficulty: ").Append(TotalDifficulty).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  TransactionsRoot: ").Append(TransactionsRoot).Append("\n");
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
            return this.Equals(input as EthBlock);
        }

        /// <summary>
        /// Returns true if EthBlock instances are equal
        /// </summary>
        /// <param name="input">Instance of EthBlock to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EthBlock input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Difficulty == input.Difficulty ||
                    (this.Difficulty != null &&
                    this.Difficulty.Equals(input.Difficulty))
                ) && 
                (
                    this.ExtraData == input.ExtraData ||
                    (this.ExtraData != null &&
                    this.ExtraData.Equals(input.ExtraData))
                ) && 
                (
                    this.GasLimit == input.GasLimit ||
                    this.GasLimit.Equals(input.GasLimit)
                ) && 
                (
                    this.GasUsed == input.GasUsed ||
                    this.GasUsed.Equals(input.GasUsed)
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.LogsBloom == input.LogsBloom ||
                    (this.LogsBloom != null &&
                    this.LogsBloom.Equals(input.LogsBloom))
                ) && 
                (
                    this.Miner == input.Miner ||
                    (this.Miner != null &&
                    this.Miner.Equals(input.Miner))
                ) && 
                (
                    this.MixHash == input.MixHash ||
                    (this.MixHash != null &&
                    this.MixHash.Equals(input.MixHash))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.ParentHash == input.ParentHash ||
                    (this.ParentHash != null &&
                    this.ParentHash.Equals(input.ParentHash))
                ) && 
                (
                    this.ReceiptsRoot == input.ReceiptsRoot ||
                    (this.ReceiptsRoot != null &&
                    this.ReceiptsRoot.Equals(input.ReceiptsRoot))
                ) && 
                (
                    this.Sha3Uncles == input.Sha3Uncles ||
                    (this.Sha3Uncles != null &&
                    this.Sha3Uncles.Equals(input.Sha3Uncles))
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.StateRoot == input.StateRoot ||
                    (this.StateRoot != null &&
                    this.StateRoot.Equals(input.StateRoot))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    this.Timestamp.Equals(input.Timestamp)
                ) && 
                (
                    this.TotalDifficulty == input.TotalDifficulty ||
                    (this.TotalDifficulty != null &&
                    this.TotalDifficulty.Equals(input.TotalDifficulty))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && 
                (
                    this.TransactionsRoot == input.TransactionsRoot ||
                    (this.TransactionsRoot != null &&
                    this.TransactionsRoot.Equals(input.TransactionsRoot))
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
                if (this.Difficulty != null)
                {
                    hashCode = (hashCode * 59) + this.Difficulty.GetHashCode();
                }
                if (this.ExtraData != null)
                {
                    hashCode = (hashCode * 59) + this.ExtraData.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GasLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.GasUsed.GetHashCode();
                if (this.Hash != null)
                {
                    hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                }
                if (this.LogsBloom != null)
                {
                    hashCode = (hashCode * 59) + this.LogsBloom.GetHashCode();
                }
                if (this.Miner != null)
                {
                    hashCode = (hashCode * 59) + this.Miner.GetHashCode();
                }
                if (this.MixHash != null)
                {
                    hashCode = (hashCode * 59) + this.MixHash.GetHashCode();
                }
                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                if (this.ParentHash != null)
                {
                    hashCode = (hashCode * 59) + this.ParentHash.GetHashCode();
                }
                if (this.ReceiptsRoot != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiptsRoot.GetHashCode();
                }
                if (this.Sha3Uncles != null)
                {
                    hashCode = (hashCode * 59) + this.Sha3Uncles.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
                if (this.StateRoot != null)
                {
                    hashCode = (hashCode * 59) + this.StateRoot.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                if (this.TotalDifficulty != null)
                {
                    hashCode = (hashCode * 59) + this.TotalDifficulty.GetHashCode();
                }
                if (this.Transactions != null)
                {
                    hashCode = (hashCode * 59) + this.Transactions.GetHashCode();
                }
                if (this.TransactionsRoot != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionsRoot.GetHashCode();
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