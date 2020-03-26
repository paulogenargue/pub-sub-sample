using Messaging.InMemory;
using Microsoft.Extensions.DependencyInjection;
using SampleApp.ConsoleIO;
using SampleApp.NameFormatting;
using System;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddInMemoryMessaging();
            services.AddConsoleIO();
            services.AddNameFormatting();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            // Run the display
            serviceProvider.GetService<NameDisplay>().Run();

            // Run the main
            serviceProvider.GetService<NameReader>().Run();
        }
    }
}
