using System.Collections.Generic;
using System.Linq;

namespace One.Core.Validation
{
    public class ValidationResult
    {
        private readonly List<ValidationError> _errors = new List<ValidationError>();

        #region Ctor
        public ValidationResult() : this(new List<ValidationError>())
        {
        }

        public ValidationResult(IEnumerable<ValidationError> errors, string message = null)
        {
            Message = message;
            AddErrors(errors);
        }
        #endregion

        #region Properties
        public string Message { get; }
        public IEnumerable<ValidationError> Errors
        {
            get
            {
                return _errors;
            }
        }
        public bool HasErrors { get; private set; }
        #endregion

        #region Public methods
        public void AddError(string field, string message)
        {
            AddError(new ValidationError(field, errorType: null, message));
        }

        public void AddError(string field, ErrorType errorType, string message = null)
        {
            AddError(new ValidationError(field, errorType, message));
        }

        public void AddError(ValidationError validationError)
        {
            _errors.Add(validationError);
            HasErrors = _errors.Any();
        }

        public void AddErrors(IEnumerable<ValidationError> validationErrors)
        {
            _errors.AddRange(validationErrors);
            HasErrors = _errors.Any();
        }
        #endregion
    }
}
