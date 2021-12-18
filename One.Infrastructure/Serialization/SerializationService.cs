using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using One.Core.Serialization;

namespace One.Infrastructure.Serialization
{
    public class SerializationService : ISerializationService
    {
        public Task SerializeAsync(object obj, string outputPath)
        {
            return Task.Run(async () =>
             {
                 StreamWriter writer = null;

                 try
                 {
                     writer = new StreamWriter(outputPath);
                     await SerializeAsync(obj, writer).ConfigureAwait(false);
                 }
                 finally
                 {
                     writer?.Close();
                 }
             });
        }

        public Task SerializeAsync(object obj, StreamWriter streamWriter)
        {
            return Task.Run(() =>
            {
                var serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(streamWriter, obj);
            });
        }

        public Task<object> DeserializeAsync(string inputPath, Type type)
        {
            return Task.Run(async () =>
            {
                StreamReader streamReader = null;

                try
                {
                    var serializer = new XmlSerializer(type);
                    return await DeserializeAsync(streamReader, type).ConfigureAwait(false);
                }
                finally
                {
                    streamReader?.Close();
                }
            });
        }

        public Task<object> DeserializeAsync(StreamReader streamReader, Type type)
        {
            return Task.Run(() =>
            {
                var serializer = new XmlSerializer(type);
                return serializer.Deserialize(streamReader);
            });
        }
    }
}
