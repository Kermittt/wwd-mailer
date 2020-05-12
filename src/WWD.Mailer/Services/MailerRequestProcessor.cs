using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WWD.Mailer.Interfaces;
using WWD.Mailer.Models;

namespace WWD.Mailer.Services
{
    public class MailerRequestProcessor : IMailerRequestProcessor
    {
        private readonly ILogger<IMailerRequestProcessor> _log;

        public MailerRequestProcessor(ILogger<IMailerRequestProcessor> log)
        {
            _log = log;
        }

        public async Task ProcessRequest(MailerRequest request, CancellationToken cancellationToken = default)
        {
            
        }
    }
}
