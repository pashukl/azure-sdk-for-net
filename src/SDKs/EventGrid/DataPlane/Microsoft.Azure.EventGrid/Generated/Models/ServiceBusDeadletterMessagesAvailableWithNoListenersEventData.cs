// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Schema of the Data property of an EventGridEvent for a
    /// Microsoft.ServiceBus.DeadletterMessagesAvailableWithNoListenersEvent
    /// event.
    /// </summary>
    public partial class ServiceBusDeadletterMessagesAvailableWithNoListenersEventData
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ServiceBusDeadletterMessagesAvailableWithNoListenersEventData
        /// class.
        /// </summary>
        public ServiceBusDeadletterMessagesAvailableWithNoListenersEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ServiceBusDeadletterMessagesAvailableWithNoListenersEventData
        /// class.
        /// </summary>
        /// <param name="namespaceName">The namespace name of the
        /// Microsoft.ServiceBus resource.</param>
        /// <param name="requestUri">The endpoint of the Microsoft.ServiceBus
        /// resource.</param>
        /// <param name="entityType">The entity type of the
        /// Microsoft.ServiceBus resource. Could be one of 'queue' or
        /// 'subscriber'.</param>
        /// <param name="queueName">The name of the Microsoft.ServiceBus queue.
        /// If the entity type is of type 'subscriber', then this value will be
        /// null.</param>
        /// <param name="topicName">The name of the Microsoft.ServiceBus topic.
        /// If the entity type is of type 'queue', then this value will be
        /// null.</param>
        /// <param name="subscriptionName">The name of the Microsoft.ServiceBus
        /// topic's subscription. If the entity type is of type 'queue', then
        /// this value will be null.</param>
        public ServiceBusDeadletterMessagesAvailableWithNoListenersEventData(string namespaceName = default(string), string requestUri = default(string), string entityType = default(string), string queueName = default(string), string topicName = default(string), string subscriptionName = default(string))
        {
            NamespaceName = namespaceName;
            RequestUri = requestUri;
            EntityType = entityType;
            QueueName = queueName;
            TopicName = topicName;
            SubscriptionName = subscriptionName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the namespace name of the Microsoft.ServiceBus
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "namespaceName")]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Gets or sets the endpoint of the Microsoft.ServiceBus resource.
        /// </summary>
        [JsonProperty(PropertyName = "requestUri")]
        public string RequestUri { get; set; }

        /// <summary>
        /// Gets or sets the entity type of the Microsoft.ServiceBus resource.
        /// Could be one of 'queue' or 'subscriber'.
        /// </summary>
        [JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or sets the name of the Microsoft.ServiceBus queue. If the
        /// entity type is of type 'subscriber', then this value will be null.
        /// </summary>
        [JsonProperty(PropertyName = "queueName")]
        public string QueueName { get; set; }

        /// <summary>
        /// Gets or sets the name of the Microsoft.ServiceBus topic. If the
        /// entity type is of type 'queue', then this value will be null.
        /// </summary>
        [JsonProperty(PropertyName = "topicName")]
        public string TopicName { get; set; }

        /// <summary>
        /// Gets or sets the name of the Microsoft.ServiceBus topic's
        /// subscription. If the entity type is of type 'queue', then this
        /// value will be null.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionName")]
        public string SubscriptionName { get; set; }

    }
}
