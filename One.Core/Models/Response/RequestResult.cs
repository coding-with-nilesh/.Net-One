using One.Core.Validation;

namespace One.Core.Models.Authentication
{
    public class RequestResult<TResult>
    {
        public RequestResult(TResult result)
        {
            Result = result;
        }

        public RequestResult(ValidationResult validationResult)
        {
            HasError = true;
            ValidationResult = validationResult;
        }

        public RequestResult(ValidationResultForJson validationResult)
        {
            HasError = true;
            ValidationResult = new ValidationResult(validationResult.Errors);
        }

        public bool HasError { get; private set; }
        public ValidationResult ValidationResult { get; private set; }
        public TResult Result { get; private set; }
    }
}
