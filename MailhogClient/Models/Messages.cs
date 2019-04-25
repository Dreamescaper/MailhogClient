namespace Mailhog.Models
{
    public class Messages
    {
        /// <summary>
        /// Total number of stored messages
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Number of returned messages
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Start index of first returned message
        /// </summary>
        public int Start { get; set; }

        public Message[] Items { get; set; }
    }
}
