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
    /// objectIdentity
    /// </summary>
    public partial class MicrosoftgraphobjectIdentity
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphobjectIdentity
        /// class.
        /// </summary>
        public MicrosoftgraphobjectIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphobjectIdentity
        /// class.
        /// </summary>
        public MicrosoftgraphobjectIdentity(string signInType = default(string), string issuer = default(string), string issuerAssignedId = default(string))
        {
            SignInType = signInType;
            Issuer = issuer;
            IssuerAssignedId = issuerAssignedId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "signInType")]
        public string SignInType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issuerAssignedId")]
        public string IssuerAssignedId { get; set; }

    }
}
