using System.Collections.Generic;

namespace SugarChat.Message.Commands.Groups
{
    public class BatchAddGroupCommand
    {
        public string UserId { get; set; }
        public IEnumerable<AddGroupCommand> Groups { get; set; }
    }
}
