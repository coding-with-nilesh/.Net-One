using One.Core.Models.Authentication;

namespace One.Core.Authentication
{
    public class AuthenticationRequestWithId: AuthenticationRequestBase
    {
        public string ApplicationId { get; set; }
    }
}
