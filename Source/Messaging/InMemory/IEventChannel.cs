using System;

namespace Messaging.InMemory
{
    public interface IEventChannel<T>
    {
        void Publish(T message);
        void Subscribe(Action<T> handler);
    }
}