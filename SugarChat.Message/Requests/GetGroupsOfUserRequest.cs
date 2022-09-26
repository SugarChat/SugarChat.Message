using Mediator.Net.Contracts;
using SugarChat.Message.Commands;
using SugarChat.Message.Paging;

namespace SugarChat.Message.Requests
{
    public class GetGroupsOfUserRequest : IRequest, INeedUserExist
    {
        public PageSettings PageSettings { get; set; }
        public string UserId { get; set; }
        public int? GroupType { get; set; }
        public int? FilterGroupType { get; set; }
        public int? FilterGroupUserType { get; set; }
    }
}