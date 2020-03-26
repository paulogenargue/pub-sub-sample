using SampleApp.NameFormatting.Model;

namespace SampleApp.NameFormatting.Output
{
    public class FirstNameFirstOutput : IOutput<Name>
    {
        private readonly IOutput<string> stringOutput;

        public FirstNameFirstOutput(IOutput<string> stringOutput)
        {
            this.stringOutput = stringOutput;
        }

        public void Write(Name value)
        {
            stringOutput.Write($"{value.First} {value.Last}".Trim());
        }
    }
}