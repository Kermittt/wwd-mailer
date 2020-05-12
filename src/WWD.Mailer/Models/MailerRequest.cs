using System;
using System.Collections.Generic;

namespace WWD.Mailer.Models
{
    public class MailerRequest
    {
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public string Subject { get; set; }
        public Guid TemplateKey { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}
