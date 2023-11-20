//using System.ComponentModel.DataAnnotations.Schema;

//namespace EventCalendarApp.Models
//{
//    public class Reminder
//    {
//        public int Id { get; set; }
//        public string Message { get; set; }
//        public DateTime? ReminderDateTime { get; set; }
//        public int EventId { get; set; }

//        [ForeignKey("EventId")]
//        public Event? Event { get; set; }

//        public string Email { get; set; }  // Assuming you have a User entity

//        [ForeignKey("Email")]
//        public User? User { get; set; }

//        public enum NotificationType
//        {
//            Email,
//            InApp,
//            PushNotifications
//        }

//        public NotificationType PreferredNotification { get; set; }
//    }
//}