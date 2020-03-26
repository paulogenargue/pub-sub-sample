using System;
using SampleApp.NameFormatting.Output;

namespace SampleApp.ConsoleIO
{
    public class ConsoleOutput : IOutput<string>
    {
        public void Write(string value) => Console.WriteLine(value);
    }
}