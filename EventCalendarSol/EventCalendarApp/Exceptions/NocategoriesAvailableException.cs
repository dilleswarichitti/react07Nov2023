using System.Runtime.Serialization;

namespace EventCalendarApp.Exceptions
{
    [Serializable]
    public class NocategoriesAvailableException : Exception
    {
        string message;
        public NocategoriesAvailableException()
        {
            message = "No categories are available";
        }
        public override string Message => message;

    }
}