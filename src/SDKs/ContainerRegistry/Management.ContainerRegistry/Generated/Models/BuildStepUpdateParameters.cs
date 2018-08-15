// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters for updating a build step.
    /// </summary>
    public partial class BuildStepUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the BuildStepUpdateParameters class.
        /// </summary>
        public BuildStepUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuildStepUpdateParameters class.
        /// </summary>
        /// <param name="properties">The properties for updating a build
        /// step.</param>
        /// <param name="tags">The ARM resource tags.</param>
        public BuildStepUpdateParameters(BuildStepPropertiesUpdateParameters properties = default(BuildStepPropertiesUpdateParameters), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Properties = properties;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the properties for updating a build step.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public BuildStepPropertiesUpdateParameters Properties { get; set; }

        /// <summary>
        /// Gets or sets the ARM resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}