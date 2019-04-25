namespace Mailhog.Models
{
    public class Headers
    {
        public string[] ContentId { get; set; }
        public string[] ContentType { get; set; }
        public string[] Date { get; set; }
        public string[] From { get; set; }
        public string[] MIMEVersion { get; set; }
        public string[] MessageId { get; set; }
        public string[] Received { get; set; }
        public string[] ReturnPath { get; set; }
        public string[] Subject { get; set; }
        public string[] To { get; set; }
    }
}
