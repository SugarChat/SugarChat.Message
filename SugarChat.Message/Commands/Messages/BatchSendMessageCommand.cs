using System.Collections.Generic;

namespace SugarChat.Message.Commands.Messages
{
    public class BatchSendMessageCommand
    {
        public string UserId { get; set; }
        public IEnumerable<SendMessageCommand> SendMessageCommands { get; set; }
    }
}
