using Mediator.Net.Contracts;
using System.Collections.Generic;

namespace SugarChat.Message.Requests.Conversations
{
    public class GetConversationProfileRequest : IRequest
    {
        public string ConversationId{ get; set; }
        public string UserId { get; set; }
    }
}
