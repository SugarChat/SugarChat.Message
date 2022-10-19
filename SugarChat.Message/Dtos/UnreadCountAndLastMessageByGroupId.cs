using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Dtos
{
    public class UnreadCountAndLastMessageByGroupId
    {
        public string GroupId { get; set; }

        public int UnreadCount { get; set; }

        public MessageDto LastMessage { get; set; }

        public DateTimeOffset LastSentTime { get; set; }
    }
}
