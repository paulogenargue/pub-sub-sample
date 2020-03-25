namespace Messaging
{
    public interface IPublisherFactory
    {
        IPublisher Create(string topic);
    }
}