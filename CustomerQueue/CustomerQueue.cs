using Azure.Storage.Queues;
using OrderingQueue;
using System;

namespace OrderingQueues
{
    public class CustomerQueue
    {
        public string DequeueMessage()
        {
            var queueClient = new QueueClient(Configuration.QueueConnString, "customermsg");
            var message = queueClient.ReceiveMessage();

            return message.Value.Body.ToString();
        }

        public void PeekMessage()
        {
            var queueClient = new QueueClient(Configuration.QueueConnString, "customermsg");
            var message = queueClient.PeekMessage();
            Console.WriteLine(message.Value.MessageId);
        }

        public void EqueueMessage(string message)
        {
            var queueClient = new QueueClient(Configuration.QueueConnString, "customermsg");
            queueClient.SendMessage(message);
        }
    }
}