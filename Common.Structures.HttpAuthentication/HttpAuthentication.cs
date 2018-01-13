using Common.EnumStringValues;
using ProtoBuf;
using System.Net.Http.Headers;

namespace Common.Structures.HttpAuthentication
{
    [ProtoContract]
    public class HttpAuthentication
    {
        public HttpAuthentication(PrefixType prefix, string value)
        {
            Prefix = prefix;
            Value = value;
        }

        [ProtoMember(1)]
        public PrefixType Prefix { get; set; }

        [ProtoMember(2)]
        public string Value { get; set; }

        public AuthenticationHeaderValue Header
            => new AuthenticationHeaderValue(Prefix.GetStringValue(), Value);
    }
}
