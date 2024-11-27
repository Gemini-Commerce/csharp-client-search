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
    /// contains search request information about how and where to make the search
    /// </summary>
    [DataContract(Name = "searchQueryRequest")]
    public partial class SearchQueryRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public SearchQueryRequestType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchQueryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchQueryRequest()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchQueryRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenant to search on [#DOCGENBUG REQUIRED FIELD].</param>
        /// <param name="type">type.</param>
        /// <param name="payload">contains the search request payload (required).</param>
        public SearchQueryRequest(string tenantId = default(string), SearchQueryRequestType? type = default(SearchQueryRequestType?), List<SearchPayload> payload = default(List<SearchPayload>))
        {
            // to ensure "payload" is required (not null)
            if (payload == null)
            {
                throw new ArgumentNullException("payload is a required property for SearchQueryRequest and cannot be null");
            }
            this.Payload = payload;
            this.TenantId = tenantId;
            this.Type = type;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// tenant to search on [#DOCGENBUG REQUIRED FIELD]
        /// </summary>
        /// <value>tenant to search on [#DOCGENBUG REQUIRED FIELD]</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// contains the search request payload
        /// </summary>
        /// <value>contains the search request payload</value>
        [DataMember(Name = "payload", IsRequired = true, EmitDefaultValue = true)]
        public List<SearchPayload> Payload { get; set; }

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
            sb.Append("class SearchQueryRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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