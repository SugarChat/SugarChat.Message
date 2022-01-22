using Mediator.Net.Contracts;
using SugarChat.Message.Dtos.GroupUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Commands.GroupUsers
{
    public class UpdateGroupUserCommand : ICommand
    {
        public string UserId { get; set; }

        public IEnumerable<UpdateGroupUserDto> GroupUsers { get; set; }
    }
}
