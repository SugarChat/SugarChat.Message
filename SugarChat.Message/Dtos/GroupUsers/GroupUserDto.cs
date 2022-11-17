using System;
using System.Collections.Generic;

namespace SugarChat.Message.Dtos.GroupUsers
{
    public class GroupUserDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string GroupId { get; set; }
        public DateTimeOffset? LastReadTime { get; set; }
        public UserRole Role { get; set; }
        public MessageRemindType MessageRemindType { get; set; }
        public Dictionary<string, string> CustomProperties { get; set; }
        public string AvatarUrl { get; set; }
        public string DisplayName { get; set; }
        public int UnreadCount { get; set; }
    }
}
