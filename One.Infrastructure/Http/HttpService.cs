using One.Core.Http;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;

namespace One.Infrastructure.Http
{
    public class HttpService : IHttpService
    {
        public HttpResponse<TResponse> PostJson<TRequest, TResponse>(string url, TRequest data)
        {
            var request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/atom+xml;type=entry";

            var json = JsonSerializer.Serialize(data);
            byte[] byteArray = Encoding.UTF8.GetBytes(json);

            request.ContentType = RequestDataType.Json;
            request.ContentLength = byteArray.Length;

            using var reqStream = request.GetRequestStream();
            reqStream.Write(byteArray, 0, byteArray.Length);

            using var response = request.GetResponse();
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            using var respStream = response.GetResponseStream();
            using var reader = new StreamReader(respStream);
            string responseData = reader.ReadToEnd();
            var responseObject = JsonSerializer.Deserialize<TResponse>(responseData);
            return new HttpResponse<TResponse> { Response = responseObject };
        }
    }
}
