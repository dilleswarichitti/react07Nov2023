using System.Runtime.Serialization;

namespace EventCalendarApp.Exceptions
{
    [Serializable]
    public class IdAlreadyExist : Exception
    {
        string message;
        public IdAlreadyExist()
        {
            message = "id already exists";
        }
        public override string Message => message;

    }
}