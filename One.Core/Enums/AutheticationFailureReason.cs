namespace One.Core.Enums
{
    public enum AuthenticationFailureReason
    {
        EmailMissing,
        PasswordMissing,
        UserIdNotAvailable,
        PasswordMismatch,
        UserIdOrPasswordIncorrect,
        BlockedAccount,
    }
}
