﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Commands
{
    public interface INeedUserExist
    {
        public string UserId { get; set; }
    }
}
