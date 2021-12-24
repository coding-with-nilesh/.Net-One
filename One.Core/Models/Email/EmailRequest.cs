using System.Collections.Generic;

namespace One.Core.Models.Email
{
    public class EmailRequest
    {
        public string EmailType { get; set; }
        public IEnumerable<EmailAddress> Tos { get; set; }
        public EmailAddress From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
