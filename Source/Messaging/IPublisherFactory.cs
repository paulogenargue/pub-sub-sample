namespace Messaging
{
    public interface IPublisherFactory<T>
    {
        IPublisher<T> Create();
    }
}