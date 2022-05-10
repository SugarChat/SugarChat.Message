using Mediator.Net.Contracts;
using SugarChat.Message.Dtos.Configurations;

namespace SugarChat.Message.Responses.Configurations
{
    public class GetServerConfigurationsResponse : IResponse
    {
        public ServerConfigurationsDto Configurations { get; set; }
    }
}
