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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// profilePhoto
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphProfilephotoallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphProfilephotoallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphProfilephotoallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphProfilephotoallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphProfilephotoallof1(int? height = default(int?), int? width = default(int?))
        {
            Height = height;
            Width = width;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Height > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Height", 2147483647);
            }
            if (Height < -2147483648)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Height", -2147483648);
            }
            if (Width > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Width", 2147483647);
            }
            if (Width < -2147483648)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Width", -2147483648);
            }
        }
    }
}
