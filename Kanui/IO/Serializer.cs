using Kanui.IO.Abstractions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Kanui.IO
{
    internal sealed class Serializer : ISerializer
    {
        public void Serialize<SomeType>(SomeType data, string pathToFile)
        {
            var formatter = new BinaryFormatter();
            using (var stream = new FileStream(pathToFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, data);
            }
        }

        public SomeType DeserializeFrom<SomeType>(string pathToFile)
        {
            var formatter = new BinaryFormatter();
            using (var stream = new FileStream(pathToFile, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return (SomeType)formatter.Deserialize(stream);
            }
        }
    }
}
