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

        public ValidationResult(string error) : this(null, error)
        {
        }

        public ValidationResult(string errorType, string error) : this(new List<ValidationError> { new ValidationError(null, errorType, error) })
        {
        }

        public ValidationResult(IEnumerable<ValidationError> errors)
        {
            AddErrors(errors);
        }
        #endregion

        #region Properties
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
        public void AddError(string field, string error)
        {
            AddError(new ValidationError(field, errorType: null, error));
        }

        public void AddError(string field, string errorType, string error = null)
        {
            AddError(new ValidationError(field, errorType, error));
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
