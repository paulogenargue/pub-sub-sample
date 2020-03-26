using SampleApp.NameFormatting.Model;

namespace SampleApp.NameFormatting.Output
{
    public class LastNameFirstOutput : IOutput<Name>
    {
        private readonly IOutput<string> stringOutput;

        public LastNameFirstOutput(IOutput<string> stringOutput)
        {
            this.stringOutput = stringOutput;
        }

        public void Write(Name value)
        {
            if (!string.IsNullOrEmpty(value.First) && !string.IsNullOrEmpty(value.Last))
            {
                stringOutput.Write($"{value.Last}, {value.First}");
            }
            else
            {
                stringOutput.Write($"{value.First} {value.Last}".Trim());
            }
        }
    }
}