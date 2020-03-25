using System;

namespace Messaging
{
    public interface IPublisher
    {
        void Publish(string message);
    }
}
