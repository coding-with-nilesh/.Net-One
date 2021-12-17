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
            HasError = true;
            ValidationResult = validationResult;
        }

        public bool HasError { get; private set; }
        public ValidationResult ValidationResult { get; private set; }
    }
}
