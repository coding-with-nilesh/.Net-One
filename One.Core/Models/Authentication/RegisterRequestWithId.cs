using One.Core.Models.Authentication;

namespace One.Core.Authentication
{
    public class RegisterRequestWithId: RegisterRequest
    {
        public string ApplicationId { get; set; }
    }
}
