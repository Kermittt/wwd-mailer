using System.Threading;
using System.Threading.Tasks;
using WWD.Mailer.Models;

namespace WWD.Mailer.Interfaces
{
    public interface IMailerRequestProcessor
    {
        Task ProcessRequest(MailerRequest request, CancellationToken cancellationToken = default);
    }
}
