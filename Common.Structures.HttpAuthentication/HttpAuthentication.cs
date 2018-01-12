using System.Net.Http.Headers;

namespace Common.Structures.HttpAuthentication
{
    public abstract class HttpAuthentication
    {
        public HttpAuthentication(string prefix)
        {
            Prefix = prefix;
        }

        protected string Prefix { get; }
        protected abstract string Value { get; }

        public AuthenticationHeaderValue Header
            => new AuthenticationHeaderValue(Prefix, Value);
    }
}
