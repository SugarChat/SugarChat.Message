﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Dtos
{
    public class GroupUserCustomPropertyDto
    {
        public string GroupUserId { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}
