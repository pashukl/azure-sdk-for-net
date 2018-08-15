// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object model for updating an application's settings.
    /// </summary>
    public partial class ApplicationSettingUpdateObject
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationSettingUpdateObject
        /// class.
        /// </summary>
        public ApplicationSettingUpdateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationSettingUpdateObject
        /// class.
        /// </summary>
        /// <param name="publicProperty">Setting your application as public
        /// allows other people to use your application's endpoint using their
        /// own keys.</param>
        public ApplicationSettingUpdateObject(bool publicProperty = default(bool))
        {
            PublicProperty = publicProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets setting your application as public allows other people
        /// to use your application's endpoint using their own keys.
        /// </summary>
        [JsonProperty(PropertyName = "public")]
        public bool PublicProperty { get; set; }

    }
}
