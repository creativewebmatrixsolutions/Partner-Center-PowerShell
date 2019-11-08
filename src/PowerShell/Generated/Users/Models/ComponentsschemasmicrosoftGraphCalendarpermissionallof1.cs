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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// calendarPermission
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphCalendarpermissionallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphCalendarpermissionallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphCalendarpermissionallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphCalendarpermissionallof1 class.
        /// </summary>
        /// <param name="role">Possible values include: 'none', 'freeBusyRead',
        /// 'limitedRead', 'read', 'write',
        /// 'delegateWithoutPrivateEventAccess',
        /// 'delegateWithPrivateEventAccess', 'custom'</param>
        public ComponentsschemasmicrosoftGraphCalendarpermissionallof1(MicrosoftgraphemailAddress emailAddress = default(MicrosoftgraphemailAddress), bool? isRemovable = default(bool?), bool? isInsideOrganization = default(bool?), string role = default(string), IList<string> allowedRoles = default(IList<string>))
        {
            EmailAddress = emailAddress;
            IsRemovable = isRemovable;
            IsInsideOrganization = isInsideOrganization;
            Role = role;
            AllowedRoles = allowedRoles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public MicrosoftgraphemailAddress EmailAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isRemovable")]
        public bool? IsRemovable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isInsideOrganization")]
        public bool? IsInsideOrganization { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'none', 'freeBusyRead',
        /// 'limitedRead', 'read', 'write',
        /// 'delegateWithoutPrivateEventAccess',
        /// 'delegateWithPrivateEventAccess', 'custom'
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowedRoles")]
        public IList<string> AllowedRoles { get; set; }

    }
}
