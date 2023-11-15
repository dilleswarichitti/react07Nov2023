namespace EventCalendarApp.Models
{
    public class Event
    {
        public int Id { get; set; } //identity-GUID
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? Location { get; set; }
        public bool? Recurring { get; set; }
        public List<Category>? Categories { get; set; }
        public List<SharingEvent>? SharingEvents { get; set; }
        public List<Remainder>? Reminders { get; set; }
    }
}
