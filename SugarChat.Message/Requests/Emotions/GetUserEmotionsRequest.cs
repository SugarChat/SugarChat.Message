using Mediator.Net.Contracts;

namespace SugarChat.Message.Requests.Emotions
{
    public class GetUserEmotionsRequest : IRequest
    {
        public string UserId { get; set; }
    }
}