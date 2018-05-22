﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoubSharp.Dtos.Versions
{
    public class AudioVersionsDto
    {
        public class Chunks
        {
            [JsonProperty("template")]
            public string Template { get; set; }

            [JsonProperty("versions")]
            public IEnumerable<string> Versions { get; set; }

            [JsonProperty("chunks")]
            public IEnumerable<int> ChunksList { get; set; }
        }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("versions")]
        public IEnumerable<string> Versions { get; set; }

        [JsonProperty("chunks")]
        public Chunks ChunksList { get; set; }
    }
}
