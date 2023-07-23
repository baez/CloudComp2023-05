using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ExperimentAzFunc1
{
    public class MyQueueFunc
    {
        [FunctionName("MyQueueFunc")]
        public void Run([QueueTrigger("myqueue20230722", Connection = "QueueStorage")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"MyQueue processor picked up: {myQueueItem}");
        }
    }
}
