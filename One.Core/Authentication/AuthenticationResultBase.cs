using One.Core.Enums;

namespace One.Core.Authentication
{
    public class AuthenticationResultBase<T>
    {
        public AuthenticationResultBase(AuthenticationFailureReason failureReason)
        {
            FailureReason = failureReason;
            IsSuccess = false;
        }

        public AuthenticationResultBase(T user)
        {
            IsSuccess = true;
        }

        public string Id { get; protected set; }
        public bool IsSuccess { get; protected set; }
        public string Role { get; protected set; }
        public string EmailId { get; protected set; }
        public string MobileNumber { get; protected set; }
        public AuthenticationFailureReason? FailureReason { get; protected set; }
    }
}
