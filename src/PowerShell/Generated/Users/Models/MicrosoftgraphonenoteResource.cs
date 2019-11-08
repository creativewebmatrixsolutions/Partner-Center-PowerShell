// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Store.PartnerCenter.PowerShell.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftgraphonenoteResource
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphonenoteResource
        /// class.
        /// </summary>
        public MicrosoftgraphonenoteResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphonenoteResource
        /// class.
        /// </summary>
        public MicrosoftgraphonenoteResource(string id = default(string), string self = default(string), byte[] content = default(byte[]), string contentUrl = default(string))
        {
            Id = id;
            Self = self;
            Content = content;
            ContentUrl = contentUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "self")]
        public string Self { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "content")]
        public byte[] Content { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contentUrl")]
        public string ContentUrl { get; set; }

    }
}
