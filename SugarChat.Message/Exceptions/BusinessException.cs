using System;
using Serilog.Events;
using SugarChat.Message.Common;

namespace SugarChat.Message.Exceptions
{
    public class BusinessException : Exception, IBusinessException
    {
        public BusinessException(LogEventLevel logLevel, ExceptionPrompt prompt, Exception innerException = null) : base(prompt.Message, innerException)
        {
            LogLevel = logLevel;
            Code = prompt.Code;
        }

        public LogEventLevel LogLevel { get; }
        public ExceptionCode Code { get; }
    }
}