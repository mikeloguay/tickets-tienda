using System;

namespace TiendaArreglos.Client.Wpf.Interfaces
{
    public interface ISerializer<T>
    {
        T DeserializeObject(string fileName);

        void SerializeObject(T objectToSerialize, string fileName);
    }
}