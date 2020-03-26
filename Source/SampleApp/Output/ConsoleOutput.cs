using System;

namespace SampleApp.Output
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string value)
        {
            Console.WriteLine(value);
        }
    }
}