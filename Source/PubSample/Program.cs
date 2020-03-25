using System;
using Messaging;
using Messaging.RabbitMQ;
using static System.Console;

namespace PubSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisherFactory = new PublisherFactory();
            var publisher = publisherFactory.Create("SecureText");

            WriteLine("Publish secure texts:");

            // while (TryReadLine(out string message))
            // {
                var message = Console.ReadLine();
                publisher.Publish(message);
                WriteLine("Sent.") ;
            // }
        }

        static bool TryReadLine(out string message)
        {
            message = ReadLine();
            return string.IsNullOrEmpty(message);
        }
    }
}
