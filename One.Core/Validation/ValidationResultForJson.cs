using System.Collections.Generic;
using System.Linq;

namespace One.Core.Validation
{
    // Duplicate of ValidationResult, but supports JSON deserialization by making properties public
    public class ValidationResultForJson
    {
        private List<ValidationError> _errors = new List<ValidationError>();

        #region Properties
        public IEnumerable<ValidationError> Errors
        {
            get
            {
                return _errors;
            }
            set
            {
                _errors = value.ToList();
            }
        }
        public bool HasErrors { get; set; }
        #endregion
    }
}
