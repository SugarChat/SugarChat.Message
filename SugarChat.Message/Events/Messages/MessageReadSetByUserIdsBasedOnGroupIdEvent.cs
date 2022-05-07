using System.Collections.Generic;

namespace SugarChat.Message.Events.Messages
{
    public class MessageReadSetByUserIdsBasedOnGroupIdEvent : EventBase
    {
        public IEnumerable<string> UserIds { get; set; }
        public string GroupId { get; set; }
    }
}
