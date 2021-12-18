namespace One.Core.Validation
{
    public class ValidationError
    {
        // Field can be null when you are doing validation for entity instead of the field
        public ValidationError(string field, string errorType = null, string error = null)
        {
            Field = field;
            ErrorType = errorType;
            Error = error;
        }

        // [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; }
        public string ErrorType { get; }
        public string Error { get; }
    }
}
