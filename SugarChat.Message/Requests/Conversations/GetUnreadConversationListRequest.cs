using Mediator.Net.Contracts;
using SugarChat.Message.Commands;
using SugarChat.Message.Dtos;
using SugarChat.Message.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Requests.Conversations
{
    public class GetUnreadConversationListRequest : IRequest, INeedUserExist
    {
        public string UserId { get; set; }
        public PageSettings PageSettings { get; set; }
        public IEnumerable<string> GroupIds { get; set; } = new List<string>();
        public int GroupType { get; set; }
        public SearchGroupByGroupCustomPropertiesDto ExcludeGroupByGroupCustomProperties { get; set; }
        public SearchGroupByGroupCustomPropertiesDto IncludeGroupByGroupCustomProperties { get; set; }
    }
}
