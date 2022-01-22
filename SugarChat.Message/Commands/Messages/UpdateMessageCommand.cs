﻿using Mediator.Net.Contracts;
using SugarChat.Message.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Commands.Messages
{
    public class UpdateMessageCommand : ICommand
    {
        public string UserId { get; set; }

        public IEnumerable<UpdateMessageDto> Messages { get; set; }
    }
}
