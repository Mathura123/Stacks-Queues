using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Queues
{
    class StackException : Exception
    {
        public enum ExceptionType
        {
            NO_VALUE
        }
        private ExceptionType type;
        public StackException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
