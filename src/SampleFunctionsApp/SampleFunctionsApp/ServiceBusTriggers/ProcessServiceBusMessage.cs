using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace SampleFunctionsApp.ServiceBusTriggers
{
    public static class ProcessServiceBusMessage
    {
        [FunctionName("ProcessServiceBusMessage")]
        public static async Task RunAsync(
            [ServiceBusTrigger("inbound-queue", Connection = "ServiceBusConnectionString")] 
            string myQueueItem,
            ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}