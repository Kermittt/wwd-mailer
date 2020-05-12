namespace WWD.Mailer.Models
{
    /// <summary>
    /// Email attachment for a <see cref="MailerRequest"/>.
    /// </summary>
    public class Attachment
    {
        /// <summary>
        /// Name of the attachment.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// URI describing where the attachment blob can be retrieved from.
        /// </summary>
        public string Uri { get; set; }
    }
}
