using ProtoBuf;
using System.Net.Http.Headers;

namespace Common.Structures.HttpAuthentication
{
    [ProtoContract]
    public abstract class HttpAuthentication
    {
        public HttpAuthentication(string prefix, string value)
        {
            Prefix = prefix;
            Value = value;
        }

        [ProtoMember(1)]
        public string Prefix { get; set; }

        [ProtoMember(2)]
        public string Value { get; set; }

        public AuthenticationHeaderValue Header
            => new AuthenticationHeaderValue(Prefix, Value);
    }
}
