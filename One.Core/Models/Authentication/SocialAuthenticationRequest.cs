namespace One.Core.Models.Authentication
{
    public class SocialAuthenticationRequest
    {
        public string Token { get; set; }
        public string Role { get; set; }
        public string Provider { get; set; }
    }
}
