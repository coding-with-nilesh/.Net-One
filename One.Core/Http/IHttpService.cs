namespace One.Core.Http
{
    public interface IHttpService
    {
        public HttpResponse<TResponse> PostJson<TRequest, TResponse>(string url, TRequest data);
    }
}