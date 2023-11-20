//using System.ComponentModel.DataAnnotations.Schema;

//namespace EventCalendarApp.Models
//{
//    public class Notification
//    {
//        public int Id { get; set; }
//        public string Content { get; set; }
//        public DateTime? NotificationDateTime { get; set; }
//        public int ReminderId { get; set; }

//        [ForeignKey("ReminderId")]
//        public Reminder? Reminder { get; set; }

//        public string Email { get; set; }

//        [ForeignKey("Email")]
//        public User? User { get; set; }

//    }
//}