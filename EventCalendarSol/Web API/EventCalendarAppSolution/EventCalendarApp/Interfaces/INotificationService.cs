using EventCalendarApp.Models;

namespace EventCalendarApp.Interfaces
{
    public interface INotificationService
    {
        Notification Add(Notification notification);
        List<Notification> GetNotifications();
        void SendNotification(Notification notification, string userEmail);
    }
}
