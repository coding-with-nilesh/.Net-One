﻿namespace One.Core.Models.Authentication
{
    public class RegisterationRequest
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
        public string Role { get; set; }
    }
}
