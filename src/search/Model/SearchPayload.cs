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
    /// contains the search request payload
    /// </summary>
    [DataContract(Name = "searchPayload")]
    public partial class SearchPayload : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchPayload()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPayload" /> class.
        /// </summary>
        /// <param name="index">index where to search data (required).</param>
        /// <param name="varParams">varParams (required).</param>
        public SearchPayload(string index = default(string), SearchParams varParams = default(SearchParams))
        {
            // to ensure "index" is required (not null)
            if (index == null)
            {
                throw new ArgumentNullException("index is a required property for SearchPayload and cannot be null");
            }
            this.Index = index;
            // to ensure "varParams" is required (not null)
            if (varParams == null)
            {
                throw new ArgumentNullException("varParams is a required property for SearchPayload and cannot be null");
            }
            this.Params = varParams;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// index where to search data
        /// </summary>
        /// <value>index where to search data</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public string Index { get; set; }

        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name = "params", IsRequired = true, EmitDefaultValue = true)]
        public SearchParams Params { get; set; }

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
            sb.Append("class SearchPayload {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
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
