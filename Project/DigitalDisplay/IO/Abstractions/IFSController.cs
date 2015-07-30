using System.Collections.Generic;

namespace DigitalDisplay.IO.Abstractions
{
    public interface IFSController
    {
        bool TryRead(string pathToFile, out IEnumerable<string> fileContent);
        bool Exists(string pathToFile);
    }
}
