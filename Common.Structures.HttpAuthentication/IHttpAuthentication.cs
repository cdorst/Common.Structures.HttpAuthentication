using System.Net.Http.Headers;

namespace Common.Structures.HttpAuthentication
{
    public interface IHttpAuthentication
    {
        AuthenticationHeaderValue Header { get; }
    }
}
