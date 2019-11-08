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

    /// <summary>
    /// thumbnail
    /// </summary>
    public partial class Microsoftgraphthumbnail
    {
        /// <summary>
        /// Initializes a new instance of the Microsoftgraphthumbnail class.
        /// </summary>
        public Microsoftgraphthumbnail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Microsoftgraphthumbnail class.
        /// </summary>
        public Microsoftgraphthumbnail(byte[] content = default(byte[]), int? height = default(int?), string sourceItemId = default(string), string url = default(string), int? width = default(int?))
        {
            Content = content;
            Height = height;
            SourceItemId = sourceItemId;
            Url = url;
            Width = width;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "content")]
        public byte[] Content { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceItemId")]
        public string SourceItemId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Height > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Height", 2147483647);
            }
            if (Height < -2147483648)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Height", -2147483648);
            }
            if (Width > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Width", 2147483647);
            }
            if (Width < -2147483648)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Width", -2147483648);
            }
        }
    }
}
