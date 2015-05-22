// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    /// <summary>
    /// Parameters supplied to the Create Virtual Network Gateway operation.
    /// </summary>
    public partial class VirtualNetworkGatewayCreateParameters
    {
        private string _gatewayName;

        /// <summary>
        /// Optional. The name of the virtual network gateway.
        /// </summary>
        public string GatewayName
        {
            get { return this._gatewayName; }
            set { this._gatewayName = value; }
        }

        private string _gatewaySKU;

        /// <summary>
        /// Optional. The SKU of this virtual network gateway. Valid values are
        /// Default, HighPerformance and Standard.
        /// </summary>
        public string GatewaySKU
        {
            get { return this._gatewaySKU; }
            set { this._gatewaySKU = value; }
        }

        private string _gatewayType;

        /// <summary>
        /// Optional. The routing type for this virtual network gateway.
        /// </summary>
        public string GatewayType
        {
            get { return this._gatewayType; }
            set { this._gatewayType = value; }
        }

        private string _location;

        /// <summary>
        /// Optional. The location of the virtual network gateway.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        private string _vnetId;

        /// <summary>
        /// Optional. Virtual network Id.
        /// </summary>
        public string VnetId
        {
            get { return this._vnetId; }
            set { this._vnetId = value; }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualNetworkGatewayCreateParameters class.
        /// </summary>
        public VirtualNetworkGatewayCreateParameters()
        {
        }
    }
}
