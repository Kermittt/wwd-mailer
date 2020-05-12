using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace WWD.Mailer.Interfaces
{
    public interface IEmailService
    {
        Task SendEmail(string toAddress, string fromAddress, string subject, string body, IEnumerable<string> attachmentUris , CancellationToken cancellationToken = default);
    }
}
