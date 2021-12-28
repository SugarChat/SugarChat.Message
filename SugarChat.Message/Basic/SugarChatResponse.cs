using SugarChat.Message.Common;

namespace SugarChat.Message.Basic
{
    public class SugarChatResponse<T> : ISugarChatResponse<T>
    {
        public ExceptionCode Code { get; set; } = Common.ExceptionCode.Success;
        public string Message { get; set; } = "Success";
        public T Data { get; set; }
    }

    public class SugarChatResponse : ISugarChatResponse
    {
        public ExceptionCode Code { get; set; } = Common.ExceptionCode.Success;
        public string Message { get; set; } = "Success";
    }
}