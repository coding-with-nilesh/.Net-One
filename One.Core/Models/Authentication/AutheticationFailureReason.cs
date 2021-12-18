namespace One.Core.Models.Authentication
{
    public class AuthenticationFailureReason
    {
        public const string EmailMissing = "EmailMissing";
        public const string PasswordMissing = "PasswordMissing";
        public const string UserIdNotAvailable = "UserIdNotAvailable";
        public const string PasswordMismatch = "PasswordMismatch";
        public const string UserIdOrPasswordIncorrect = "UserIdOrPasswordIncorrect";
        public const string BlockedAccount = "BlockedAccount";
        public const string UnknownError = "UnknownError";
        public const string TokenExpired = "TokenExpired";
    }
}
