using Moq;
using NUnit.Framework;

namespace Messaging.InMemory.UnitTests
{
    public class Tests
    {
        [Test]
        public void Subscribe_OneSubscription_HandlerShouldBeCalledWithCorrectMessage()
        {
            // Arrange
            var channel = new EventChannel<string>();
            var mockHandler = new Mock<ITestHandler<string>>();

            // Act
            channel.Subscribe(mockHandler.Object.Handle);
            channel.Publish("Apple");

            // Assert
            mockHandler.Verify(h => h.Handle("Apple"), Times.Once());
        }

        [Test]
        public void Subscribe_MultipleSubscriptions_HandlersShouldBeCalledWithCorrectMessage()
        {
            // Arrange
            var channel = new EventChannel<string>();
            var mockHandler1 = new Mock<ITestHandler<string>>();
            var mockHandler2 = new Mock<ITestHandler<string>>();

            // Act
            channel.Subscribe(mockHandler1.Object.Handle);
            channel.Subscribe(mockHandler2.Object.Handle);
            channel.Publish("Orange");

            // Assert
            mockHandler1.Verify(h => h.Handle("Orange"), Times.Once());
            mockHandler2.Verify(h => h.Handle("Orange"), Times.Once());
        }
    }
}