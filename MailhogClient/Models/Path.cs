using Newtonsoft.Json;

namespace Mailhog.Models
{
    public class Path
    {
        public string[] Relays { get; set; }
        public string Mailbox { get; set; }
        public string Domain { get; set; }
        public string Params { get; set; }

        [JsonIgnore]
        public string Address => $"{Mailbox}@{Domain}";

        public override string ToString() => Address;
    }
}
