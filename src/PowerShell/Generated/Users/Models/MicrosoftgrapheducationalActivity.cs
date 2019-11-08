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

    public partial class MicrosoftgrapheducationalActivity
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgrapheducationalActivity
        /// class.
        /// </summary>
        public MicrosoftgrapheducationalActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgrapheducationalActivity
        /// class.
        /// </summary>
        /// <param name="allowedAudiences">Possible values include: 'me',
        /// 'family', 'contacts', 'groupMembers', 'organization',
        /// 'federatedOrganizations', 'everyone', 'unknownFutureValue'</param>
        public MicrosoftgrapheducationalActivity(string id = default(string), string allowedAudiences = default(string), MicrosoftgraphinferenceData inference = default(MicrosoftgraphinferenceData), System.DateTime? createdDateTime = default(System.DateTime?), MicrosoftgraphidentitySet createdBy = default(MicrosoftgraphidentitySet), System.DateTime? lastModifiedDateTime = default(System.DateTime?), MicrosoftgraphidentitySet lastModifiedBy = default(MicrosoftgraphidentitySet), System.DateTime? completionMonthYear = default(System.DateTime?), System.DateTime? endMonthYear = default(System.DateTime?), MicrosoftgraphinstitutionData institution = default(MicrosoftgraphinstitutionData), MicrosoftgrapheducationalActivityDetail program = default(MicrosoftgrapheducationalActivityDetail), System.DateTime? startMonthYear = default(System.DateTime?))
        {
            Id = id;
            AllowedAudiences = allowedAudiences;
            Inference = inference;
            CreatedDateTime = createdDateTime;
            CreatedBy = createdBy;
            LastModifiedDateTime = lastModifiedDateTime;
            LastModifiedBy = lastModifiedBy;
            CompletionMonthYear = completionMonthYear;
            EndMonthYear = endMonthYear;
            Institution = institution;
            Program = program;
            StartMonthYear = startMonthYear;
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
        /// Gets or sets possible values include: 'me', 'family', 'contacts',
        /// 'groupMembers', 'organization', 'federatedOrganizations',
        /// 'everyone', 'unknownFutureValue'
        /// </summary>
        [JsonProperty(PropertyName = "allowedAudiences")]
        public string AllowedAudiences { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inference")]
        public MicrosoftgraphinferenceData Inference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdBy")]
        public MicrosoftgraphidentitySet CreatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedDateTime")]
        public System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedBy")]
        public MicrosoftgraphidentitySet LastModifiedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "completionMonthYear")]
        public System.DateTime? CompletionMonthYear { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endMonthYear")]
        public System.DateTime? EndMonthYear { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "institution")]
        public MicrosoftgraphinstitutionData Institution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "program")]
        public MicrosoftgrapheducationalActivityDetail Program { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startMonthYear")]
        public System.DateTime? StartMonthYear { get; set; }

    }
}
