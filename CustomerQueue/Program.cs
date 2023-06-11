using Azure.Storage.Queues;
using System;

namespace CustomerQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SendQueueMessage("test4 from VS ---. ");
            SendQueueMessage("test5 from VS ---. ");
            PeekQueueMessage();
            DequeueMessage();
        }

        public static void SendQueueMessage(string message)
        {
            var queueClient = new QueueClient(Configuration.QueueConnString, "customermsg");
            queueClient.SendMessage(message);
        }

        public static void PeekQueueMessage()
        {
            var queueClient = new QueueClient(Configuration.QueueConnString, "customermsg");
            var message = queueClient.PeekMessage();
            Console.WriteLine(message.Value.MessageId);
        }

        public static void DequeueMessage()
        {
            var queueClient = new QueueClient(Configuration.QueueConnString, "customermsg");
            var message = queueClient.ReceiveMessage();
            Console.WriteLine(message.Value.MessageId);
            Console.WriteLine(message.Value.Body);
        }
    }
}
