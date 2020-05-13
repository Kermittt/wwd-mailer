using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WWD.Mailer.Interfaces;

namespace WWD.Mailer.Services
{
    /// <inheritdoc cref="IEmailService" />
    public class EmailService : IEmailService
    {
        /// <inheritdoc />
        public Task SendEmail(string toAddress, string fromAddress, string subject, string body, IEnumerable<string> attachmentUris, CancellationToken cancellationToken = default)
        {
            // Dummy exception to test retries
            //throw new Exception("Failed to send email.");

            // TODO : This service should make a call to the external email service to send the email
            return Task.CompletedTask;
        }
    }
}
