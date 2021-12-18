using System.Threading.Tasks;

namespace One.Core.WebContent
{
    /// <summary>
    /// Interface for service class to download the web content
    /// </summary>
    public interface IWebContentService
    {
        Task<string> GetWebContentAsync(string url);
    }
}
