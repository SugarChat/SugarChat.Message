using System;
using Mediator.Net.Contracts;

namespace SugarChat.Message.Commands.Emotions
{
    public class RemoveEmotionCommand : ICommand
    {
        public string Id { get; set; }
        public string UserId { get; set; }
    }
}