using System.Net.Http.Headers;

namespace Common.Structures.HttpAuthentication
{
    public abstract class HttpAuthentication
    {
        protected readonly string _prefix;
        protected readonly string _value;

        public HttpAuthentication(string prefix, string value)
        {
            _prefix = prefix;
            _value = value;
        }

        public AuthenticationHeaderValue Header
            => new AuthenticationHeaderValue(_prefix, _value);
    }
}
