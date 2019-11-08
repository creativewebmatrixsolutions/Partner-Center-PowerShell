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

    /// <summary>
    /// command
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphCommandallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphCommandallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphCommandallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphCommandallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphCommandallof1(string status = default(string), string type = default(string), string appServiceName = default(string), string packageFamilyName = default(string), string error = default(string), object payload = default(object), string permissionTicket = default(string), string postBackUri = default(string), MicrosoftgraphpayloadResponse responsepayload = default(MicrosoftgraphpayloadResponse))
        {
            Status = status;
            Type = type;
            AppServiceName = appServiceName;
            PackageFamilyName = packageFamilyName;
            Error = error;
            Payload = payload;
            PermissionTicket = permissionTicket;
            PostBackUri = postBackUri;
            Responsepayload = responsepayload;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AppServiceName")]
        public string AppServiceName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PackageFamilyName")]
        public string PackageFamilyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Error")]
        public string Error { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Payload")]
        public object Payload { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PermissionTicket")]
        public string PermissionTicket { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PostBackUri")]
        public string PostBackUri { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "responsepayload")]
        public MicrosoftgraphpayloadResponse Responsepayload { get; set; }

    }
}
