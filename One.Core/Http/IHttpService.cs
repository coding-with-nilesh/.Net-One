namespace One.Core.Http
{
    public interface IHttpService
    {
        public HttpResponse<string> PostJson<TRequest, TResponse>(string url, TRequest data);
    }
}