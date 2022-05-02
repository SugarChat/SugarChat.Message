using System;
using System.Collections.Generic;
using Mediator.Net.Contracts;

namespace SugarChat.Message.Requests.Emotions
{
    public class GetEmotionByIdsRequest : IRequest
    {
        public IEnumerable<string> Ids { get; set; }
    }
}