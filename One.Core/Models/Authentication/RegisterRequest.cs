﻿namespace One.Core.Models.Authentication
{
    public class RegisterRequest
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string MobileNumber { get; set; }
    }
}