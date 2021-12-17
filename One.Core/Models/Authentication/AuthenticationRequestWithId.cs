using One.Core.Models.Authentication;

namespace One.Core.Authentication
{
    public class AuthenticationRequestWithId: AuthenticationRequest
    {
        public string ApplicationId { get; set; }
    }
}
