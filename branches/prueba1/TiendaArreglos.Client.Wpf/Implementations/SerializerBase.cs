using System;
using System.IO;
using System.Xml.Serialization;
using TiendaArreglos.Client.Wpf.Interfaces;

namespace TiendaArreglos.Client.Wpf.Implementations
{
    public class SerializerBase<T> : ISerializer<T>
    {
        public T DeserializeObject(string fileName)
        {
            FileStream fs = default(FileStream);
            T objectToDeserialize;

            try
            {
                fs = new FileStream(fileName, FileMode.Open);
                XmlSerializer x = new XmlSerializer(typeof(T));
                objectToDeserialize = (T)x.Deserialize(fs);
            }
            finally
            {
                fs.Close();
            }

            return objectToDeserialize;
        }

        public void SerializeObject(T objectToSerialize, string fileName)
        {
            TextWriter writer = default(TextWriter);

            try
            {
                // Create the XmlSerializer.
                XmlSerializer s = new XmlSerializer(typeof(T));

                // To write the file, a TextWriter is required.
                writer = new StreamWriter(fileName);

                // Serialize the object, and close the TextWriter.      
                s.Serialize(writer, objectToSerialize);
            }
            finally
            {
                writer.Close();
            }
        }
    }
}