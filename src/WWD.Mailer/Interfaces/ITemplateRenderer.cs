using System;
using System.Threading;
using System.Threading.Tasks;

namespace WWD.Mailer.Interfaces
{
    /// <summary>
    /// Client service for connecting to an external template renderer service.
    /// </summary>
    public interface ITemplateRenderer
    {
        /// <summary>
        /// Renders a template.
        /// </summary>
        /// <param name="key">The key of the template to render.</param>
        /// <param name="data">A JSON string containing additional data for the template.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>A HTML string containing the rendered template.</returns>
        Task<string> RenderTemplate(Guid key, string data, CancellationToken cancellationToken = default);
    }
}
