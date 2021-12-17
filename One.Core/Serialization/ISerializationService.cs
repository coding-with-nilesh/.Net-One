using System;
using System.IO;
using System.Threading.Tasks;

namespace One.Core.Serialization
{
    /// <summary>
    /// Interface for service class that can be used to serialize/deserialize objects
    /// </summary>
    public interface ISerializationService
    {
        /// <summary>
        /// Serializes the object and saves it at given location
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="outputPath"></param>
        /// <returns></returns>
        Task SerializeAsync(object obj, string outputPath);

        /// <summary>
        /// Serializes the object and saves it using the given streamwriter
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="streamWriter"></param>
        /// <returns></returns>
        Task SerializeAsync(object obj, StreamWriter streamWriter);

        /// <summary>
        /// Deserializes the object from the given location
        /// </summary>
        /// <param name="inputPath"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        Task<object> DeserializeAsync(string inputPath, Type type);

        /// <summary>
        /// Deserializes the object obtained from the given streamreader
        /// </summary>
        /// <param name="streamReader"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        Task<object> DeserializeAsync(StreamReader streamReader, Type type);
    }
}
