using System.Collections.Generic;

namespace One.Core.Models.Email
{
    public class EmailRequest
    {
        public string EmailType { get; set; }
        public IEnumerable<EmailAddress> Tos { get; set; }
        public EmailAddress From { get; set; }
        public object TemplateData { get; set; }
    }

    public class EmailRequestWithId : EmailRequest
    {
        public string ApplicationId { get; set; }
    }
}
