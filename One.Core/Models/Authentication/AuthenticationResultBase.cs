using One.Core.Enums;

namespace One.Core.Models.Authentication
{
    public class AuthenticationResultBase
    {
        public AuthenticationResultBase()
        {
        }

        public AuthenticationResultBase(AuthenticationFailureReason failureReason)
        {
            FailureReason = failureReason;
            HasError = true;
        }

        public string Id { get; protected set; }
        public bool HasError { get; protected set; }
        public string Role { get; protected set; }
        public string EmailId { get; protected set; }
        public string MobileNumber { get; protected set; }
        public AuthenticationFailureReason? FailureReason { get; protected set; }
    }
}
