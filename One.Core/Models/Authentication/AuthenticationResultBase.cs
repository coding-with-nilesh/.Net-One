namespace One.Core.Models.Authentication
{
    public class AuthenticationResultBase<T>
    {
        public AuthenticationResultBase(T user)
        {
            User = user;
        }

        public AuthenticationResultBase(AuthenticationFailureReason failureReason)
        {
            FailureReason = failureReason;
            HasError = true;
        }

        public T User { get; protected set; }
        public bool HasError { get; protected set; }
        public AuthenticationFailureReason? FailureReason { get; protected set; }
    }
}
