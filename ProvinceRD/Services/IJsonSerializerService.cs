using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ProvinceRD.Services
{
    public interface IJsonSerializerService
    {
        string Serialize(object payload);
        T Deserialize<T>(string payload);
    }
}
