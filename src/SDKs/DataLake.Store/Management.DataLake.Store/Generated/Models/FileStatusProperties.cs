// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data Lake Store file or directory information.
    /// </summary>
    public partial class FileStatusProperties
    {
        /// <summary>
        /// Initializes a new instance of the FileStatusProperties class.
        /// </summary>
        public FileStatusProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileStatusProperties class.
        /// </summary>
        /// <param name="accessTime">the last access time as ticks since the
        /// epoch.</param>
        /// <param name="blockSize">the block size for the file.</param>
        /// <param name="expirationTime">Gets the expiration time, if any, as
        /// ticks since the epoch. If the value is 0 or DateTime.MaxValue there
        /// is no expiration.</param>
        /// <param name="group">the group owner.</param>
        /// <param name="length">the number of bytes in a file.</param>
        /// <param name="modificationTime">the modification time as ticks since
        /// the epoch.</param>
        /// <param name="owner">the user who is the owner.</param>
        /// <param name="pathSuffix">the path suffix.</param>
        /// <param name="permission">the permission represented as an
        /// string.</param>
        /// <param name="type">the type of the path object. Possible values
        /// include: 'FILE', 'DIRECTORY'</param>
        /// <param name="aclBit">flag to indicate if extended acls are enabled
        /// </param>
        public FileStatusProperties(long? accessTime = default(long?), long? blockSize = default(long?), long? expirationTime = default(long?), string group = default(string), long? length = default(long?), long? modificationTime = default(long?), string owner = default(string), string pathSuffix = default(string), string permission = default(string), FileType? type = default(FileType?), bool? aclBit = default(bool?))
        {
            AccessTime = accessTime;
            BlockSize = blockSize;
            ExpirationTime = expirationTime;
            Group = group;
            Length = length;
            ModificationTime = modificationTime;
            Owner = owner;
            PathSuffix = pathSuffix;
            Permission = permission;
            Type = type;
            AclBit = aclBit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the last access time as ticks since the epoch.
        /// </summary>
        [JsonProperty(PropertyName = "accessTime")]
        public long? AccessTime { get; private set; }

        /// <summary>
        /// Gets the block size for the file.
        /// </summary>
        [JsonProperty(PropertyName = "blockSize")]
        public long? BlockSize { get; private set; }

        /// <summary>
        /// Gets the expiration time, if any, as ticks since the epoch. If the
        /// value is 0 or DateTime.MaxValue there is no expiration.
        /// </summary>
        [JsonProperty(PropertyName = "msExpirationTime")]
        public long? ExpirationTime { get; private set; }

        /// <summary>
        /// Gets the group owner.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; private set; }

        /// <summary>
        /// Gets the number of bytes in a file.
        /// </summary>
        [JsonProperty(PropertyName = "length")]
        public long? Length { get; private set; }

        /// <summary>
        /// Gets the modification time as ticks since the epoch.
        /// </summary>
        [JsonProperty(PropertyName = "modificationTime")]
        public long? ModificationTime { get; private set; }

        /// <summary>
        /// Gets the user who is the owner.
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; private set; }

        /// <summary>
        /// Gets the path suffix.
        /// </summary>
        [JsonProperty(PropertyName = "pathSuffix")]
        public string PathSuffix { get; private set; }

        /// <summary>
        /// Gets the permission represented as an string.
        /// </summary>
        [JsonProperty(PropertyName = "permission")]
        public string Permission { get; private set; }

        /// <summary>
        /// Gets the type of the path object. Possible values include: 'FILE',
        /// 'DIRECTORY'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public FileType? Type { get; private set; }

        /// <summary>
        /// Gets flag to indicate if extended acls are enabled
        /// </summary>
        [JsonProperty(PropertyName = "aclBit")]
        public bool? AclBit { get; private set; }

    }
}
