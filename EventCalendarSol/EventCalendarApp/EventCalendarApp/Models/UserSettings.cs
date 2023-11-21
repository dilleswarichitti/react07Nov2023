using Humanizer;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;

namespace EventCalendarApp.Models
{
    public class UserSettings
    {
        public int Id { get; set; } 
        [ForeignKey("Email")]
        public string Email { get; set; } 
        public User User { get; set; }
        public bool ShowWeekend { get; set; } 
        public bool EnableReminders { get; set; } 
        public int DefaultViewMode { get; set; } 
        public bool ShowHolidays { get; set; } 
        public bool DarkMode { get; set; } 
        public int TimeZoneOffset { get; set; }
                                         
    }
}