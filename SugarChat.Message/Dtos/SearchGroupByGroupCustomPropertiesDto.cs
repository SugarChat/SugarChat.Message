using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Dtos
{
    public class SearchGroupByGroupCustomPropertiesDto
    {
        public Dictionary<string, List<string>> GroupCustomProperties { get; set; }
        public bool IsExactSearch { get; set; } = true;
    }
}