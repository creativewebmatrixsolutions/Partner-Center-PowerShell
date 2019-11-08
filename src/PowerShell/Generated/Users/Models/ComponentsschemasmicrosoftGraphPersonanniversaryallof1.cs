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
    /// personAnniversary
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphPersonanniversaryallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphPersonanniversaryallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphPersonanniversaryallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphPersonanniversaryallof1 class.
        /// </summary>
        /// <param name="type">Possible values include: 'birthday', 'wedding',
        /// 'unknownFutureValue'</param>
        public ComponentsschemasmicrosoftGraphPersonanniversaryallof1(string type = default(string), System.DateTime? date = default(System.DateTime?))
        {
            Type = type;
            Date = date;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'birthday', 'wedding',
        /// 'unknownFutureValue'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "date")]
        public System.DateTime? Date { get; set; }

    }
}
