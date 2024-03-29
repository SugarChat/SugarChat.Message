using System.Collections.Generic;
using SugarChat.Message.Dtos.GroupUsers;

namespace SugarChat.Message.Commands.Groups
{
    public class AddGroupCommand : IdRequiredCommand, INeedUserExist
    {
        public string UserId { get; set; }

        public string Name { get; set; }

        public string AvatarUrl { get; set; }

        public string Description { get; set; }

        public Dictionary<string, string> CustomProperties { get; set; }

        public string CreatedBy { get; set; }

        public int Type { get; set; }

        public IEnumerable<GroupUserDto> GroupUsers { get; set; }
    }
}