namespace One.Core.Models.Authentication
{
    public class ResetPasswordRequest
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Code { get; set; }
    }
}
