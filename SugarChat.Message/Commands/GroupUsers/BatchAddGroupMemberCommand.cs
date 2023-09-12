using System.Collections.Generic;

namespace SugarChat.Message.Commands.GroupUsers
{
    public class BatchAddGroupMemberCommand
    {
        public string UserId { get; set; }
        public IEnumerable<AddGroupMemberCommand> AddGroupMemberCommands { get; set; }
    }
}
