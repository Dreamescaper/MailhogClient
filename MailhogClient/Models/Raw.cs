namespace Mailhog.Models
{
    public class Raw
    {
        public string From { get; set; }
        public string[] To { get; set; }
        public string Data { get; set; }
        public string Helo { get; set; }
    }
}
