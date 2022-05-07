using Mediator.Net.Contracts;
using System.Collections.Generic;

namespace SugarChat.Message.Commands.Messages
{
    public class SetMessageReadByUserIdsBasedOnGroupIdCommand : ICommand
    {
        public IEnumerable<string> UserIds { get; set; }
        public string GroupId { get; set; }
    }
}
