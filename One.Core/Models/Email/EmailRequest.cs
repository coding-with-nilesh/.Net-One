using System.Collections.Generic;

namespace One.Core.Models.Email
{
    public class EmailRequest
    {
        public EmailAddress From { get; set; }
        public IEnumerable<EmailAddress> Tos { get; set; }
    }

    public class EmailRequestWithId : EmailRequest
    {
        public string ApplicationId { get; set; }
    }
}
