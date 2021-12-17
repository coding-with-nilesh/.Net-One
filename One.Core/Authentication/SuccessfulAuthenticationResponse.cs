using System;

namespace One.Core.Authentication
{
    public class SuccessfulAuthenticationResponse
    {
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public string Role { get; set; }
        public DateTime? LastLoggedOn { get; set; }
        public string Token { get; set; }
    }
}
