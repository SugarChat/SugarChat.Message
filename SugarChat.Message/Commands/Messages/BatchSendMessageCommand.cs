using Mediator.Net.Contracts;
using System.Collections.Generic;

namespace SugarChat.Message.Commands.Messages
{
    public class BatchSendMessageCommand : ICommand
    {
        public string UserId { get; set; }
        public IEnumerable<SendMessageCommand> SendMessageCommands { get; set; } = new List<SendMessageCommand>();
    }
}
