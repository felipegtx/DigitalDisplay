
namespace DigitalDisplay.IO.Abstractions
{
    public interface ILogOutput
    {
        void Info(string data, params object[] @params);
    }
}
