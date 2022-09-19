﻿using System;
using System.Collections.Generic;

namespace SugarChat.Message.Dtos
{
    public class GroupDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AvatarUrl { get; set; }
        public string Description { get; set; }
        [Obsolete("过时", false)]
        public Dictionary<string, string> CustomProperties { get; set; }
        public IEnumerable<GroupCustomPropertyDto> CustomPropertyList { get; set; }
        public int MemberCount { get; set; }
        public int UnreadCount { get; set; }
        public int? Type { get; set; }
    }
}