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
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftgraphresourceSpecificPermissionGrant
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphresourceSpecificPermissionGrant class.
        /// </summary>
        public MicrosoftgraphresourceSpecificPermissionGrant()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphresourceSpecificPermissionGrant class.
        /// </summary>
        public MicrosoftgraphresourceSpecificPermissionGrant(string id = default(string), System.DateTime? deletedDateTime = default(System.DateTime?), string clientId = default(string), string clientAppId = default(string), string resourceAppId = default(string), string permissionType = default(string), string permission = default(string))
        {
            Id = id;
            DeletedDateTime = deletedDateTime;
            ClientId = clientId;
            ClientAppId = clientAppId;
            ResourceAppId = resourceAppId;
            PermissionType = permissionType;
            Permission = permission;
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
        [JsonProperty(PropertyName = "deletedDateTime")]
        public System.DateTime? DeletedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientAppId")]
        public string ClientAppId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resourceAppId")]
        public string ResourceAppId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "permissionType")]
        public string PermissionType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "permission")]
        public string Permission { get; set; }

    }
}
