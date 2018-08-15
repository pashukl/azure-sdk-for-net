// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error information returned by the API
    /// </summary>
    public partial class APIError
    {
        /// <summary>
        /// Initializes a new instance of the APIError class.
        /// </summary>
        public APIError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the APIError class.
        /// </summary>
        public APIError(Error error = default(Error))
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Error")]
        public Error Error { get; set; }

    }
}
