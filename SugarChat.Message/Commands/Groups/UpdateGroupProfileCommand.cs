using Mediator.Net.Contracts;
using System.Collections.Generic;

namespace SugarChat.Message.Commands.Groups
{
    public class UpdateGroupProfileCommand : ICommand
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string AvatarUrl { get; set; }

        public string Description { get; set; }

        public int Type { get; set; }

        public Dictionary<string, string> CustomProperties { get; set; }
    }
}
