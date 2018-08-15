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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Definition of the source control sync job stream by id.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SourceControlSyncJobStreamById
    {
        /// <summary>
        /// Initializes a new instance of the SourceControlSyncJobStreamById
        /// class.
        /// </summary>
        public SourceControlSyncJobStreamById()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SourceControlSyncJobStreamById
        /// class.
        /// </summary>
        /// <param name="id">Resource id.</param>
        /// <param name="syncJobStreamId">The sync job stream id.</param>
        /// <param name="summary">The summary of the sync job stream.</param>
        /// <param name="time">The time of the sync job stream.</param>
        /// <param name="streamType">The type of the sync job stream. Possible
        /// values include: 'Error', 'Output'</param>
        /// <param name="streamText">The text of the sync job stream.</param>
        /// <param name="value">The values of the job stream.</param>
        public SourceControlSyncJobStreamById(string id = default(string), string syncJobStreamId = default(string), string summary = default(string), System.DateTimeOffset? time = default(System.DateTimeOffset?), string streamType = default(string), string streamText = default(string), IDictionary<string, object> value = default(IDictionary<string, object>))
        {
            Id = id;
            SyncJobStreamId = syncJobStreamId;
            Summary = summary;
            Time = time;
            StreamType = streamType;
            StreamText = streamText;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the sync job stream id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.syncJobStreamId")]
        public string SyncJobStreamId { get; set; }

        /// <summary>
        /// Gets or sets the summary of the sync job stream.
        /// </summary>
        [JsonProperty(PropertyName = "properties.summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Gets the time of the sync job stream.
        /// </summary>
        [JsonProperty(PropertyName = "properties.time")]
        public System.DateTimeOffset? Time { get; private set; }

        /// <summary>
        /// Gets or sets the type of the sync job stream. Possible values
        /// include: 'Error', 'Output'
        /// </summary>
        [JsonProperty(PropertyName = "properties.streamType")]
        public string StreamType { get; set; }

        /// <summary>
        /// Gets or sets the text of the sync job stream.
        /// </summary>
        [JsonProperty(PropertyName = "properties.streamText")]
        public string StreamText { get; set; }

        /// <summary>
        /// Gets or sets the values of the job stream.
        /// </summary>
        [JsonProperty(PropertyName = "properties.value")]
        public IDictionary<string, object> Value { get; set; }

    }
}