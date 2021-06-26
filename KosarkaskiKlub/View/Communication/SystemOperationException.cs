using System;
using System.Runtime.Serialization;

namespace View.Communication
{
    [Serializable]
    internal class SystemOperationException : Exception
    {
        public SystemOperationException()
        {
        }

        public SystemOperationException(string message) : base(message)
        {
        }

        public SystemOperationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SystemOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}