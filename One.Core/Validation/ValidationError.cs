namespace One.Core.Validation
{
    public class ValidationError
    {
        public ValidationError(string field, ErrorType? errorType = null, string message = null)
        {
            Field = field;
            ErrorType = errorType;
            Message = message;
        }

        // [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; }
        public ErrorType? ErrorType { get; }
        public string Message { get; }
    }
}
