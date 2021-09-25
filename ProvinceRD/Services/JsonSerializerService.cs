﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ProvinceRD.Services
{
    public class JsonSerializerService : IJsonSerializerService
    {
        public T Deserialize<T>(string payload) => JsonSerializer.Deserialize<T>(payload);

        public string Serialize(object payload) => JsonSerializer.Serialize(payload);

    }
}
