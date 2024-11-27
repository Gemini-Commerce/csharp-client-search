/*
 * Search Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
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
using OpenAPIDateConverter = search.Client.OpenAPIDateConverter;

namespace search.Model
{
    /// <summary>
    /// contains where and what data to write in search storage
    /// </summary>
    [DataContract(Name = "searchWriteRequest")]
    public partial class SearchWriteRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWriteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchWriteRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWriteRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenant id data identifier where to write data [#DOCGENBUG REQUIRED FIELD].</param>
        /// <param name="index">elasticsearch index identifier where to write data (required).</param>
        /// <param name="documents">A JSON array of documents to write or update (required).</param>
        public SearchWriteRequest(string tenantId = default(string), string index = default(string), List<string> documents = default(List<string>))
        {
            // to ensure "index" is required (not null)
            if (index == null)
            {
                throw new ArgumentNullException("index is a required property for SearchWriteRequest and cannot be null");
            }
            this.Index = index;
            // to ensure "documents" is required (not null)
            if (documents == null)
            {
                throw new ArgumentNullException("documents is a required property for SearchWriteRequest and cannot be null");
            }
            this.Documents = documents;
            this.TenantId = tenantId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// tenant id data identifier where to write data [#DOCGENBUG REQUIRED FIELD]
        /// </summary>
        /// <value>tenant id data identifier where to write data [#DOCGENBUG REQUIRED FIELD]</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// elasticsearch index identifier where to write data
        /// </summary>
        /// <value>elasticsearch index identifier where to write data</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public string Index { get; set; }

        /// <summary>
        /// A JSON array of documents to write or update
        /// </summary>
        /// <value>A JSON array of documents to write or update</value>
        [DataMember(Name = "documents", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Documents { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchWriteRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
