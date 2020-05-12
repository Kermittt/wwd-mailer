using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace WWD.Mailer.Interfaces
{
    /// <summary>
    /// Client library for connecting to an external email service.
    /// </summary>
    public interface IEmailService
    {
        /// <summary>
        /// Sends an email.
        /// </summary>
        /// <param name="toAddress">The email address of the recipient.</param>
        /// <param name="fromAddress">The email address of the sender.</param>
        /// <param name="subject">The subject of the email.</param>
        /// <param name="body">The body of the email.</param>
        /// <param name="attachmentUris">A list of strings containing URI's referencing blob data to include as attachments.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
        Task SendEmail(string toAddress, string fromAddress, string subject, string body, IEnumerable<string> attachmentUris , CancellationToken cancellationToken = default);
    }
}
