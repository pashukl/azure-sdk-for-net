// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Software update configuration collection item properties.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SoftwareUpdateConfigurationCollectionItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SoftwareUpdateConfigurationCollectionItem class.
        /// </summary>
        public SoftwareUpdateConfigurationCollectionItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SoftwareUpdateConfigurationCollectionItem class.
        /// </summary>
        /// <param name="name">Name of the software update
        /// configuration.</param>
        /// <param name="id">Resource Id of the software update
        /// configuration</param>
        /// <param name="updateConfiguration">Update specific properties of the
        /// software update configuration.</param>
        /// <param name="frequency">execution frequency of the schedule
        /// associated with the software update configuration. Possible values
        /// include: 'OneTime', 'Day', 'Hour', 'Week', 'Month'</param>
        /// <param name="startTime">the start time of the update.</param>
        /// <param name="creationTime">Creation time of the software update
        /// configuration, which only appears in the response.</param>
        /// <param name="lastModifiedTime">Last time software update
        /// configuration was modified, which only appears in the
        /// response.</param>
        /// <param name="provisioningState">Provisioning state for the software
        /// update configuration, which only appears in the response.</param>
        /// <param name="nextRun">ext run time of the update.</param>
        public SoftwareUpdateConfigurationCollectionItem(string name = default(string), string id = default(string), CollectionItemUpdateConfiguration updateConfiguration = default(CollectionItemUpdateConfiguration), string frequency = default(string), System.DateTimeOffset startTime = default(System.DateTimeOffset), System.DateTimeOffset creationTime = default(System.DateTimeOffset), System.DateTimeOffset lastModifiedTime = default(System.DateTimeOffset), string provisioningState = default(string), System.DateTimeOffset? nextRun = default(System.DateTimeOffset?))
        {
            Name = name;
            Id = id;
            UpdateConfiguration = updateConfiguration;
            Frequency = frequency;
            StartTime = startTime;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            ProvisioningState = provisioningState;
            NextRun = nextRun;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the software update configuration.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource Id of the software update configuration
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets update specific properties of the software update
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updateConfiguration")]
        public CollectionItemUpdateConfiguration UpdateConfiguration { get; set; }

        /// <summary>
        /// Gets or sets execution frequency of the schedule associated with
        /// the software update configuration. Possible values include:
        /// 'OneTime', 'Day', 'Hour', 'Week', 'Month'
        /// </summary>
        [JsonProperty(PropertyName = "properties.frequency")]
        public string Frequency { get; set; }

        /// <summary>
        /// Gets or sets the start time of the update.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// Gets creation time of the software update configuration, which only
        /// appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTimeOffset CreationTime { get; private set; }

        /// <summary>
        /// Gets last time software update configuration was modified, which
        /// only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTimeOffset LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets provisioning state for the software update configuration,
        /// which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets ext run time of the update.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nextRun")]
        public System.DateTimeOffset? NextRun { get; set; }

    }
}
