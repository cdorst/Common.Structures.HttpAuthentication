using System.Net.Http.Headers;

namespace Common.Structures.HttpAuthentication
{
    public abstract class HttpAuthentication
    {
        public HttpAuthentication(string prefix, string value)
        {
            Prefix = prefix;
            Value = value;
        }

        public string Prefix { get; set; }
        public string Value { get; set; }

        public AuthenticationHeaderValue Header
            => new AuthenticationHeaderValue(Prefix, Value);
    }
}
