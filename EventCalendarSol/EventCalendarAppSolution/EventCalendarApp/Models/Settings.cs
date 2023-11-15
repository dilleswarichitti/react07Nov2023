using System.ComponentModel.DataAnnotations.Schema;

namespace EventCalendarApp.Models
{
    public class Settings
    {
        public int Id { get; set; }
        public string Email { get; set; }
        [ForeignKey("Email")]
        public User User { get; set; }
        public bool ShowWeekend { get; set; }
        public bool EnableReminders { get; set; }
        public int DefaultViewMode { get; set; }
        public bool ShowHolidays { get; set; }
        public bool DarkMode { get; set; }
        public int TimeZoneOffset { get; set; }
    }
}
