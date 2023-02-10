using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarChat.Message.Dtos
{
    public class SearchParamDto
    {
        public IEnumerable<SearchParamDetail> SearchParamDetails { get; set; }
        public JoinType InternalJoin { get; set; }
        public JoinType ExternalJoin { get; set; }
        public SearchTable SearchTable { get; set; }
    }

    public class SearchParamDetail
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public Condition ConditionCondition { get; set; }
        public ValueType ValueType { get; set; }
    }

    public enum ValueType
    {
        String,
        Number
    }

    public enum Condition
    {
        Equal,
        Unequal,
        GreaterThan,
        LessThan,
        GreaterThanOrEqual,
        LessThanThanOrEqual,
        Contain
    }

    public enum SearchTable
    {
        Group,
        Message
    }
}