using SugarChat.Message.Common;

namespace SugarChat.Message.Exceptions
{
    public class ExceptionPrompt
    {
        private readonly string _formatString;
        private string[] _contents = {};

        public ExceptionPrompt(ExceptionCode code, string formatString)
        {
            _formatString = formatString;
            Code = code;
        }

        public ExceptionCode Code { get; }
        public string Message => string.Format(_formatString, _contents);

        public ExceptionPrompt WithParams(params string[] contents)
        {
            _contents = contents;
            return this;
        }
    }
}