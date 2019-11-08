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
    /// video
    /// </summary>
    public partial class Microsoftgraphvideo
    {
        /// <summary>
        /// Initializes a new instance of the Microsoftgraphvideo class.
        /// </summary>
        public Microsoftgraphvideo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Microsoftgraphvideo class.
        /// </summary>
        public Microsoftgraphvideo(int? audioBitsPerSample = default(int?), int? audioChannels = default(int?), string audioFormat = default(string), int? audioSamplesPerSecond = default(int?), int? bitrate = default(int?), long? duration = default(long?), string fourCC = default(string), double? frameRate = default(double?), int? height = default(int?), int? width = default(int?))
        {
            AudioBitsPerSample = audioBitsPerSample;
            AudioChannels = audioChannels;
            AudioFormat = audioFormat;
            AudioSamplesPerSecond = audioSamplesPerSecond;
            Bitrate = bitrate;
            Duration = duration;
            FourCC = fourCC;
            FrameRate = frameRate;
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
        [JsonProperty(PropertyName = "audioBitsPerSample")]
        public int? AudioBitsPerSample { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "audioChannels")]
        public int? AudioChannels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "audioFormat")]
        public string AudioFormat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "audioSamplesPerSecond")]
        public int? AudioSamplesPerSecond { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public long? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fourCC")]
        public string FourCC { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "frameRate")]
        public double? FrameRate { get; set; }

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
            if (AudioBitsPerSample > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "AudioBitsPerSample", 2147483647);
            }
            if (AudioBitsPerSample < -2147483648)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "AudioBitsPerSample", -2147483648);
            }
            if (AudioChannels > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "AudioChannels", 2147483647);
            }
            if (AudioChannels < -2147483648)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "AudioChannels", -2147483648);
            }
            if (AudioSamplesPerSecond > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "AudioSamplesPerSecond", 2147483647);
            }
            if (AudioSamplesPerSecond < -2147483648)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "AudioSamplesPerSecond", -2147483648);
            }
            if (Bitrate > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Bitrate", 2147483647);
            }
            if (Bitrate < -2147483648)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Bitrate", -2147483648);
            }
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