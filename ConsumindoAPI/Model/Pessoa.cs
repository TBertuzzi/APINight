using System;
using Newtonsoft.Json;

namespace ConsumindoAPI.Model
{
    public class Pessoa
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("foto")]
        public Uri Foto { get; set; }

        [JsonProperty("__v")]
        public long V { get; set; }
    }
}
