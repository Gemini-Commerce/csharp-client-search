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
    /// contains the configurations needed to define which index attributes can be used for sort
    /// </summary>
    [DataContract(Name = "searchConfigSchemaSortable")]
    public partial class SearchConfigSchemaSortable : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchConfigSchemaSortable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchConfigSchemaSortable()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchConfigSchemaSortable" /> class.
        /// </summary>
        /// <param name="attribute">json array of attributes of index which can be used for sort (required).</param>
        public SearchConfigSchemaSortable(string attribute = default(string))
        {
            // to ensure "attribute" is required (not null)
            if (attribute == null)
            {
                throw new ArgumentNullException("attribute is a required property for SearchConfigSchemaSortable and cannot be null");
            }
            this.Attribute = attribute;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// json array of attributes of index which can be used for sort
        /// </summary>
        /// <value>json array of attributes of index which can be used for sort</value>
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
            sb.Append("class SearchConfigSchemaSortable {\n");
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
