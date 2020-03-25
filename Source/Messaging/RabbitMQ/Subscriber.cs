using System;

namespace Messaging.RabbitMQ
{
    internal class Subscriber : ISubscriber
    {
        public void Subscribe(Action<string> handler)
        {
            throw new NotImplementedException();
        }
    }
}