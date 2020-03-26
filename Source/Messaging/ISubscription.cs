using System;

namespace Messaging
{
    public interface ISubscription<T>
    {
        void Subscribe(Action<T> handler);
    }
}