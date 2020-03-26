using Microsoft.Extensions.DependencyInjection;
using SampleApp.NameFormatting.Input;
using SampleApp.NameFormatting.Output;

namespace SampleApp.ConsoleIO
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddConsoleIO(this IServiceCollection self)
        {
            self.AddSingleton<IInput<string>, ConsoleInput>();
            self.AddSingleton<IOutput<string>, ConsoleOutput>();
            return self;
        }
    }
}