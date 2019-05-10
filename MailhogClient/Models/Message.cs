using System;
using System.Linq;
using Newtonsoft.Json;

namespace Mailhog.Models
{
    public class Message
    {
        public string ID { get; set; }
        public Path From { get; set; }
        public Path[] To { get; set; }
        public Content Content { get; set; }
        public DateTime Created { get; set; }
        public Mime Mime { get; set; }
        public Raw Raw { get; set; }

        [JsonIgnore]
        public string Subject => Content?.Headers?.Subject?.FirstOrDefault();
    }
}
