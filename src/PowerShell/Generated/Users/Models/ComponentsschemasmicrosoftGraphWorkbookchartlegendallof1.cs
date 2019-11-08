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
    /// workbookChartLegend
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphWorkbookchartlegendallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphWorkbookchartlegendallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphWorkbookchartlegendallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphWorkbookchartlegendallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphWorkbookchartlegendallof1(bool? overlay = default(bool?), string position = default(string), bool? visible = default(bool?), MicrosoftgraphworkbookChartLegendFormat format = default(MicrosoftgraphworkbookChartLegendFormat))
        {
            Overlay = overlay;
            Position = position;
            Visible = visible;
            Format = format;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overlay")]
        public bool? Overlay { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public MicrosoftgraphworkbookChartLegendFormat Format { get; set; }

    }
}
