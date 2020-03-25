using System;

namespace Messaging
{
    public interface ISubscriber 
    {
        void Subscribe(Action<string> handler);
    }
}