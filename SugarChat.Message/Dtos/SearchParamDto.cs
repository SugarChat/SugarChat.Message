using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Dtos
{
    public class SearchParamDto
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public Dictionary<string, List<string>> Params { get; set; }
        public bool IsExactSearch { get; set; } = true;
        public JoinType InternalJoin { get; set; }
        public JoinType ExternalJoin { get; set; }
        public SearchTable SearchTable { get; set; }
    }

    public enum SearchTable
    {
        Group,
        Message
    }
}