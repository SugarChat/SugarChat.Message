using Mediator.Net.Contracts;

namespace SugarChat.Message.Commands.Emotions
{
    public class AddEmotionCommand : ICommand
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
    }
}