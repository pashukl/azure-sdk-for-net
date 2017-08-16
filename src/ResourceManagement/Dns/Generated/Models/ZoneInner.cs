// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Dns.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Dns;
    using Microsoft.Azure.Management.Dns.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a DNS zone.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ZoneInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the ZoneInner class.
        /// </summary>
        public ZoneInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ZoneInner class.
        /// </summary>
        /// <param name="etag">The etag of the zone.</param>
        /// <param name="maxNumberOfRecordSets">The maximum number of record
        /// sets that can be created in this DNS zone.  This is a read-only
        /// property and any attempt to set this value will be ignored.</param>
        /// <param name="numberOfRecordSets">The current number of record sets
        /// in this DNS zone.  This is a read-only property and any attempt to
        /// set this value will be ignored.</param>
        /// <param name="nameServers">The name servers for this DNS zone. This
        /// is a read-only property and any attempt to set this value will be
        /// ignored.</param>
        public ZoneInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), long? maxNumberOfRecordSets = default(long?), long? numberOfRecordSets = default(long?), IList<string> nameServers = default(IList<string>))
            : base(location, id, name, type, tags)
        {
            Etag = etag;
            MaxNumberOfRecordSets = maxNumberOfRecordSets;
            NumberOfRecordSets = numberOfRecordSets;
            NameServers = nameServers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the etag of the zone.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of record sets that can be created
        /// in this DNS zone.  This is a read-only property and any attempt to
        /// set this value will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxNumberOfRecordSets")]
        public long? MaxNumberOfRecordSets { get; set; }

        /// <summary>
        /// Gets or sets the current number of record sets in this DNS zone.
        /// This is a read-only property and any attempt to set this value will
        /// be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfRecordSets")]
        public long? NumberOfRecordSets { get; set; }

        /// <summary>
        /// Gets the name servers for this DNS zone. This is a read-only
        /// property and any attempt to set this value will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nameServers")]
        public IList<string> NameServers { get; private set; }

    }
}