using System.Collections.Generic;

namespace One.Core.Models.Email
{
    public class EmailRequestBase
    {
        public string EmailType { get; set; }
        public IEnumerable<EmailAddressBase> Tos { get; set; }
        public EmailAddressBase From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
