using DigitalDisplay.IO.Abstractions;
using System.Diagnostics;

namespace DigitalDisplay.Tests.Fakes
{
    public sealed class FakeLogOutput : ILogOutput
    {
        public void Info(string data, params object[] @params)
        {
            Debug.WriteLine(data, @params);
        }
    }
}
