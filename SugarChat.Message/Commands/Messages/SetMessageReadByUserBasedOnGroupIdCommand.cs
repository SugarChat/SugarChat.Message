﻿using Mediator.Net.Contracts;

namespace SugarChat.Message.Commands.Messages
{
    public class SetMessageReadByUserBasedOnGroupIdCommand : ICommand, INeedUserExist
    {
        public string UserId { get; set; }
        public string GroupId { get; set; }
    }
}