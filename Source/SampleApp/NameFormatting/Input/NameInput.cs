using SampleApp.NameFormatting.Model;
using SampleApp.NameFormatting.Output;

namespace SampleApp.NameFormatting.Input
{
    public class NameInput : IInput<Name>
    {
        private readonly IInput<string> stringInput;
        private readonly IOutput<string> stringOutput;

        public NameInput(IInput<string> stringInput, IOutput<string> stringOutput)
        {
            this.stringInput = stringInput;
            this.stringOutput = stringOutput;
        }

        public Name Read()
        {
            stringOutput.Write("First Name:");
            string first = stringInput.Read();

            stringOutput.Write("Last Name:");
            string last = stringInput.Read();

            return string.IsNullOrEmpty(first) && string.IsNullOrEmpty(last)
                ? null
                : new Name { First = first, Last = last };
        }
    }
}