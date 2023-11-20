using System.Runtime.Serialization;

namespace EventCalendarApp.Services
{
    [Serializable]
    internal class IdAlreadyExist : Exception
    {
        public IdAlreadyExist()
        {
        }

        public IdAlreadyExist(string? message) : base(message)
        {
        }

        public IdAlreadyExist(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IdAlreadyExist(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}