using SampleApp.NameFormatting.Model;

namespace SampleApp.NameFormatting.Output
{
    public class FirstNameFirstOutput : IOutput<Name>
    {
        private readonly IOutput<string> strOutput;

        public FirstNameFirstOutput(IOutput<string> strOutput)
        {
            this.strOutput = strOutput;
        }

        public void Write(Name value)
        {
            strOutput.Write($"{value.First} {value.Last}".Trim());
        }
    }
}