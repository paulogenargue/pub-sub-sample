using Messaging;
using Messaging.InMemory;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddInMemoryMessaging();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            var publisher = serviceProvider.GetService<IPublisher<string>>();
            var subscription = serviceProvider.GetService<ISubscription<string>>();
            subscription.Subscribe(Console.WriteLine);
            var subscription2 = serviceProvider.GetService<ISubscription<string>>();
            subscription2.Subscribe(Console.WriteLine);

            var numPublihser = serviceProvider.GetService<IPublisher<int>>();
            var numericSubscription = serviceProvider.GetService<ISubscription<int>>();
            numericSubscription.Subscribe(Console.WriteLine);

            publisher.Publish("Apple");
            numPublihser.Publish(1000);
            Console.Read();
        }
    }
}
