﻿using Mediator.Net.Contracts;
using SugarChat.Message.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Requests.Conversations
{
    public class GetConversationByKeywordRequest : IRequest
    {
        public string UserId { get; set; }
        [Obsolete("过时", false)]
        public Dictionary<string, string> SearchParms { get; set; }
        public Dictionary<string, string> GroupSearchParms { get; set; }
        public Dictionary<string, string> MessageSearchParms { get; set; }
        public PageSettings PageSettings { get; set; }
        public bool IsExactSearch { get; set; }
        public IEnumerable<string> GroupIds { get; set; } = new List<string>();
        public int? GroupType { get; set; }
        public int? FilterGroupType { get; set; }
        public int? FilterGroupUserType { get; set; }
    }
}
