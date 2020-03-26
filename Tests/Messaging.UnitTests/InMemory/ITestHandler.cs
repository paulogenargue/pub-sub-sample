namespace Messaging.InMemory.UnitTests
{
    /// <summary>
    /// Helper interface to verify method invocations.
    /// </summary>
    public interface ITestHandler<T>
    {
        void Handle(T message);
    }
}