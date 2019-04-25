namespace Mailhog.Models
{
    public class Path
    {
        public string[] Relays { get; set; }
        public string Mailbox { get; set; }
        public string Domain { get; set; }
        public string Params { get; set; }
    }
}
