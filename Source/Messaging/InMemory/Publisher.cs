namespace Messaging.InMemory
{
    public class Publisher<T> : IPublisher<T>
    {
        private readonly IEventChannel<T> eventChannel;

        public Publisher(IEventChannel<T> eventChannel)
        {
            this.eventChannel = eventChannel;
        }

        public void Publish(T message)
        {
            eventChannel.Publish(message);
        }
    }
}