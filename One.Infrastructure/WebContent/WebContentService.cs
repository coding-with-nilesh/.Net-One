using System;
using System.Net;
using System.Threading.Tasks;
using One.Core.WebContent;

namespace One.Infrastructure.WebContent
{
    // One instance of webclient can not download more than one URI at time.
    public class WebContentService : IWebContentService
    {
        public Task<string> GetWebContentAsync(string url)
        {
            return Task.Run(() =>
            {
                var webClient = new WebClient();
                return webClient.DownloadString(new Uri(url));
            });
        }
    }
}
