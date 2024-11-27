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
    /// contains the configurations needed to define which index attributes can be used as filter
    /// </summary>
    [DataContract(Name = "searchConfigSchemaFilter")]
    public partial class SearchConfigSchemaFilter : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchConfigSchemaFilter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchConfigSchemaFilter()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchConfigSchemaFilter" /> class.
        /// </summary>
        /// <param name="attribute">json array of attributes of index that you can use to filter search results (required).</param>
        public SearchConfigSchemaFilter(string attribute = default(string))
        {
            // to ensure "attribute" is required (not null)
            if (attribute == null)
            {
                throw new ArgumentNullException("attribute is a required property for SearchConfigSchemaFilter and cannot be null");
            }
            this.Attribute = attribute;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// json array of attributes of index that you can use to filter search results
        /// </summary>
        /// <value>json array of attributes of index that you can use to filter search results</value>
        [DataMember(Name = "attribute", IsRequired = true, EmitDefaultValue = true)]
        public string Attribute { get; set; }

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
            sb.Append("class SearchConfigSchemaFilter {\n");
            sb.Append("  Attribute: ").Append(Attribute).Append("\n");
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