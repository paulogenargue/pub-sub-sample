using System;
using System.Collections.Generic;

namespace Messaging.InMemory
{
    /// <summary>
    /// Simulates an event channel between publishers and subscribers.
    /// </summary>
    public class EventChannel<T> : IEventChannel<T>
    {
        private readonly List<Action<T>> subscriptions = new List<Action<T>>();

        public void Publish(T message)
        {
            subscriptions.ForEach(handler => handler(message));
        }

        public void Subscribe(Action<T> handler)
        {
            subscriptions.Add(handler);
        }
    }
}