using System.ComponentModel.DataAnnotations.Schema;

namespace EventCalendarApp.Models
{
    public class Settings
    {
        public int Id { get; set; }
        public string Email { get; set; }//ForeignKey of User
        [ForeignKey("Email")]
        public User User { get; set; }
        public bool ShowWeekend { get; set; }//Whether to display weekends in the calendar
        public bool EnableReminders { get; set; }//Whether to enable event reminders
        public int DefaultViewMode { get; set; }//Default view mode for the calendar
        public bool ShowHolidays { get; set; }// Whether to display holidays on the calendar
        public bool DarkMode { get; set; }//Enable dark mode for the calendar
        public bool Eventaccessibility { get; set; }//event should be in public or private
        public int TimeZoneOffset { get; set; }//User's preferred time zone offset
    }
}
