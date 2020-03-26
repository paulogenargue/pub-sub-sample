using Microsoft.Extensions.DependencyInjection;

namespace Messaging.InMemory
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInMemoryMessaging(this IServiceCollection self)
        {
            self.AddSingleton(typeof(IEventChannel<>), typeof(EventChannel<>));
            self.AddSingleton(typeof(ISubscription<>), typeof(Subscription<>));
            self.AddSingleton(typeof(IPublisher<>), typeof(Publisher<>));
            return self;
        }
    }
}