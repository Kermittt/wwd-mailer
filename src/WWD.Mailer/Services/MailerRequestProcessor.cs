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
        private readonly ITemplateRenderer _templateRenderer;

        public MailerRequestProcessor(ILogger<IMailerRequestProcessor> log, ITemplateRenderer templateRenderer)
        {
            _log = log;
            _templateRenderer = templateRenderer;
        }

        public async Task ProcessRequest(MailerRequest request, CancellationToken cancellationToken = default)
        {
            // Render template
            _log.LogInformation($"Rendering template {request.TemplateKey}");
            var html = await _templateRenderer.RenderTemplate(request.TemplateKey, cancellationToken);

            // Send email
            _log.LogInformation($"Sending email for template {request.TemplateKey} to {request.ToAddress}");

        }
    }
}
