using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WWD.Mailer.Interfaces;
using WWD.Mailer.Models;

namespace WWD.Mailer.Functions
{
    /// <summary>
    /// MailerFunction Azure Storage Service trigger.
    /// </summary>
    public class MailerFunction
    {
        private readonly IMailerRequestProcessor _requestProcessor;

        public MailerFunction(IMailerRequestProcessor requestProcessor)
        {
            _requestProcessor = requestProcessor;
        }

        /// <summary>
        /// Accepts requests from the 'inbound-queue' and initiates processing.
        /// </summary>
        /// <param name="queueItem">The queue item to be processed.</param>
        /// <param name="log">An <see cref="ILogger"/> instance to perform logging.</param>
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
                log.LogError(e, "Error processing request.");
            }
        }
    }
}
