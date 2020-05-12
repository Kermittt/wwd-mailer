using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using WWD.Mailer.Interfaces;
using WWD.Mailer.Services;

[assembly: FunctionsStartup(typeof(WWD.Mailer.Startup))]

namespace WWD.Mailer
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddTransient<IMailerRequestProcessor, MailerRequestProcessor>();
            builder.Services.AddTransient<ITemplateRenderer, TemplateRenderer>();
            builder.Services.AddTransient<IEmailService, EmailService>();
        }
    }
}
