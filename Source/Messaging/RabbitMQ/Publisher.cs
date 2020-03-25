using System.Text;
using RabbitMQ.Client;

namespace Messaging.RabbitMQ
{
    internal class Publisher : IPublisher
    {
        private readonly string exchange;
        private readonly IModel channel;

        public Publisher(string topic, IModel channel)
        {
            this.exchange = topic;
            this.channel = channel;
        }

        public void Publish(string message)
        {
            byte[] body = Encoding.UTF8.GetBytes(message);
            channel.BasicPublish(exchange, "", null, body);
        }
    }
}