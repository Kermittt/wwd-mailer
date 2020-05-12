using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WWD.Mailer.Interfaces;
using WWD.Mailer.Models;

namespace WWD.Mailer.Functions
{
    // TODO : 0 : Add summary comments to all classes and interfaces
    public class MailerFunction
    {
        private readonly IMailerRequestProcessor _requestProcessor;

        public MailerFunction(IMailerRequestProcessor requestProcessor)
        {
            _requestProcessor = requestProcessor;
        }

        [FunctionName("MailerFunction")]
        public async Task Run([QueueTrigger("inbound-queue", Connection = "QueueConnection")]string queueItem, ILogger log)
        {
            log.LogInformation("Queue message received.");
            try
            {
                // Attempt to deserialize the request and process it
                var request = JsonConvert.DeserializeObject<MailerRequest>(queueItem);
                await _requestProcessor.ProcessRequest(request);
            }
            catch (Exception e)
            {
                log.LogError(e, "Exception during processing.");
            }
        }
    }
}
