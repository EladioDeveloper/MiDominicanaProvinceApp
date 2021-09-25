﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProvinceRD.Models
{
    public class ProvinceResponse
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("surface")]
        public double Surface { get; set; }

        [JsonPropertyName("population")]
        public int Population { get; set; }

        [JsonPropertyName("density")]
        public int Density { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }
    }
}
