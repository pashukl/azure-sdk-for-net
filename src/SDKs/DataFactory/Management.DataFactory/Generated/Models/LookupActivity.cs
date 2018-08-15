// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Lookup activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Lookup")]
    [Rest.Serialization.JsonTransformation]
    public partial class LookupActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the LookupActivity class.
        /// </summary>
        public LookupActivity()
        {
            Dataset = new DatasetReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LookupActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="source">Dataset-specific source properties, same as
        /// copy activity source.</param>
        /// <param name="dataset">Lookup activity dataset reference.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="firstRowOnly">Whether to return first row or all rows.
        /// Default value is true. Type: boolean (or Expression with resultType
        /// boolean).</param>
        public LookupActivity(string name, CopySource source, DatasetReference dataset, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<UserProperty> userProperties = default(IList<UserProperty>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), object firstRowOnly = default(object))
            : base(name, additionalProperties, description, dependsOn, userProperties, linkedServiceName, policy)
        {
            Source = source;
            Dataset = dataset;
            FirstRowOnly = firstRowOnly;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets dataset-specific source properties, same as copy
        /// activity source.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.source")]
        public CopySource Source { get; set; }

        /// <summary>
        /// Gets or sets lookup activity dataset reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.dataset")]
        public DatasetReference Dataset { get; set; }

        /// <summary>
        /// Gets or sets whether to return first row or all rows. Default value
        /// is true. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.firstRowOnly")]
        public object FirstRowOnly { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (Dataset == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Dataset");
            }
            if (Dataset != null)
            {
                Dataset.Validate();
            }
        }
    }
}
