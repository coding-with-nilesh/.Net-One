using System.Net;

namespace One.Core.Http
{
    public class HttpResponse<TResponse>
    {
        public TResponse Response { get; set; }
        public bool  IsSuccess { get; set; }
        public string Error { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
