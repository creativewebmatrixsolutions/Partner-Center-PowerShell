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

    public partial class Microsoftgraphchannel
    {
        /// <summary>
        /// Initializes a new instance of the Microsoftgraphchannel class.
        /// </summary>
        public Microsoftgraphchannel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Microsoftgraphchannel class.
        /// </summary>
        /// <param name="membershipType">Possible values include: 'standard',
        /// 'private', 'unknownFutureValue'</param>
        public Microsoftgraphchannel(string id = default(string), string displayName = default(string), string description = default(string), bool? isFavoriteByDefault = default(bool?), string email = default(string), string webUrl = default(string), string membershipType = default(string), IList<MicrosoftgraphchatMessage> messages = default(IList<MicrosoftgraphchatMessage>), IList<MicrosoftgraphchatThread> chatThreads = default(IList<MicrosoftgraphchatThread>), IList<MicrosoftgraphteamsTab> tabs = default(IList<MicrosoftgraphteamsTab>), IList<MicrosoftgraphconversationMember> members = default(IList<MicrosoftgraphconversationMember>), MicrosoftgraphdriveItem filesFolder = default(MicrosoftgraphdriveItem))
        {
            Id = id;
            DisplayName = displayName;
            Description = description;
            IsFavoriteByDefault = isFavoriteByDefault;
            Email = email;
            WebUrl = webUrl;
            MembershipType = membershipType;
            Messages = messages;
            ChatThreads = chatThreads;
            Tabs = tabs;
            Members = members;
            FilesFolder = filesFolder;
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
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isFavoriteByDefault")]
        public bool? IsFavoriteByDefault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webUrl")]
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'standard', 'private',
        /// 'unknownFutureValue'
        /// </summary>
        [JsonProperty(PropertyName = "membershipType")]
        public string MembershipType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages")]
        public IList<MicrosoftgraphchatMessage> Messages { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "chatThreads")]
        public IList<MicrosoftgraphchatThread> ChatThreads { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tabs")]
        public IList<MicrosoftgraphteamsTab> Tabs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<MicrosoftgraphconversationMember> Members { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filesFolder")]
        public MicrosoftgraphdriveItem FilesFolder { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FilesFolder != null)
            {
                FilesFolder.Validate();
            }
        }
    }
}
