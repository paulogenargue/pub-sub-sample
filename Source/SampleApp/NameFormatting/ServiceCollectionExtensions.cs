using Microsoft.Extensions.DependencyInjection;
using SampleApp.NameFormatting.Input;
using SampleApp.NameFormatting.Model;
using SampleApp.NameFormatting.Output;

namespace SampleApp.NameFormatting
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddNameFormatting(this IServiceCollection self)
        {
            self.AddSingleton<IInput<Name>, NameInput>();
            self.AddSingleton<IOutput<Name>, FirstNameFirstOutput>();
            self.AddSingleton<IOutput<Name>, LastNameFirstOutput>();

            self.AddSingleton<NameReader>();
            self.AddSingleton<NameDisplay>();

            return self;
        }
    }
}