using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Dtos
{
    public class UpdateMessageDto
    {
        public string Id { get; set; }
        public string GroupId { get; set; }
        public string Content { get; set; }
        public int Type { get; set; }
        public string SentBy { get; set; }
        public DateTimeOffset SentTime { get; set; }
        public bool IsSystem { get; set; }
        public string Payload { get; set; }
        public bool IsRevoked { get; set; }
        public Dictionary<string, string> CustomProperties { get; set; }
    }
}
