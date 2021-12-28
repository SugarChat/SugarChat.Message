using Mediator.Net.Contracts;
using SugarChat.Message.Common;

namespace SugarChat.Message.Basic
{
    public interface ISugarChatResponse : IResponse
    {
        ExceptionCode Code { get; set;  }

        string Message { get; set; }
        
    }

    public interface ISugarChatResponse<T> : ISugarChatResponse
    {
        T Data { get; set; }
    }
}
