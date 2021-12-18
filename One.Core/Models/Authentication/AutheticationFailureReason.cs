namespace One.Core.Models.Authentication
{
    public enum AuthenticationFailureReason
    {
        EmailMissing,
        PasswordMissing,
        UserIdNotAvailable,
        PasswordMismatch,
        UserIdOrPasswordIncorrect,
        BlockedAccount,
        UnknownError,
        TokenExpired
    }
}
