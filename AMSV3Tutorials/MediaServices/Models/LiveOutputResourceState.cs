// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for LiveOutputResourceState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LiveOutputResourceState
    {
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Deleting")]
        Deleting
    }
    internal static class LiveOutputResourceStateEnumExtension
    {
        internal static string ToSerializedValue(this LiveOutputResourceState? value)
        {
            return value == null ? null : ((LiveOutputResourceState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this LiveOutputResourceState value)
        {
            switch( value )
            {
                case LiveOutputResourceState.Creating:
                    return "Creating";
                case LiveOutputResourceState.Running:
                    return "Running";
                case LiveOutputResourceState.Deleting:
                    return "Deleting";
            }
            return null;
        }

        internal static LiveOutputResourceState? ParseLiveOutputResourceState(this string value)
        {
            switch( value )
            {
                case "Creating":
                    return LiveOutputResourceState.Creating;
                case "Running":
                    return LiveOutputResourceState.Running;
                case "Deleting":
                    return LiveOutputResourceState.Deleting;
            }
            return null;
        }
    }
}