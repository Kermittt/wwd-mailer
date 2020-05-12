using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace WWD.Mailer.Functions
{
    public static class MailerFunction
    {
        [FunctionName("MailerFunction")]
        public static void Run([QueueTrigger("inbound-queue", Connection = "QueueConnection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
