﻿using System;
using Serilog.Events;

namespace SugarChat.Message.Exceptions
{
    public class BusinessWarningException : BusinessException
    {
        public BusinessWarningException(ExceptionPrompt prompt) : base(LogEventLevel.Warning, prompt)
        {
        }
        public BusinessWarningException(ExceptionPrompt prompt, Exception innerException) : base(LogEventLevel.Warning, prompt,
            innerException)
        {
        }
    }
}