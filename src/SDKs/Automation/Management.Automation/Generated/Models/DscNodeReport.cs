// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Automation;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Definition of the dsc node report type.
    /// </summary>
    public partial class DscNodeReport
    {
        /// <summary>
        /// Initializes a new instance of the DscNodeReport class.
        /// </summary>
        public DscNodeReport()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DscNodeReport class.
        /// </summary>
        /// <param name="endTime">Gets or sets the end time of the node
        /// report.</param>
        /// <param name="lastModifiedTime">Gets or sets the lastModifiedTime of
        /// the node report.</param>
        /// <param name="startTime">Gets or sets the start time of the node
        /// report.</param>
        /// <param name="type">Gets or sets the type of the node
        /// report.</param>
        /// <param name="reportId">Gets or sets the id of the node
        /// report.</param>
        /// <param name="status">Gets or sets the status of the node
        /// report.</param>
        /// <param name="refreshMode">Gets or sets the refreshMode of the node
        /// report.</param>
        /// <param name="rebootRequested">Gets or sets the rebootRequested of
        /// the node report.</param>
        /// <param name="reportFormatVersion">Gets or sets the
        /// reportFormatVersion of the node report.</param>
        /// <param name="configurationVersion">Gets or sets the
        /// configurationVersion of the node report.</param>
        /// <param name="id">Gets or sets the id.</param>
        /// <param name="errors">Gets or sets the errors for the node
        /// report.</param>
        /// <param name="resources">Gets or sets the resource for the node
        /// report.</param>
        /// <param name="metaConfiguration">Gets or sets the metaConfiguration
        /// of the node at the time of the report.</param>
        /// <param name="hostName">Gets or sets the hostname of the node that
        /// sent the report.</param>
        /// <param name="iPV4Addresses">Gets or sets the IPv4 address of the
        /// node that sent the report.</param>
        /// <param name="iPV6Addresses">Gets or sets the IPv6 address of the
        /// node that sent the report.</param>
        /// <param name="numberOfResources">Gets or sets the number of resource
        /// in the node report.</param>
        /// <param name="rawErrors">Gets or sets the unparsed errors for the
        /// node report.</param>
        public DscNodeReport(System.DateTime? endTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), System.DateTime? startTime = default(System.DateTime?), string type = default(string), string reportId = default(string), string status = default(string), string refreshMode = default(string), string rebootRequested = default(string), string reportFormatVersion = default(string), string configurationVersion = default(string), string id = default(string), IList<DscReportError> errors = default(IList<DscReportError>), IList<DscReportResource> resources = default(IList<DscReportResource>), DscMetaConfiguration metaConfiguration = default(DscMetaConfiguration), string hostName = default(string), IList<string> iPV4Addresses = default(IList<string>), IList<string> iPV6Addresses = default(IList<string>), int? numberOfResources = default(int?), string rawErrors = default(string))
        {
            EndTime = endTime;
            LastModifiedTime = lastModifiedTime;
            StartTime = startTime;
            Type = type;
            ReportId = reportId;
            Status = status;
            RefreshMode = refreshMode;
            RebootRequested = rebootRequested;
            ReportFormatVersion = reportFormatVersion;
            ConfigurationVersion = configurationVersion;
            Id = id;
            Errors = errors;
            Resources = resources;
            MetaConfiguration = metaConfiguration;
            HostName = hostName;
            IPV4Addresses = iPV4Addresses;
            IPV6Addresses = iPV6Addresses;
            NumberOfResources = numberOfResources;
            RawErrors = rawErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the end time of the node report.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the lastModifiedTime of the node report.
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the start time of the node report.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the type of the node report.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the id of the node report.
        /// </summary>
        [JsonProperty(PropertyName = "reportId")]
        public string ReportId { get; set; }

        /// <summary>
        /// Gets or sets the status of the node report.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the refreshMode of the node report.
        /// </summary>
        [JsonProperty(PropertyName = "refreshMode")]
        public string RefreshMode { get; set; }

        /// <summary>
        /// Gets or sets the rebootRequested of the node report.
        /// </summary>
        [JsonProperty(PropertyName = "rebootRequested")]
        public string RebootRequested { get; set; }

        /// <summary>
        /// Gets or sets the reportFormatVersion of the node report.
        /// </summary>
        [JsonProperty(PropertyName = "reportFormatVersion")]
        public string ReportFormatVersion { get; set; }

        /// <summary>
        /// Gets or sets the configurationVersion of the node report.
        /// </summary>
        [JsonProperty(PropertyName = "configurationVersion")]
        public string ConfigurationVersion { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the errors for the node report.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<DscReportError> Errors { get; set; }

        /// <summary>
        /// Gets or sets the resource for the node report.
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<DscReportResource> Resources { get; set; }

        /// <summary>
        /// Gets or sets the metaConfiguration of the node at the time of the
        /// report.
        /// </summary>
        [JsonProperty(PropertyName = "metaConfiguration")]
        public DscMetaConfiguration MetaConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the hostname of the node that sent the report.
        /// </summary>
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets the IPv4 address of the node that sent the report.
        /// </summary>
        [JsonProperty(PropertyName = "iPV4Addresses")]
        public IList<string> IPV4Addresses { get; set; }

        /// <summary>
        /// Gets or sets the IPv6 address of the node that sent the report.
        /// </summary>
        [JsonProperty(PropertyName = "iPV6Addresses")]
        public IList<string> IPV6Addresses { get; set; }

        /// <summary>
        /// Gets or sets the number of resource in the node report.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfResources")]
        public int? NumberOfResources { get; set; }

        /// <summary>
        /// Gets or sets the unparsed errors for the node report.
        /// </summary>
        [JsonProperty(PropertyName = "rawErrors")]
        public string RawErrors { get; set; }

    }
}
