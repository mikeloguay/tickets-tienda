﻿using System;
using System.Linq;

namespace TiendaArreglos.Client.Infrastructure.Interface.Serialization
{
    public interface ISerializer<T>
    {
        T DeserializeObject(string fileName);

        void SerializeObject(T objectToSerialize, string fileName);
    }
}