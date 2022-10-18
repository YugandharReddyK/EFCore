using Newtonsoft.Json;

namespace Common
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [Serializable]
    public class Logs
    {
        [JsonProperty]
        public Guid Id { get; set; }

        [JsonProperty]
        public DateTime DateTime { get; set; }
    }
}