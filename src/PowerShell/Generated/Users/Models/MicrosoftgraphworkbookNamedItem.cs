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

    public partial class MicrosoftgraphworkbookNamedItem
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphworkbookNamedItem
        /// class.
        /// </summary>
        public MicrosoftgraphworkbookNamedItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphworkbookNamedItem
        /// class.
        /// </summary>
        public MicrosoftgraphworkbookNamedItem(string id = default(string), string comment = default(string), string name = default(string), string scope = default(string), string type = default(string), object value = default(object), bool? visible = default(bool?), MicrosoftgraphworkbookWorksheet worksheet = default(MicrosoftgraphworkbookWorksheet))
        {
            Id = id;
            Comment = comment;
            Name = name;
            Scope = scope;
            Type = type;
            Value = value;
            Visible = visible;
            Worksheet = worksheet;
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
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string Scope { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "worksheet")]
        public MicrosoftgraphworkbookWorksheet Worksheet { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Worksheet != null)
            {
                Worksheet.Validate();
            }
        }
    }
}
