using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using TiendaArreglos.Client.Infrastructure.Interface.Serialization;

namespace TiendaArreglos.Client.Infrastructure.Implementation.Serialization
{
    public class SerializerBase<T> : ISerializer<T>
    {
        public T DeserializeObject(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            XmlSerializer x = new XmlSerializer(typeof(T));
            T objectToDeserialize = (T)x.Deserialize(fs);
            fs.Close();
            return objectToDeserialize;
        }

        public void SerializeObject(T objectToSerialize, string fileName)
        {
            // Create the XmlSerializer.
            XmlSerializer s = new XmlSerializer(typeof(T));

            // To write the file, a TextWriter is required.
            TextWriter writer = new StreamWriter(fileName);

            // Serialize the object, and close the TextWriter.      
            s.Serialize(writer, objectToSerialize);
            writer.Close();
        }
    }
}