namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Azure;

    /// <summary>
    /// </summary>
    public partial class ConnectionResetSharedKey
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ConnectionResetSharedKeyPropertiesFormat Properties { get; set; }

    }
}
