using System;

namespace One.Core.Models.Authentication
{
    public abstract class UserBase
    {
        public string Id { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public UserStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? LastLoginOn { get; set; }
        public string Attributes { get; set; }
    }
}
