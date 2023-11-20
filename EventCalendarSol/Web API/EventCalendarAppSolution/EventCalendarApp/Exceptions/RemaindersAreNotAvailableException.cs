using System.Runtime.Serialization;

namespace EventCalendarApp.Exceptions
{
    [Serializable]
    public class RemaindersAreNotAvailableException : Exception
    {
        string message;
        public RemaindersAreNotAvailableException()
        {
            message = "no reminder is given to event";
        }
        public override string Message => message;
    }
} 