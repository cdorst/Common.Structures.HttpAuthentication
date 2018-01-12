using System.Net.Http.Headers;

namespace Common.Structures.HttpAuthentication
{
    public abstract class HttpAuthentication
    {
        protected abstract string Prefix { get; }
        protected abstract string Value { get; }

        public AuthenticationHeaderValue Header
            => new AuthenticationHeaderValue(Prefix, Value);
    }
}
