using System;
using System.Threading;
using System.Threading.Tasks;
using WWD.Mailer.Interfaces;

namespace WWD.Mailer.Services
{
    public class TemplateRenderer : ITemplateRenderer
    {
        public Task<string> RenderTemplate(Guid templateKey, CancellationToken cancellationToken = default)
        {
            // TODO : This service should make a call to the external template renderer and return the resulting html string
            return Task.FromResult("<html><body><h1>I am a template</h1></body></html>");
        }
    }
}
