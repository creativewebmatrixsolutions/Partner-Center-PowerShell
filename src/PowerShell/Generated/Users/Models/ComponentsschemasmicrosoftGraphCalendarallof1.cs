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
    /// calendar
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphCalendarallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphCalendarallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphCalendarallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphCalendarallof1 class.
        /// </summary>
        /// <param name="color">Possible values include: 'lightBlue',
        /// 'lightGreen', 'lightOrange', 'lightGray', 'lightYellow',
        /// 'lightTeal', 'lightPink', 'lightBrown', 'lightRed', 'maxColor',
        /// 'auto'</param>
        /// <param name="defaultOnlineMeetingProvider">Possible values include:
        /// 'unknown', 'skypeForBusiness', 'skypeForConsumer',
        /// 'teamsForBusiness'</param>
        public ComponentsschemasmicrosoftGraphCalendarallof1(string name = default(string), string color = default(string), string hexColor = default(string), bool? isDefaultCalendar = default(bool?), string changeKey = default(string), bool? canShare = default(bool?), bool? canViewPrivateItems = default(bool?), bool? isShared = default(bool?), bool? isSharedWithMe = default(bool?), bool? canEdit = default(bool?), MicrosoftgraphemailAddress owner = default(MicrosoftgraphemailAddress), IList<string> allowedOnlineMeetingProviders = default(IList<string>), string defaultOnlineMeetingProvider = default(string), bool? isTallyingResponses = default(bool?), bool? isRemovable = default(bool?), IList<MicrosoftgraphsingleValueLegacyExtendedProperty> singleValueExtendedProperties = default(IList<MicrosoftgraphsingleValueLegacyExtendedProperty>), IList<MicrosoftgraphmultiValueLegacyExtendedProperty> multiValueExtendedProperties = default(IList<MicrosoftgraphmultiValueLegacyExtendedProperty>), IList<MicrosoftgraphcalendarPermission> calendarPermissions = default(IList<MicrosoftgraphcalendarPermission>), IList<Microsoftgraphevent> events = default(IList<Microsoftgraphevent>), IList<Microsoftgraphevent> calendarView = default(IList<Microsoftgraphevent>))
        {
            Name = name;
            Color = color;
            HexColor = hexColor;
            IsDefaultCalendar = isDefaultCalendar;
            ChangeKey = changeKey;
            CanShare = canShare;
            CanViewPrivateItems = canViewPrivateItems;
            IsShared = isShared;
            IsSharedWithMe = isSharedWithMe;
            CanEdit = canEdit;
            Owner = owner;
            AllowedOnlineMeetingProviders = allowedOnlineMeetingProviders;
            DefaultOnlineMeetingProvider = defaultOnlineMeetingProvider;
            IsTallyingResponses = isTallyingResponses;
            IsRemovable = isRemovable;
            SingleValueExtendedProperties = singleValueExtendedProperties;
            MultiValueExtendedProperties = multiValueExtendedProperties;
            CalendarPermissions = calendarPermissions;
            Events = events;
            CalendarView = calendarView;
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
        /// Gets or sets possible values include: 'lightBlue', 'lightGreen',
        /// 'lightOrange', 'lightGray', 'lightYellow', 'lightTeal',
        /// 'lightPink', 'lightBrown', 'lightRed', 'maxColor', 'auto'
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hexColor")]
        public string HexColor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isDefaultCalendar")]
        public bool? IsDefaultCalendar { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "changeKey")]
        public string ChangeKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canShare")]
        public bool? CanShare { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canViewPrivateItems")]
        public bool? CanViewPrivateItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isShared")]
        public bool? IsShared { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isSharedWithMe")]
        public bool? IsSharedWithMe { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canEdit")]
        public bool? CanEdit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public MicrosoftgraphemailAddress Owner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowedOnlineMeetingProviders")]
        public IList<string> AllowedOnlineMeetingProviders { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'unknown',
        /// 'skypeForBusiness', 'skypeForConsumer', 'teamsForBusiness'
        /// </summary>
        [JsonProperty(PropertyName = "defaultOnlineMeetingProvider")]
        public string DefaultOnlineMeetingProvider { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isTallyingResponses")]
        public bool? IsTallyingResponses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isRemovable")]
        public bool? IsRemovable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "singleValueExtendedProperties")]
        public IList<MicrosoftgraphsingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "multiValueExtendedProperties")]
        public IList<MicrosoftgraphmultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarPermissions")]
        public IList<MicrosoftgraphcalendarPermission> CalendarPermissions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<Microsoftgraphevent> Events { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarView")]
        public IList<Microsoftgraphevent> CalendarView { get; set; }

    }
}
