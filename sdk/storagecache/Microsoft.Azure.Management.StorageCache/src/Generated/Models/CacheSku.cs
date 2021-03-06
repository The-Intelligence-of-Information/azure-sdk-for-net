// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SKU for the Cache.
    /// </summary>
    public partial class CacheSku
    {
        /// <summary>
        /// Initializes a new instance of the CacheSku class.
        /// </summary>
        public CacheSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CacheSku class.
        /// </summary>
        /// <param name="name">SKU name for this Cache.</param>
        public CacheSku(string name = default(string))
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SKU name for this Cache.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
