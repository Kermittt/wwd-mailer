using System;
using System.Threading;
using System.Threading.Tasks;

namespace WWD.Mailer.Interfaces
{
    public interface ITemplateRenderer
    {
        Task<string> RenderTemplate(Guid templateKey, CancellationToken cancellationToken = default);
    }
}
