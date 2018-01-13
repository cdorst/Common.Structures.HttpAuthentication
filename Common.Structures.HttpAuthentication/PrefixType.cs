using Common.EnumStringValues;

namespace Common.Structures.HttpAuthentication
{
    public enum PrefixType : byte
    {
        [EnumStringValue(nameof(Basic))]
        Basic,
        [EnumStringValue(nameof(Bearer))]
        Bearer,
        [EnumStringValue(nameof(token))]
        token
    }
}
