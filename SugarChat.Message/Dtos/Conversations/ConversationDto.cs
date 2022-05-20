using System;

namespace SugarChat.Message.Dtos.Conversations
{
    public class ConversationDto
    {
        public string ConversationID { get; set; }
        public int UnreadCount { get; set; }
        public DateTimeOffset LastMessageSentTime { get; set; }
        public MessageDto LastMessage { get; set; }
        public GroupDto GroupProfile { get; set; }
    }
}
