using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VirtoCommerce.StoreModule.Client.Model
{
    /// <summary>
    /// SearchResult
    /// </summary>
    [DataContract]
    public partial class SearchResult :  IEquatable<SearchResult>
    {
        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets Stores
        /// </summary>
        [DataMember(Name="stores", EmitDefaultValue=false)]
        public List<Store> Stores { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResult {\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  Stores: ").Append(Stores).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SearchResult);
        }

        /// <summary>
        /// Returns true if SearchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
                ) && 
                (
                    this.Stores == other.Stores ||
                    this.Stores != null &&
                    this.Stores.SequenceEqual(other.Stores)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)

                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();

                if (this.Stores != null)
                    hash = hash * 59 + this.Stores.GetHashCode();

                return hash;
            }
        }
    }
}
