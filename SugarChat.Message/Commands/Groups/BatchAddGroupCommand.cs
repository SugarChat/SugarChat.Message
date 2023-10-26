using Mediator.Net.Contracts;
using System.Collections.Generic;

namespace SugarChat.Message.Commands.Groups
{
    public class BatchAddGroupCommand : ICommand
    {
        public string UserId { get; set; }
        public IEnumerable<AddGroupCommand> AddGroupCommands { get; set; } = new List<AddGroupCommand>();
    }
}
