﻿using Mediator.Net.Contracts;
using SugarChat.Message.Commands;
using SugarChat.Message.Paging;
using System.Collections.Generic;

namespace SugarChat.Message.Requests.Conversations
{
    public class GetConversationListRequest : IRequest, INeedUserExist
    {
        public string UserId { get; set; }
        public PageSettings PageSettings { get; set; }
        public IEnumerable<string> GroupIds { get; set; } = new List<string>();
        public int? GroupType { get; set; }
    }
}
