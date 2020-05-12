using System.Threading;
using System.Threading.Tasks;
using WWD.Mailer.Models;

namespace WWD.Mailer.Interfaces
{
    /// <summary>
    /// Processor for <see cref="MailerRequest"/>s.
    /// </summary>
    public interface IMailerRequestProcessor
    {
        /// <summary>
        /// Processes a single <see cref="MailerRequest"/>.
        /// </summary>
        /// <param name="request">The <see cref="MailerRequest"/> to process.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
        Task ProcessRequest(MailerRequest request, CancellationToken cancellationToken = default);
    }
}
