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
    /// contains the search results, aggregations and paging information
    /// </summary>
    [DataContract(Name = "searchResult")]
    public partial class SearchResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchResult()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult" /> class.
        /// </summary>
        /// <param name="index">index where the data were extrapolated (required).</param>
        /// <param name="varParams">varParams.</param>
        /// <param name="page">page number of the results you are processing.</param>
        /// <param name="totalPages">number of pages of results.</param>
        /// <param name="totalHits">number of total search results.</param>
        /// <param name="hits">search result records contained in the specified page.</param>
        /// <param name="aggregations">array of aggregation obtained by search result.</param>
        public SearchResult(string index = default(string), SearchParams varParams = default(SearchParams), long page = default(long), long totalPages = default(long), long totalHits = default(long), List<string> hits = default(List<string>), Dictionary<string, SearchAggrMap> aggregations = default(Dictionary<string, SearchAggrMap>))
        {
            // to ensure "index" is required (not null)
            if (index == null)
            {
                throw new ArgumentNullException("index is a required property for SearchResult and cannot be null");
            }
            this.Index = index;
            this.Params = varParams;
            this.Page = page;
            this.TotalPages = totalPages;
            this.TotalHits = totalHits;
            this.Hits = hits;
            this.Aggregations = aggregations;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// index where the data were extrapolated
        /// </summary>
        /// <value>index where the data were extrapolated</value>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public string Index { get; set; }

        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name = "params", EmitDefaultValue = false)]
        public SearchParams Params { get; set; }

        /// <summary>
        /// page number of the results you are processing
        /// </summary>
        /// <value>page number of the results you are processing</value>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public long Page { get; set; }

        /// <summary>
        /// number of pages of results
        /// </summary>
        /// <value>number of pages of results</value>
        [DataMember(Name = "totalPages", EmitDefaultValue = false)]
        public long TotalPages { get; set; }

        /// <summary>
        /// number of total search results
        /// </summary>
        /// <value>number of total search results</value>
        [DataMember(Name = "totalHits", EmitDefaultValue = false)]
        public long TotalHits { get; set; }

        /// <summary>
        /// search result records contained in the specified page
        /// </summary>
        /// <value>search result records contained in the specified page</value>
        [DataMember(Name = "hits", EmitDefaultValue = false)]
        public List<string> Hits { get; set; }

        /// <summary>
        /// array of aggregation obtained by search result
        /// </summary>
        /// <value>array of aggregation obtained by search result</value>
        [DataMember(Name = "aggregations", EmitDefaultValue = false)]
        public Dictionary<string, SearchAggrMap> Aggregations { get; set; }

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
            sb.Append("class SearchResult {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  TotalHits: ").Append(TotalHits).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
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
