using Mediator.Net.Contracts;
using System.Collections.Generic;

namespace SugarChat.Message.Commands.GroupUsers
{
    public class BatchAddGroupMemberCommand : ICommand
    {
        public string UserId { get; set; }
        public IEnumerable<AddGroupMemberCommand> AddGroupMemberCommands { get; set; } = new List<AddGroupMemberCommand>();
    }
}
