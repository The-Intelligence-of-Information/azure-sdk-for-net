// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Minimum properties that should be present in each individual validation
    /// response.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ValidationInputResponse")]
    public partial class ValidationInputResponse
    {
        /// <summary>
        /// Initializes a new instance of the ValidationInputResponse class.
        /// </summary>
        public ValidationInputResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValidationInputResponse class.
        /// </summary>
        /// <param name="error">Error code and message of validation
        /// response.</param>
        public ValidationInputResponse(CloudError error = default(CloudError))
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets error code and message of validation response.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public CloudError Error { get; private set; }

    }
}
