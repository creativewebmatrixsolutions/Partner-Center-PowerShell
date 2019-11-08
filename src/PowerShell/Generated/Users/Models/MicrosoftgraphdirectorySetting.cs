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

    public partial class MicrosoftgraphdirectorySetting
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphdirectorySetting
        /// class.
        /// </summary>
        public MicrosoftgraphdirectorySetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphdirectorySetting
        /// class.
        /// </summary>
        public MicrosoftgraphdirectorySetting(string id = default(string), string displayName = default(string), string templateId = default(string), IList<MicrosoftgraphsettingValue> values = default(IList<MicrosoftgraphsettingValue>))
        {
            Id = id;
            DisplayName = displayName;
            TemplateId = templateId;
            Values = values;
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
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "templateId")]
        public string TemplateId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<MicrosoftgraphsettingValue> Values { get; set; }

    }
}
