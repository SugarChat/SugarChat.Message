using Serilog.Events;
using SugarChat.Message.Common;

namespace SugarChat.Message.Exceptions
{
    public interface IBusinessException
    {
        LogEventLevel LogLevel { get; }
        ExceptionCode Code { get; }
        string Message { get; }
    }
}