using DigitalDisplay.IO.Abstractions;
using System;

namespace DigitalDisplay.IO
{
    internal sealed class LogOutput : ILogOutput
    {
        public void Info(string data, params object[] @params)
        {
#if Debug
            Console.WriteLine(string.Format(data, @params));
#endif
        }
    }
}
