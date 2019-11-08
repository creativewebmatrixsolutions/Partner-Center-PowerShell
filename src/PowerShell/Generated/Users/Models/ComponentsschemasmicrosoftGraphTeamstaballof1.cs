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
    /// teamsTab
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphTeamstaballof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphTeamstaballof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphTeamstaballof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphTeamstaballof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphTeamstaballof1(string name = default(string), string displayName = default(string), string teamsAppId = default(string), string sortOrderIndex = default(string), string messageId = default(string), string webUrl = default(string), MicrosoftgraphteamsTabConfiguration configuration = default(MicrosoftgraphteamsTabConfiguration), MicrosoftgraphteamsApp teamsApp = default(MicrosoftgraphteamsApp))
        {
            Name = name;
            DisplayName = displayName;
            TeamsAppId = teamsAppId;
            SortOrderIndex = sortOrderIndex;
            MessageId = messageId;
            WebUrl = webUrl;
            Configuration = configuration;
            TeamsApp = teamsApp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamsAppId")]
        public string TeamsAppId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sortOrderIndex")]
        public string SortOrderIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webUrl")]
        public string WebUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public MicrosoftgraphteamsTabConfiguration Configuration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamsApp")]
        public MicrosoftgraphteamsApp TeamsApp { get; set; }

    }
}
