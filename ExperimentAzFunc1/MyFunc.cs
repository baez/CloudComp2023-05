using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ExperimentAzFunc1
{
    /// <summary>
    /// sample request: http://localhost:7168/api/MyFunc?name=romo
    ///         MyFunc: [GET,POST] http://localhost:7168/api/MyFunc
    ///    MyQueueFunc: queueTrigger
    /// MyFunc puts messages on myqueue20230722
    /// And, MyQueueFunc is listening to myqueue20230722
    /// Picks up messages from the queue for processing as they become available.
    /// 
    /// </summary>
    public static class MyFunc
    {
        [FunctionName("MyFunc")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [Queue("myqueue20230722", Connection = "QueueStorage")] out string myQueueItem,
            ILogger log)
        {
            log.LogInformation("--- MyFunc C# HTTP trigger function ---");

            string name = req.Query["name"];

            string requestBody = new StreamReader(req.Body).ReadToEndAsync().GetAwaiter().GetResult();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            string responseMessage;
            if (!string.IsNullOrWhiteSpace(name))
            {
                myQueueItem = name;
                responseMessage = $"{name} was enqueued.";
            }
            else
            {
                myQueueItem = "InvalidMessage";
                responseMessage = "This function enqueues name items to a queue. Pass a name parameter in the query string.";
            }

            return new OkObjectResult(responseMessage);
        }
    }
}
