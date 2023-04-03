using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Dtos
{
    public class SearchMessageParamDto
    {
        public IEnumerable<SearchParamDetail> SearchParamDetails { get; set; }
        public JoinType InternalJoin { get; set; }
        public JoinType ExternalJoin { get; set; }
    }
}
