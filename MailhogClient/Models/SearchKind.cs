using System.Runtime.Serialization;

namespace Mailhog.Models
{
    public enum SearchKind
    {
        [EnumMember(Value = "from")]
        From,

        [EnumMember(Value = "to")]
        To,

        [EnumMember(Value = "containing")]
        Containing
    }
}
