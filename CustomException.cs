using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegisteration
{
    public class CustomException : Exception
    {
        ExceptionType type;
        public string message;

        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, INVALID_MESSAGE, NO_SUCH_CLASS, NO_CONSTRUCTOR_FOUND
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}