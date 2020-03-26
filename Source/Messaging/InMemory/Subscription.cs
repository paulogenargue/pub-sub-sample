using System;

namespace Messaging.InMemory
{
    public class Subscription<T> : ISubscription<T>
    {
        private readonly IEventChannel<T> eventChannel;

        public Subscription(IEventChannel<T> eventChannel)
        {
            this.eventChannel = eventChannel;
        }

        public void Subscribe(Action<T> handler)
        {
            eventChannel.Subscribe(handler);
        }
    }
}