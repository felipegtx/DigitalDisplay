
namespace DigitalDisplay.IO.Abstractions
{
    public interface ISerializer
    {
        void Serialize<SomeType>(SomeType data, string pathToFile);
        SomeType DeserializeFrom<SomeType>(string pathToFile);
    }
}
