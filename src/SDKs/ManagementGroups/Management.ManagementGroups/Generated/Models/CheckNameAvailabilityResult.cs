// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagementGroups.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the result of the request to check management group name
    /// availability.
    /// </summary>
    public partial class CheckNameAvailabilityResult
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResult
        /// class.
        /// </summary>
        public CheckNameAvailabilityResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResult
        /// class.
        /// </summary>
        /// <param name="nameAvailable">Required. True indicates name is valid
        /// and available. False indicates the name is invalid, unavailable, or
        /// both.</param>
        /// <param name="reason">Required if nameAvailable == false. Invalid
        /// indicates the name provided does not match the resource provider's
        /// naming requirements (incorrect length, unsupported characters,
        /// etc.) AlreadyExists indicates that the name is already in use and
        /// is therefore unavailable. Possible values include: 'Invalid',
        /// 'AlreadyExists'</param>
        /// <param name="message">Required if nameAvailable == false.
        /// Localized. If reason == invalid, provide the user with the reason
        /// why the given name is invalid, and provide the resource naming
        /// requirements so that the user can select a valid name. If reason ==
        /// AlreadyExists, explain that is already in use, and direct them to
        /// select a different name.</param>
        public CheckNameAvailabilityResult(bool? nameAvailable = default(bool?), Reason? reason = default(Reason?), string message = default(string))
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets required. True indicates name is valid and available. False
        /// indicates the name is invalid, unavailable, or both.
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable { get; private set; }

        /// <summary>
        /// Gets required if nameAvailable == false. Invalid indicates the name
        /// provided does not match the resource provider's naming requirements
        /// (incorrect length, unsupported characters, etc.) AlreadyExists
        /// indicates that the name is already in use and is therefore
        /// unavailable. Possible values include: 'Invalid', 'AlreadyExists'
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public Reason? Reason { get; private set; }

        /// <summary>
        /// Gets required if nameAvailable == false. Localized. If reason ==
        /// invalid, provide the user with the reason why the given name is
        /// invalid, and provide the resource naming requirements so that the
        /// user can select a valid name. If reason == AlreadyExists, explain
        /// that is already in use, and direct them to select a different name.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

    }
}
