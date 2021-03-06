// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Virtual Hub identifier. </summary>
    public partial class VirtualHubId
    {
        /// <summary> Initializes a new instance of VirtualHubId. </summary>
        public VirtualHubId()
        {
        }

        /// <summary> Initializes a new instance of VirtualHubId. </summary>
        /// <param name="id"> The resource URI for the Virtual Hub where the ExpressRoute gateway is or will be deployed. The Virtual Hub resource and the ExpressRoute gateway resource reside in the same subscription. </param>
        internal VirtualHubId(string id)
        {
            Id = id;
        }

        /// <summary> The resource URI for the Virtual Hub where the ExpressRoute gateway is or will be deployed. The Virtual Hub resource and the ExpressRoute gateway resource reside in the same subscription. </summary>
        public string Id { get; set; }
    }
}
