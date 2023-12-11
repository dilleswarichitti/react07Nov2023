using System.ComponentModel.DataAnnotations;

namespace EventCalendarApp.Models
{
    public class Settings
    {
        [Key]
        public string Email {  get; set; }
        public string? Theme { get; set; }
        public string? DefaultCalendarView { get; set; }
        public bool NotificationEnabled { get; set; }
        public int DefaultReminder { get; set; }
        public string FirstDayOfWeek { get; set; }
    }
}
