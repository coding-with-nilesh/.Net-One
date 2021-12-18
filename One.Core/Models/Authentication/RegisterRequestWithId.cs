using One.Core.Models.Authentication;

namespace One.Core.Authentication
{
    public class RegisterRequestWithId: RegisterationRequest
    {
        public string ApplicationId { get; set; }
    }
}
