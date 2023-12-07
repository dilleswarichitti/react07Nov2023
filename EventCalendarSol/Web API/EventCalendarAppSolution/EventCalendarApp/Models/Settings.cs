namespace EventCalendarApp.Models
{
    public class Settings
    {
        public string TimeZone { get; set; }
        public bool ReceiveNotifications { get; set; }
        public bool ShowEventsOnLogin { get; set; }
        public bool ReceiveEventReminders { get; set; }
        public bool KeepProfilePrivate { get; set; }
        public bool ShowFullName { get; set; }
        public bool TwoFactorAuthentication { get; set; }
        public string? Theme { get; set; }
        public string? DefaultCalendarView { get; set; }
    }
}
