// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Preset for Media Encoder Standard.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.StandardEncoderPreset")]
    public partial class StandardEncoderPreset : Preset
    {
        /// <summary>
        /// Initializes a new instance of the StandardEncoderPreset class.
        /// </summary>
        public StandardEncoderPreset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StandardEncoderPreset class.
        /// </summary>
        /// <param name="streams">Gets the Stream definitions for this
        /// source.</param>
        /// <param name="filters">Gets or sets the filters for the
        /// preset.</param>
        /// <param name="codecs">Gets the list of codecs to use.</param>
        /// <param name="formats">Gets the list of outputs.</param>
        public StandardEncoderPreset(IList<StreamSelection> streams = default(IList<StreamSelection>), Filters filters = default(Filters), IList<Codec> codecs = default(IList<Codec>), IList<Format> formats = default(IList<Format>))
        {
            Streams = streams;
            Filters = filters;
            Codecs = codecs;
            Formats = formats;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the Stream definitions for this source.
        /// </summary>
        [JsonProperty(PropertyName = "streams")]
        public IList<StreamSelection> Streams { get; set; }

        /// <summary>
        /// Gets or sets the filters for the preset.
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public Filters Filters { get; set; }

        /// <summary>
        /// Gets the list of codecs to use.
        /// </summary>
        [JsonProperty(PropertyName = "codecs")]
        public IList<Codec> Codecs { get; set; }

        /// <summary>
        /// Gets the list of outputs.
        /// </summary>
        [JsonProperty(PropertyName = "formats")]
        public IList<Format> Formats { get; set; }

    }
}