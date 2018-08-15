// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// You use the API to scan your content as it is generated. Content
    /// Moderator then processes your content and sends the results along with
    /// relevant information either back to your systems or to the built-in
    /// review tool. You can use this information to take decisions e.g. take
    /// it down, send to human judge, etc.
    ///
    /// When using the API, images need to have a minimum of 128 pixels and a
    /// maximum file size of 4MB.
    /// Text can be at most 1024 characters long.
    /// If the content passed to the text API or the image API exceeds the size
    /// limits, the API will return an error code that informs about the issue.
    ///
    /// This API is currently available in:
    ///
    /// * West US - westus.api.cognitive.microsoft.com
    /// * East US 2 - eastus2.api.cognitive.microsoft.com
    /// * West Central US - westcentralus.api.cognitive.microsoft.com
    /// * West Europe - westeurope.api.cognitive.microsoft.com
    /// * Southeast Asia - southeastasia.api.cognitive.microsoft.com .
    /// </summary>
    public partial class ContentModeratorClient : ServiceClient<ContentModeratorClient>, IContentModeratorClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        internal string BaseUri {get; set;}

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Supported Azure regions for Content Moderator endpoints. Possible values
        /// include: 'westus.api.cognitive.microsoft.com',
        /// 'westus2.api.cognitive.microsoft.com',
        /// 'eastus.api.cognitive.microsoft.com',
        /// 'eastus2.api.cognitive.microsoft.com',
        /// 'westcentralus.api.cognitive.microsoft.com',
        /// 'southcentralus.api.cognitive.microsoft.com',
        /// 'westeurope.api.cognitive.microsoft.com',
        /// 'northeurope.api.cognitive.microsoft.com',
        /// 'southeastasia.api.cognitive.microsoft.com',
        /// 'eastasia.api.cognitive.microsoft.com',
        /// 'australiaeast.api.cognitive.microsoft.com',
        /// 'brazilsouth.api.cognitive.microsoft.com',
        /// 'contentmoderatortest.azure-api.net'
        /// </summary>
        public string BaseUrl { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client subscription.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Gets the IImageModeration.
        /// </summary>
        public virtual IImageModeration ImageModeration { get; private set; }

        /// <summary>
        /// Gets the ITextModeration.
        /// </summary>
        public virtual ITextModeration TextModeration { get; private set; }

        /// <summary>
        /// Gets the IListManagementImageLists.
        /// </summary>
        public virtual IListManagementImageLists ListManagementImageLists { get; private set; }

        /// <summary>
        /// Gets the IListManagementTermLists.
        /// </summary>
        public virtual IListManagementTermLists ListManagementTermLists { get; private set; }

        /// <summary>
        /// Gets the IListManagementImage.
        /// </summary>
        public virtual IListManagementImage ListManagementImage { get; private set; }

        /// <summary>
        /// Gets the IListManagementTerm.
        /// </summary>
        public virtual IListManagementTerm ListManagementTerm { get; private set; }

        /// <summary>
        /// Gets the IReviews.
        /// </summary>
        public virtual IReviews Reviews { get; private set; }

        /// <summary>
        /// Initializes a new instance of the ContentModeratorClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected ContentModeratorClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ContentModeratorClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected ContentModeratorClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the ContentModeratorClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ContentModeratorClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the ContentModeratorClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public ContentModeratorClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            ImageModeration = new ImageModeration(this);
            TextModeration = new TextModeration(this);
            ListManagementImageLists = new ListManagementImageLists(this);
            ListManagementTermLists = new ListManagementTermLists(this);
            ListManagementImage = new ListManagementImage(this);
            ListManagementTerm = new ListManagementTerm(this);
            Reviews = new Reviews(this);
            BaseUri = "https://{baseUrl}";
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }
    }
}
