using One.Core.Validation;

namespace One.Core.Models.Authentication
{
    public class UserResult<TUser>
    {
        public UserResult(TUser user)
        {
            User = user;
        }

        public UserResult(ValidationResult validationResult)
        {
            HasError = true;
            ValidationResult = validationResult;
        }

        public bool HasError { get; private set; }
        public ValidationResult ValidationResult { get; private set; }
        public TUser User { get; private set; }
    }
}
