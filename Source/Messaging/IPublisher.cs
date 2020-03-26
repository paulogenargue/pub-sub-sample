using System;

namespace Messaging
{
    public interface IPublisher<T>
    {
        void Publish(T message);
    }
}
