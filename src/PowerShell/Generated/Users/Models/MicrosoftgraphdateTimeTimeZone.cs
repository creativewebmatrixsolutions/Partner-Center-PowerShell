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
    /// dateTimeTimeZone
    /// </summary>
    public partial class MicrosoftgraphdateTimeTimeZone
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphdateTimeTimeZone
        /// class.
        /// </summary>
        public MicrosoftgraphdateTimeTimeZone()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphdateTimeTimeZone
        /// class.
        /// </summary>
        public MicrosoftgraphdateTimeTimeZone(string dateTime = default(string), string timeZone = default(string))
        {
            DateTime = dateTime;
            TimeZone = timeZone;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateTime")]
        public string DateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

    }
}
