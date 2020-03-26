using Messaging;
using SampleApp.NameFormatting.Input;
using SampleApp.NameFormatting.Model;

namespace SampleApp
{
        public class NameReader
        {
            private readonly IInput<Name> input;
            private readonly IPublisher<Name> publisher;

            public NameReader(IInput<Name> input, IPublisher<Name> publisher)
            {
                this.input = input;
                this.publisher = publisher;
            }

            public void Run()
            {
                while (true)
                {
                    var name = input.Read();

                    if (name == null)
                        break;

                    publisher.Publish(name);
                }
            }
        }
}
