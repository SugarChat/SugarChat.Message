﻿using Mediator.Net.Contracts;
using SugarChat.Message.Commands;
using SugarChat.Message.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Requests.Messages
{
    public class GetMessagesByGroupIdsRequest : IRequest, INeedUserExist
    {
        public string UserId { get; set; }
        public IEnumerable<string> GroupIds { get; set; }
        public DateTimeOffset? FromDate { get; set; }
        public PageSettings PageSettings { get; set; }
    }
}
