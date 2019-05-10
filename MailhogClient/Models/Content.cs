namespace Mailhog.Models
{
    public class Content
    {
        public Headers Headers { get; set; }
        public string Body { get; set; }
        public int Size { get; set; }
        public Mime Mime { get; set; }
    }
}
