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
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftgraphgroupLifecyclePolicy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphgroupLifecyclePolicy class.
        /// </summary>
        public MicrosoftgraphgroupLifecyclePolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphgroupLifecyclePolicy class.
        /// </summary>
        public MicrosoftgraphgroupLifecyclePolicy(string id = default(string), int? groupLifetimeInDays = default(int?), string managedGroupTypes = default(string), string alternateNotificationEmails = default(string))
        {
            Id = id;
            GroupLifetimeInDays = groupLifetimeInDays;
            ManagedGroupTypes = managedGroupTypes;
            AlternateNotificationEmails = alternateNotificationEmails;
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
        [JsonProperty(PropertyName = "groupLifetimeInDays")]
        public int? GroupLifetimeInDays { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "managedGroupTypes")]
        public string ManagedGroupTypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "alternateNotificationEmails")]
        public string AlternateNotificationEmails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (GroupLifetimeInDays > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "GroupLifetimeInDays", 2147483647);
            }
            if (GroupLifetimeInDays < -2147483648)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "GroupLifetimeInDays", -2147483648);
            }
        }
    }
}
