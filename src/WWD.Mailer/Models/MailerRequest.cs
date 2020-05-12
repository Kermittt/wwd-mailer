using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace WWD.Mailer.Models
{
    /// <summary>
    /// A email template request to be processed.
    /// </summary>
    public class MailerRequest
    {
        /// <summary>
        /// The email address of the recipient.
        /// </summary>
        public string ToAddress { get; set; }

        /// <summary>
        /// The email address of the sender.
        /// </summary>
        public string FromAddress { get; set; }

        /// <summary>
        /// The subject of the email.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// The key of the template to render as the email body.
        /// </summary>
        public Guid TemplateKey { get; set; }

        /// <summary>
        /// Additional data for the template.
        /// </summary>
        public JObject TemplateData { get; set; }

        /// <summary>
        /// A list of <see cref="Attachment"/>s to include on the email.
        /// </summary>
        public List<Attachment> Attachments { get; set; }
    }
}
