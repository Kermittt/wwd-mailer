using System.Linq;
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
        private readonly IEmailService _emailService;

        public MailerRequestProcessor(ILogger<IMailerRequestProcessor> log, ITemplateRenderer templateRenderer, IEmailService emailService)
        {
            _log = log;
            _templateRenderer = templateRenderer;
            _emailService = emailService;
        }

        public async Task ProcessRequest(MailerRequest request, CancellationToken cancellationToken = default)
        {
            // Render template
            _log.LogInformation($"Rendering template '{request.TemplateKey}'.");
            var html = await _templateRenderer.RenderTemplate(request.TemplateKey, cancellationToken);

            // Send email
            _log.LogInformation($"Sending email for template '{request.TemplateKey}' to '{request.ToAddress}'.");
            var attachmentUris = request.Attachments.Select(a => a.Uri).ToList();
            await _emailService.SendEmail(request.ToAddress, request.FromAddress, request.Subject, html, attachmentUris, cancellationToken);
        }
    }
}
