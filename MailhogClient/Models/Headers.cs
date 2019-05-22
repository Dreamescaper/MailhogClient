using Newtonsoft.Json;

namespace Mailhog.Models
{
    public class Headers
    {
        [JsonProperty(PropertyName = "Content-Id")]
        public string[] ContentId { get; set; }

        [JsonProperty(PropertyName = "Content-Disposition")]
        public string[] ContentDisposition { get; set; }

        [JsonProperty(PropertyName = "Content-Transfer-Encoding")]
        public string[] ContentTransferEncoding { get; set; }

        [JsonProperty(PropertyName = "Content-Type")]
        public string[] ContentType { get; set; }

        [JsonProperty(PropertyName = "Date")]
        public string[] Date { get; set; }

        [JsonProperty(PropertyName = "From")]
        public string[] From { get; set; }

        [JsonProperty(PropertyName = "MIME-Version")]
        public string[] MIMEVersion { get; set; }

        [JsonProperty(PropertyName = "Message-Id")]
        public string[] MessageId { get; set; }

        [JsonProperty(PropertyName = "Received")]
        public string[] Received { get; set; }

        [JsonProperty(PropertyName = "Return-Path")]
        public string[] ReturnPath { get; set; }

        [JsonProperty(PropertyName = "Subject")]
        public string[] Subject { get; set; }

        [JsonProperty(PropertyName = "To")]
        public string[] To { get; set; }
    }
}
