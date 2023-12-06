using Mediator.Net.Contracts;
using System.Collections.Generic;

namespace SugarChat.Message.Commands.Messages
{
    public class BatchSetMessageReadByUserIdsBasedOnGroupIdCommand : ICommand
    {
        public IEnumerable<SetMessageReadByUserIdsBasedOnGroupIdCommand> SetMessageReadCommands { get; set; }
    }
}
