// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Compute.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Disk migration child task.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MigrationSubTask
    {
        /// <summary>
        /// Initializes a new instance of the MigrationSubTask class.
        /// </summary>
        public MigrationSubTask()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrationSubTask class.
        /// </summary>
        /// <param name="migrationSubTaskId">The id of migration child
        /// task.</param>
        /// <param name="migrationSubtaskStatus">The disk migration child task
        /// status. Possible values include: 'Undefined', 'Running',
        /// 'Succeeded', 'Failed', 'Canceled', 'Pending', 'Skipped'</param>
        /// <param name="reason">The reason of task failure.</param>
        /// <param name="startTime">The task start time.</param>
        /// <param name="endTime">The task end time.</param>
        /// <param name="targetShare">The target share of migration
        /// task.</param>
        /// <param name="sourceShare">The source share of migration
        /// task.</param>
        /// <param name="targetDiskStateForMigration">The disk status. Possible
        /// values include: 'Undefined', 'Unattached', 'Attached', 'Reserved',
        /// 'ActiveSAS', 'Unknown', 'All', 'Recommended', 'OfflineMigration',
        /// 'OnlineMigration'</param>
        /// <param name="diskId">The id of disk.</param>
        public MigrationSubTask(string migrationSubTaskId = default(string), string migrationSubtaskStatus = default(string), string reason = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string targetShare = default(string), string sourceShare = default(string), string targetDiskStateForMigration = default(string), string diskId = default(string))
        {
            MigrationSubTaskId = migrationSubTaskId;
            MigrationSubtaskStatus = migrationSubtaskStatus;
            Reason = reason;
            StartTime = startTime;
            EndTime = endTime;
            TargetShare = targetShare;
            SourceShare = sourceShare;
            TargetDiskStateForMigration = targetDiskStateForMigration;
            DiskId = diskId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the id of migration child task.
        /// </summary>
        [JsonProperty(PropertyName = "migrationSubTaskId")]
        public string MigrationSubTaskId { get; private set; }

        /// <summary>
        /// Gets the disk migration child task status. Possible values include:
        /// 'Undefined', 'Running', 'Succeeded', 'Failed', 'Canceled',
        /// 'Pending', 'Skipped'
        /// </summary>
        [JsonProperty(PropertyName = "properties.migrationSubtaskStatus")]
        public string MigrationSubtaskStatus { get; private set; }

        /// <summary>
        /// Gets the reason of task failure.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reason")]
        public string Reason { get; private set; }

        /// <summary>
        /// Gets the task start time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets the task end time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets the target share of migration task.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetShare")]
        public string TargetShare { get; private set; }

        /// <summary>
        /// Gets the source share of migration task.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceShare")]
        public string SourceShare { get; private set; }

        /// <summary>
        /// Gets the disk status. Possible values include: 'Undefined',
        /// 'Unattached', 'Attached', 'Reserved', 'ActiveSAS', 'Unknown',
        /// 'All', 'Recommended', 'OfflineMigration', 'OnlineMigration'
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetDiskStateForMigration")]
        public string TargetDiskStateForMigration { get; private set; }

        /// <summary>
        /// Gets the id of disk.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diskId")]
        public string DiskId { get; private set; }

    }
}
