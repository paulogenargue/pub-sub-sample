using System.Collections.Generic;
using System.Linq;
using Messaging;
using SampleApp.NameFormatting.Model;
using SampleApp.NameFormatting.Output;

namespace SampleApp
{
    /// <summary>
    /// Subscribes to new names and displays them.
    /// </summary>
    public class NameDisplay
    {
        private readonly ISubscription<Name> subscription;
        private readonly IEnumerable<IOutput<Name>> output;

        public NameDisplay(ISubscription<Name> subscription, IEnumerable<IOutput<Name>> output)
        {
            this.subscription = subscription;
            this.output = output;
        }

        public void Run()
        {
            subscription.Subscribe((Name) =>
            {
                output.ToList().ForEach(o => o.Write(Name));
            });
        }
    }
}
