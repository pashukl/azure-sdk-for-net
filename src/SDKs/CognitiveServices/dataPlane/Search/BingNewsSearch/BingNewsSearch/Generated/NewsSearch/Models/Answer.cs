// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.NewsSearch.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines an answer.
    /// </summary>
    public partial class Answer : Response
    {
        /// <summary>
        /// Initializes a new instance of the Answer class.
        /// </summary>
        public Answer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Answer class.
        /// </summary>
        /// <param name="id">A String identifier.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        public Answer(string id = default(string), string webSearchUrl = default(string), IList<Query> followUpQueries = default(IList<Query>))
            : base(id, webSearchUrl)
        {
            FollowUpQueries = followUpQueries;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "followUpQueries")]
        public IList<Query> FollowUpQueries { get; private set; }

    }
}
