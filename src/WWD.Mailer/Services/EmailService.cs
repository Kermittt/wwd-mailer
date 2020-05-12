using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WWD.Mailer.Interfaces;

namespace WWD.Mailer.Services
{
    public class EmailService : IEmailService
    {
        public Task SendEmail(string toAddress, string fromAddress, string subject, string body, IEnumerable<string> attachmentUris, CancellationToken cancellationToken = default)
        {
            // TODO : This service should make a call to the external email service to send the email
            return Task.CompletedTask;
        }
    }
}
