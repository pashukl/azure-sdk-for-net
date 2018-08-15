// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response from a List Indexes request. If successful, it includes the
    /// full definitions of all indexes.
    /// </summary>
    public partial class IndexListResult
    {
        /// <summary>
        /// Initializes a new instance of the IndexListResult class.
        /// </summary>
        public IndexListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IndexListResult class.
        /// </summary>
        /// <param name="indexes">The indexes in the Search service.</param>
        public IndexListResult(IList<Index> indexes = default(IList<Index>))
        {
            Indexes = indexes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the indexes in the Search service.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Index> Indexes { get; private set; }

    }
}
