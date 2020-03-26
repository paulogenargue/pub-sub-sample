using System;

namespace SampleApp.Input
{
    public class ConsoleInput : IInput
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}