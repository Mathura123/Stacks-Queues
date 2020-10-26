using System;
using System.Collections.Generic;
using System.Text;

namespace StacksQueuesProblem
{
    public class StacksAndQueuesException : Exception
    {
        public enum ExceptionType
        {
            NO_VALUE_IN_STACK,
            NO_VALUE_IN_QUEUE
        }
        private ExceptionType type;
        public StacksAndQueuesException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
