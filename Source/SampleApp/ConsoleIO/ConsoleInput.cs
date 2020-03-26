using System;
using SampleApp.NameFormatting.Input;

namespace SampleApp.ConsoleIO
{
    public class ConsoleInput : IInput<string>
    {
        public string Read() => Console.ReadLine();
    }
}