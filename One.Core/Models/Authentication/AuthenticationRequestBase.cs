namespace One.Core.Models.Authentication
{
    public class AuthenticationRequestBase
    {
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string EmailConfirmationCode { get; set; }
    }
}
