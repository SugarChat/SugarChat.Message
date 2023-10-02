﻿using Mediator.Net.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Commands.GroupUsers
{
    public class BatchSetGroupMemberCustomFieldCommand : ICommand
    {
        public IEnumerable<SetGroupMemberCustomFieldCommand> SetGroupMemberCustomFieldCommands { get; set; }
    }
}
