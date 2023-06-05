using Mediator.Net.Contracts;
using SugarChat.Message.Dtos;
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
        public PageSettings PageSettings { get; set; }
        public IEnumerable<string> GroupIds { get; set; } = new List<string>();
        public int GroupType { get; set; }
        public List<SearchParamDto> SearchParams { get; set; }
        public List<SearchMessageParamDto> SearchMessageParams { get; set; }
        /// <summary>
        /// Specifies how many months ago to start querying data. Set to 0 to retrieve data without time limit.
        /// </summary>
        public int MonthsAgo { get; set; } = 6;
    }
}
