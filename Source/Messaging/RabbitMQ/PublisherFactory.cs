using RabbitMQ.Client;

namespace Messaging.RabbitMQ
{
    public class PublisherFactory : IPublisherFactory
    {
        private readonly IConnection connection;

        public PublisherFactory()
        {
            var connectionFactory = new ConnectionFactory();
            connectionFactory.HostName = "localhost";
            connectionFactory.Port = 5672;
            connectionFactory.VirtualHost = "pub-sub-sample";
            connectionFactory.UserName = "dev";
            connectionFactory.Password = "dev";
            connection = connectionFactory.CreateConnection();
        }

        public IPublisher Create(string topic)
        {
            return new Publisher(topic, connection.CreateModel());
        }
    }
}