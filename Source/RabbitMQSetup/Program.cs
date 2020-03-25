using System;
using RabbitMQ.Client;

namespace RabbitMQSetup
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionFactory = new ConnectionFactory();
            connectionFactory.HostName = "localhost";
            connectionFactory.VirtualHost = "pub-sub-sample";
            connectionFactory.Port = 5672;
            connectionFactory.UserName = "dev";
            connectionFactory.Password = "dev";

            using var connection = connectionFactory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.ExchangeDeclare("SecureText", "fanout", durable: true);
            // channel.QueueDeclare("", durable: true);
            // channel.QueueBind()
            Console.WriteLine("RabbitMQ setup complete.");
        }
    }
}
