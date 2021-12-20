using One.Core.Http;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace One.Infrastructure.Http
{
    public class HttpService : IHttpService
    {
        //HttpClient should be instancied once and not be disposed 
        private static readonly HttpClient client = new HttpClient();

        //public HttpResponse<string> PostJson<TRequest, TResponse>(string url, TRequest data)
        //{
        //    try
        //    {
        //        var request = WebRequest.Create(url);
        //        request.Method = "POST";
        //        request.ContentType = RequestDataType.Json;

        //        var json = JsonSerializer.Serialize(data);
        //        byte[] byteArray = Encoding.UTF8.GetBytes(json);

        //        request.ContentType = RequestDataType.Json;
        //        request.ContentLength = byteArray.Length;

        //        using var reqStream = request.GetRequestStream();
        //        reqStream.Write(byteArray, 0, byteArray.Length);

        //        using var response = request.GetResponse();
        //        //Console.WriteLine(((HttpWebResponse)response).StatusDescription);

        //        using var respStream = response.GetResponseStream();
        //        using var reader = new StreamReader(respStream);
        //        string responseData = reader.ReadToEnd();
        //        return new HttpResponse<string> { Response = responseData, IsSuccess = true };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new HttpResponse<string> { Error = ex.Message };
        //    }

        //}

        public async Task<HttpResponse<string>> PostJson<TRequest, TResponse>(string url, TRequest data)
        {
            try
            {
                var jsonObject = JsonSerializer.Serialize(data);
                var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                var response = client.PostAsync(url, content).Result;
                var responseString = await response.Content.ReadAsStringAsync();
                return new HttpResponse<string> { Response = responseString, StatusCode = response.StatusCode, IsSuccess = response.IsSuccessStatusCode };
            }
            catch (Exception ex)
            {
                return new HttpResponse<string> { Error = ex.Message };
            }

        }
    }
}
