using One.Core.Validation;

namespace One.Core.Models.Authentication
{
    public class UserRegistrationResultBase
    {
        public UserRegistrationResultBase()
        {
        }

        public UserRegistrationResultBase(ValidationResult validationResult)
        {
            HasErrors = true;
            ValidationResult = validationResult;
        }

        public bool HasErrors { get; private set; }
        public ValidationResult ValidationResult { get; private set; }
    }
}
