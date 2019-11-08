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
    /// followupFlag
    /// </summary>
    public partial class MicrosoftgraphfollowupFlag
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphfollowupFlag class.
        /// </summary>
        public MicrosoftgraphfollowupFlag()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphfollowupFlag class.
        /// </summary>
        /// <param name="flagStatus">Possible values include: 'notFlagged',
        /// 'complete', 'flagged'</param>
        public MicrosoftgraphfollowupFlag(MicrosoftgraphdateTimeTimeZone completedDateTime = default(MicrosoftgraphdateTimeTimeZone), MicrosoftgraphdateTimeTimeZone dueDateTime = default(MicrosoftgraphdateTimeTimeZone), MicrosoftgraphdateTimeTimeZone startDateTime = default(MicrosoftgraphdateTimeTimeZone), string flagStatus = default(string))
        {
            CompletedDateTime = completedDateTime;
            DueDateTime = dueDateTime;
            StartDateTime = startDateTime;
            FlagStatus = flagStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "completedDateTime")]
        public MicrosoftgraphdateTimeTimeZone CompletedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dueDateTime")]
        public MicrosoftgraphdateTimeTimeZone DueDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startDateTime")]
        public MicrosoftgraphdateTimeTimeZone StartDateTime { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'notFlagged', 'complete',
        /// 'flagged'
        /// </summary>
        [JsonProperty(PropertyName = "flagStatus")]
        public string FlagStatus { get; set; }

    }
}
