/*
 * Tatum API Reference
 *
 * # Welcome to the Tatum API Reference!  ## What is Tatum?  Tatum offers a flexible framework to build, run, and scale blockchain apps fast. To learn more about the Tatum blockchain development framework, visit [our website](https://tatum.io/framework).  The Tatum API features powerful endpoints that simplify a complex blockchain into single API requests. Code for all supported blockchains using unified API calls.  ## Supported blockchains  Tatum supports multiple blockchains and various blockchain features.  Because not all blockchains function identically, Tatum supports a different set of features on each blockchain.  To see all the blockchains that Tatum supports, please refer to [this article](https://docs.tatum.io/introduction/supported-blockchains).  ## Need help?  To chat with other developers, get help from the Support team, and engage with the thriving Tatum community, join  our [Discord server](https://discord.com/invite/tatum). For more information about how to work with Tatum, review the [online documentation](https://docs.tatum.io/).  # Authentication  When using the Tatum API, you authenticate yourself with an **API key**. <SecurityDefinitions /> 
 *
 * The version of the OpenAPI document: 3.17.2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.IO;

namespace Tatum.CSharp.Solana.Core.Client
{

    /// <summary>
    /// Represents a File passed to the API as a Parameter, allows using different backends for files
    /// </summary>
    public class FileParameter
    {
        /// <summary>
        /// The filename
        /// </summary>
        public string Name { get; set; } = "no_name_provided";

        /// <summary>
        /// The content type of the file
        /// </summary>
        public string ContentType { get; set; } = "application/octet-stream";

        /// <summary>
        /// The content of the file
        /// </summary>
        public Stream Content { get; set; }

        /// <summary>
        /// Construct a FileParameter just from the contents, will extract the filename from a filestream
        /// </summary>
        /// <param name="content"> The file content </param>
        public FileParameter(Stream content)
        {
            if (content is FileStream fs)
            {
                Name = fs.Name;
            }
            Content = content;
        }

        /// <summary>
        /// Construct a FileParameter from name and content
        /// </summary>
        /// <param name="filename">The filename</param>
        /// <param name="content">The file content</param>
        public FileParameter(string filename, Stream content)
        {
            Name = filename;
            Content = content;
        }

        /// <summary>
        /// Construct a FileParameter from name and content
        /// </summary>
        /// <param name="filename">The filename</param>
        /// <param name="contentType">The content type of the file</param>
        /// <param name="content">The file content</param>
        public FileParameter(string filename, string contentType, Stream content)
        {
            Name = filename;
            ContentType = contentType;
            Content = content;
        }

        /// <summary>
        /// Implicit conversion of stream to file parameter. Useful for backwards compatibility.
        /// </summary>
        /// <param name="s">Stream to convert</param>
        /// <returns>FileParameter</returns>
        public static implicit operator FileParameter(Stream s) => new FileParameter(s);
    }
}