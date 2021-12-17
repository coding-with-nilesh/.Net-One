using One.Core.Http;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;

namespace One.Infrastructure.Http
{
    public class HttpService : IHttpService
    {
        public HttpResponse<string> PostJson<TRequest, TResponse>(string url, TRequest data)
        {
            try
            {
                var request = WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = RequestDataType.Json;

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
                return new HttpResponse<string> { Response = responseData, IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new HttpResponse<string> { Error = ex.Message };
            }

        }
    }
}
