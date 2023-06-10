using Azure.Storage.Queues;
using System;

namespace CustomerQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SendQueueMessage("test2 from VS");
        }

        public static void SendQueueMessage(string message)
        {
            var queueClient = new QueueClient(Configuration.QueueConnString, "customermsg");
            queueClient.SendMessage(message);
        }

    }
}
