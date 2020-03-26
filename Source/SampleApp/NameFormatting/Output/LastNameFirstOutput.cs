using SampleApp.NameFormatting.Model;

namespace SampleApp.NameFormatting.Output
{
    public class LastNameFirstOutput : IOutput<Name>
    {
        private readonly IOutput<string> strOutput;

        public LastNameFirstOutput(IOutput<string> strOutput)
        {
            this.strOutput = strOutput;
        }

        public void Write(Name name)
        {
            if (!string.IsNullOrEmpty(name.First) && !string.IsNullOrEmpty(name.Last))
            {
                strOutput.Write($"{name.Last}, {name.First}");
            }
            else
            {
                strOutput.Write($"{name.First} {name.Last}".Trim());
            }
        }
    }
}