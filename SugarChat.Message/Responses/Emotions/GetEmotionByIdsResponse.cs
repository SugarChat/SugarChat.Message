using System.Collections.Generic;
using Mediator.Net.Contracts;
using SugarChat.Message.Dtos.Emotions;

namespace SugarChat.Message.Responses.Emotions
{
    public class GetEmotionByIdsResponse : IResponse
    {
        public IEnumerable<EmotionDto> Emotions { get; set; }
    }
}