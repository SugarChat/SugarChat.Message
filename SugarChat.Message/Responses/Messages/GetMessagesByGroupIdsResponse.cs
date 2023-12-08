using SugarChat.Message.Dtos;
using SugarChat.Message.Paging;

namespace SugarChat.Message.Responses.Messages
{
    public class GetMessagesByGroupIdsResponse
    {
        public PagedResult<MessageDto> Messages { get; set; }
    }
}
