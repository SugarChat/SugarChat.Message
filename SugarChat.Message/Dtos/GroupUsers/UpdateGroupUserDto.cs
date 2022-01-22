using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Dtos.GroupUsers
{
    public class UpdateGroupUserDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string GroupId { get; set; }
        public DateTimeOffset? LastReadTime { get; set; }
        public UserRole Role { get; set; }
        public MessageRemindType MessageRemindType { get; set; }
        public Dictionary<string, string> CustomProperties { get; set; }
    }
}
