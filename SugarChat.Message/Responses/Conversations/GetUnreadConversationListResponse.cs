using Mediator.Net.Contracts;
using SugarChat.Message.Dtos.Conversations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Responses.Conversations
{
    public class GetUnreadConversationListResponse : IResponse
    {
        public IEnumerable<ConversationDto> Result { get; set; }
    }
}
