using System.Threading.Tasks;

namespace One.Core.Http
{
    public interface IHttpService
    {
        public Task<HttpResponse<string>> PostJson<TRequest, TResponse>(string url, TRequest data);
    }
}